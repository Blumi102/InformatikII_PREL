﻿namespace Basic_G08
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zeichnen_Panel = new System.Windows.Forms.Panel();
            this.Amplituden_slider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Frequenz_slider = new System.Windows.Forms.TrackBar();
            this.Zeit_t = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Amplituden_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frequenz_slider)).BeginInit();
            this.SuspendLayout();
            // 
            // zeichnen_Panel
            // 
            this.zeichnen_Panel.Location = new System.Drawing.Point(23, 81);
            this.zeichnen_Panel.Name = "zeichnen_Panel";
            this.zeichnen_Panel.Size = new System.Drawing.Size(900, 410);
            this.zeichnen_Panel.TabIndex = 0;
            this.zeichnen_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.zeichnen_Panel_Paint);
            // 
            // Amplituden_slider
            // 
            this.Amplituden_slider.Location = new System.Drawing.Point(23, 30);
            this.Amplituden_slider.Name = "Amplituden_slider";
            this.Amplituden_slider.Size = new System.Drawing.Size(104, 45);
            this.Amplituden_slider.TabIndex = 1;
            this.Amplituden_slider.Value = 2;
            this.Amplituden_slider.Scroll += new System.EventHandler(this.Amplituden_slider_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ampltude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Frequenz";
            // 
            // Frequenz_slider
            // 
            this.Frequenz_slider.Location = new System.Drawing.Point(133, 30);
            this.Frequenz_slider.Minimum = 3;
            this.Frequenz_slider.Name = "Frequenz_slider";
            this.Frequenz_slider.Size = new System.Drawing.Size(104, 45);
            this.Frequenz_slider.TabIndex = 3;
            this.Frequenz_slider.Value = 3;
            this.Frequenz_slider.Scroll += new System.EventHandler(this.Frequenz_slider_Scroll);
            // 
            // Zeit_t
            // 
            this.Zeit_t.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Frequenz_slider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Amplituden_slider);
            this.Controls.Add(this.zeichnen_Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Amplituden_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frequenz_slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel zeichnen_Panel;
        private System.Windows.Forms.TrackBar Amplituden_slider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Frequenz_slider;
        private System.Windows.Forms.Timer Zeit_t;
    }
}

