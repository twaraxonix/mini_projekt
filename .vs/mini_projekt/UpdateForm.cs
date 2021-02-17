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
    public partial class UpdateForm : Form
    {
        Update U = new Update();
        public UpdateForm()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            Kraji();
            if (Public.lokacija == "NULL")
            {
                id2();
            }
            else
            {
                id();
            }
            DatumDateTimePicker.Value = Convert.ToDateTime(Public.datum);
            ZnesekTextBox.Text = Convert.ToString(Public.znesek);
            LokacijaComboBox.Text = Public.lokacija;
        }

        private void spremeni()
        {
            DatumDateTimePicker.Format = DateTimePickerFormat.Custom;
            DatumDateTimePicker.CustomFormat = "yyyy-MM-dd";
            DatumDateTimePicker.ShowUpDown = true;
            string dt = DatumDateTimePicker.Value.ToString("yyyy-MM-dd");
            U.update(Convert.ToDouble(ZnesekTextBox.Text), dt);
        }
        private void id()
        {
            U.ID();
        }
        private void id2()
        {
            U.ID2();
        }
        private void Lokacije()
        {
            List<string> list = new List<string>(U.lokacije(comboBox1.Text));
            foreach (string item in list)
            {
                LokacijaComboBox.Items.Add(item);
            }
        }

        private void Kraji()
        {
            List<string> list2 = new List<string>(U.kraji());
            foreach (string item in list2)
            {
                ImeKrajaConboBox.Items.Add(item);
                comboBox1.Items.Add(item);
            }
        }

        private void Posta()
        {
            List<string> list = new List<string>(U.posta(ImeKrajaConboBox.Text));
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
            U.dodaj_Lokacijo(ImeKrajaConboBox.Text, PostnaStevilkaGroupBox.Text, ImeLokacijeTextBox.Text, NaslovLokacijeTextBox.Text);
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

        private void SpremeniButton_Click(object sender, EventArgs e)
        {
            spremeni();
        }
    }
}
