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
    public partial class ArhivForm : Form
    {
        public ArhivForm()
        {
            InitializeComponent();
            PrikazCelotnegaArhiva();
        }

        private void NazajButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainForm = new MainForm();
            MainForm.Closed += (s, args) => this.Close();
            MainForm.Show();
        }

        private void PrikazDolecenegaDelaArhiva()
        {
            listView1.Items.Clear();
            DatumOdDateTimePicker.Format = DateTimePickerFormat.Custom;
            DatumOdDateTimePicker.CustomFormat = "yyyy-MM-dd";
            DatumOdDateTimePicker.ShowUpDown = true;
            string dtOd = DatumOdDateTimePicker.Value.ToString("yyyy-MM-dd");

            DatumDoDateTimePicker.Format = DateTimePickerFormat.Custom;
            DatumDoDateTimePicker.CustomFormat = "yyyy-MM-dd";
            DatumDoDateTimePicker.ShowUpDown = true;
            string dtDo = DatumDoDateTimePicker.Value.ToString("yyyy-MM-dd");

            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                int a = 0;
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_arhiv_dolocen_datum('"+dtOd+"','"+dtDo+"'," + Public.id + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    DateTime x = reader.GetDateTime(0);

                    var row = new string[] { Convert.ToString(a), x.ToString("dd-MM-yyyy"), Convert.ToString(reader.GetDouble(1)) };
                    var lvl = new ListViewItem(row);
                    listView1.Items.Add(lvl);
                    a++;
                }
                con.Close();
            }
        }

        private void PrikazCelotnegaArhiva()
        {
            listView1.Items.Clear();
            int a = 1;
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_arhiv(" + Public.id + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    DateTime x = reader.GetDateTime(0);
                    
                    var row = new string[] {Convert.ToString(a), x.ToString("dd-MM-yyyy"), Convert.ToString(reader.GetDouble(1)) };
                    var lvl = new ListViewItem(row);
                    listView1.Items.Add(lvl);
                    a++;
                }
                con.Close();
            }
        }

        private void SpremeniDatumButton_Click(object sender, EventArgs e)
        {
            PrikazDolecenegaDelaArhiva();
        }
    }
}
