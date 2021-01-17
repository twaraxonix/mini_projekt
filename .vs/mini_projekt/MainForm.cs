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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Porabe_denarja();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var InsertForm = new InsertForm();
            InsertForm.Closed += (s, args) => this.Close();
            InsertForm.Show();
        }

        private void Porabe_denarja()
        {
            int a = 1;
            listView1.Items.Clear();
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vse_porabe_denarja(" + Public.id + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    var row = new string[] {Convert.ToString(a), Convert.ToString(reader.GetTimeStamp(0)), reader.GetString(1), Convert.ToString(reader.GetInt32(2)) };
                    var lvl = new ListViewItem(row);
                    listView1.Items.Add(lvl);
                    a++;
                }
                con.Close();
            }
        }
    }
}
