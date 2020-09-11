namespace Program
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AirportTextBox = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(125, 327);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(562, 110);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // AirportTextBox
            // 
            this.AirportTextBox.Location = new System.Drawing.Point(125, 12);
            this.AirportTextBox.Name = "AirportTextBox";
            this.AirportTextBox.Size = new System.Drawing.Size(100, 20);
            this.AirportTextBox.TabIndex = 1;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(37, 15);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(88, 13);
            this.A.TabIndex = 2;
            this.A.Text = "Add new Airport: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "AddAirport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.A);
            this.Controls.Add(this.AirportTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox AirportTextBox;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Button button1;
    }
}