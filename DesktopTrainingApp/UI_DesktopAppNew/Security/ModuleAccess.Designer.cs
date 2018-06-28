namespace UI_DesktopAppNew.Security
{
    partial class ModuleAccess
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
            this.label26 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbModules = new System.Windows.Forms.ComboBox();
            this.lsbxFunctionsAll = new System.Windows.Forms.ListBox();
            this.lsbxFunctionsSelected = new System.Windows.Forms.ListBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commonTemplate1
            // 
            this.commonTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonTemplate1.Location = new System.Drawing.Point(0, 0);
            this.commonTemplate1.Name = "commonTemplate1";
            this.commonTemplate1.Size = new System.Drawing.Size(803, 653);
            this.commonTemplate1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Module Access";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label26.Location = new System.Drawing.Point(31, 74);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 13);
            this.label26.TabIndex = 42;
            this.label26.Text = "Role:";
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(74, 72);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(130, 21);
            this.cmbRoles.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(219, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Modules :";
            // 
            // cmbModules
            // 
            this.cmbModules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModules.FormattingEnabled = true;
            this.cmbModules.Location = new System.Drawing.Point(287, 72);
            this.cmbModules.Name = "cmbModules";
            this.cmbModules.Size = new System.Drawing.Size(130, 21);
            this.cmbModules.TabIndex = 43;
            this.cmbModules.SelectedIndexChanged += new System.EventHandler(this.cmbModules_SelectedIndexChanged);
            // 
            // lsbxFunctionsAll
            // 
            this.lsbxFunctionsAll.FormattingEnabled = true;
            this.lsbxFunctionsAll.Location = new System.Drawing.Point(34, 148);
            this.lsbxFunctionsAll.Name = "lsbxFunctionsAll";
            this.lsbxFunctionsAll.Size = new System.Drawing.Size(270, 355);
            this.lsbxFunctionsAll.TabIndex = 45;
            // 
            // lsbxFunctionsSelected
            // 
            this.lsbxFunctionsSelected.FormattingEnabled = true;
            this.lsbxFunctionsSelected.Location = new System.Drawing.Point(447, 148);
            this.lsbxFunctionsSelected.Name = "lsbxFunctionsSelected";
            this.lsbxFunctionsSelected.Size = new System.Drawing.Size(270, 355);
            this.lsbxFunctionsSelected.TabIndex = 46;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(357, 262);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(39, 29);
            this.btnForward.TabIndex = 47;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(357, 308);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(39, 29);
            this.btnBackward.TabIndex = 48;
            this.btnBackward.Text = "<<";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // ModuleAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 653);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.lsbxFunctionsSelected);
            this.Controls.Add(this.lsbxFunctionsAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbModules);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commonTemplate1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModuleAccess";
            this.Text = "ModuleAccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.CommonTemplate commonTemplate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbModules;
        private System.Windows.Forms.ListBox lsbxFunctionsAll;
        private System.Windows.Forms.ListBox lsbxFunctionsSelected;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
    }
}