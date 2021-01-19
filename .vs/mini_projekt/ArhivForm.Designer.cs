namespace mini_projekt
{
    partial class ArhivForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.NazajButton = new System.Windows.Forms.Button();
            this.DatumOdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DatumDoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SpremeniDatumButton = new System.Windows.Forms.Button();
            this.IzbiraDatumaLabel = new System.Windows.Forms.Label();
            this.OdLabel = new System.Windows.Forms.Label();
            this.DoLabel = new System.Windows.Forms.Label();
            this.PonastaviButton = new System.Windows.Forms.Button();
            this.IdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ZnesekColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumnHeader,
            this.DatumColumnHeader,
            this.ZnesekColumnHeader});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(455, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(431, 370);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NazajButton
            // 
            this.NazajButton.Location = new System.Drawing.Point(67, 385);
            this.NazajButton.Name = "NazajButton";
            this.NazajButton.Size = new System.Drawing.Size(75, 23);
            this.NazajButton.TabIndex = 1;
            this.NazajButton.Text = "Nazaj";
            this.NazajButton.UseVisualStyleBackColor = true;
            this.NazajButton.Click += new System.EventHandler(this.NazajButton_Click);
            // 
            // DatumOdDateTimePicker
            // 
            this.DatumOdDateTimePicker.Location = new System.Drawing.Point(916, 129);
            this.DatumOdDateTimePicker.Name = "DatumOdDateTimePicker";
            this.DatumOdDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DatumOdDateTimePicker.TabIndex = 2;
            // 
            // DatumDoDateTimePicker
            // 
            this.DatumDoDateTimePicker.Location = new System.Drawing.Point(916, 230);
            this.DatumDoDateTimePicker.Name = "DatumDoDateTimePicker";
            this.DatumDoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DatumDoDateTimePicker.TabIndex = 3;
            // 
            // SpremeniDatumButton
            // 
            this.SpremeniDatumButton.Location = new System.Drawing.Point(916, 302);
            this.SpremeniDatumButton.Name = "SpremeniDatumButton";
            this.SpremeniDatumButton.Size = new System.Drawing.Size(131, 41);
            this.SpremeniDatumButton.TabIndex = 4;
            this.SpremeniDatumButton.Text = "Spremeni datum";
            this.SpremeniDatumButton.UseVisualStyleBackColor = true;
            this.SpremeniDatumButton.Click += new System.EventHandler(this.SpremeniDatumButton_Click);
            // 
            // IzbiraDatumaLabel
            // 
            this.IzbiraDatumaLabel.AutoSize = true;
            this.IzbiraDatumaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IzbiraDatumaLabel.Location = new System.Drawing.Point(944, 46);
            this.IzbiraDatumaLabel.Name = "IzbiraDatumaLabel";
            this.IzbiraDatumaLabel.Size = new System.Drawing.Size(156, 29);
            this.IzbiraDatumaLabel.TabIndex = 5;
            this.IzbiraDatumaLabel.Text = "Izberi datum";
            // 
            // OdLabel
            // 
            this.OdLabel.AutoSize = true;
            this.OdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdLabel.Location = new System.Drawing.Point(1002, 92);
            this.OdLabel.Name = "OdLabel";
            this.OdLabel.Size = new System.Drawing.Size(30, 18);
            this.OdLabel.TabIndex = 6;
            this.OdLabel.Text = "Od";
            // 
            // DoLabel
            // 
            this.DoLabel.AutoSize = true;
            this.DoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DoLabel.Location = new System.Drawing.Point(1002, 198);
            this.DoLabel.Name = "DoLabel";
            this.DoLabel.Size = new System.Drawing.Size(30, 18);
            this.DoLabel.TabIndex = 7;
            this.DoLabel.Text = "Do";
            // 
            // PonastaviButton
            // 
            this.PonastaviButton.Location = new System.Drawing.Point(1092, 302);
            this.PonastaviButton.Name = "PonastaviButton";
            this.PonastaviButton.Size = new System.Drawing.Size(108, 41);
            this.PonastaviButton.TabIndex = 8;
            this.PonastaviButton.Text = "Ponastavi";
            this.PonastaviButton.UseVisualStyleBackColor = true;
            // 
            // IdColumnHeader
            // 
            this.IdColumnHeader.Text = "";
            // 
            // DatumColumnHeader
            // 
            this.DatumColumnHeader.Text = "Datum vnosa";
            this.DatumColumnHeader.Width = 197;
            // 
            // ZnesekColumnHeader
            // 
            this.ZnesekColumnHeader.Text = "Znesek";
            this.ZnesekColumnHeader.Width = 200;
            // 
            // ArhivForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 484);
            this.Controls.Add(this.PonastaviButton);
            this.Controls.Add(this.DoLabel);
            this.Controls.Add(this.OdLabel);
            this.Controls.Add(this.IzbiraDatumaLabel);
            this.Controls.Add(this.SpremeniDatumButton);
            this.Controls.Add(this.DatumDoDateTimePicker);
            this.Controls.Add(this.DatumOdDateTimePicker);
            this.Controls.Add(this.NazajButton);
            this.Controls.Add(this.listView1);
            this.Name = "ArhivForm";
            this.Text = "ArhivForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button NazajButton;
        private System.Windows.Forms.DateTimePicker DatumOdDateTimePicker;
        private System.Windows.Forms.DateTimePicker DatumDoDateTimePicker;
        private System.Windows.Forms.Button SpremeniDatumButton;
        private System.Windows.Forms.ColumnHeader IdColumnHeader;
        private System.Windows.Forms.ColumnHeader DatumColumnHeader;
        private System.Windows.Forms.ColumnHeader ZnesekColumnHeader;
        private System.Windows.Forms.Label IzbiraDatumaLabel;
        private System.Windows.Forms.Label OdLabel;
        private System.Windows.Forms.Label DoLabel;
        private System.Windows.Forms.Button PonastaviButton;
    }
}