namespace E4mini_Admin_tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.us = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tprgPars = new System.Windows.Forms.Button();
            this.mon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.us);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 51);
            this.panel1.TabIndex = 0;
            // 
            // us
            // 
            this.us.BackColor = System.Drawing.SystemColors.Highlight;
            this.us.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.us.Location = new System.Drawing.Point(3, 3);
            this.us.MaximumSize = new System.Drawing.Size(100, 100);
            this.us.Name = "us";
            this.us.Size = new System.Drawing.Size(82, 29);
            this.us.TabIndex = 0;
            this.us.Text = "Users";
            this.us.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.us.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(3, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 191);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Logs";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 164);
            this.textBox1.TabIndex = 0;
            // 
            // tprgPars
            // 
            this.tprgPars.Location = new System.Drawing.Point(71, 80);
            this.tprgPars.Name = "tprgPars";
            this.tprgPars.Size = new System.Drawing.Size(105, 40);
            this.tprgPars.TabIndex = 7;
            this.tprgPars.Text = "Создать торговую пару";
            this.tprgPars.UseVisualStyleBackColor = true;
            this.tprgPars.Click += new System.EventHandler(this.tprgPars_Click);
            // 
            // mon
            // 
            this.mon.Location = new System.Drawing.Point(71, 14);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(105, 40);
            this.mon.TabIndex = 8;
            this.mon.Text = "Добавить новую валюту";
            this.mon.Click += new System.EventHandler(this.mon_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mon);
            this.panel3.Controls.Add(this.tprgPars);
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 148);
            this.panel3.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(262, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button us;
        private Panel panel3;
      public TextBox textBox1;
        private Label label4;
        private Button tprgPars;
        private Button mon;
    }
}