namespace UI_DesktopAppNew
{
    partial class DashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.commonTemplate1 = new UI_DesktopAppNew.UserControls.CommonTemplate();
            this.chartTrainingTypes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRunningStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrainingTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRunningStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // commonTemplate1
            // 
            this.commonTemplate1.BackColor = System.Drawing.Color.White;
            this.commonTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonTemplate1.Location = new System.Drawing.Point(0, 0);
            this.commonTemplate1.Name = "commonTemplate1";
            this.commonTemplate1.Size = new System.Drawing.Size(840, 729);
            this.commonTemplate1.TabIndex = 0;
            // 
            // chartTrainingTypes
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTrainingTypes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTrainingTypes.Legends.Add(legend1);
            this.chartTrainingTypes.Location = new System.Drawing.Point(25, 77);
            this.chartTrainingTypes.Name = "chartTrainingTypes";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Training";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Support";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Exams";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Proxy";
            this.chartTrainingTypes.Series.Add(series1);
            this.chartTrainingTypes.Series.Add(series2);
            this.chartTrainingTypes.Series.Add(series3);
            this.chartTrainingTypes.Series.Add(series4);
            this.chartTrainingTypes.Size = new System.Drawing.Size(391, 237);
            this.chartTrainingTypes.TabIndex = 1;
            this.chartTrainingTypes.Text = "Chart Training Types";
            title1.Name = "TrainingTypes";
            title1.Text = "Training Types";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartTrainingTypes.Titles.Add(title1);
            // 
            // chartRunningStatus
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRunningStatus.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRunningStatus.Legends.Add(legend2);
            this.chartRunningStatus.Location = new System.Drawing.Point(422, 77);
            this.chartRunningStatus.Name = "chartRunningStatus";
            series5.ChartArea = "ChartArea1";
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Following";
            series6.ChartArea = "ChartArea1";
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Scheduled";
            series7.ChartArea = "ChartArea1";
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "Holding";
            series8.ChartArea = "ChartArea1";
            series8.IsValueShownAsLabel = true;
            series8.Legend = "Legend1";
            series8.Name = "Accepted";
            series9.ChartArea = "ChartArea1";
            series9.IsValueShownAsLabel = true;
            series9.Legend = "Legend1";
            series9.Name = "Rejected";
            this.chartRunningStatus.Series.Add(series5);
            this.chartRunningStatus.Series.Add(series6);
            this.chartRunningStatus.Series.Add(series7);
            this.chartRunningStatus.Series.Add(series8);
            this.chartRunningStatus.Series.Add(series9);
            this.chartRunningStatus.Size = new System.Drawing.Size(370, 249);
            this.chartRunningStatus.TabIndex = 2;
            this.chartRunningStatus.Text = "Chart Running Status";
            title2.Name = "Current Running Status";
            title2.Text = "Current Running Status";
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartRunningStatus.Titles.Add(title2);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(25, 345);
            this.chart3.Name = "chart3";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart3.Series.Add(series10);
            this.chart3.Size = new System.Drawing.Size(391, 237);
            this.chart3.TabIndex = 3;
            this.chart3.Text = "chartProgress";
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(422, 345);
            this.chart4.Name = "chart4";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chart4.Series.Add(series11);
            this.chart4.Size = new System.Drawing.Size(373, 237);
            this.chart4.TabIndex = 4;
            this.chart4.Text = "chartAmounts";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 729);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chartRunningStatus);
            this.Controls.Add(this.chartTrainingTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commonTemplate1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTrainingTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRunningStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.CommonTemplate commonTemplate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrainingTypes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRunningStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}