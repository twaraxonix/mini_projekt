namespace mini_projekt
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.listView1 = new System.Windows.Forms.ListView();
            this.StevilkaColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LokacijaColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ZnesekColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.DodajButton = new System.Windows.Forms.Button();
            this.ArhivButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IzvoziButton = new System.Windows.Forms.Button();
            this.OsebniPodatkiButton = new System.Windows.Forms.Button();
            this.SkupajTextBox = new System.Windows.Forms.TextBox();
            this.SkupajLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StevilkaColumnHeader,
            this.DatumColumnHeader,
            this.LokacijaColumnHeader,
            this.ZnesekColumnHeader});
            this.listView1.FullRowSelect = true;
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "StevilkaListViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(57, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(788, 245);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // StevilkaColumnHeader
            // 
            this.StevilkaColumnHeader.Text = "";
            // 
            // DatumColumnHeader
            // 
            this.DatumColumnHeader.Text = "Datum";
            this.DatumColumnHeader.Width = 178;
            // 
            // LokacijaColumnHeader
            // 
            this.LokacijaColumnHeader.DisplayIndex = 3;
            this.LokacijaColumnHeader.Text = "Lokacija";
            this.LokacijaColumnHeader.Width = 172;
            // 
            // ZnesekColumnHeader
            // 
            this.ZnesekColumnHeader.DisplayIndex = 2;
            this.ZnesekColumnHeader.Text = "Znesek";
            this.ZnesekColumnHeader.Width = 168;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tvoji Stroški";
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(124, 372);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(119, 41);
            this.DodajButton.TabIndex = 2;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // ArhivButton
            // 
            this.ArhivButton.Location = new System.Drawing.Point(318, 372);
            this.ArhivButton.Name = "ArhivButton";
            this.ArhivButton.Size = new System.Drawing.Size(122, 41);
            this.ArhivButton.TabIndex = 3;
            this.ArhivButton.Text = "Arhiv";
            this.ArhivButton.UseVisualStyleBackColor = true;
            this.ArhivButton.Click += new System.EventHandler(this.ArhivButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(642, 326);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(104, 46);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(749, 326);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 46);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IzvoziButton
            // 
            this.IzvoziButton.Location = new System.Drawing.Point(860, 326);
            this.IzvoziButton.Name = "IzvoziButton";
            this.IzvoziButton.Size = new System.Drawing.Size(103, 46);
            this.IzvoziButton.TabIndex = 6;
            this.IzvoziButton.Text = "Izvozi";
            this.IzvoziButton.UseVisualStyleBackColor = true;
            this.IzvoziButton.Click += new System.EventHandler(this.IzvoziButton_Click);
            // 
            // OsebniPodatkiButton
            // 
            this.OsebniPodatkiButton.Location = new System.Drawing.Point(476, 372);
            this.OsebniPodatkiButton.Name = "OsebniPodatkiButton";
            this.OsebniPodatkiButton.Size = new System.Drawing.Size(115, 41);
            this.OsebniPodatkiButton.TabIndex = 7;
            this.OsebniPodatkiButton.Text = "Osebni Podatki";
            this.OsebniPodatkiButton.UseVisualStyleBackColor = true;
            this.OsebniPodatkiButton.Click += new System.EventHandler(this.OsebniPodatkiButton_Click);
            // 
            // SkupajTextBox
            // 
            this.SkupajTextBox.Enabled = false;
            this.SkupajTextBox.Location = new System.Drawing.Point(861, 137);
            this.SkupajTextBox.Name = "SkupajTextBox";
            this.SkupajTextBox.Size = new System.Drawing.Size(100, 22);
            this.SkupajTextBox.TabIndex = 8;
            // 
            // SkupajLabel
            // 
            this.SkupajLabel.AutoSize = true;
            this.SkupajLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SkupajLabel.Location = new System.Drawing.Point(874, 91);
            this.SkupajLabel.Name = "SkupajLabel";
            this.SkupajLabel.Size = new System.Drawing.Size(73, 24);
            this.SkupajLabel.TabIndex = 9;
            this.SkupajLabel.Text = "Skupaj";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 450);
            this.Controls.Add(this.SkupajLabel);
            this.Controls.Add(this.SkupajTextBox);
            this.Controls.Add(this.OsebniPodatkiButton);
            this.Controls.Add(this.IzvoziButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ArhivButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader StevilkaColumnHeader;
        private System.Windows.Forms.ColumnHeader DatumColumnHeader;
        private System.Windows.Forms.ColumnHeader ZnesekColumnHeader;
        private System.Windows.Forms.ColumnHeader LokacijaColumnHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Button ArhivButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button IzvoziButton;
        private System.Windows.Forms.Button OsebniPodatkiButton;
        private System.Windows.Forms.TextBox SkupajTextBox;
        private System.Windows.Forms.Label SkupajLabel;
    }
}