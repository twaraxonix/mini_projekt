﻿using System;
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
            DateTime dt = DateTime.Now;
            string datumZ = dt.Year + "-" + dt.Month + "-01";
            int days = DateTime.DaysInMonth(dt.Year, dt.Month);
            string datumK = dt.Year + "-" + dt.Month + "-" + days;
            listView1.Items.Clear();
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vse_porabe_denarja(" + Public.id + ",'"+datumZ+"','"+datumK+"')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    DateTime x = reader.GetDateTime(0);
                    var row = new string[] {Convert.ToString(a), x.ToString("yyyy-MM-dd"), reader.GetString(1), Convert.ToString(reader.GetDouble(2)) };
                    var lvl = new ListViewItem(row);
                    listView1.Items.Add(lvl);
                    a++;
                }
                con.Close();
            }
        }

        private void ArhivButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ArhivForm = new ArhivForm();
            ArhivForm.Closed += (s, args) => this.Close();
            ArhivForm.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Public.Change2(listView1.SelectedItems[0].SubItems[1].Text, listView1.SelectedItems[0].SubItems[2].Text,
            Convert.ToDouble(listView1.SelectedItems[0].SubItems[3].Text));
            this.Hide();
            var UpdateForm = new UpdateForm();
            UpdateForm.Closed += (s, args) => this.Close();
            UpdateForm.Show();
        }
    }
}
