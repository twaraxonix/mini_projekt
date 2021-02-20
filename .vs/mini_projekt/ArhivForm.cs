using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace mini_projekt
{
    public partial class ArhivForm : Form
    {
        Arhiv A = new Arhiv();
        public ArhivForm()
        {
            InitializeComponent();
            PrikazCelotnegaArhiva();
            groupBox1.Visible = false;
        }

        private void NazajButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainForm = new MainForm();
            MainForm.Closed += (s, args) => this.Close();
            MainForm.Show();
        }

        private void PrikazDolecenegaDelaArhiva()
        {
            try
            {
                listView1.Items.Clear();
                DatumOdDateTimePicker.Format = DateTimePickerFormat.Custom;
                DatumOdDateTimePicker.CustomFormat = "yyyy-MM-dd";
                DatumOdDateTimePicker.ShowUpDown = true;
                string dtOd = DatumOdDateTimePicker.Value.ToString("yyyy-MM-dd");

                DatumDoDateTimePicker.Format = DateTimePickerFormat.Custom;
                DatumDoDateTimePicker.CustomFormat = "yyyy-MM-dd";
                DatumDoDateTimePicker.ShowUpDown = true;
                string dtDo = DatumDoDateTimePicker.Value.ToString("yyyy-MM-dd");

                if ((dtOd != null) && (dtDo != null))
                {
                    List<ItemA> list = new List<ItemA>(A.IzpisArhivaDatum(dtOd, dtDo));
                    foreach (ItemA item in list)
                    {
                        var row = new string[] { item.A, item.B, item.C };
                        var lvl = new ListViewItem(row);
                        listView1.Items.Add(lvl);
                    }
                }
                else
                    MessageBox.Show("DatumColumnHeader je prazen");
            }
            catch (Exception)
            {

                MessageBox.Show("Napaka, poskusite ponovno");
            }
            
            
        }

        private void PrikazCelotnegaArhiva()
        {
            groupBox1.Visible = true;
            listView1.Items.Clear();
            try
            {
                List<ItemA> list = new List<ItemA>(A.IzpisArhiva());
                foreach (ItemA item in list)
                {
                    var row = new string[] { item.A, item.B, item.C };
                    var lvl = new ListViewItem(row);
                    listView1.Items.Add(lvl);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Napaka, poskusite ponovno");
            }

        }

        private void SpremeniDatumButton_Click(object sender, EventArgs e)
        {
            PrikazDolecenegaDelaArhiva();
        }

        private void PonastaviButton_Click(object sender, EventArgs e)
        {
            PrikazCelotnegaArhiva();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PodrobnoButton_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = true;
                DatumDateTimePicker.Value = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[1].Text);
                string b = listView1.SelectedItems[0].SubItems[2].Text;
                string a = DatumDateTimePicker.Value.ToString("yyyy-MM-dd");

                if ((a != null) && (b != null))
                {
                    ItemA item = A.Podrobno(a, b);
                    DatumDateTimePicker.Value = item.D;
                    ZnesekTextBox.Text = item.A;
                    LokacijaTextBox.Text = item.B;
                    KrajTextBox.Text = item.C;
                }
                else
                    MessageBox.Show("Prosimo izberite željen račun ter določite datum");
            }
            catch (Exception)
            {
                DatumDateTimePicker.Value = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[1].Text);
                ZnesekTextBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
                MessageBox.Show("Ta podatek nima lokacije"); ;
            }
        }

        private void SkrijButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
