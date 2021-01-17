namespace mini_projekt
{
    partial class UpdateForm
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
            this.ZnesekTextBox = new System.Windows.Forms.TextBox();
            this.LokacijaComboBox = new System.Windows.Forms.ComboBox();
            this.LokacijaLabel = new System.Windows.Forms.Label();
            this.ZnesekLabel = new System.Windows.Forms.Label();
            this.DatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DatumLabel = new System.Windows.Forms.Label();
            this.SpremeniLabel = new System.Windows.Forms.Label();
            this.NazajButton = new System.Windows.Forms.Button();
            this.DodajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZnesekTextBox
            // 
            this.ZnesekTextBox.Location = new System.Drawing.Point(265, 235);
            this.ZnesekTextBox.Name = "ZnesekTextBox";
            this.ZnesekTextBox.Size = new System.Drawing.Size(270, 22);
            this.ZnesekTextBox.TabIndex = 12;
            // 
            // LokacijaComboBox
            // 
            this.LokacijaComboBox.FormattingEnabled = true;
            this.LokacijaComboBox.Location = new System.Drawing.Point(265, 317);
            this.LokacijaComboBox.Name = "LokacijaComboBox";
            this.LokacijaComboBox.Size = new System.Drawing.Size(265, 24);
            this.LokacijaComboBox.TabIndex = 11;
            // 
            // LokacijaLabel
            // 
            this.LokacijaLabel.AutoSize = true;
            this.LokacijaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LokacijaLabel.Location = new System.Drawing.Point(350, 289);
            this.LokacijaLabel.Name = "LokacijaLabel";
            this.LokacijaLabel.Size = new System.Drawing.Size(84, 25);
            this.LokacijaLabel.TabIndex = 10;
            this.LokacijaLabel.Text = "Lokacija";
            // 
            // ZnesekLabel
            // 
            this.ZnesekLabel.AutoSize = true;
            this.ZnesekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZnesekLabel.Location = new System.Drawing.Point(350, 207);
            this.ZnesekLabel.Name = "ZnesekLabel";
            this.ZnesekLabel.Size = new System.Drawing.Size(77, 25);
            this.ZnesekLabel.TabIndex = 9;
            this.ZnesekLabel.Text = "Znesek";
            // 
            // DatumDateTimePicker
            // 
            this.DatumDateTimePicker.Location = new System.Drawing.Point(265, 154);
            this.DatumDateTimePicker.Name = "DatumDateTimePicker";
            this.DatumDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.DatumDateTimePicker.TabIndex = 8;
            // 
            // DatumLabel
            // 
            this.DatumLabel.AutoSize = true;
            this.DatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatumLabel.Location = new System.Drawing.Point(350, 110);
            this.DatumLabel.Name = "DatumLabel";
            this.DatumLabel.Size = new System.Drawing.Size(69, 25);
            this.DatumLabel.TabIndex = 7;
            this.DatumLabel.Text = "Datum";
            // 
            // SpremeniLabel
            // 
            this.SpremeniLabel.AutoSize = true;
            this.SpremeniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SpremeniLabel.Location = new System.Drawing.Point(315, 32);
            this.SpremeniLabel.Name = "SpremeniLabel";
            this.SpremeniLabel.Size = new System.Drawing.Size(149, 36);
            this.SpremeniLabel.TabIndex = 13;
            this.SpremeniLabel.Text = "Spremeni";
            // 
            // NazajButton
            // 
            this.NazajButton.Location = new System.Drawing.Point(192, 369);
            this.NazajButton.Name = "NazajButton";
            this.NazajButton.Size = new System.Drawing.Size(92, 31);
            this.NazajButton.TabIndex = 15;
            this.NazajButton.Text = "Nazaj";
            this.NazajButton.UseVisualStyleBackColor = true;
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(345, 369);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(94, 31);
            this.DodajButton.TabIndex = 14;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NazajButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.SpremeniLabel);
            this.Controls.Add(this.ZnesekTextBox);
            this.Controls.Add(this.LokacijaComboBox);
            this.Controls.Add(this.LokacijaLabel);
            this.Controls.Add(this.ZnesekLabel);
            this.Controls.Add(this.DatumDateTimePicker);
            this.Controls.Add(this.DatumLabel);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ZnesekTextBox;
        private System.Windows.Forms.ComboBox LokacijaComboBox;
        private System.Windows.Forms.Label LokacijaLabel;
        private System.Windows.Forms.Label ZnesekLabel;
        private System.Windows.Forms.DateTimePicker DatumDateTimePicker;
        private System.Windows.Forms.Label DatumLabel;
        private System.Windows.Forms.Label SpremeniLabel;
        private System.Windows.Forms.Button NazajButton;
        private System.Windows.Forms.Button DodajButton;
    }
}