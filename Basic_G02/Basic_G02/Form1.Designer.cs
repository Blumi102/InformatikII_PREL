namespace Basic_G02
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
            this.Zaehlerbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nennerbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Ausgabebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Zaehlerbox
            // 
            this.Zaehlerbox.Location = new System.Drawing.Point(27, 43);
            this.Zaehlerbox.Name = "Zaehlerbox";
            this.Zaehlerbox.Size = new System.Drawing.Size(100, 20);
            this.Zaehlerbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "/";
            // 
            // Nennerbox
            // 
            this.Nennerbox.Location = new System.Drawing.Point(151, 43);
            this.Nennerbox.Name = "Nennerbox";
            this.Nennerbox.Size = new System.Drawing.Size(100, 20);
            this.Nennerbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitte geben Sie einen Bruch ein!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "(Zähler)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "(Nenner)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dezimalbruch anzeigen!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ausgabebox
            // 
            this.Ausgabebox.Location = new System.Drawing.Point(27, 85);
            this.Ausgabebox.Multiline = true;
            this.Ausgabebox.Name = "Ausgabebox";
            this.Ausgabebox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ausgabebox.Size = new System.Drawing.Size(343, 271);
            this.Ausgabebox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 384);
            this.Controls.Add(this.Ausgabebox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nennerbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zaehlerbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Zaehlerbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nennerbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Ausgabebox;
    }
}

