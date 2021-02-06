using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
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
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vse_porabe_denarja(" + Public.id + ",'" + datumZ + "','" + datumK + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    DateTime x = reader.GetDateTime(0);
                    var row = new string[] { Convert.ToString(a), x.ToString("yyyy-MM-dd"), reader.GetString(1), Convert.ToString(reader.GetDouble(2)) };
                    var lvl = new ListViewItem(row);
                    listView1.Items.Add(lvl);
                    a++;
                }
                con.Close();
            }
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
                {
                    con.Open();
                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_sum(" + Public.id + ",'" + datumZ + "','" + datumK + "')", con);
                    NpgsqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        SkupajTextBox.Text = Convert.ToString(reader.GetDouble(0));
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vsota je nič");
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Public.Change2(listView1.SelectedItems[0].SubItems[1].Text, listView1.SelectedItems[0].SubItems[2].Text,
            Convert.ToDouble(listView1.SelectedItems[0].SubItems[3].Text));
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT return_id_porabe_denarja(" + Public.id + "," + Public.znesek + ",'" + Public.datum + "','" + Public.lokacija + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Public.idP = reader.GetInt32(0);
                }
                con.Close();
            }
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT delete_poraba_denarja(" + Public.idP + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
            Public.Change2("","",0);
        }

        private void IzvoziButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Stevilka";
                    ws.Cells[1, 2] = "Datum";
                    ws.Cells[1, 3] = "Lokacija";
                    ws.Cells[1, 4] = "Znesek";
                    int i = 2;
                    foreach(ListViewItem item in listView1.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Vaši podatki so bili izvoženi v excel tabelo");
                }
        }

        private void OsebniPodatkiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var OsebniPodatkiForm = new OsebniPodatkiForm();
            OsebniPodatkiForm.Closed += (s, args) => this.Close();
            OsebniPodatkiForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var OstaloForm = new OstaloForm();
            OstaloForm.Closed += (s, args) => this.Close();
            OstaloForm.Show();
        }
    }
}
