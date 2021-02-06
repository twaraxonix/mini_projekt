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
        public OstaloForm()
        {
            InitializeComponent();
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
            int a = 1;
            listView1.Items.Clear();
            var title = new string[] { "Številka", "Ime", "Poštna številka", "" };
            var Title = new ListViewItem(title);
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
    }
}
