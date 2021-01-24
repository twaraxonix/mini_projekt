namespace mini_projekt
{
    partial class OsebniPodatkiForm
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
            this.EmailLabel = new System.Windows.Forms.Label();
            this.priimekLabel = new System.Windows.Forms.Label();
            this.ImeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Geslolabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(336, 220);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email";
            // 
            // priimekLabel
            // 
            this.priimekLabel.AutoSize = true;
            this.priimekLabel.Location = new System.Drawing.Point(328, 151);
            this.priimekLabel.Name = "priimekLabel";
            this.priimekLabel.Size = new System.Drawing.Size(54, 17);
            this.priimekLabel.TabIndex = 1;
            this.priimekLabel.Text = "Priimek";
            // 
            // ImeLabel
            // 
            this.ImeLabel.AutoSize = true;
            this.ImeLabel.Location = new System.Drawing.Point(339, 83);
            this.ImeLabel.Name = "ImeLabel";
            this.ImeLabel.Size = new System.Drawing.Size(30, 17);
            this.ImeLabel.TabIndex = 2;
            this.ImeLabel.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(237, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Osebni podatki";
            // 
            // Geslolabel
            // 
            this.Geslolabel.AutoSize = true;
            this.Geslolabel.Location = new System.Drawing.Point(336, 285);
            this.Geslolabel.Name = "Geslolabel";
            this.Geslolabel.Size = new System.Drawing.Size(45, 17);
            this.Geslolabel.TabIndex = 4;
            this.Geslolabel.Text = "Geslo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(352, 301);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(360, 309);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(368, 317);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            // 
            // OsebniPodatkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Geslolabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ImeLabel);
            this.Controls.Add(this.priimekLabel);
            this.Controls.Add(this.EmailLabel);
            this.Name = "OsebniPodatkiForm";
            this.Text = "OsebniPodatkiForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label priimekLabel;
        private System.Windows.Forms.Label ImeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Geslolabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}