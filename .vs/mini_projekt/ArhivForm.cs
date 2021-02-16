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
            listView1.Items.Clear();
            DatumOdDateTimePicker.Format = DateTimePickerFormat.Custom;
            DatumOdDateTimePicker.CustomFormat = "yyyy-MM-dd";
            DatumOdDateTimePicker.ShowUpDown = true;
            string dtOd = DatumOdDateTimePicker.Value.ToString("yyyy-MM-dd");

            DatumDoDateTimePicker.Format = DateTimePickerFormat.Custom;
            DatumDoDateTimePicker.CustomFormat = "yyyy-MM-dd";
            DatumDoDateTimePicker.ShowUpDown = true;
            string dtDo = DatumDoDateTimePicker.Value.ToString("yyyy-MM-dd");

            var row = Arhiv.IzpisArhiva(dtOd, dtDo);
            var lvl = new ListViewItem(row);
            listView1.Items.Add(lvl);
        }

        private void PrikazCelotnegaArhiva()
        {
            groupBox1.Visible = true;
            listView1.Items.Clear();
            int a = 1;
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_arhiv(" + Public.id + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    DateTime x = reader.GetDateTime(0);
                    
                    var row = new string[] {Convert.ToString(a), x.ToString("yyyy-MM-dd"), Convert.ToString(reader.GetDouble(1)) };
                    var lvl = new ListViewItem(row);
                    listView1.Items.Add(lvl);
                    a++;
                }
                con.Close();
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
            //ListViewItem item = listView1.SelectedItems[0];
            //fill the text boxes
            //textBoxID.Text = item.Text;
            groupBox1.Visible = true;
            string a = listView1.SelectedItems[0].SubItems[1].Text;
            string b = listView1.SelectedItems[0].SubItems[2].Text;
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_podrobno_arhiv(" + Public.id + ",'" + a + "'," + b + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    DatumDateTimePicker.Value = reader.GetDateTime(0);
                    ZnesekTextBox.Text = Convert.ToString(reader.GetDouble(1));
                    LokacijaTextBox.Text = reader.GetString(2);
                    KrajTextBox.Text = reader.GetString(3);
                }
                con.Close();
            }
        }

        private void SkrijButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
