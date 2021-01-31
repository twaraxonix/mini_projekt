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
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_podatke_uporabnika(" + Public.id + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ImeTextBox.Text = reader.GetString(0);
                    PriimekTextBox.Text = reader.GetString(1);
                    NaslovTextBox.Text = reader.GetString(2);
                    EmailTextBox.Text = reader.GetString(4);
                    DatumRojstvaDateTimePicker.Value = reader.GetDateTime(3);
                    DatumRojstvaDateTimePicker.Format = DateTimePickerFormat.Custom;
                    DatumRojstvaDateTimePicker.CustomFormat = "yyyy-MM-dd";
                    DatumRojstvaDateTimePicker.ShowUpDown = true;
                }
                con.Close();
            }
        }

        private void SpremeniPodatke()
        {
            DatumRojstvaDateTimePicker.Format = DateTimePickerFormat.Custom;
            DatumRojstvaDateTimePicker.CustomFormat = "yyyy-MM-dd";
            DatumRojstvaDateTimePicker.ShowUpDown = true;
            string dt = DatumRojstvaDateTimePicker.Value.ToString("yyyy-MM-dd");
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT FROM update_podatke_uporabnika(" + Public.id + ",'" + ImeTextBox.Text + "','" + PriimekTextBox.Text + "','" + dt + "','"+ NaslovTextBox.Text +"')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
        }

        private void SpremeniButton_Click(object sender, EventArgs e)
        {
            SpremeniPodatke();
        }

        private void SpremeniEmailButton_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT update_email_uporabnika(" + Public.id + ",'" + EmailTextBox.Text + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
        }

        private void SpremeniGesloUporabnika()
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT update_geslo_uporabnika(" + Public.id + ",'" + Ena.CreateMD5(GesloTextBox.Text) + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
        }

        private void Spremeni2Button_Click(object sender, EventArgs e)
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

        private void SpremeniGesloButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
