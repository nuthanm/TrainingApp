namespace UI_DesktopAppNew.Notifications
{
    partial class SendCampaign
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgViewCampaigns = new System.Windows.Forms.DataGridView();
            this.btnSendCampaign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCampaigns)).BeginInit();
            this.SuspendLayout();
            // 
            // commonTemplate1
            // 
            this.commonTemplate1.BackColor = System.Drawing.Color.White;
            this.commonTemplate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commonTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonTemplate1.Location = new System.Drawing.Point(0, 0);
            this.commonTemplate1.Name = "commonTemplate1";
            this.commonTemplate1.Size = new System.Drawing.Size(803, 653);
            this.commonTemplate1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Campaign Details";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.White;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserName.Location = new System.Drawing.Point(35, 92);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 13);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Lists :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // dgViewCampaigns
            // 
            this.dgViewCampaigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewCampaigns.Location = new System.Drawing.Point(38, 156);
            this.dgViewCampaigns.Name = "dgViewCampaigns";
            this.dgViewCampaigns.Size = new System.Drawing.Size(726, 467);
            this.dgViewCampaigns.TabIndex = 5;
            // 
            // btnSendCampaign
            // 
            this.btnSendCampaign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSendCampaign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.btnSendCampaign.FlatAppearance.BorderSize = 0;
            this.btnSendCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCampaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCampaign.ForeColor = System.Drawing.Color.White;
            this.btnSendCampaign.Location = new System.Drawing.Point(625, 92);
            this.btnSendCampaign.Name = "btnSendCampaign";
            this.btnSendCampaign.Size = new System.Drawing.Size(139, 40);
            this.btnSendCampaign.TabIndex = 6;
            this.btnSendCampaign.Text = "Send Campaign";
            this.btnSendCampaign.UseVisualStyleBackColor = false;
            // 
            // SendCampaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 653);
            this.ControlBox = false;
            this.Controls.Add(this.btnSendCampaign);
            this.Controls.Add(this.dgViewCampaigns);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commonTemplate1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendCampaign";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Campaign";
            this.Load += new System.EventHandler(this.SendCampaign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCampaigns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.CommonTemplate commonTemplate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgViewCampaigns;
        private System.Windows.Forms.Button btnSendCampaign;
    }
}