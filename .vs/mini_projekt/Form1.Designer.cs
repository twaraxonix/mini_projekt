﻿namespace mini_projekt
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PrijavaGroupBox = new System.Windows.Forms.GroupBox();
            this.PrijavaButton = new System.Windows.Forms.Button();
            this.Registracija1Button = new System.Windows.Forms.Button();
            this.GesloLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GesloTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.RegistracijaGroupBox = new System.Windows.Forms.GroupBox();
            this.NazajButton = new System.Windows.Forms.Button();
            this.RegistracijaButton = new System.Windows.Forms.Button();
            this.PriimekGesloLabel = new System.Windows.Forms.Label();
            this.ImeLabel = new System.Windows.Forms.Label();
            this.PriimekTextBox = new System.Windows.Forms.TextBox();
            this.ImeTextBox = new System.Windows.Forms.TextBox();
            this.Geslo2Label = new System.Windows.Forms.Label();
            this.Email2Label = new System.Windows.Forms.Label();
            this.Geslo2textBox = new System.Windows.Forms.TextBox();
            this.Email2TextBox = new System.Windows.Forms.TextBox();
            this.PrijavaGroupBox.SuspendLayout();
            this.RegistracijaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // PrijavaGroupBox
            // 
            this.PrijavaGroupBox.Controls.Add(this.PrijavaButton);
            this.PrijavaGroupBox.Controls.Add(this.Registracija1Button);
            this.PrijavaGroupBox.Controls.Add(this.GesloLabel);
            this.PrijavaGroupBox.Controls.Add(this.EmailLabel);
            this.PrijavaGroupBox.Controls.Add(this.GesloTextBox);
            this.PrijavaGroupBox.Controls.Add(this.EmailTextBox);
            this.PrijavaGroupBox.Location = new System.Drawing.Point(12, 69);
            this.PrijavaGroupBox.Name = "PrijavaGroupBox";
            this.PrijavaGroupBox.Size = new System.Drawing.Size(309, 265);
            this.PrijavaGroupBox.TabIndex = 2;
            this.PrijavaGroupBox.TabStop = false;
            this.PrijavaGroupBox.Text = "Prijava";
            // 
            // PrijavaButton
            // 
            this.PrijavaButton.Location = new System.Drawing.Point(74, 193);
            this.PrijavaButton.Name = "PrijavaButton";
            this.PrijavaButton.Size = new System.Drawing.Size(91, 35);
            this.PrijavaButton.TabIndex = 5;
            this.PrijavaButton.Text = "Prijavi se";
            this.PrijavaButton.UseVisualStyleBackColor = true;
            this.PrijavaButton.Click += new System.EventHandler(this.PrijavaButton_Click);
            // 
            // Registracija1Button
            // 
            this.Registracija1Button.Location = new System.Drawing.Point(210, 193);
            this.Registracija1Button.Name = "Registracija1Button";
            this.Registracija1Button.Size = new System.Drawing.Size(93, 35);
            this.Registracija1Button.TabIndex = 4;
            this.Registracija1Button.Text = "Registracija";
            this.Registracija1Button.UseVisualStyleBackColor = true;
            this.Registracija1Button.Click += new System.EventHandler(this.Registracija1Button_Click);
            // 
            // GesloLabel
            // 
            this.GesloLabel.AutoSize = true;
            this.GesloLabel.Location = new System.Drawing.Point(108, 114);
            this.GesloLabel.Name = "GesloLabel";
            this.GesloLabel.Size = new System.Drawing.Size(45, 17);
            this.GesloLabel.TabIndex = 3;
            this.GesloLabel.Text = "Geslo";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(107, 28);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email";
            // 
            // GesloTextBox
            // 
            this.GesloTextBox.Location = new System.Drawing.Point(32, 145);
            this.GesloTextBox.Name = "GesloTextBox";
            this.GesloTextBox.Size = new System.Drawing.Size(228, 22);
            this.GesloTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(32, 57);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(228, 22);
            this.EmailTextBox.TabIndex = 0;
            // 
            // RegistracijaGroupBox
            // 
            this.RegistracijaGroupBox.Controls.Add(this.NazajButton);
            this.RegistracijaGroupBox.Controls.Add(this.RegistracijaButton);
            this.RegistracijaGroupBox.Controls.Add(this.PriimekGesloLabel);
            this.RegistracijaGroupBox.Controls.Add(this.ImeLabel);
            this.RegistracijaGroupBox.Controls.Add(this.PriimekTextBox);
            this.RegistracijaGroupBox.Controls.Add(this.ImeTextBox);
            this.RegistracijaGroupBox.Controls.Add(this.Geslo2Label);
            this.RegistracijaGroupBox.Controls.Add(this.Email2Label);
            this.RegistracijaGroupBox.Controls.Add(this.Geslo2textBox);
            this.RegistracijaGroupBox.Controls.Add(this.Email2TextBox);
            this.RegistracijaGroupBox.Location = new System.Drawing.Point(342, 82);
            this.RegistracijaGroupBox.Name = "RegistracijaGroupBox";
            this.RegistracijaGroupBox.Size = new System.Drawing.Size(405, 362);
            this.RegistracijaGroupBox.TabIndex = 4;
            this.RegistracijaGroupBox.TabStop = false;
            this.RegistracijaGroupBox.Text = "Registracija";
            // 
            // NazajButton
            // 
            this.NazajButton.Location = new System.Drawing.Point(324, 316);
            this.NazajButton.Name = "NazajButton";
            this.NazajButton.Size = new System.Drawing.Size(75, 23);
            this.NazajButton.TabIndex = 6;
            this.NazajButton.Text = "Nazaj";
            this.NazajButton.UseVisualStyleBackColor = true;
            this.NazajButton.Click += new System.EventHandler(this.NazajButton_Click);
            // 
            // RegistracijaButton
            // 
            this.RegistracijaButton.Location = new System.Drawing.Point(152, 308);
            this.RegistracijaButton.Name = "RegistracijaButton";
            this.RegistracijaButton.Size = new System.Drawing.Size(104, 31);
            this.RegistracijaButton.TabIndex = 12;
            this.RegistracijaButton.Text = "Registriraj se";
            this.RegistracijaButton.UseVisualStyleBackColor = true;
            this.RegistracijaButton.Click += new System.EventHandler(this.RegistracijaButton_Click);
            // 
            // PriimekGesloLabel
            // 
            this.PriimekGesloLabel.AutoSize = true;
            this.PriimekGesloLabel.Location = new System.Drawing.Point(168, 92);
            this.PriimekGesloLabel.Name = "PriimekGesloLabel";
            this.PriimekGesloLabel.Size = new System.Drawing.Size(54, 17);
            this.PriimekGesloLabel.TabIndex = 11;
            this.PriimekGesloLabel.Text = "Priimek";
            // 
            // ImeLabel
            // 
            this.ImeLabel.AutoSize = true;
            this.ImeLabel.Location = new System.Drawing.Point(175, 18);
            this.ImeLabel.Name = "ImeLabel";
            this.ImeLabel.Size = new System.Drawing.Size(30, 17);
            this.ImeLabel.TabIndex = 10;
            this.ImeLabel.Text = "Ime";
            // 
            // PriimekTextBox
            // 
            this.PriimekTextBox.Location = new System.Drawing.Point(96, 112);
            this.PriimekTextBox.Name = "PriimekTextBox";
            this.PriimekTextBox.Size = new System.Drawing.Size(228, 22);
            this.PriimekTextBox.TabIndex = 9;
            // 
            // ImeTextBox
            // 
            this.ImeTextBox.Location = new System.Drawing.Point(96, 44);
            this.ImeTextBox.Name = "ImeTextBox";
            this.ImeTextBox.Size = new System.Drawing.Size(228, 22);
            this.ImeTextBox.TabIndex = 8;
            // 
            // Geslo2Label
            // 
            this.Geslo2Label.AutoSize = true;
            this.Geslo2Label.Location = new System.Drawing.Point(168, 235);
            this.Geslo2Label.Name = "Geslo2Label";
            this.Geslo2Label.Size = new System.Drawing.Size(45, 17);
            this.Geslo2Label.TabIndex = 7;
            this.Geslo2Label.Text = "Geslo";
            // 
            // Email2Label
            // 
            this.Email2Label.AutoSize = true;
            this.Email2Label.Location = new System.Drawing.Point(171, 164);
            this.Email2Label.Name = "Email2Label";
            this.Email2Label.Size = new System.Drawing.Size(42, 17);
            this.Email2Label.TabIndex = 6;
            this.Email2Label.Text = "Email";
            // 
            // Geslo2textBox
            // 
            this.Geslo2textBox.Location = new System.Drawing.Point(96, 268);
            this.Geslo2textBox.Name = "Geslo2textBox";
            this.Geslo2textBox.Size = new System.Drawing.Size(228, 22);
            this.Geslo2textBox.TabIndex = 5;
            // 
            // Email2TextBox
            // 
            this.Email2TextBox.Location = new System.Drawing.Point(96, 193);
            this.Email2TextBox.Name = "Email2TextBox";
            this.Email2TextBox.Size = new System.Drawing.Size(228, 22);
            this.Email2TextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegistracijaGroupBox);
            this.Controls.Add(this.PrijavaGroupBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PrijavaGroupBox.ResumeLayout(false);
            this.PrijavaGroupBox.PerformLayout();
            this.RegistracijaGroupBox.ResumeLayout(false);
            this.RegistracijaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox PrijavaGroupBox;
        private System.Windows.Forms.Label GesloLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox GesloTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.GroupBox RegistracijaGroupBox;
        private System.Windows.Forms.Label PriimekGesloLabel;
        private System.Windows.Forms.Label ImeLabel;
        private System.Windows.Forms.TextBox PriimekTextBox;
        private System.Windows.Forms.TextBox ImeTextBox;
        private System.Windows.Forms.Label Geslo2Label;
        private System.Windows.Forms.Label Email2Label;
        private System.Windows.Forms.TextBox Geslo2textBox;
        private System.Windows.Forms.TextBox Email2TextBox;
        private System.Windows.Forms.Button PrijavaButton;
        private System.Windows.Forms.Button Registracija1Button;
        private System.Windows.Forms.Button NazajButton;
        private System.Windows.Forms.Button RegistracijaButton;
    }
}
