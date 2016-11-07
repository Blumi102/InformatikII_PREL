namespace W02_gpx
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
            this.laenge_box = new System.Windows.Forms.TextBox();
            this.breite_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.select_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openfile_dialog = new System.Windows.Forms.OpenFileDialog();
            this.pfadlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laenge_box
            // 
            this.laenge_box.Location = new System.Drawing.Point(17, 178);
            this.laenge_box.Multiline = true;
            this.laenge_box.Name = "laenge_box";
            this.laenge_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.laenge_box.Size = new System.Drawing.Size(156, 355);
            this.laenge_box.TabIndex = 0;
            // 
            // breite_box
            // 
            this.breite_box.Location = new System.Drawing.Point(179, 178);
            this.breite_box.Multiline = true;
            this.breite_box.Name = "breite_box";
            this.breite_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.breite_box.Size = new System.Drawing.Size(156, 355);
            this.breite_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Längengrade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Breitengrade";
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(16, 12);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(179, 23);
            this.select_button.TabIndex = 4;
            this.select_button.Text = "GPX - Datei auswählen";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ausgewählte Datei: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Koordinaten anzeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openfile_dialog
            // 
            this.openfile_dialog.FileName = "openFileDialog1";
            // 
            // pfadlabel
            // 
            this.pfadlabel.Location = new System.Drawing.Point(20, 60);
            this.pfadlabel.Name = "pfadlabel";
            this.pfadlabel.Size = new System.Drawing.Size(315, 73);
            this.pfadlabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 568);
            this.Controls.Add(this.pfadlabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.breite_box);
            this.Controls.Add(this.laenge_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox laenge_box;
        private System.Windows.Forms.TextBox breite_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openfile_dialog;
        private System.Windows.Forms.Label pfadlabel;
    }
}

