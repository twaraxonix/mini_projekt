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
            string MD5 = CreateMD5(Geslo2textBox.Text);
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT add_uporabnik1('"+ImeTextBox.Text+"','"+PriimekTextBox.Text+"','"+Email2TextBox.Text+"','"+MD5+"')", con);
                NpgsqlDataReader reader = com.ExecuteReader(); 
                while (reader.Read())
                {
                    int a = reader.GetInt32(0);
                    //comboBox1.Items.Add(ime);
                    comboBox1.Items.Add(a);
                }
                con.Close();
            }
        }
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void PrijavaButton_Click(object sender, EventArgs e)
        {
            string MD5 = CreateMD5(Geslo2textBox.Text);
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT prijava('" + EmailTextBox.Text + "','" + MD5 + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read()) 
                {
                    bool a = reader.GetBoolean(0);
                    //comboBox1.Items.Add(ime);
                    comboBox1.Items.Add(a);
                }
                con.Close();
            }
        }
    }
    
}
