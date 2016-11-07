namespace Basic_G04
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
            this.Amplitudenslider2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Wellenlaengen_slider2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Wellenlaengen_slider1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.Amplitudenslider1 = new System.Windows.Forms.TrackBar();
            this.ampl1_box = new System.Windows.Forms.TextBox();
            this.freq1_box = new System.Windows.Forms.TextBox();
            this.ampl2_box = new System.Windows.Forms.TextBox();
            this.freq2_box = new System.Windows.Forms.TextBox();
            this.Zeichnen_Panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Amplitudenslider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wellenlaengen_slider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wellenlaengen_slider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amplitudenslider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Amplitudenslider2
            // 
            this.Amplitudenslider2.BackColor = System.Drawing.Color.White;
            this.Amplitudenslider2.Location = new System.Drawing.Point(280, 31);
            this.Amplitudenslider2.Name = "Amplitudenslider2";
            this.Amplitudenslider2.Size = new System.Drawing.Size(104, 45);
            this.Amplitudenslider2.TabIndex = 0;
            this.Amplitudenslider2.Value = 5;
            this.Amplitudenslider2.Scroll += new System.EventHandler(this.Amplitudenslider2_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amplitude 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(405, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wellenlänge 2";
            // 
            // Wellenlaengen_slider2
            // 
            this.Wellenlaengen_slider2.BackColor = System.Drawing.Color.White;
            this.Wellenlaengen_slider2.Location = new System.Drawing.Point(390, 31);
            this.Wellenlaengen_slider2.Minimum = 1;
            this.Wellenlaengen_slider2.Name = "Wellenlaengen_slider2";
            this.Wellenlaengen_slider2.Size = new System.Drawing.Size(104, 45);
            this.Wellenlaengen_slider2.TabIndex = 2;
            this.Wellenlaengen_slider2.Value = 6;
            this.Wellenlaengen_slider2.Scroll += new System.EventHandler(this.Wellenlaengenslider2_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wellenlänge 1";
            // 
            // Wellenlaengen_slider1
            // 
            this.Wellenlaengen_slider1.BackColor = System.Drawing.Color.White;
            this.Wellenlaengen_slider1.Location = new System.Drawing.Point(122, 31);
            this.Wellenlaengen_slider1.Minimum = 1;
            this.Wellenlaengen_slider1.Name = "Wellenlaengen_slider1";
            this.Wellenlaengen_slider1.Size = new System.Drawing.Size(104, 45);
            this.Wellenlaengen_slider1.TabIndex = 7;
            this.Wellenlaengen_slider1.Value = 5;
            this.Wellenlaengen_slider1.Scroll += new System.EventHandler(this.Wellenlaengenslider1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amplitude 1";
            // 
            // Amplitudenslider1
            // 
            this.Amplitudenslider1.BackColor = System.Drawing.Color.White;
            this.Amplitudenslider1.Location = new System.Drawing.Point(12, 31);
            this.Amplitudenslider1.Name = "Amplitudenslider1";
            this.Amplitudenslider1.Size = new System.Drawing.Size(104, 45);
            this.Amplitudenslider1.TabIndex = 5;
            this.Amplitudenslider1.Value = 5;
            this.Amplitudenslider1.Scroll += new System.EventHandler(this.Amplitudenslider1_Scroll);
            // 
            // ampl1_box
            // 
            this.ampl1_box.Location = new System.Drawing.Point(12, 82);
            this.ampl1_box.Name = "ampl1_box";
            this.ampl1_box.Size = new System.Drawing.Size(104, 20);
            this.ampl1_box.TabIndex = 10;
            this.ampl1_box.Text = "5";
            // 
            // freq1_box
            // 
            this.freq1_box.Location = new System.Drawing.Point(122, 82);
            this.freq1_box.Name = "freq1_box";
            this.freq1_box.Size = new System.Drawing.Size(104, 20);
            this.freq1_box.TabIndex = 11;
            this.freq1_box.Text = "5";
            // 
            // ampl2_box
            // 
            this.ampl2_box.Location = new System.Drawing.Point(280, 82);
            this.ampl2_box.Name = "ampl2_box";
            this.ampl2_box.Size = new System.Drawing.Size(104, 20);
            this.ampl2_box.TabIndex = 12;
            this.ampl2_box.Text = "5";
            // 
            // freq2_box
            // 
            this.freq2_box.Location = new System.Drawing.Point(390, 82);
            this.freq2_box.Name = "freq2_box";
            this.freq2_box.Size = new System.Drawing.Size(104, 20);
            this.freq2_box.TabIndex = 13;
            this.freq2_box.Text = "6";
            // 
            // Zeichnen_Panel
            // 
            this.Zeichnen_Panel.BackColor = System.Drawing.Color.Silver;
            this.Zeichnen_Panel.Location = new System.Drawing.Point(10, 110);
            this.Zeichnen_Panel.Name = "Zeichnen_Panel";
            this.Zeichnen_Panel.Size = new System.Drawing.Size(880, 420);
            this.Zeichnen_Panel.TabIndex = 14;
            this.Zeichnen_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Zeichnen_Panel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 546);
            this.Controls.Add(this.Zeichnen_Panel);
            this.Controls.Add(this.freq2_box);
            this.Controls.Add(this.ampl2_box);
            this.Controls.Add(this.freq1_box);
            this.Controls.Add(this.ampl1_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Wellenlaengen_slider1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Amplitudenslider1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Wellenlaengen_slider2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Amplitudenslider2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Amplitudenslider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wellenlaengen_slider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wellenlaengen_slider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amplitudenslider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Amplitudenslider2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Wellenlaengen_slider2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar Wellenlaengen_slider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar Amplitudenslider1;
        private System.Windows.Forms.TextBox ampl1_box;
        private System.Windows.Forms.TextBox freq1_box;
        private System.Windows.Forms.TextBox ampl2_box;
        private System.Windows.Forms.TextBox freq2_box;
        private System.Windows.Forms.Panel Zeichnen_Panel;
    }
}

