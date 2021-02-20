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
    public partial class OsebniPodatkiForm : Form
    {
        Uporabnik U = new Uporabnik();
        public OsebniPodatkiForm()
        {
            InitializeComponent();
            ImeTextBox.Enabled = false;
            PriimekTextBox.Enabled = false;
            NaslovTextBox.Enabled = false;
            DatumRojstvaDateTimePicker.Enabled = false;
            EmailTextBox.Enabled = false;
            SpremeniButton.Visible = false;
            IzpisiPodatke();
        }

        private void SpremeniPodatkeButton_Click(object sender, EventArgs e)
        {
            ImeTextBox.Enabled = true;
            PriimekTextBox.Enabled = true;
            NaslovTextBox.Enabled = true;
            DatumRojstvaDateTimePicker.Enabled = true;
            EmailTextBox.Enabled = true;
            SpremeniButton.Visible = true;
        }

        private void NazajButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainForm = new MainForm();
            MainForm.Closed += (s, args) => this.Close();
            MainForm.Show();
        }

        
        private void IzpisiPodatke()
        {
            try
            {
                List<Podatki> list = new List<Podatki>(U.podatki_Uporabnika());
                foreach (Podatki item in list)
                {
                    ImeTextBox.Text = item.A;
                    PriimekTextBox.Text = item.B;
                    NaslovTextBox.Text = item.C;
                    EmailTextBox.Text = item.D;
                    DatumRojstvaDateTimePicker.Value = item.E;
                    DatumRojstvaDateTimePicker.Format = DateTimePickerFormat.Custom;
                    DatumRojstvaDateTimePicker.CustomFormat = "yyyy-MM-dd";
                    DatumRojstvaDateTimePicker.ShowUpDown = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Napaka, poskusite ponovno");
            }
            
            
        }

        private void SpremeniPodatke()
        {
            try
            {
                DatumRojstvaDateTimePicker.Format = DateTimePickerFormat.Custom;
                DatumRojstvaDateTimePicker.CustomFormat = "yyyy-MM-dd";
                DatumRojstvaDateTimePicker.ShowUpDown = true;
                string dt = DatumRojstvaDateTimePicker.Value.ToString("yyyy-MM-dd");
                if ((DatumRojstvaDateTimePicker.Value != null)&&(ImeTextBox.Text != "")&&(PriimekTextBox.Text != ""))//+naslov
                {
                    
                    U.spremeni_Podatke_Uporabnika(ImeTextBox.Text, PriimekTextBox.Text, dt, NaslovTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Vnešena polja ne smejo biti prazna");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Napaka, poskusite ponovno");
            }
            
        }

        private void SpremeniButton_Click(object sender, EventArgs e)
        {
            SpremeniPodatke();
        }

        private void SpremeniEmailButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmailTextBox.Text != "")
                {
                    U.spremeni_Email(EmailTextBox.Text);
                }
                else
                    MessageBox.Show("Polje ne sme biti prazno");
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
                throw;
            }
            
        }

        private void SpremeniGesloUporabnika()
        {
            try
            {
                if (GesloTextBox.Text != "")
                {
                    U.spremeni_Geslo(GesloTextBox.Text);
                }
                else
                    MessageBox.Show("Polje ne sme biti prazno");
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
                throw;
            }
            
        }

        private void Spremeni2Button_Click(object sender, EventArgs e)
        {
            try
            {
                if ((GesloTextBox.Text == Geslo3TextBox.Text) && (GesloTextBox.Text != ""))
                {
                    SpremeniGesloUporabnika();
                }
                else
                {
                    MessageBox.Show("Gesli se ne ujemata");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Napaka, poskusite ponovno");
            }
            
        }

        private void SpremeniGesloButton_Click(object sender, EventArgs e)
        {
            
        }

        private void IzbrisiButton_Click(object sender, EventArgs e)
        {
            U.Izbris();
        }
    }
}
