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
            SpremeniButton.Visible = false;
            IzpisiPodatke();
        }

        private void SpremeniPodatkeButton_Click(object sender, EventArgs e)
        {
            ImeTextBox.Enabled = true;
            PriimekTextBox.Enabled = true;
            NaslovTextBox.Enabled = true;
            DatumRojstvaDateTimePicker.Enabled = true;
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
                    if(reader.GetString(2) != null){
                        NaslovTextBox.Text = reader.GetString(2);
                    }
                    EmailTextBox.Text = reader.GetString(4);
                    //DatumRojstvaDateTimePicker.Value = reader
                }
                con.Close();
            }
        }
    }
}
