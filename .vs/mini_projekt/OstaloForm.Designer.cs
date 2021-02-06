namespace mini_projekt
{
    partial class OstaloForm
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NazajButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.KrajiButton = new System.Windows.Forms.Button();
            this.LokacijeButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(641, 290);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 162;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 191;
            // 
            // NazajButton
            // 
            this.NazajButton.Location = new System.Drawing.Point(37, 476);
            this.NazajButton.Name = "NazajButton";
            this.NazajButton.Size = new System.Drawing.Size(81, 31);
            this.NazajButton.TabIndex = 1;
            this.NazajButton.Text = "Nazaj";
            this.NazajButton.UseVisualStyleBackColor = true;
            this.NazajButton.Click += new System.EventHandler(this.NazajButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(380, 358);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 54);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Izbriši";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // KrajiButton
            // 
            this.KrajiButton.Location = new System.Drawing.Point(37, 358);
            this.KrajiButton.Name = "KrajiButton";
            this.KrajiButton.Size = new System.Drawing.Size(112, 54);
            this.KrajiButton.TabIndex = 3;
            this.KrajiButton.Text = "Kraji";
            this.KrajiButton.UseVisualStyleBackColor = true;
            this.KrajiButton.Click += new System.EventHandler(this.KrajiButton_Click);
            // 
            // LokacijeButton
            // 
            this.LokacijeButton.Location = new System.Drawing.Point(180, 358);
            this.LokacijeButton.Name = "LokacijeButton";
            this.LokacijeButton.Size = new System.Drawing.Size(95, 54);
            this.LokacijeButton.TabIndex = 4;
            this.LokacijeButton.Text = "Lokacije";
            this.LokacijeButton.UseVisualStyleBackColor = true;
            this.LokacijeButton.Click += new System.EventHandler(this.LokacijeButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OstaloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LokacijeButton);
            this.Controls.Add(this.KrajiButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NazajButton);
            this.Controls.Add(this.listView1);
            this.Name = "OstaloForm";
            this.Text = "OstaloForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button NazajButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button KrajiButton;
        private System.Windows.Forms.Button LokacijeButton;
        private System.Windows.Forms.Button button2;
    }
}