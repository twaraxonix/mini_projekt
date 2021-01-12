namespace mini_projekt
{
    partial class InsertForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DatumLabel = new System.Windows.Forms.Label();
            this.DatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ZnesekLabel = new System.Windows.Forms.Label();
            this.LokacijaLabel = new System.Windows.Forms.Label();
            this.LokacijaComboBox = new System.Windows.Forms.ComboBox();
            this.ZnesekTextBox = new System.Windows.Forms.TextBox();
            this.DodajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(323, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj";
            // 
            // DatumLabel
            // 
            this.DatumLabel.AutoSize = true;
            this.DatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatumLabel.Location = new System.Drawing.Point(339, 87);
            this.DatumLabel.Name = "DatumLabel";
            this.DatumLabel.Size = new System.Drawing.Size(69, 25);
            this.DatumLabel.TabIndex = 1;
            this.DatumLabel.Text = "Datum";
            // 
            // DatumDateTimePicker
            // 
            this.DatumDateTimePicker.Location = new System.Drawing.Point(233, 124);
            this.DatumDateTimePicker.Name = "DatumDateTimePicker";
            this.DatumDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.DatumDateTimePicker.TabIndex = 2;
            // 
            // ZnesekLabel
            // 
            this.ZnesekLabel.AutoSize = true;
            this.ZnesekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZnesekLabel.Location = new System.Drawing.Point(339, 185);
            this.ZnesekLabel.Name = "ZnesekLabel";
            this.ZnesekLabel.Size = new System.Drawing.Size(77, 25);
            this.ZnesekLabel.TabIndex = 3;
            this.ZnesekLabel.Text = "Znesek";
            // 
            // LokacijaLabel
            // 
            this.LokacijaLabel.AutoSize = true;
            this.LokacijaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LokacijaLabel.Location = new System.Drawing.Point(339, 265);
            this.LokacijaLabel.Name = "LokacijaLabel";
            this.LokacijaLabel.Size = new System.Drawing.Size(84, 25);
            this.LokacijaLabel.TabIndex = 4;
            this.LokacijaLabel.Text = "Lokacija";
            // 
            // LokacijaComboBox
            // 
            this.LokacijaComboBox.FormattingEnabled = true;
            this.LokacijaComboBox.Location = new System.Drawing.Point(233, 318);
            this.LokacijaComboBox.Name = "LokacijaComboBox";
            this.LokacijaComboBox.Size = new System.Drawing.Size(265, 24);
            this.LokacijaComboBox.TabIndex = 5;
            // 
            // ZnesekTextBox
            // 
            this.ZnesekTextBox.Location = new System.Drawing.Point(233, 221);
            this.ZnesekTextBox.Name = "ZnesekTextBox";
            this.ZnesekTextBox.Size = new System.Drawing.Size(270, 22);
            this.ZnesekTextBox.TabIndex = 6;
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(329, 370);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(94, 31);
            this.DodajButton.TabIndex = 7;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.ZnesekTextBox);
            this.Controls.Add(this.LokacijaComboBox);
            this.Controls.Add(this.LokacijaLabel);
            this.Controls.Add(this.ZnesekLabel);
            this.Controls.Add(this.DatumDateTimePicker);
            this.Controls.Add(this.DatumLabel);
            this.Controls.Add(this.label1);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DatumLabel;
        private System.Windows.Forms.DateTimePicker DatumDateTimePicker;
        private System.Windows.Forms.Label ZnesekLabel;
        private System.Windows.Forms.Label LokacijaLabel;
        private System.Windows.Forms.ComboBox LokacijaComboBox;
        private System.Windows.Forms.TextBox ZnesekTextBox;
        private System.Windows.Forms.Button DodajButton;
    }
}