namespace EvdekiHesap
{
    partial class Istatistikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Dağılım1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Dağılım2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dağılım1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dağılım2)).BeginInit();
            this.SuspendLayout();
            // 
            // Dağılım1
            // 
            this.Dağılım1.BackColor = System.Drawing.Color.Transparent;
            this.Dağılım1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.Dağılım1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Dağılım1.Legends.Add(legend3);
            this.Dağılım1.Location = new System.Drawing.Point(42, 69);
            this.Dağılım1.Name = "Dağılım1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Dağılım1";
            this.Dağılım1.Series.Add(series3);
            this.Dağılım1.Size = new System.Drawing.Size(566, 492);
            this.Dağılım1.TabIndex = 0;
            this.Dağılım1.Text = "chart1";
            this.Dağılım1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Dağılım2
            // 
            this.Dağılım2.BackColor = System.Drawing.Color.Transparent;
            this.Dağılım2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Dağılım2.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Dağılım2.BorderlineColor = System.Drawing.Color.DarkRed;
            chartArea4.Name = "ChartArea1";
            this.Dağılım2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Dağılım2.Legends.Add(legend4);
            this.Dağılım2.Location = new System.Drawing.Point(691, 69);
            this.Dağılım2.Name = "Dağılım2";
            this.Dağılım2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Birikim Miktarı";
            this.Dağılım2.Series.Add(series4);
            this.Dağılım2.Size = new System.Drawing.Size(537, 492);
            this.Dağılım2.TabIndex = 1;
            this.Dağılım2.Text = "chart2";
            title2.Name = "Birikim Miktarı";
            this.Dağılım2.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(764, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bankalara Göre Birikim Dağılım Grafiği";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(191, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Harcama Dağılım Grafiği";
            // 
            // Istatistikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1283, 620);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dağılım2);
            this.Controls.Add(this.Dağılım1);
            this.Name = "Istatistikler";
            this.Text = "Istatistikler";
            this.Load += new System.EventHandler(this.Istatistikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dağılım1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dağılım2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Dağılım1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Dağılım2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}