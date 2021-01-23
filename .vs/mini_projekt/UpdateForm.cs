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
        public UpdateForm()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            Kraji();
            id();
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
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT update_porabe_denarja(" + Public.idP + "," + Convert.ToDouble(ZnesekTextBox.Text) + ",'" + dt+"')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
        }
        private void id()
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT return_id_porabe_denarja(" + Public.id + ","+Public.znesek+",'"+Public.datum+"','"+Public.lokacija+"')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Public.idP = reader.GetInt32(0);
                }
                con.Close();
            }
        }

        private void Lokacije()
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vse_lokacije('" + comboBox1.Text + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    //string ime_l = reader.GetString(1);
                    //string skupaj = ime +", "+ ime_l;
                    LokacijaComboBox.Items.Add(ime);
                }
                con.Close();
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
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_posto_krajev('" + ImeKrajaConboBox.Text + "')", con);
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
                NpgsqlCommand com = new NpgsqlCommand("SELECT add_lokacija('" + ImeKrajaConboBox.Text + "','" + PostnaStevilkaGroupBox.Text + "','" + ImeLokacijeTextBox.Text + "','" + NaslovLokacijeTextBox.Text + "')", con);
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

        private void SpremeniButton_Click(object sender, EventArgs e)
        {
            spremeni();
        }
    }
}
