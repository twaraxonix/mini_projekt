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
        Arhiv A = new Arhiv();
        public ArhivForm()
        {
            InitializeComponent();
            PrikazCelotnegaArhiva();
            groupBox1.Visible = false;
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

            List<ItemA> list = new List<ItemA>(A.IzpisArhivaDatum(dtOd, dtDo));
            foreach (ItemA item in list)
            {
                var row = new string[] { item.A, item.B, item.C };
                var lvl = new ListViewItem(row);
                listView1.Items.Add(lvl);
            }
            
        }

        private void PrikazCelotnegaArhiva()
        {
            groupBox1.Visible = true;
            listView1.Items.Clear();
            List<ItemA> list = new List<ItemA>(A.IzpisArhiva());
            foreach (ItemA item in list)
            {
                var row = new string[] { item.A, item.B, item.C };
                var lvl = new ListViewItem(row);
                listView1.Items.Add(lvl);
            }

        }

        private void SpremeniDatumButton_Click(object sender, EventArgs e)
        {
            PrikazDolecenegaDelaArhiva();
        }

        private void PonastaviButton_Click(object sender, EventArgs e)
        {
            PrikazCelotnegaArhiva();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PodrobnoButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            string a = listView1.SelectedItems[0].SubItems[1].Text;
            string b = listView1.SelectedItems[0].SubItems[2].Text;
            ItemA item = A.Podrobno(a, b);
            DatumDateTimePicker.Value = item.D;
            ZnesekTextBox.Text = item.A;
            LokacijaTextBox.Text = item.B;
            KrajTextBox.Text = item.C;
        }

        private void SkrijButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
