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
            DatumDateTimePicker.Format = DateTimePickerFormat.Custom;
            DatumDateTimePicker.CustomFormat = "yyyy-MM-dd";
            DatumDateTimePicker.ShowUpDown = true;
            string dt = DatumDateTimePicker.Value.ToString("yyyy-MM-dd");
            I.Dodaj(LokacijaComboBox.Text, Convert.ToDouble(ZnesekTextBox.Text), dt);
            
        }

        private void Lokacije()
        {
            I.lokacije(comboBox1.Text);
            List<string> list = new List<string>(I.lokacije(comboBox1.Text));
            foreach (string item in list)
            {
                LokacijaComboBox.Items.Add(item);
            }
               
        }

        private void Kraji()
        {
            List<string> list = new List<string>(I.kraji());
            foreach (string item in list)
            {
                ImeKrajaConboBox.Items.Add(item);
                comboBox1.Items.Add(item);
            }
        }

       private void Posta()
        {
            List<string> list = new List<string>(I.posta(ImeKrajaConboBox.Text));
            foreach (string item in list)
            {
                PostnaStevilkaGroupBox.Items.Add(item);
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
            I.vnesi_lokacijo(ImeKrajaConboBox.Text, PostnaStevilkaGroupBox.Text, ImeLokacijeTextBox.Text, NaslovLokacijeTextBox.Text);
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
    }
}
