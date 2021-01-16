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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
            Lokacije();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Lokacije()
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_obstojece_lokacije()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    string ime_l = reader.GetString(1);
                    string skupaj = ime +", "+ ime_l;
                    LokacijaComboBox.Items.Add(ime);
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
    }
}