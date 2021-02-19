using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace mini_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrijavaGroupBox.Visible = true;
            RegistracijaGroupBox.Visible = false;
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Registracija1Button_Click(object sender, EventArgs e)
        {
            PrijavaGroupBox.Visible = false;
            RegistracijaGroupBox.Visible = true;
        }

        private void NazajButton_Click(object sender, EventArgs e)
        {
            PrijavaGroupBox.Visible = true;
            RegistracijaGroupBox.Visible = false;
        }

        private void RegistracijaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((ImeTextBox.Text != "") && (PriimekTextBox.Text != "") && (Email2TextBox.Text != "") && (Geslo2textBox.Text != ""))
                {
                    Ena.Registracija(ImeTextBox.Text, PriimekTextBox.Text, Email2TextBox.Text, Geslo2textBox.Text);
                }
                else
                    MessageBox.Show("Vsi podatki morajo biti izpolnjeni");
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
            }
            
        }
        

        private void PrijavaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((EmailTextBox.Text != "") && (GesloTextBox.Text != ""))
                {
                    bool x = Ena.Prijava(EmailTextBox.Text, GesloTextBox.Text);
                    if (x == true)
                    {
                        this.Hide();
                        var MainForm = new MainForm();
                        MainForm.Closed += (s, args) => this.Close();
                        MainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email ali geslo ni pravilno");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
            }
            
        }

        private void SpremenitevGeslaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Geslo3TextBox.Text == Geslo4TextBox.Text) && (Geslo3TextBox.Text != ""))
                {
                    Ena.PozabljenoGeslo(Email3TextBox.Text, Geslo3TextBox.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            PrijavaGroupBox.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            PrijavaGroupBox.Visible = true;
        }
    }
    
}
