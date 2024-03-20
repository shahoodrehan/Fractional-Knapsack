namespace DSAKnap
{
    partial class ChartForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Exit_Lbl = new System.Windows.Forms.LinkLabel();
            this.Weight_Chart = new LiveCharts.WinForms.PieChart();
            this.Benefit_Chart = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Weight %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Benifit %";
            // 
            // Exit_Lbl
            // 
            this.Exit_Lbl.AutoSize = true;
            this.Exit_Lbl.Location = new System.Drawing.Point(690, 323);
            this.Exit_Lbl.Name = "Exit_Lbl";
            this.Exit_Lbl.Size = new System.Drawing.Size(31, 13);
            this.Exit_Lbl.TabIndex = 30;
            this.Exit_Lbl.TabStop = true;
            this.Exit_Lbl.Text = "EXIT";
            this.Exit_Lbl.Click += new System.EventHandler(this.Exit_Lbl_Click);
            // 
            // Weight_Chart
            // 
            this.Weight_Chart.Location = new System.Drawing.Point(22, 36);
            this.Weight_Chart.Name = "Weight_Chart";
            this.Weight_Chart.Size = new System.Drawing.Size(300, 240);
            this.Weight_Chart.TabIndex = 31;
            this.Weight_Chart.Text = "pieChart1";
            // 
            // Benefit_Chart
            // 
            this.Benefit_Chart.Location = new System.Drawing.Point(411, 36);
            this.Benefit_Chart.Name = "Benefit_Chart";
            this.Benefit_Chart.Size = new System.Drawing.Size(300, 240);
            this.Benefit_Chart.TabIndex = 32;
            this.Benefit_Chart.Text = "pieChart2";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(733, 345);
            this.Controls.Add(this.Benefit_Chart);
            this.Controls.Add(this.Weight_Chart);
            this.Controls.Add(this.Exit_Lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ChartForm";
            this.Text = "Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Exit_Lbl;
        private LiveCharts.WinForms.PieChart Weight_Chart;
        private LiveCharts.WinForms.PieChart Benefit_Chart;
    }
}