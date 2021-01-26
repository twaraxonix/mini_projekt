using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_projekt
{
    public partial class OsebniPodatkiForm : Form
    {
        public OsebniPodatkiForm()
        {
            InitializeComponent();
            ImeTextBox.Enabled = false;
            PriimekTextBox.Enabled = false;
            NaslovTextBox.Enabled = false;
            DatumRojstvaDateTimePicker.Enabled = false;
        }

        private void SpremeniPodatkeButton_Click(object sender, EventArgs e)
        {
            ImeTextBox.Enabled = true;
            PriimekTextBox.Enabled = true;
            NaslovTextBox.Enabled = true;
            DatumRojstvaDateTimePicker.Enabled = true;
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
