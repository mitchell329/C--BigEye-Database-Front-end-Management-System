namespace BigEye
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnCaseAssignMaintenance = new System.Windows.Forms.Button();
            this.btnCaseMaintenance = new System.Windows.Forms.Button();
            this.btnEquipmentMaintenance = new System.Windows.Forms.Button();
            this.btnInvestigatorMaintenance = new System.Windows.Forms.Button();
            this.btnClientMaintenance = new System.Windows.Forms.Button();
            this.grpReporting = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnCaseAssignMaintenance);
            this.grpMaintenance.Controls.Add(this.btnCaseMaintenance);
            this.grpMaintenance.Controls.Add(this.btnEquipmentMaintenance);
            this.grpMaintenance.Controls.Add(this.btnInvestigatorMaintenance);
            this.grpMaintenance.Controls.Add(this.btnClientMaintenance);
            this.grpMaintenance.Location = new System.Drawing.Point(35, 28);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(300, 400);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnCaseAssignMaintenance
            // 
            this.btnCaseAssignMaintenance.Location = new System.Drawing.Point(35, 325);
            this.btnCaseAssignMaintenance.Name = "btnCaseAssignMaintenance";
            this.btnCaseAssignMaintenance.Size = new System.Drawing.Size(230, 40);
            this.btnCaseAssignMaintenance.TabIndex = 4;
            this.btnCaseAssignMaintenance.Text = "Case Assignment Maintenance";
            this.btnCaseAssignMaintenance.UseVisualStyleBackColor = true;
            this.btnCaseAssignMaintenance.Click += new System.EventHandler(this.btnCaseAssignMaintenance_Click);
            // 
            // btnCaseMaintenance
            // 
            this.btnCaseMaintenance.Location = new System.Drawing.Point(35, 255);
            this.btnCaseMaintenance.Name = "btnCaseMaintenance";
            this.btnCaseMaintenance.Size = new System.Drawing.Size(230, 40);
            this.btnCaseMaintenance.TabIndex = 3;
            this.btnCaseMaintenance.Text = "Case Maintenance";
            this.btnCaseMaintenance.UseVisualStyleBackColor = true;
            this.btnCaseMaintenance.Click += new System.EventHandler(this.btnCaseMaintenance_Click);
            // 
            // btnEquipmentMaintenance
            // 
            this.btnEquipmentMaintenance.Location = new System.Drawing.Point(35, 185);
            this.btnEquipmentMaintenance.Name = "btnEquipmentMaintenance";
            this.btnEquipmentMaintenance.Size = new System.Drawing.Size(230, 40);
            this.btnEquipmentMaintenance.TabIndex = 2;
            this.btnEquipmentMaintenance.Text = "Equipment Maintenance";
            this.btnEquipmentMaintenance.UseVisualStyleBackColor = true;
            this.btnEquipmentMaintenance.Click += new System.EventHandler(this.btnEquipmentMaintenance_Click);
            // 
            // btnInvestigatorMaintenance
            // 
            this.btnInvestigatorMaintenance.Location = new System.Drawing.Point(35, 115);
            this.btnInvestigatorMaintenance.Name = "btnInvestigatorMaintenance";
            this.btnInvestigatorMaintenance.Size = new System.Drawing.Size(230, 40);
            this.btnInvestigatorMaintenance.TabIndex = 1;
            this.btnInvestigatorMaintenance.Text = "Investigator Maintenance";
            this.btnInvestigatorMaintenance.UseVisualStyleBackColor = true;
            this.btnInvestigatorMaintenance.Click += new System.EventHandler(this.btnInvestigatorMaintenance_Click);
            // 
            // btnClientMaintenance
            // 
            this.btnClientMaintenance.Location = new System.Drawing.Point(35, 45);
            this.btnClientMaintenance.Name = "btnClientMaintenance";
            this.btnClientMaintenance.Size = new System.Drawing.Size(230, 40);
            this.btnClientMaintenance.TabIndex = 0;
            this.btnClientMaintenance.Text = "Client Maintenance";
            this.btnClientMaintenance.UseVisualStyleBackColor = true;
            this.btnClientMaintenance.Click += new System.EventHandler(this.btnClientMaintenance_Click);
            // 
            // grpReporting
            // 
            this.grpReporting.Controls.Add(this.btnExit);
            this.grpReporting.Controls.Add(this.btnInvoices);
            this.grpReporting.Location = new System.Drawing.Point(380, 28);
            this.grpReporting.Name = "grpReporting";
            this.grpReporting.Size = new System.Drawing.Size(300, 400);
            this.grpReporting.TabIndex = 1;
            this.grpReporting.TabStop = false;
            this.grpReporting.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(35, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(230, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(35, 45);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(230, 40);
            this.btnInvoices.TabIndex = 0;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 473);
            this.Controls.Add(this.grpReporting);
            this.Controls.Add(this.grpMaintenance);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReporting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnCaseAssignMaintenance;
        private System.Windows.Forms.Button btnCaseMaintenance;
        private System.Windows.Forms.Button btnEquipmentMaintenance;
        private System.Windows.Forms.Button btnInvestigatorMaintenance;
        private System.Windows.Forms.Button btnClientMaintenance;
        private System.Windows.Forms.GroupBox grpReporting;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInvoices;
    }
}

