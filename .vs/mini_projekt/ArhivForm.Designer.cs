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
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(455, 46);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(431, 370);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // NazajButton
            // 
            this.NazajButton.Location = new System.Drawing.Point(455, 427);
            this.NazajButton.Name = "NazajButton";
            this.NazajButton.Size = new System.Drawing.Size(85, 33);
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
            this.PonastaviButton.Click += new System.EventHandler(this.PonastaviButton_Click);
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
            // PodrobnoButton
            // 
            this.PodrobnoButton.Location = new System.Drawing.Point(627, 422);
            this.PodrobnoButton.Name = "PodrobnoButton";
            this.PodrobnoButton.Size = new System.Drawing.Size(92, 42);
            this.PodrobnoButton.TabIndex = 9;
            this.PodrobnoButton.Text = "Podrobno";
            this.PodrobnoButton.UseVisualStyleBackColor = true;
            this.PodrobnoButton.Click += new System.EventHandler(this.PodrobnoButton_Click);
            // 
            // ArhivLabel
            // 
            this.ArhivLabel.AutoSize = true;
            this.ArhivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArhivLabel.Location = new System.Drawing.Point(634, 9);
            this.ArhivLabel.Name = "ArhivLabel";
            this.ArhivLabel.Size = new System.Drawing.Size(85, 32);
            this.ArhivLabel.TabIndex = 10;
            this.ArhivLabel.Text = "Arhiv";
            // 
            // PodrbnoLabel
            // 
            this.PodrbnoLabel.AutoSize = true;
            this.PodrbnoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PodrbnoLabel.Location = new System.Drawing.Point(71, 4);
            this.PodrbnoLabel.Name = "PodrbnoLabel";
            this.PodrbnoLabel.Size = new System.Drawing.Size(105, 25);
            this.PodrbnoLabel.TabIndex = 11;
            this.PodrbnoLabel.Text = "Podrobno";
            // 
            // ZnesekLabel
            // 
            this.ZnesekLabel.AutoSize = true;
            this.ZnesekLabel.Location = new System.Drawing.Point(89, 145);
            this.ZnesekLabel.Name = "ZnesekLabel";
            this.ZnesekLabel.Size = new System.Drawing.Size(55, 17);
            this.ZnesekLabel.TabIndex = 12;
            this.ZnesekLabel.Text = "Znesek";
            // 
            // DatumLabel
            // 
            this.DatumLabel.AutoSize = true;
            this.DatumLabel.Location = new System.Drawing.Point(89, 51);
            this.DatumLabel.Name = "DatumLabel";
            this.DatumLabel.Size = new System.Drawing.Size(49, 17);
            this.DatumLabel.TabIndex = 13;
            this.DatumLabel.Text = "Datum";
            // 
            // ZnesekTextBox
            // 
            this.ZnesekTextBox.Location = new System.Drawing.Point(50, 165);
            this.ZnesekTextBox.Name = "ZnesekTextBox";
            this.ZnesekTextBox.Size = new System.Drawing.Size(126, 22);
            this.ZnesekTextBox.TabIndex = 14;
            // 
            // LokacijaTextBox
            // 
            this.LokacijaTextBox.Location = new System.Drawing.Point(19, 244);
            this.LokacijaTextBox.Name = "LokacijaTextBox";
            this.LokacijaTextBox.Size = new System.Drawing.Size(200, 22);
            this.LokacijaTextBox.TabIndex = 15;
            // 
            // DatumDateTimePicker
            // 
            this.DatumDateTimePicker.Location = new System.Drawing.Point(19, 83);
            this.DatumDateTimePicker.Name = "DatumDateTimePicker";
            this.DatumDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DatumDateTimePicker.TabIndex = 16;
            // 
            // LokacijaLabel
            // 
            this.LokacijaLabel.AutoSize = true;
            this.LokacijaLabel.Location = new System.Drawing.Point(84, 224);
            this.LokacijaLabel.Name = "LokacijaLabel";
            this.LokacijaLabel.Size = new System.Drawing.Size(60, 17);
            this.LokacijaLabel.TabIndex = 17;
            this.LokacijaLabel.Text = "Lokacija";
            // 
            // KrajLabel
            // 
            this.KrajLabel.AutoSize = true;
            this.KrajLabel.Location = new System.Drawing.Point(98, 296);
            this.KrajLabel.Name = "KrajLabel";
            this.KrajLabel.Size = new System.Drawing.Size(33, 17);
            this.KrajLabel.TabIndex = 18;
            this.KrajLabel.Text = "Kraj";
            // 
            // KrajTextBox
            // 
            this.KrajTextBox.Location = new System.Drawing.Point(19, 316);
            this.KrajTextBox.Name = "KrajTextBox";
            this.KrajTextBox.Size = new System.Drawing.Size(200, 22);
            this.KrajTextBox.TabIndex = 19;
            // 
            // SkrijButton
            // 
            this.SkrijButton.Location = new System.Drawing.Point(76, 366);
            this.SkrijButton.Name = "SkrijButton";
            this.SkrijButton.Size = new System.Drawing.Size(82, 33);
            this.SkrijButton.TabIndex = 20;
            this.SkrijButton.Text = "Skrij";
            this.SkrijButton.UseVisualStyleBackColor = true;
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
            this.groupBox1.Size = new System.Drawing.Size(263, 424);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ArhivForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 484);
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