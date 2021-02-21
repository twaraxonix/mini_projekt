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
using System.Runtime;

namespace mini_projekt
{
    public partial class InsertForm : Form
    {
        Insert I = new Insert();
        public InsertForm()
        {
            InitializeComponent();
            //Lokacije();
            groupBox1.Visible = false;
            Kraji();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            Dodaj();  
        }

        private void Dodaj()
        {
            try
            {
                DatumDateTimePicker.Format = DateTimePickerFormat.Custom;
                DatumDateTimePicker.CustomFormat = "yyyy-MM-dd";
                DatumDateTimePicker.ShowUpDown = true;
                string dt = DatumDateTimePicker.Value.ToString("yyyy-MM-dd");
                if ((LokacijaComboBox.Text != "") && (ZnesekTextBox.Text != "") && (dt != null))
                {
                    I.Dodaj(LokacijaComboBox.Text, Convert.ToDouble(ZnesekTextBox.Text), dt);
                }
                else
                    MessageBox.Show("Vnešeni podatki ne smejo biti prazni");
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
            }
            
            
        }

        private void Lokacije()
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    I.lokacije(comboBox1.Text);
                    List<string> list = new List<string>(I.lokacije(comboBox1.Text));
                    foreach (string item in list)
                    {
                        LokacijaComboBox.Items.Add(item);
                    }
                }
                else
                    MessageBox.Show("Prosim izberite kraj");

            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
            }
            
        }

        private void Kraji()
        {
            try
            {
                List<string> list = new List<string>(I.kraji());
                foreach (string item in list)
                {
                    ImeKrajaConboBox.Items.Add(item);
                    comboBox1.Items.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
            }
            
        }

       private void Posta()
        {
            try
            {
                if (ImeKrajaConboBox.Text != null)
                {
                    List<string> list = new List<string>(I.posta(ImeKrajaConboBox.Text));
                    foreach (string item in list)
                    {
                        PostnaStevilkaGroupBox.Items.Add(item);
                    }
                }
                else
                    MessageBox.Show("Prosim izberite Kraj");
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, pokusite ponovno");
            }
            
        }
        

        private void NazajButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainForm = new MainForm();
            MainForm.Closed += (s, args) => this.Close();
            MainForm.Show();
        }

        private void DodadLokacijoButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            //Kraji();
        }

        private void ImeKrajaConboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PostnaStevilkaGroupBox.Items.Clear();
            Posta();
        }

        private void DodajLokacijo2_Click(object sender, EventArgs e)
        {
            try
            {
                if ((ImeKrajaConboBox.Text != "") && (PostnaStevilkaGroupBox.Text != null) && (ImeLokacijeTextBox.Text != "") && (NaslovLokacijeTextBox.Text != null))
                {
                    I.vnesi_lokacijo(ImeKrajaConboBox.Text, PostnaStevilkaGroupBox.Text, ImeLokacijeTextBox.Text, NaslovLokacijeTextBox.Text);
                }
                else
                    MessageBox.Show("Prosim, izpolnite vse podatke");
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LokacijaComboBox.Items.Clear();
            Lokacije();
        }

        private void NazajButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            if ((Public.font != "x") || (Public.velikost != 1))
            {
                List<Control> allControls = GetAllControls(this);
                allControls.ForEach(k => k.Font = new System.Drawing.Font(Public.font, Public.velikost));
            }
            if (Public.barva != "x")
            {
                this.BackColor = (Color)new ColorConverter().ConvertFromString(Public.barva);
            }
        }
        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }
        private List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }

    }
}
