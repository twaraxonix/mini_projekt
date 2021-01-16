﻿namespace mini_projekt
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
            this.label1 = new System.Windows.Forms.Label();
            this.StevilkaColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ZnesekColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LokacijaColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DodajButton = new System.Windows.Forms.Button();
            this.ArhivButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StevilkaColumnHeader,
            this.DatumColumnHeader,
            this.ZnesekColumnHeader,
            this.LokacijaColumnHeader,
            this.UpdateColumnHeader});
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "StevilkaListViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(788, 245);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // StevilkaColumnHeader
            // 
            this.StevilkaColumnHeader.Text = "";
            // 
            // DatumColumnHeader
            // 
            this.DatumColumnHeader.Text = "Datum";
            this.DatumColumnHeader.Width = 144;
            // 
            // ZnesekColumnHeader
            // 
            this.ZnesekColumnHeader.Text = "Znesek";
            this.ZnesekColumnHeader.Width = 88;
            // 
            // LokacijaColumnHeader
            // 
            this.LokacijaColumnHeader.Text = "Lokacija";
            this.LokacijaColumnHeader.Width = 211;
            // 
            // UpdateColumnHeader
            // 
            this.UpdateColumnHeader.Text = "Update";
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
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
        private System.Windows.Forms.ColumnHeader UpdateColumnHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Button ArhivButton;
    }
}