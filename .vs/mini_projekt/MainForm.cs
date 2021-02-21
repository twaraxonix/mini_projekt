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
        Main M = new Main();
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
            try
            {
                DateTime dt = DateTime.Now;
                string datumZ = dt.Year + "-" + dt.Month + "-01";
                int days = DateTime.DaysInMonth(dt.Year, dt.Month);
                string datumK = dt.Year + "-" + dt.Month + "-" + days;
                listView1.Items.Clear();
                List<denar> list = new List<denar>(M.update(datumZ, datumK));
                foreach (denar item in list)
                {
                    var row = new string[] { item.a, item.b, item.c, item.d };
                    var lvl = new ListViewItem(row);
                    listView1.Items.Add(lvl);
                }
                try
                {
                    SkupajTextBox.Text = M.sum(datumZ, datumK);
                }
                catch (Exception)
                {

                    MessageBox.Show("Vsota je nič");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("napaka, poskusite ponovno");
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
            try
            {
                Public.Change2(listView1.SelectedItems[0].SubItems[1].Text, listView1.SelectedItems[0].SubItems[2].Text,
                Convert.ToDouble(listView1.SelectedItems[0].SubItems[3].Text));
                this.Hide();
                var UpdateForm = new UpdateForm();
                UpdateForm.Closed += (s, args) => this.Close();
                UpdateForm.Show();
            }
            catch (Exception)
            {
            MessageBox.Show("Napaka, poskusite ponovno");
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Public.Change2(listView1.SelectedItems[0].SubItems[1].Text, listView1.SelectedItems[0].SubItems[2].Text,
                Convert.ToDouble(listView1.SelectedItems[0].SubItems[3].Text));
                if (listView1.SelectedItems[0].SubItems[2].Text != "NULL")
                {
                    M.ID();
                    M.deleteDenar();
                }
                else
                {
                    Update U = new Update();
                    U.ID2();
                    M.deleteDenar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponvno");
            }
            
        }

        private void IzvoziButton_Click(object sender, EventArgs e)
        {
            try
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
                        foreach (ListViewItem item in listView1.Items)
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
            catch (Exception)
            {
                MessageBox.Show("Napaka, poskusite ponovno");
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

        private void OdjavaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }



        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }
        private List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            M.Nastavitve();
            if ((Public.font != "x") || (Public.velikost != 1))
            {
                List<Control> allControls = GetAllControls(this);
                allControls.ForEach(k => k.Font = new System.Drawing.Font(Public.font, Public.velikost)); 
            }
            if (Public.barva != "x") 
            {
                this.BackColor = (Color)new ColorConverter().ConvertFromString(Public.barva);
            }

        }
    }
}
