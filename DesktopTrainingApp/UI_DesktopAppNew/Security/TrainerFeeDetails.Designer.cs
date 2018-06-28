namespace UI_DesktopAppNew.Security
{
    partial class TrainerFeeDetails
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
            this.commonTemplate1 = new UI_DesktopAppNew.UserControls.CommonTemplate();
            this.label2 = new System.Windows.Forms.Label();
            this.dgViewTrainerFeeDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewTrainerFeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // commonTemplate1
            // 
            this.commonTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonTemplate1.Location = new System.Drawing.Point(0, 0);
            this.commonTemplate1.Name = "commonTemplate1";
            this.commonTemplate1.Size = new System.Drawing.Size(484, 270);
            this.commonTemplate1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trainer Fee Details";
            // 
            // dgViewTrainerFeeDetails
            // 
            this.dgViewTrainerFeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewTrainerFeeDetails.Location = new System.Drawing.Point(12, 64);
            this.dgViewTrainerFeeDetails.Name = "dgViewTrainerFeeDetails";
            this.dgViewTrainerFeeDetails.Size = new System.Drawing.Size(460, 194);
            this.dgViewTrainerFeeDetails.TabIndex = 4;
            // 
            // TrainerFeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 270);
            this.ControlBox = false;
            this.Controls.Add(this.dgViewTrainerFeeDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commonTemplate1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TrainerFeeDetails";
            this.ShowInTaskbar = false;
            this.Text = "Trainer Fee Details";
            this.Load += new System.EventHandler(this.TrainerFeeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewTrainerFeeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.CommonTemplate commonTemplate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgViewTrainerFeeDetails;
    }
}