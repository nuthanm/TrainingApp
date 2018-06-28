namespace UI_DesktopAppNew.Enquiry
{
    partial class EnquiryForm
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
            this.dgEnquiries = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEnquiry = new System.Windows.Forms.Button();
            this.txtBxTechnology = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtBxStudentFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxSEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBxSMobileNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxTrainerMobileNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxTrainerEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxTrainerFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmBxTrainers = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmBxStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBxRemarks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbTraineeTypes = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtStudentReferredBy = new System.Windows.Forms.TextBox();
            this.txtTrainerReferredBy = new System.Windows.Forms.TextBox();
            this.dgViewTrainingFees = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.TrainingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commonTemplate1 = new UI_DesktopAppNew.UserControls.CommonTemplate();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnquiries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewTrainingFees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enquiry Form";
            // 
            // dgEnquiries
            // 
            this.dgEnquiries.AllowUserToAddRows = false;
            this.dgEnquiries.AllowUserToDeleteRows = false;
            this.dgEnquiries.AllowUserToResizeColumns = false;
            this.dgEnquiries.AllowUserToResizeRows = false;
            this.dgEnquiries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEnquiries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgEnquiries.Location = new System.Drawing.Point(26, 566);
            this.dgEnquiries.MultiSelect = false;
            this.dgEnquiries.Name = "dgEnquiries";
            this.dgEnquiries.ReadOnly = true;
            this.dgEnquiries.RowHeadersVisible = false;
            this.dgEnquiries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgEnquiries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgEnquiries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEnquiries.ShowCellToolTips = false;
            this.dgEnquiries.Size = new System.Drawing.Size(781, 150);
            this.dgEnquiries.TabIndex = 15;
            this.dgEnquiries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEnquiries_CellContentClick);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(593, 537);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEnquiry
            // 
            this.btnEnquiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnquiry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.btnEnquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnquiry.ForeColor = System.Drawing.Color.White;
            this.btnEnquiry.Location = new System.Drawing.Point(708, 537);
            this.btnEnquiry.Name = "btnEnquiry";
            this.btnEnquiry.Size = new System.Drawing.Size(99, 23);
            this.btnEnquiry.TabIndex = 13;
            this.btnEnquiry.Text = "Add Enquiry Details";
            this.btnEnquiry.UseVisualStyleBackColor = false;
            this.btnEnquiry.Click += new System.EventHandler(this.btnEnquiry_Click);
            // 
            // txtBxTechnology
            // 
            this.txtBxTechnology.Location = new System.Drawing.Point(119, 90);
            this.txtBxTechnology.Name = "txtBxTechnology";
            this.txtBxTechnology.Size = new System.Drawing.Size(282, 20);
            this.txtBxTechnology.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(21, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Technology :";
            // 
            // txtBxStudentName
            // 
            this.txtBxStudentName.Location = new System.Drawing.Point(119, 125);
            this.txtBxStudentName.Name = "txtBxStudentName";
            this.txtBxStudentName.Size = new System.Drawing.Size(282, 20);
            this.txtBxStudentName.TabIndex = 2;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.lblStudentName.Location = new System.Drawing.Point(15, 129);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(99, 13);
            this.lblStudentName.TabIndex = 13;
            this.lblStudentName.Text = " Student Name :";
            // 
            // txtBxStudentFee
            // 
            this.txtBxStudentFee.Location = new System.Drawing.Point(119, 157);
            this.txtBxStudentFee.Name = "txtBxStudentFee";
            this.txtBxStudentFee.Size = new System.Drawing.Size(282, 20);
            this.txtBxStudentFee.TabIndex = 3;
            this.txtBxStudentFee.Leave += new System.EventHandler(this.txtBxStudentFee_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(17, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = " Student Fee :";
            // 
            // txtBxSEmail
            // 
            this.txtBxSEmail.Location = new System.Drawing.Point(119, 190);
            this.txtBxSEmail.Name = "txtBxSEmail";
            this.txtBxSEmail.Size = new System.Drawing.Size(282, 20);
            this.txtBxSEmail.TabIndex = 4;
            this.txtBxSEmail.Leave += new System.EventHandler(this.txtBxSEmail_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label12.Location = new System.Drawing.Point(17, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Student Email :";
            // 
            // txtBxSMobileNo
            // 
            this.txtBxSMobileNo.Location = new System.Drawing.Point(119, 223);
            this.txtBxSMobileNo.Name = "txtBxSMobileNo";
            this.txtBxSMobileNo.Size = new System.Drawing.Size(281, 20);
            this.txtBxSMobileNo.TabIndex = 5;
            this.txtBxSMobileNo.Leave += new System.EventHandler(this.txtBxSMobileNo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(17, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Mobile :";
            // 
            // txtBxTrainerMobileNo
            // 
            this.txtBxTrainerMobileNo.Location = new System.Drawing.Point(530, 194);
            this.txtBxTrainerMobileNo.Name = "txtBxTrainerMobileNo";
            this.txtBxTrainerMobileNo.Size = new System.Drawing.Size(210, 20);
            this.txtBxTrainerMobileNo.TabIndex = 9;
            this.txtBxTrainerMobileNo.Leave += new System.EventHandler(this.txtBxTrainerMobileNo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(426, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Trainer Mobile :";
            // 
            // txtBxTrainerEmail
            // 
            this.txtBxTrainerEmail.Location = new System.Drawing.Point(530, 160);
            this.txtBxTrainerEmail.Name = "txtBxTrainerEmail";
            this.txtBxTrainerEmail.Size = new System.Drawing.Size(210, 20);
            this.txtBxTrainerEmail.TabIndex = 8;
            this.txtBxTrainerEmail.Leave += new System.EventHandler(this.txtBxTrainerEmail_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(427, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Trainer Email :";
            // 
            // txtBxTrainerFee
            // 
            this.txtBxTrainerFee.Location = new System.Drawing.Point(530, 129);
            this.txtBxTrainerFee.Name = "txtBxTrainerFee";
            this.txtBxTrainerFee.Size = new System.Drawing.Size(210, 20);
            this.txtBxTrainerFee.TabIndex = 7;
            this.txtBxTrainerFee.Leave += new System.EventHandler(this.txtBxTrainerFee_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label7.Location = new System.Drawing.Point(427, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Trainer Fee :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label8.Location = new System.Drawing.Point(427, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Trainer :";
            // 
            // cmBxTrainers
            // 
            this.cmBxTrainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxTrainers.FormattingEnabled = true;
            this.cmBxTrainers.Location = new System.Drawing.Point(530, 93);
            this.cmBxTrainers.Name = "cmBxTrainers";
            this.cmBxTrainers.Size = new System.Drawing.Size(210, 21);
            this.cmBxTrainers.TabIndex = 6;
            this.cmBxTrainers.SelectedIndexChanged += new System.EventHandler(this.cmBxTrainers_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label9.Location = new System.Drawing.Point(431, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Status :";
            // 
            // cmBxStatus
            // 
            this.cmBxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxStatus.FormattingEnabled = true;
            this.cmBxStatus.Items.AddRange(new object[] {
            "-- Select Status --",
            "Following",
            "Scheduled",
            "Accepted",
            "Rejected",
            "Holding"});
            this.cmBxStatus.Location = new System.Drawing.Point(530, 227);
            this.cmBxStatus.Name = "cmBxStatus";
            this.cmBxStatus.Size = new System.Drawing.Size(210, 21);
            this.cmBxStatus.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label10.Location = new System.Drawing.Point(23, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Remarks :";
            // 
            // txtBxRemarks
            // 
            this.txtBxRemarks.Location = new System.Drawing.Point(119, 265);
            this.txtBxRemarks.Multiline = true;
            this.txtBxRemarks.Name = "txtBxRemarks";
            this.txtBxRemarks.Size = new System.Drawing.Size(281, 48);
            this.txtBxRemarks.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(431, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Trainer Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(23, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "Student Details";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label24.Location = new System.Drawing.Point(23, 540);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(108, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "Search by Name :";
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.Location = new System.Drawing.Point(137, 537);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(264, 20);
            this.txtBxSearch.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(488, 537);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label14.Location = new System.Drawing.Point(427, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Trainee Types :";
            // 
            // cmbTraineeTypes
            // 
            this.cmbTraineeTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTraineeTypes.FormattingEnabled = true;
            this.cmbTraineeTypes.Items.AddRange(new object[] {
            "-- Select Status --",
            "Following",
            "Scheduled",
            "Accepted",
            "Rejected",
            "Holding"});
            this.cmbTraineeTypes.Location = new System.Drawing.Point(530, 265);
            this.cmbTraineeTypes.Name = "cmbTraineeTypes";
            this.cmbTraineeTypes.Size = new System.Drawing.Size(210, 21);
            this.cmbTraineeTypes.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label15.Location = new System.Drawing.Point(21, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Referred By :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label16.Location = new System.Drawing.Point(431, 305);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Referred By :";
            // 
            // txtStudentReferredBy
            // 
            this.txtStudentReferredBy.Location = new System.Drawing.Point(119, 323);
            this.txtStudentReferredBy.Name = "txtStudentReferredBy";
            this.txtStudentReferredBy.Size = new System.Drawing.Size(281, 20);
            this.txtStudentReferredBy.TabIndex = 46;
            // 
            // txtTrainerReferredBy
            // 
            this.txtTrainerReferredBy.Location = new System.Drawing.Point(530, 300);
            this.txtTrainerReferredBy.Name = "txtTrainerReferredBy";
            this.txtTrainerReferredBy.Size = new System.Drawing.Size(210, 20);
            this.txtTrainerReferredBy.TabIndex = 47;
            // 
            // dgViewTrainingFees
            // 
            this.dgViewTrainingFees.AllowUserToAddRows = false;
            this.dgViewTrainingFees.AllowUserToDeleteRows = false;
            this.dgViewTrainingFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewTrainingFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrainingType,
            this.Fee});
            this.dgViewTrainingFees.Location = new System.Drawing.Point(430, 375);
            this.dgViewTrainingFees.Name = "dgViewTrainingFees";
            this.dgViewTrainingFees.ReadOnly = true;
            this.dgViewTrainingFees.Size = new System.Drawing.Size(377, 138);
            this.dgViewTrainingFees.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(431, 345);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 16);
            this.label17.TabIndex = 49;
            this.label17.Text = "Trainer Fee Details";
            // 
            // TrainingType
            // 
            this.TrainingType.DataPropertyName = "TypeName";
            this.TrainingType.HeaderText = "Training Type";
            this.TrainingType.Name = "TrainingType";
            this.TrainingType.ReadOnly = true;
            // 
            // Fee
            // 
            this.Fee.DataPropertyName = "Price";
            this.Fee.HeaderText = "Fee";
            this.Fee.Name = "Fee";
            this.Fee.ReadOnly = true;
            // 
            // commonTemplate1
            // 
            this.commonTemplate1.AutoScroll = true;
            this.commonTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonTemplate1.Location = new System.Drawing.Point(0, 0);
            this.commonTemplate1.Name = "commonTemplate1";
            this.commonTemplate1.Size = new System.Drawing.Size(848, 788);
            this.commonTemplate1.TabIndex = 43;
            // 
            // EnquiryForm
            // 
            this.AcceptButton = this.btnEnquiry;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(848, 788);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgViewTrainingFees);
            this.Controls.Add(this.txtTrainerReferredBy);
            this.Controls.Add(this.txtStudentReferredBy);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbTraineeTypes);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBxRemarks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmBxStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmBxTrainers);
            this.Controls.Add(this.txtBxTrainerMobileNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxTrainerEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxTrainerFee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBxSMobileNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxSEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBxStudentFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtBxTechnology);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnquiry);
            this.Controls.Add(this.dgEnquiries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commonTemplate1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnquiryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enquiry Form";
            this.Load += new System.EventHandler(this.EnquiryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEnquiries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewTrainingFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgEnquiries;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEnquiry;
        private System.Windows.Forms.TextBox txtBxTechnology;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtBxStudentFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxSEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBxSMobileNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxTrainerMobileNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxTrainerEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxTrainerFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmBxTrainers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmBxStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBxRemarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBxSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbTraineeTypes;
        private UserControls.CommonTemplate commonTemplate1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtStudentReferredBy;
        private System.Windows.Forms.TextBox txtTrainerReferredBy;
        private System.Windows.Forms.DataGridView dgViewTrainingFees;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee;
    }
}