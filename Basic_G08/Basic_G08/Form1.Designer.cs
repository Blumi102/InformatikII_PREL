namespace Basic_G08
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Ampltuden_slider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ampltuden_slider)).BeginInit();
            this.SuspendLayout();
            // 
            // zeichnen_Panel
            // 
            this.zeichnen_Panel.Location = new System.Drawing.Point(23, 81);
            this.zeichnen_Panel.Name = "zeichnen_Panel";
            this.zeichnen_Panel.Size = new System.Drawing.Size(900, 300);
            this.zeichnen_Panel.TabIndex = 0;
            this.zeichnen_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.zeichnen_Panel_Paint);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Ampltuden_slider
            // 
            this.Ampltuden_slider.Location = new System.Drawing.Point(23, 30);
            this.Ampltuden_slider.Name = "Ampltuden_slider";
            this.Ampltuden_slider.Size = new System.Drawing.Size(104, 45);
            this.Ampltuden_slider.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ampltuden_slider);
            this.Controls.Add(this.zeichnen_Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ampltuden_slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel zeichnen_Panel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TrackBar Ampltuden_slider;
        private System.Windows.Forms.Label label1;
    }
}

