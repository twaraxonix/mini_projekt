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
    public partial class OstaloForm : Form
    {
        bool x = true;
        public OstaloForm()
        {
            InitializeComponent();
            comboBox1.Visible = false;
        }

        private void NazajButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainForm = new MainForm();
            MainForm.Closed += (s, args) => this.Close();
            MainForm.Show();
        }


        private void KrajiButton_Click(object sender, EventArgs e)
        {
            x = true;
            int a = 1;
            listView1.Items.Clear();
            var title = new string[] { "Številka", "Ime", "Poštna številka", "" };
            var Title = new ListViewItem(title);
            listView1.Items.Add(Title);
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vsi_kraji()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    var row = new string[] { Convert.ToString(a), reader.GetString(0), reader.GetString(1),};
                    var lvl = new ListViewItem(row);
                    listView1.Items.Add(lvl);
                    a++;
                }
                con.Close();
            }
        }

        private void LokacijeButton_Click(object sender, EventArgs e)
        {
            x = false;
            int a = 1;
            listView1.Items.Clear();
            var title = new string[] { "Številka", "Ime", "Naslov", "Kraj" };
            var Title = new ListViewItem(title);
            listView1.Items.Add(Title);
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vse_lokacije()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    var row = new string[] { Convert.ToString(a), reader.GetString(0), reader.GetString(1), reader.GetString(2) };
                    var lvl = new ListViewItem(row);
                    listView1.Items.Add(lvl);
                    a++;
                }
                con.Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (x) {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM delete_kraj('"+ listView1.SelectedItems[0].SubItems[1].Text + "','"+ listView1.SelectedItems[0].SubItems[2].Text + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                    }
                    con.Close();
                }
            }
        }

        private void VnesiKrajButton_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            label4.Text = "Vnesi kraj";
            label1.Text = "Vnesi ime";
            label2.Text = "Vnesi poštno številko";
            label3.Text = "";
            button1.Text = "Vnesi kraj";
        }

        private void VnesiLokacijoButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vsi_kraji()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                }
                con.Close();
            }
            comboBox1.Visible = true;
            label4.Text = "Vnesi lokacijo";
            label1.Text = "Vnesi ime";
            label2.Text = "Vnesi naslov";
            label3.Text = "Izberi kraj";
            button1.Text = "Vnesi lokacijo";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (x)
            {
                comboBox1.Visible = true;
                label4.Text = "Spremeni kraj";
                label1.Text = "Ime kraja";
                label2.Text = "Poštna številka kraja";
                label3.Text = "";
                button1.Text = "Spremeni kraj";
                textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Vnesi kraj")
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM add_kraj('" + textBox1.Text + "','" + textBox2.Text + "','')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                    }
                    con.Close();
                }
            }
            else if(button1.Text == "Spremeni kraj")
            {
                if (button1.Text == "Vnesi kraj")
                {
                    using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
                    {
                        con.Open();
                        NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM update_kraj('" + textBox1.Text + "','" + textBox2.Text + "','')", con);
                        NpgsqlDataReader reader = com.ExecuteReader();
                        while (reader.Read())
                        {
                        }
                        con.Close();
                    }
                }
            }
            else if(button1.Text == "Vnesi lokacijo")
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM add_lokacija2('" + textBox1.Text + "','" + textBox2.Text + "','"+comboBox1.SelectedItem.ToString()+"')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                    }
                    con.Close();
                }
            }
        }
    }
}
