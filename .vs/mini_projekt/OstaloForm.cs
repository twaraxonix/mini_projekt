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
        string ime;
        string naslov;
        string imek;
        bool x = true;
        Ostalo O = new Ostalo();
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
            
            listView1.Items.Clear();
            var title = new string[] { "Številka", "Ime", "Poštna številka", "" };
            var Title = new ListViewItem(title);
            listView1.Items.Add(Title);
            List<kraj> list = new List<kraj>(O.Kraji());
            foreach (kraj item in list)
            {
                var row = new string[] {item.st, item.ime, item.posta };
                var lvl = new ListViewItem(row);
                listView1.Items.Add(lvl);
            }


        }

        private void LokacijeButton_Click(object sender, EventArgs e)
        {
            x = false;
            
            listView1.Items.Clear();
            var title = new string[] { "Številka", "Ime", "Naslov", "Kraj" };
            var Title = new ListViewItem(title);
            listView1.Items.Add(Title);
            List<lokacija> list = new List<lokacija>(O.Lokacije());
            foreach (lokacija item in list)
            {
                var row = new string[] { item.st, item.ime, item.naslov, item.kraj};
                var lvl = new ListViewItem(row);
                listView1.Items.Add(lvl);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (x) {
                string a = listView1.SelectedItems[0].SubItems[1].Text;
                string b = listView1.SelectedItems[0].SubItems[2].Text;
                O.deleteKraj(a, b);
            }
            else
            {
                string a = listView1.SelectedItems[0].SubItems[1].Text;
                string b = listView1.SelectedItems[0].SubItems[2].Text;
                O.deleteLokacija(a, b);
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
            List<string> list = new List<string>(O.VsiKraji());
            foreach (string item in list)
            {
                comboBox1.Items.Add(item);
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
                ime = textBox1.Text;
                naslov = textBox2.Text;
            }
            else
            {
                comboBox1.Visible = true;
                label4.Text = "Spremeni lokacijo";
                label1.Text = "Ime lokacije";
                label2.Text = "Naslov lokacije";
                label3.Text = "Kraj";
                button1.Text = "Spremeni lokacijo";
                comboBox1.Items.Clear();

                List<string> list = new List<string>(O.VsiKraji());
                foreach (string item in list)
                {
                    comboBox1.Items.Add(item);
                }
                comboBox1.Visible = true;

                List<kraj> list2 = new List<kraj>(O.en_Kraj(listView1.SelectedItems[0].SubItems[1].Text, listView1.SelectedItems[0].SubItems[2].Text));
                foreach (kraj item in list2)
                {
                    textBox1.Text = item.st;
                    textBox2.Text = item.ime;
                    comboBox1.Text = item.posta;
                    ime = textBox1.Text;
                    naslov = textBox2.Text;
                    imek = comboBox1.Text;
                }
            }
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Vnesi kraj")
            {
                O.vnesi_Kraj(textBox1.Text, textBox2.Text);
            }
            else if(button1.Text == "Spremeni kraj")
            {
                O.spremeni_Kraj(textBox1.Text, textBox2.Text, ime, naslov);
            }
            else if(button1.Text == "Vnesi lokacijo")
            {
                O.vnesi_lokacijo(comboBox1.SelectedItem.ToString(), textBox1.Text, textBox2.Text);
            }
            else if(button1.Text == "Spremeni lokacijo")
            {
                O.spremeni_Lokacijo(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), ime, naslov);
            }
        }
    }
}
