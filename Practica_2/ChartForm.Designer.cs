
namespace Practica_2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BttnShowChart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BttnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(2, 2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(796, 435);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // BttnShowChart
            // 
            this.BttnShowChart.Location = new System.Drawing.Point(12, 443);
            this.BttnShowChart.Name = "BttnShowChart";
            this.BttnShowChart.Size = new System.Drawing.Size(134, 57);
            this.BttnShowChart.TabIndex = 1;
            this.BttnShowChart.Text = "Нарисовать";
            this.BttnShowChart.UseVisualStyleBackColor = true;
            this.BttnShowChart.Click += new System.EventHandler(this.BttnShowChart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить в .docx";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveChartDOCX_Click);
            // 
            // BttnReturn
            // 
            this.BttnReturn.Location = new System.Drawing.Point(654, 444);
            this.BttnReturn.Name = "BttnReturn";
            this.BttnReturn.Size = new System.Drawing.Size(134, 56);
            this.BttnReturn.TabIndex = 3;
            this.BttnReturn.Text = "Назад";
            this.BttnReturn.UseVisualStyleBackColor = true;
            this.BttnReturn.Click += new System.EventHandler(this.BttnReturn_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.BttnReturn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BttnShowChart);
            this.Controls.Add(this.chart1);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BttnShowChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BttnReturn;
    }
}