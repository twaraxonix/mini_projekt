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
            this.IdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ZnesekColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NazajButton = new System.Windows.Forms.Button();
            this.DatumOdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DatumDoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SpremeniDatumButton = new System.Windows.Forms.Button();
            this.IzbiraDatumaLabel = new System.Windows.Forms.Label();
            this.OdLabel = new System.Windows.Forms.Label();
            this.DoLabel = new System.Windows.Forms.Label();
            this.PonastaviButton = new System.Windows.Forms.Button();
            this.PodrobnoButton = new System.Windows.Forms.Button();
            this.ArhivLabel = new System.Windows.Forms.Label();
            this.PodrbnoLabel = new System.Windows.Forms.Label();
            this.ZnesekLabel = new System.Windows.Forms.Label();
            this.DatumLabel = new System.Windows.Forms.Label();
            this.ZnesekTextBox = new System.Windows.Forms.TextBox();
            this.LokacijaTextBox = new System.Windows.Forms.TextBox();
            this.DatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LokacijaLabel = new System.Windows.Forms.Label();
            this.KrajLabel = new System.Windows.Forms.Label();
            this.KrajTextBox = new System.Windows.Forms.TextBox();
            this.SkrijButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumnHeader,
            this.DatumColumnHeader,
            this.ZnesekColumnHeader});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(456, 64);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(431, 370);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IdColumnHeader
            // 
            this.IdColumnHeader.Text = "";
            this.IdColumnHeader.Width = 75;
            // 
            // DatumColumnHeader
            // 
            this.DatumColumnHeader.Text = "Datum vnosa";
            this.DatumColumnHeader.Width = 142;
            // 
            // ZnesekColumnHeader
            // 
            this.ZnesekColumnHeader.Text = "Znesek";
            this.ZnesekColumnHeader.Width = 200;
            // 
            // NazajButton
            // 
            this.NazajButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.NazajButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NazajButton.FlatAppearance.BorderSize = 3;
            this.NazajButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.NazajButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.NazajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NazajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazajButton.ForeColor = System.Drawing.SystemColors.Control;
            this.NazajButton.Location = new System.Drawing.Point(341, 12);
            this.NazajButton.Name = "NazajButton";
            this.NazajButton.Size = new System.Drawing.Size(215, 46);
            this.NazajButton.TabIndex = 1;
            this.NazajButton.Text = "Nazaj";
            this.NazajButton.UseVisualStyleBackColor = false;
            this.NazajButton.Click += new System.EventHandler(this.NazajButton_Click);
            // 
            // DatumOdDateTimePicker
            // 
            this.DatumOdDateTimePicker.Location = new System.Drawing.Point(957, 127);
            this.DatumOdDateTimePicker.Name = "DatumOdDateTimePicker";
            this.DatumOdDateTimePicker.Size = new System.Drawing.Size(243, 22);
            this.DatumOdDateTimePicker.TabIndex = 2;
            // 
            // DatumDoDateTimePicker
            // 
            this.DatumDoDateTimePicker.Location = new System.Drawing.Point(957, 229);
            this.DatumDoDateTimePicker.Name = "DatumDoDateTimePicker";
            this.DatumDoDateTimePicker.Size = new System.Drawing.Size(243, 22);
            this.DatumDoDateTimePicker.TabIndex = 3;
            // 
            // SpremeniDatumButton
            // 
            this.SpremeniDatumButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SpremeniDatumButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SpremeniDatumButton.FlatAppearance.BorderSize = 3;
            this.SpremeniDatumButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.SpremeniDatumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.SpremeniDatumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpremeniDatumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SpremeniDatumButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SpremeniDatumButton.Location = new System.Drawing.Point(957, 302);
            this.SpremeniDatumButton.Name = "SpremeniDatumButton";
            this.SpremeniDatumButton.Size = new System.Drawing.Size(243, 51);
            this.SpremeniDatumButton.TabIndex = 4;
            this.SpremeniDatumButton.Text = "Spremeni datum";
            this.SpremeniDatumButton.UseVisualStyleBackColor = false;
            this.SpremeniDatumButton.Click += new System.EventHandler(this.SpremeniDatumButton_Click);
            // 
            // IzbiraDatumaLabel
            // 
            this.IzbiraDatumaLabel.AutoSize = true;
            this.IzbiraDatumaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IzbiraDatumaLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.IzbiraDatumaLabel.Location = new System.Drawing.Point(991, 34);
            this.IzbiraDatumaLabel.Name = "IzbiraDatumaLabel";
            this.IzbiraDatumaLabel.Size = new System.Drawing.Size(189, 36);
            this.IzbiraDatumaLabel.TabIndex = 5;
            this.IzbiraDatumaLabel.Text = "Izberi datum";
            // 
            // OdLabel
            // 
            this.OdLabel.AutoSize = true;
            this.OdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.OdLabel.Location = new System.Drawing.Point(1060, 92);
            this.OdLabel.Name = "OdLabel";
            this.OdLabel.Size = new System.Drawing.Size(33, 20);
            this.OdLabel.TabIndex = 6;
            this.OdLabel.Text = "Od";
            // 
            // DoLabel
            // 
            this.DoLabel.AutoSize = true;
            this.DoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DoLabel.Location = new System.Drawing.Point(1061, 182);
            this.DoLabel.Name = "DoLabel";
            this.DoLabel.Size = new System.Drawing.Size(33, 20);
            this.DoLabel.TabIndex = 7;
            this.DoLabel.Text = "Do";
            // 
            // PonastaviButton
            // 
            this.PonastaviButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.PonastaviButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PonastaviButton.FlatAppearance.BorderSize = 3;
            this.PonastaviButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.PonastaviButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.PonastaviButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PonastaviButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PonastaviButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PonastaviButton.Location = new System.Drawing.Point(957, 370);
            this.PonastaviButton.Name = "PonastaviButton";
            this.PonastaviButton.Size = new System.Drawing.Size(243, 46);
            this.PonastaviButton.TabIndex = 8;
            this.PonastaviButton.Text = "Ponastavi";
            this.PonastaviButton.UseVisualStyleBackColor = false;
            this.PonastaviButton.Click += new System.EventHandler(this.PonastaviButton_Click);
            // 
            // PodrobnoButton
            // 
            this.PodrobnoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.PodrobnoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PodrobnoButton.FlatAppearance.BorderSize = 3;
            this.PodrobnoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.PodrobnoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.PodrobnoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PodrobnoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PodrobnoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PodrobnoButton.Location = new System.Drawing.Point(566, 446);
            this.PodrobnoButton.Name = "PodrobnoButton";
            this.PodrobnoButton.Size = new System.Drawing.Size(214, 46);
            this.PodrobnoButton.TabIndex = 9;
            this.PodrobnoButton.Text = "Podrobno";
            this.PodrobnoButton.UseVisualStyleBackColor = false;
            this.PodrobnoButton.Click += new System.EventHandler(this.PodrobnoButton_Click);
            // 
            // ArhivLabel
            // 
            this.ArhivLabel.AutoSize = true;
            this.ArhivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArhivLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ArhivLabel.Location = new System.Drawing.Point(633, 9);
            this.ArhivLabel.Name = "ArhivLabel";
            this.ArhivLabel.Size = new System.Drawing.Size(90, 36);
            this.ArhivLabel.TabIndex = 10;
            this.ArhivLabel.Text = "Arhiv";
            // 
            // PodrbnoLabel
            // 
            this.PodrbnoLabel.AutoSize = true;
            this.PodrbnoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PodrbnoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PodrbnoLabel.Location = new System.Drawing.Point(64, 18);
            this.PodrbnoLabel.Name = "PodrbnoLabel";
            this.PodrbnoLabel.Size = new System.Drawing.Size(155, 36);
            this.PodrbnoLabel.TabIndex = 11;
            this.PodrbnoLabel.Text = "Podrobno";
            // 
            // ZnesekLabel
            // 
            this.ZnesekLabel.AutoSize = true;
            this.ZnesekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZnesekLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ZnesekLabel.Location = new System.Drawing.Point(113, 149);
            this.ZnesekLabel.Name = "ZnesekLabel";
            this.ZnesekLabel.Size = new System.Drawing.Size(68, 20);
            this.ZnesekLabel.TabIndex = 12;
            this.ZnesekLabel.Text = "Znesek";
            // 
            // DatumLabel
            // 
            this.DatumLabel.AutoSize = true;
            this.DatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatumLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DatumLabel.Location = new System.Drawing.Point(112, 70);
            this.DatumLabel.Name = "DatumLabel";
            this.DatumLabel.Size = new System.Drawing.Size(64, 20);
            this.DatumLabel.TabIndex = 13;
            this.DatumLabel.Text = "Datum";
            // 
            // ZnesekTextBox
            // 
            this.ZnesekTextBox.Enabled = false;
            this.ZnesekTextBox.Location = new System.Drawing.Point(19, 185);
            this.ZnesekTextBox.Name = "ZnesekTextBox";
            this.ZnesekTextBox.Size = new System.Drawing.Size(238, 22);
            this.ZnesekTextBox.TabIndex = 14;
            // 
            // LokacijaTextBox
            // 
            this.LokacijaTextBox.Enabled = false;
            this.LokacijaTextBox.Location = new System.Drawing.Point(19, 271);
            this.LokacijaTextBox.Name = "LokacijaTextBox";
            this.LokacijaTextBox.Size = new System.Drawing.Size(238, 22);
            this.LokacijaTextBox.TabIndex = 15;
            // 
            // DatumDateTimePicker
            // 
            this.DatumDateTimePicker.Enabled = false;
            this.DatumDateTimePicker.Location = new System.Drawing.Point(19, 105);
            this.DatumDateTimePicker.Name = "DatumDateTimePicker";
            this.DatumDateTimePicker.Size = new System.Drawing.Size(238, 22);
            this.DatumDateTimePicker.TabIndex = 16;
            // 
            // LokacijaLabel
            // 
            this.LokacijaLabel.AutoSize = true;
            this.LokacijaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LokacijaLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LokacijaLabel.Location = new System.Drawing.Point(102, 233);
            this.LokacijaLabel.Name = "LokacijaLabel";
            this.LokacijaLabel.Size = new System.Drawing.Size(79, 20);
            this.LokacijaLabel.TabIndex = 17;
            this.LokacijaLabel.Text = "Lokacija";
            // 
            // KrajLabel
            // 
            this.KrajLabel.AutoSize = true;
            this.KrajLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KrajLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.KrajLabel.Location = new System.Drawing.Point(113, 314);
            this.KrajLabel.Name = "KrajLabel";
            this.KrajLabel.Size = new System.Drawing.Size(43, 20);
            this.KrajLabel.TabIndex = 18;
            this.KrajLabel.Text = "Kraj";
            // 
            // KrajTextBox
            // 
            this.KrajTextBox.Enabled = false;
            this.KrajTextBox.Location = new System.Drawing.Point(19, 348);
            this.KrajTextBox.Name = "KrajTextBox";
            this.KrajTextBox.Size = new System.Drawing.Size(238, 22);
            this.KrajTextBox.TabIndex = 19;
            // 
            // SkrijButton
            // 
            this.SkrijButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SkrijButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SkrijButton.FlatAppearance.BorderSize = 3;
            this.SkrijButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.SkrijButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.SkrijButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkrijButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SkrijButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SkrijButton.Location = new System.Drawing.Point(19, 407);
            this.SkrijButton.Name = "SkrijButton";
            this.SkrijButton.Size = new System.Drawing.Size(238, 48);
            this.SkrijButton.TabIndex = 20;
            this.SkrijButton.Text = "Skrij";
            this.SkrijButton.UseVisualStyleBackColor = false;
            this.SkrijButton.Click += new System.EventHandler(this.SkrijButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DatumDateTimePicker);
            this.groupBox1.Controls.Add(this.SkrijButton);
            this.groupBox1.Controls.Add(this.PodrbnoLabel);
            this.groupBox1.Controls.Add(this.KrajTextBox);
            this.groupBox1.Controls.Add(this.ZnesekLabel);
            this.groupBox1.Controls.Add(this.KrajLabel);
            this.groupBox1.Controls.Add(this.DatumLabel);
            this.groupBox1.Controls.Add(this.LokacijaLabel);
            this.groupBox1.Controls.Add(this.ZnesekTextBox);
            this.groupBox1.Controls.Add(this.LokacijaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(45, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 479);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ArhivForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1260, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ArhivLabel);
            this.Controls.Add(this.PodrobnoButton);
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
            this.Load += new System.EventHandler(this.ArhivForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button PodrobnoButton;
        private System.Windows.Forms.Label ArhivLabel;
        private System.Windows.Forms.Label PodrbnoLabel;
        private System.Windows.Forms.Label ZnesekLabel;
        private System.Windows.Forms.Label DatumLabel;
        private System.Windows.Forms.TextBox ZnesekTextBox;
        private System.Windows.Forms.TextBox LokacijaTextBox;
        private System.Windows.Forms.DateTimePicker DatumDateTimePicker;
        private System.Windows.Forms.Label LokacijaLabel;
        private System.Windows.Forms.Label KrajLabel;
        private System.Windows.Forms.TextBox KrajTextBox;
        private System.Windows.Forms.Button SkrijButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}