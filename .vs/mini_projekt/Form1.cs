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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vsi_kraji()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    comboBox1.Items.Add(ime);
                }
                con.Close();
            }
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
            Ena.Registracija(ImeTextBox.Text, PriimekTextBox.Text, Email2TextBox.Text, Geslo2textBox.Text);
        }
        

        private void PrijavaButton_Click(object sender, EventArgs e)
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
    
}
