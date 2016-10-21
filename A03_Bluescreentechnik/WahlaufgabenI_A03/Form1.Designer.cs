namespace WahlaufgabenI_A03
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
            this.pic1_box = new System.Windows.Forms.PictureBox();
            this.pic2_box = new System.Windows.Forms.PictureBox();
            this.erg_box = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Convert_button = new System.Windows.Forms.Button();
            this.pic1_button = new System.Windows.Forms.Button();
            this.pic2_button = new System.Windows.Forms.Button();
            this.select_pic_dialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic1_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erg_box)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1_box
            // 
            this.pic1_box.Location = new System.Drawing.Point(12, 42);
            this.pic1_box.Name = "pic1_box";
            this.pic1_box.Size = new System.Drawing.Size(250, 250);
            this.pic1_box.TabIndex = 0;
            this.pic1_box.TabStop = false;
            // 
            // pic2_box
            // 
            this.pic2_box.Location = new System.Drawing.Point(268, 42);
            this.pic2_box.Name = "pic2_box";
            this.pic2_box.Size = new System.Drawing.Size(250, 250);
            this.pic2_box.TabIndex = 1;
            this.pic2_box.TabStop = false;
            // 
            // erg_box
            // 
            this.erg_box.Location = new System.Drawing.Point(638, 42);
            this.erg_box.Name = "erg_box";
            this.erg_box.Size = new System.Drawing.Size(250, 250);
            this.erg_box.TabIndex = 2;
            this.erg_box.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original 1 (Vordergrund vor Bluescreen)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Original 2 (Hintergrund)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ergebnis";
            // 
            // Convert_button
            // 
            this.Convert_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert_button.Location = new System.Drawing.Point(540, 122);
            this.Convert_button.Name = "Convert_button";
            this.Convert_button.Size = new System.Drawing.Size(75, 75);
            this.Convert_button.TabIndex = 6;
            this.Convert_button.Text = "OK";
            this.Convert_button.UseVisualStyleBackColor = true;
            this.Convert_button.Click += new System.EventHandler(this.Convert_button_Click);
            // 
            // pic1_button
            // 
            this.pic1_button.Location = new System.Drawing.Point(93, 298);
            this.pic1_button.Name = "pic1_button";
            this.pic1_button.Size = new System.Drawing.Size(93, 23);
            this.pic1_button.TabIndex = 7;
            this.pic1_button.Text = "Select Picture";
            this.pic1_button.UseVisualStyleBackColor = true;
            this.pic1_button.Click += new System.EventHandler(this.pic1_button_Click);
            // 
            // pic2_button
            // 
            this.pic2_button.Location = new System.Drawing.Point(351, 298);
            this.pic2_button.Name = "pic2_button";
            this.pic2_button.Size = new System.Drawing.Size(93, 23);
            this.pic2_button.TabIndex = 8;
            this.pic2_button.Text = "Select Picture";
            this.pic2_button.UseVisualStyleBackColor = true;
            this.pic2_button.Click += new System.EventHandler(this.pic2_button_Click);
            // 
            // select_pic_dialog
            // 
            this.select_pic_dialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 358);
            this.Controls.Add(this.pic2_button);
            this.Controls.Add(this.pic1_button);
            this.Controls.Add(this.Convert_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.erg_box);
            this.Controls.Add(this.pic2_box);
            this.Controls.Add(this.pic1_box);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic1_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erg_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1_box;
        private System.Windows.Forms.PictureBox pic2_box;
        private System.Windows.Forms.PictureBox erg_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Convert_button;
        private System.Windows.Forms.Button pic1_button;
        private System.Windows.Forms.Button pic2_button;
        private System.Windows.Forms.OpenFileDialog select_pic_dialog;
    }
}

