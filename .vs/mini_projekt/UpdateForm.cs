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
            MessageBox.Show(Public.lokacija);
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
            try
            {
                DatumDateTimePicker.Format = DateTimePickerFormat.Custom;
                DatumDateTimePicker.CustomFormat = "yyyy-MM-dd";
                DatumDateTimePicker.ShowUpDown = true;
                string dt = DatumDateTimePicker.Value.ToString("yyyy-MM-dd");
                if ((ZnesekTextBox.Text != "") && (dt != null))
                {
                    U.update(Convert.ToDouble(ZnesekTextBox.Text), dt);
                }
                else
                    MessageBox.Show("Vnešeneno polje e sme biti prazno");
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
            }
            
        }
        private void id()
        {
            try
            {
                U.ID();
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
            }
            
        }
        private void id2()
        {
            try
            {
                U.ID2();
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
                if (comboBox1.Text != null)
                {
                    List<string> list = new List<string>(U.lokacije(comboBox1.Text));
                    foreach (string item in list)
                    {
                        LokacijaComboBox.Items.Add(item);
                    }
                }
                else
                    MessageBox.Show("prosim izberite lokacijo");
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
                List<string> list2 = new List<string>(U.kraji());
                foreach (string item in list2)
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
                    List<string> list = new List<string>(U.posta(ImeKrajaConboBox.Text));
                    foreach (string item in list)
                    {
                        PostnaStevilkaGroupBox.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
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
                if ((ImeKrajaConboBox.Text != null) && (PostnaStevilkaGroupBox.Text != null) && (ImeLokacijeTextBox.Text != null) && (NaslovLokacijeTextBox.Text != null))
                {
                    U.dodaj_Lokacijo(ImeKrajaConboBox.Text, PostnaStevilkaGroupBox.Text, ImeLokacijeTextBox.Text, NaslovLokacijeTextBox.Text);
                }
                else
                    MessageBox.Show("Vnešena polja ne smejo biti prazna");
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

        private void SpremeniButton_Click(object sender, EventArgs e)
        {
            spremeni();
        }

        private void SpremeniNatancnoButton_Click(object sender, EventArgs e)
        {
            try
            {
                DatumDateTimePicker.Format = DateTimePickerFormat.Custom;
                DatumDateTimePicker.CustomFormat = "yyyy-MM-dd";
                DatumDateTimePicker.ShowUpDown = true;
                string dt = DatumDateTimePicker.Value.ToString("yyyy-MM-dd");
                if ((ZnesekTextBox.Text != "") && (dt != null) && (comboBox1.Text != null) && (LokacijaComboBox.Text != null))
                {
                    U.update1(Convert.ToDouble(ZnesekTextBox.Text), dt, comboBox1.Text, LokacijaComboBox.Text);
                }
                else
                    MessageBox.Show("Vnešeneno polje e sme biti prazno");
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
            }
        }
    }
}
