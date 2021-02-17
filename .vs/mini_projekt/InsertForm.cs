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
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vsi_kraji()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ImeKrajaConboBox.Items.Add(reader.GetString(0));
                    comboBox1.Items.Add(reader.GetString(0));
                }
                con.Close();
            }
        }

       private void Posta()
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_posto_krajev('"+ ImeKrajaConboBox.Text +"')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    PostnaStevilkaGroupBox.Items.Add(reader.GetString(0));
                }
                con.Close();
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
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT add_lokacija('" + ImeKrajaConboBox.Text + "','"+ PostnaStevilkaGroupBox.Text+"','"+ImeLokacijeTextBox.Text+"','"+NaslovLokacijeTextBox.Text+"')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
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
    }
}
