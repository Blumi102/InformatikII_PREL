namespace Basic_G03
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
            this.label1 = new System.Windows.Forms.Label();
            this.Wuerfelnbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.eins_abs = new System.Windows.Forms.Label();
            this.eins_rel = new System.Windows.Forms.Label();
            this.zwei_rel = new System.Windows.Forms.Label();
            this.zwei_abs = new System.Windows.Forms.Label();
            this.drei_rel = new System.Windows.Forms.Label();
            this.drei_abs = new System.Windows.Forms.Label();
            this.vier_rel = new System.Windows.Forms.Label();
            this.vier_abs = new System.Windows.Forms.Label();
            this.fuenf_rel = new System.Windows.Forms.Label();
            this.fuenf_abs = new System.Windows.Forms.Label();
            this.sechs_rel = new System.Windows.Forms.Label();
            this.sechs_abs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mit Klick auf \"Würfeln\" werden 1 Mio Zufallzahlen von 1 bis 6 erzeugt";
            // 
            // Wuerfelnbutton
            // 
            this.Wuerfelnbutton.Location = new System.Drawing.Point(153, 49);
            this.Wuerfelnbutton.Name = "Wuerfelnbutton";
            this.Wuerfelnbutton.Size = new System.Drawing.Size(75, 23);
            this.Wuerfelnbutton.TabIndex = 1;
            this.Wuerfelnbutton.Text = "Würfeln";
            this.Wuerfelnbutton.UseVisualStyleBackColor = true;
            this.Wuerfelnbutton.Click += new System.EventHandler(this.Wuerfelnbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Welche Zahl kam wie oft vor?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Zahl";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Absolute Häufigkeit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Relative Häufigkeit (in %)";
            // 
            // eins_abs
            // 
            this.eins_abs.Location = new System.Drawing.Point(151, 162);
            this.eins_abs.Name = "eins_abs";
            this.eins_abs.Size = new System.Drawing.Size(41, 13);
            this.eins_abs.TabIndex = 15;
            // 
            // eins_rel
            // 
            this.eins_rel.Location = new System.Drawing.Point(290, 162);
            this.eins_rel.Name = "eins_rel";
            this.eins_rel.Size = new System.Drawing.Size(41, 13);
            this.eins_rel.TabIndex = 16;
            // 
            // zwei_rel
            // 
            this.zwei_rel.Location = new System.Drawing.Point(290, 192);
            this.zwei_rel.Name = "zwei_rel";
            this.zwei_rel.Size = new System.Drawing.Size(41, 13);
            this.zwei_rel.TabIndex = 18;
            // 
            // zwei_abs
            // 
            this.zwei_abs.Location = new System.Drawing.Point(151, 192);
            this.zwei_abs.Name = "zwei_abs";
            this.zwei_abs.Size = new System.Drawing.Size(41, 13);
            this.zwei_abs.TabIndex = 17;
            // 
            // drei_rel
            // 
            this.drei_rel.Location = new System.Drawing.Point(290, 222);
            this.drei_rel.Name = "drei_rel";
            this.drei_rel.Size = new System.Drawing.Size(41, 13);
            this.drei_rel.TabIndex = 20;
            // 
            // drei_abs
            // 
            this.drei_abs.Location = new System.Drawing.Point(151, 222);
            this.drei_abs.Name = "drei_abs";
            this.drei_abs.Size = new System.Drawing.Size(41, 13);
            this.drei_abs.TabIndex = 19;
            // 
            // vier_rel
            // 
            this.vier_rel.Location = new System.Drawing.Point(290, 252);
            this.vier_rel.Name = "vier_rel";
            this.vier_rel.Size = new System.Drawing.Size(41, 13);
            this.vier_rel.TabIndex = 22;
            // 
            // vier_abs
            // 
            this.vier_abs.Location = new System.Drawing.Point(151, 252);
            this.vier_abs.Name = "vier_abs";
            this.vier_abs.Size = new System.Drawing.Size(41, 13);
            this.vier_abs.TabIndex = 21;
            // 
            // fuenf_rel
            // 
            this.fuenf_rel.Location = new System.Drawing.Point(290, 282);
            this.fuenf_rel.Name = "fuenf_rel";
            this.fuenf_rel.Size = new System.Drawing.Size(41, 13);
            this.fuenf_rel.TabIndex = 24;
            // 
            // fuenf_abs
            // 
            this.fuenf_abs.Location = new System.Drawing.Point(151, 282);
            this.fuenf_abs.Name = "fuenf_abs";
            this.fuenf_abs.Size = new System.Drawing.Size(41, 13);
            this.fuenf_abs.TabIndex = 23;
            // 
            // sechs_rel
            // 
            this.sechs_rel.Location = new System.Drawing.Point(290, 312);
            this.sechs_rel.Name = "sechs_rel";
            this.sechs_rel.Size = new System.Drawing.Size(41, 13);
            this.sechs_rel.TabIndex = 26;
            // 
            // sechs_abs
            // 
            this.sechs_abs.Location = new System.Drawing.Point(151, 312);
            this.sechs_abs.Name = "sechs_abs";
            this.sechs_abs.Size = new System.Drawing.Size(41, 13);
            this.sechs_abs.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 355);
            this.Controls.Add(this.sechs_rel);
            this.Controls.Add(this.sechs_abs);
            this.Controls.Add(this.fuenf_rel);
            this.Controls.Add(this.fuenf_abs);
            this.Controls.Add(this.vier_rel);
            this.Controls.Add(this.vier_abs);
            this.Controls.Add(this.drei_rel);
            this.Controls.Add(this.drei_abs);
            this.Controls.Add(this.zwei_rel);
            this.Controls.Add(this.zwei_abs);
            this.Controls.Add(this.eins_rel);
            this.Controls.Add(this.eins_abs);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Wuerfelnbutton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Zahl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Wuerfelnbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label eins_abs;
        private System.Windows.Forms.Label eins_rel;
        private System.Windows.Forms.Label zwei_rel;
        private System.Windows.Forms.Label zwei_abs;
        private System.Windows.Forms.Label drei_rel;
        private System.Windows.Forms.Label drei_abs;
        private System.Windows.Forms.Label vier_rel;
        private System.Windows.Forms.Label vier_abs;
        private System.Windows.Forms.Label fuenf_rel;
        private System.Windows.Forms.Label fuenf_abs;
        private System.Windows.Forms.Label sechs_rel;
        private System.Windows.Forms.Label sechs_abs;
    }
}

