namespace BigEye
{
    partial class AssignmentForm
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
            this.lstAssignedCase = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClientFullName = new System.Windows.Forms.Label();
            this.btnAssignInvestigator = new System.Windows.Forms.Button();
            this.btnModifyAssignment = new System.Windows.Forms.Button();
            this.btnRemoveInvestigator = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAssignInvestigator = new System.Windows.Forms.Panel();
            this.btnSaveCancel = new System.Windows.Forms.Button();
            this.btnSaveAssignment = new System.Windows.Forms.Button();
            this.dtpDateAssigned = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoursAssigned = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInvestigatorID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInvestigatorName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAssignment = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlModifyAssignment = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHourUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateInvestigator = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.pnlAssignInvestigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignment)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnlModifyAssignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAssignedCase
            // 
            this.lstAssignedCase.FormattingEnabled = true;
            this.lstAssignedCase.ItemHeight = 16;
            this.lstAssignedCase.Location = new System.Drawing.Point(23, 23);
            this.lstAssignedCase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstAssignedCase.Name = "lstAssignedCase";
            this.lstAssignedCase.Size = new System.Drawing.Size(189, 356);
            this.lstAssignedCase.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(23, 399);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(87, 27);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(125, 399);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 27);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client ID:";
            // 
            // lblClientID
            // 
            this.lblClientID.BackColor = System.Drawing.SystemColors.Info;
            this.lblClientID.Location = new System.Drawing.Point(86, 24);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(50, 20);
            this.lblClientID.TabIndex = 6;
            this.lblClientID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fullname:";
            // 
            // lblClientFullName
            // 
            this.lblClientFullName.BackColor = System.Drawing.SystemColors.Info;
            this.lblClientFullName.Location = new System.Drawing.Point(255, 24);
            this.lblClientFullName.Name = "lblClientFullName";
            this.lblClientFullName.Size = new System.Drawing.Size(148, 20);
            this.lblClientFullName.TabIndex = 8;
            this.lblClientFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAssignInvestigator
            // 
            this.btnAssignInvestigator.Location = new System.Drawing.Point(258, 399);
            this.btnAssignInvestigator.Name = "btnAssignInvestigator";
            this.btnAssignInvestigator.Size = new System.Drawing.Size(137, 27);
            this.btnAssignInvestigator.TabIndex = 11;
            this.btnAssignInvestigator.Text = "Assign Investigator";
            this.btnAssignInvestigator.UseVisualStyleBackColor = true;
            this.btnAssignInvestigator.Click += new System.EventHandler(this.btnAssignInvestigator_Click);
            // 
            // btnModifyAssignment
            // 
            this.btnModifyAssignment.Location = new System.Drawing.Point(401, 399);
            this.btnModifyAssignment.Name = "btnModifyAssignment";
            this.btnModifyAssignment.Size = new System.Drawing.Size(137, 27);
            this.btnModifyAssignment.TabIndex = 12;
            this.btnModifyAssignment.Text = "Modify Assignment";
            this.btnModifyAssignment.UseVisualStyleBackColor = true;
            this.btnModifyAssignment.Click += new System.EventHandler(this.btnModifyAssignment_Click);
            // 
            // btnRemoveInvestigator
            // 
            this.btnRemoveInvestigator.Location = new System.Drawing.Point(544, 399);
            this.btnRemoveInvestigator.Name = "btnRemoveInvestigator";
            this.btnRemoveInvestigator.Size = new System.Drawing.Size(137, 27);
            this.btnRemoveInvestigator.TabIndex = 13;
            this.btnRemoveInvestigator.Text = "Remove Investigator";
            this.btnRemoveInvestigator.UseVisualStyleBackColor = true;
            this.btnRemoveInvestigator.Click += new System.EventHandler(this.btnRemoveInvestigator_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(544, 450);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(137, 27);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAssignInvestigator
            // 
            this.pnlAssignInvestigator.Controls.Add(this.btnSaveCancel);
            this.pnlAssignInvestigator.Controls.Add(this.btnSaveAssignment);
            this.pnlAssignInvestigator.Controls.Add(this.dtpDateAssigned);
            this.pnlAssignInvestigator.Controls.Add(this.label7);
            this.pnlAssignInvestigator.Controls.Add(this.txtHoursAssigned);
            this.pnlAssignInvestigator.Controls.Add(this.label6);
            this.pnlAssignInvestigator.Controls.Add(this.cmbInvestigatorID);
            this.pnlAssignInvestigator.Controls.Add(this.label5);
            this.pnlAssignInvestigator.Location = new System.Drawing.Point(258, 131);
            this.pnlAssignInvestigator.Name = "pnlAssignInvestigator";
            this.pnlAssignInvestigator.Size = new System.Drawing.Size(423, 240);
            this.pnlAssignInvestigator.TabIndex = 15;
            this.pnlAssignInvestigator.Visible = false;
            // 
            // btnSaveCancel
            // 
            this.btnSaveCancel.Location = new System.Drawing.Point(230, 177);
            this.btnSaveCancel.Name = "btnSaveCancel";
            this.btnSaveCancel.Size = new System.Drawing.Size(136, 27);
            this.btnSaveCancel.TabIndex = 7;
            this.btnSaveCancel.Text = "Cancel";
            this.btnSaveCancel.UseVisualStyleBackColor = true;
            this.btnSaveCancel.Click += new System.EventHandler(this.btnSaveCancel_Click);
            // 
            // btnSaveAssignment
            // 
            this.btnSaveAssignment.Location = new System.Drawing.Point(45, 177);
            this.btnSaveAssignment.Name = "btnSaveAssignment";
            this.btnSaveAssignment.Size = new System.Drawing.Size(136, 27);
            this.btnSaveAssignment.TabIndex = 6;
            this.btnSaveAssignment.Text = "Save Assignment";
            this.btnSaveAssignment.UseVisualStyleBackColor = true;
            this.btnSaveAssignment.Click += new System.EventHandler(this.btnSaveAssignment_Click);
            // 
            // dtpDateAssigned
            // 
            this.dtpDateAssigned.Location = new System.Drawing.Point(87, 128);
            this.dtpDateAssigned.Name = "dtpDateAssigned";
            this.dtpDateAssigned.Size = new System.Drawing.Size(200, 22);
            this.dtpDateAssigned.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Date:";
            // 
            // txtHoursAssigned
            // 
            this.txtHoursAssigned.Location = new System.Drawing.Point(87, 87);
            this.txtHoursAssigned.Name = "txtHoursAssigned";
            this.txtHoursAssigned.Size = new System.Drawing.Size(49, 22);
            this.txtHoursAssigned.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hours:";
            // 
            // cmbInvestigatorID
            // 
            this.cmbInvestigatorID.FormattingEnabled = true;
            this.cmbInvestigatorID.Location = new System.Drawing.Point(87, 45);
            this.cmbInvestigatorID.Name = "cmbInvestigatorID";
            this.cmbInvestigatorID.Size = new System.Drawing.Size(49, 24);
            this.cmbInvestigatorID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Investigator:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInvestigatorName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvAssignment);
            this.groupBox1.Location = new System.Drawing.Point(258, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 200);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Investigator";
            // 
            // lblInvestigatorName
            // 
            this.lblInvestigatorName.BackColor = System.Drawing.SystemColors.Info;
            this.lblInvestigatorName.Location = new System.Drawing.Point(91, 161);
            this.lblInvestigatorName.Name = "lblInvestigatorName";
            this.lblInvestigatorName.Size = new System.Drawing.Size(148, 20);
            this.lblInvestigatorName.TabIndex = 11;
            this.lblInvestigatorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "FullName:";
            // 
            // dgvAssignment
            // 
            this.dgvAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignment.Location = new System.Drawing.Point(23, 34);
            this.dgvAssignment.Name = "dgvAssignment";
            this.dgvAssignment.ReadOnly = true;
            this.dgvAssignment.RowTemplate.Height = 23;
            this.dgvAssignment.Size = new System.Drawing.Size(380, 113);
            this.dgvAssignment.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblClientID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblClientFullName);
            this.groupBox2.Location = new System.Drawing.Point(258, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 61);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // pnlModifyAssignment
            // 
            this.pnlModifyAssignment.Controls.Add(this.btnUpdateCancel);
            this.pnlModifyAssignment.Controls.Add(this.btnUpdateInvestigator);
            this.pnlModifyAssignment.Controls.Add(this.dtpDateUpdate);
            this.pnlModifyAssignment.Controls.Add(this.label8);
            this.pnlModifyAssignment.Controls.Add(this.txtHourUpdate);
            this.pnlModifyAssignment.Controls.Add(this.label1);
            this.pnlModifyAssignment.Location = new System.Drawing.Point(48, 85);
            this.pnlModifyAssignment.Name = "pnlModifyAssignment";
            this.pnlModifyAssignment.Size = new System.Drawing.Size(423, 240);
            this.pnlModifyAssignment.TabIndex = 18;
            this.pnlModifyAssignment.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours:";
            // 
            // txtHourUpdate
            // 
            this.txtHourUpdate.Location = new System.Drawing.Point(88, 59);
            this.txtHourUpdate.Name = "txtHourUpdate";
            this.txtHourUpdate.Size = new System.Drawing.Size(49, 22);
            this.txtHourUpdate.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date:";
            // 
            // dtpDateUpdate
            // 
            this.dtpDateUpdate.Location = new System.Drawing.Point(88, 100);
            this.dtpDateUpdate.Name = "dtpDateUpdate";
            this.dtpDateUpdate.Size = new System.Drawing.Size(200, 22);
            this.dtpDateUpdate.TabIndex = 3;
            // 
            // btnUpdateInvestigator
            // 
            this.btnUpdateInvestigator.Location = new System.Drawing.Point(45, 177);
            this.btnUpdateInvestigator.Name = "btnUpdateInvestigator";
            this.btnUpdateInvestigator.Size = new System.Drawing.Size(136, 27);
            this.btnUpdateInvestigator.TabIndex = 4;
            this.btnUpdateInvestigator.Text = "Update Investigator";
            this.btnUpdateInvestigator.UseVisualStyleBackColor = true;
            this.btnUpdateInvestigator.Click += new System.EventHandler(this.btnUpdateInvestigator_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(230, 177);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(136, 27);
            this.btnUpdateCancel.TabIndex = 5;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 515);
            this.Controls.Add(this.pnlModifyAssignment);
            this.Controls.Add(this.pnlAssignInvestigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveInvestigator);
            this.Controls.Add(this.btnModifyAssignment);
            this.Controls.Add(this.btnAssignInvestigator);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstAssignedCase);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AssignmentForm";
            this.Text = "Case Assignment Maintenance";
            this.pnlAssignInvestigator.ResumeLayout(false);
            this.pnlAssignInvestigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlModifyAssignment.ResumeLayout(false);
            this.pnlModifyAssignment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAssignedCase;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClientFullName;
        private System.Windows.Forms.Button btnAssignInvestigator;
        private System.Windows.Forms.Button btnModifyAssignment;
        private System.Windows.Forms.Button btnRemoveInvestigator;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAssignInvestigator;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoursAssigned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbInvestigatorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateAssigned;
        private System.Windows.Forms.Button btnSaveCancel;
        private System.Windows.Forms.Button btnSaveAssignment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInvestigatorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAssignment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlModifyAssignment;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnUpdateInvestigator;
        private System.Windows.Forms.DateTimePicker dtpDateUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHourUpdate;
        private System.Windows.Forms.Label label1;
    }
}