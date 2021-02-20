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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
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
            this.OstaloButton = new System.Windows.Forms.Button();
            this.OdjavaButton = new System.Windows.Forms.Button();
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
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "StevilkaListViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
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
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tvoji Stroški";
            // 
            // DodajButton
            // 
            this.DodajButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.DodajButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DodajButton.FlatAppearance.BorderSize = 3;
            this.DodajButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.DodajButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.DodajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DodajButton.Location = new System.Drawing.Point(919, 193);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(158, 53);
            this.DodajButton.TabIndex = 2;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = false;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // ArhivButton
            // 
            this.ArhivButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ArhivButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ArhivButton.FlatAppearance.BorderSize = 3;
            this.ArhivButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.ArhivButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.ArhivButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArhivButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArhivButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ArhivButton.Location = new System.Drawing.Point(919, 262);
            this.ArhivButton.Name = "ArhivButton";
            this.ArhivButton.Size = new System.Drawing.Size(158, 48);
            this.ArhivButton.TabIndex = 3;
            this.ArhivButton.Text = "Arhiv";
            this.ArhivButton.UseVisualStyleBackColor = false;
            this.ArhivButton.Click += new System.EventHandler(this.ArhivButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UpdateButton.FlatAppearance.BorderSize = 3;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateButton.Location = new System.Drawing.Point(535, 327);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(150, 45);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteButton.FlatAppearance.BorderSize = 3;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.Location = new System.Drawing.Point(691, 327);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(154, 45);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IzvoziButton
            // 
            this.IzvoziButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.IzvoziButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IzvoziButton.FlatAppearance.BorderSize = 3;
            this.IzvoziButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.IzvoziButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.IzvoziButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IzvoziButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IzvoziButton.ForeColor = System.Drawing.SystemColors.Control;
            this.IzvoziButton.Location = new System.Drawing.Point(379, 327);
            this.IzvoziButton.Name = "IzvoziButton";
            this.IzvoziButton.Size = new System.Drawing.Size(150, 46);
            this.IzvoziButton.TabIndex = 6;
            this.IzvoziButton.Text = "Izvozi";
            this.IzvoziButton.UseVisualStyleBackColor = false;
            this.IzvoziButton.Click += new System.EventHandler(this.IzvoziButton_Click);
            // 
            // OsebniPodatkiButton
            // 
            this.OsebniPodatkiButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OsebniPodatkiButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OsebniPodatkiButton.FlatAppearance.BorderSize = 3;
            this.OsebniPodatkiButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.OsebniPodatkiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.OsebniPodatkiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OsebniPodatkiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OsebniPodatkiButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OsebniPodatkiButton.Location = new System.Drawing.Point(919, 326);
            this.OsebniPodatkiButton.Name = "OsebniPodatkiButton";
            this.OsebniPodatkiButton.Size = new System.Drawing.Size(158, 46);
            this.OsebniPodatkiButton.TabIndex = 7;
            this.OsebniPodatkiButton.Text = "Osebni Podatki";
            this.OsebniPodatkiButton.UseVisualStyleBackColor = false;
            this.OsebniPodatkiButton.Click += new System.EventHandler(this.OsebniPodatkiButton_Click);
            // 
            // SkupajTextBox
            // 
            this.SkupajTextBox.Enabled = false;
            this.SkupajTextBox.Location = new System.Drawing.Point(919, 120);
            this.SkupajTextBox.Name = "SkupajTextBox";
            this.SkupajTextBox.Size = new System.Drawing.Size(158, 22);
            this.SkupajTextBox.TabIndex = 8;
            // 
            // SkupajLabel
            // 
            this.SkupajLabel.AutoSize = true;
            this.SkupajLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SkupajLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SkupajLabel.Location = new System.Drawing.Point(958, 75);
            this.SkupajLabel.Name = "SkupajLabel";
            this.SkupajLabel.Size = new System.Drawing.Size(79, 25);
            this.SkupajLabel.TabIndex = 9;
            this.SkupajLabel.Text = "Skupaj";
            // 
            // OstaloButton
            // 
            this.OstaloButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OstaloButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OstaloButton.FlatAppearance.BorderSize = 3;
            this.OstaloButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.OstaloButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.OstaloButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OstaloButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OstaloButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OstaloButton.Location = new System.Drawing.Point(1, 398);
            this.OstaloButton.Name = "OstaloButton";
            this.OstaloButton.Size = new System.Drawing.Size(148, 40);
            this.OstaloButton.TabIndex = 10;
            this.OstaloButton.Text = "Ostalo";
            this.OstaloButton.UseVisualStyleBackColor = false;
            this.OstaloButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OdjavaButton
            // 
            this.OdjavaButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OdjavaButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OdjavaButton.FlatAppearance.BorderSize = 3;
            this.OdjavaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.OdjavaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.OdjavaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OdjavaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdjavaButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OdjavaButton.Location = new System.Drawing.Point(1, 9);
            this.OdjavaButton.Name = "OdjavaButton";
            this.OdjavaButton.Size = new System.Drawing.Size(148, 40);
            this.OdjavaButton.TabIndex = 11;
            this.OdjavaButton.Text = "Odjava";
            this.OdjavaButton.UseVisualStyleBackColor = false;
            this.OdjavaButton.Click += new System.EventHandler(this.OdjavaButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1191, 450);
            this.Controls.Add(this.OdjavaButton);
            this.Controls.Add(this.OstaloButton);
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
        private System.Windows.Forms.Button OstaloButton;
        private System.Windows.Forms.Button OdjavaButton;
    }
}