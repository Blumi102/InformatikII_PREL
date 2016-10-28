namespace WahlaufgabenI_A02
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Start_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.ergebnis_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.durchlaufe_label = new System.Windows.Forms.Label();
            this.Zeit_label = new System.Windows.Forms.Label();
            this.aussen_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ergebnis_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.BackColor = System.Drawing.Color.Green;
            this.Start_button.Location = new System.Drawing.Point(12, 12);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(91, 43);
            this.Start_button.TabIndex = 0;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(130, 32);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 2;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            // 
            // ergebnis_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.ergebnis_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ergebnis_chart.Legends.Add(legend1);
            this.ergebnis_chart.Location = new System.Drawing.Point(130, 80);
            this.ergebnis_chart.Name = "ergebnis_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ergebnis_chart.Series.Add(series1);
            this.ergebnis_chart.Size = new System.Drawing.Size(580, 300);
            this.ergebnis_chart.TabIndex = 3;
            this.ergebnis_chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Durchläufe: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zeit [ms]: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Treffer außerhalb: ";
            // 
            // durchlaufe_label
            // 
            this.durchlaufe_label.AutoSize = true;
            this.durchlaufe_label.Location = new System.Drawing.Point(74, 131);
            this.durchlaufe_label.Name = "durchlaufe_label";
            this.durchlaufe_label.Size = new System.Drawing.Size(13, 13);
            this.durchlaufe_label.TabIndex = 10;
            this.durchlaufe_label.Text = "0";
            // 
            // Zeit_label
            // 
            this.Zeit_label.AutoSize = true;
            this.Zeit_label.Location = new System.Drawing.Point(74, 181);
            this.Zeit_label.Name = "Zeit_label";
            this.Zeit_label.Size = new System.Drawing.Size(13, 13);
            this.Zeit_label.TabIndex = 11;
            this.Zeit_label.Text = "0";
            // 
            // aussen_label
            // 
            this.aussen_label.AutoSize = true;
            this.aussen_label.Location = new System.Drawing.Point(74, 333);
            this.aussen_label.Name = "aussen_label";
            this.aussen_label.Size = new System.Drawing.Size(13, 13);
            this.aussen_label.TabIndex = 12;
            this.aussen_label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 424);
            this.Controls.Add(this.aussen_label);
            this.Controls.Add(this.Zeit_label);
            this.Controls.Add(this.durchlaufe_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ergebnis_chart);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.Start_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ergebnis_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart ergebnis_chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label duchlaufe_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ausserhalb_label;
        private System.Windows.Forms.Label durchlaufe_label;
        private System.Windows.Forms.Label Zeit_label;
        private System.Windows.Forms.Label aussen_label;
    }
}

