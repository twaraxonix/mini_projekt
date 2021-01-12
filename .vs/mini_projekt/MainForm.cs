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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var InsertForm = new InsertForm();
            InsertForm.Closed += (s, args) => this.Close();
            InsertForm.Show();
        }
    }
}
