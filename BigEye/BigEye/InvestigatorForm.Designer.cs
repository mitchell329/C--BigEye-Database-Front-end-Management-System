namespace BigEye
{
    partial class InvestigatorForm
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lstInvestigator = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInvestigatorID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.btnAddInvestigator = new System.Windows.Forms.Button();
            this.btnModifyInvestigator = new System.Windows.Forms.Button();
            this.btnDeleteInvestigator = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddInvestigator = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveCancle = new System.Windows.Forms.Button();
            this.btnSaveInvestigator = new System.Windows.Forms.Button();
            this.txtAddCellPhone = new System.Windows.Forms.TextBox();
            this.txtAddHourlyRate = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.pnlModifyInvestigator = new System.Windows.Forms.Panel();
            this.btnModifyCancle = new System.Windows.Forms.Button();
            this.btnSaveModify = new System.Windows.Forms.Button();
            this.txtModifyCellPhone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtModifyHourlyRate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtModifyFirstName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtModifyLastName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chbAddLicensed = new System.Windows.Forms.CheckBox();
            this.chbModifyLicensed = new System.Windows.Forms.CheckBox();
            this.chbLicensed = new System.Windows.Forms.CheckBox();
            this.pnlAddInvestigator.SuspendLayout();
            this.pnlModifyInvestigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(150, 403);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 27);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(23, 403);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(121, 27);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lstInvestigator
            // 
            this.lstInvestigator.FormattingEnabled = true;
            this.lstInvestigator.ItemHeight = 16;
            this.lstInvestigator.Location = new System.Drawing.Point(23, 23);
            this.lstInvestigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstInvestigator.Name = "lstInvestigator";
            this.lstInvestigator.Size = new System.Drawing.Size(248, 356);
            this.lstInvestigator.TabIndex = 0;
            this.lstInvestigator.Click += new System.EventHandler(this.lstInvestigator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Investigator ID:";
            // 
            // lblInvestigatorID
            // 
            this.lblInvestigatorID.BackColor = System.Drawing.SystemColors.Info;
            this.lblInvestigatorID.Location = new System.Drawing.Point(459, 42);
            this.lblInvestigatorID.Name = "lblInvestigatorID";
            this.lblInvestigatorID.Size = new System.Drawing.Size(50, 20);
            this.lblInvestigatorID.TabIndex = 4;
            this.lblInvestigatorID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.SystemColors.Info;
            this.lblLastName.Location = new System.Drawing.Point(459, 87);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(120, 20);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.SystemColors.Info;
            this.lblFirstName.Location = new System.Drawing.Point(459, 132);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(120, 20);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hourly Rate:";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.BackColor = System.Drawing.SystemColors.Info;
            this.lblHourlyRate.Location = new System.Drawing.Point(459, 177);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(120, 20);
            this.lblHourlyRate.TabIndex = 10;
            this.lblHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cell Phone:";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.BackColor = System.Drawing.SystemColors.Info;
            this.lblCellPhone.Location = new System.Drawing.Point(459, 222);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(120, 20);
            this.lblCellPhone.TabIndex = 12;
            this.lblCellPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddInvestigator
            // 
            this.btnAddInvestigator.Location = new System.Drawing.Point(295, 403);
            this.btnAddInvestigator.Name = "btnAddInvestigator";
            this.btnAddInvestigator.Size = new System.Drawing.Size(128, 27);
            this.btnAddInvestigator.TabIndex = 15;
            this.btnAddInvestigator.Text = "Add Investigator";
            this.btnAddInvestigator.UseVisualStyleBackColor = true;
            this.btnAddInvestigator.Click += new System.EventHandler(this.btnAddInvestigator_Click);
            // 
            // btnModifyInvestigator
            // 
            this.btnModifyInvestigator.Location = new System.Drawing.Point(429, 403);
            this.btnModifyInvestigator.Name = "btnModifyInvestigator";
            this.btnModifyInvestigator.Size = new System.Drawing.Size(128, 27);
            this.btnModifyInvestigator.TabIndex = 16;
            this.btnModifyInvestigator.Text = "Modify Investigator";
            this.btnModifyInvestigator.UseVisualStyleBackColor = true;
            this.btnModifyInvestigator.Click += new System.EventHandler(this.btnModifyInvestigator_Click);
            // 
            // btnDeleteInvestigator
            // 
            this.btnDeleteInvestigator.Location = new System.Drawing.Point(563, 403);
            this.btnDeleteInvestigator.Name = "btnDeleteInvestigator";
            this.btnDeleteInvestigator.Size = new System.Drawing.Size(128, 27);
            this.btnDeleteInvestigator.TabIndex = 17;
            this.btnDeleteInvestigator.Text = "Delete Investigator";
            this.btnDeleteInvestigator.UseVisualStyleBackColor = true;
            this.btnDeleteInvestigator.Click += new System.EventHandler(this.btnDeleteInvestigator_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(563, 456);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(128, 27);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddInvestigator
            // 
            this.pnlAddInvestigator.Controls.Add(this.chbAddLicensed);
            this.pnlAddInvestigator.Controls.Add(this.label10);
            this.pnlAddInvestigator.Controls.Add(this.label9);
            this.pnlAddInvestigator.Controls.Add(this.label8);
            this.pnlAddInvestigator.Controls.Add(this.label7);
            this.pnlAddInvestigator.Controls.Add(this.btnSaveCancle);
            this.pnlAddInvestigator.Controls.Add(this.btnSaveInvestigator);
            this.pnlAddInvestigator.Controls.Add(this.txtAddCellPhone);
            this.pnlAddInvestigator.Controls.Add(this.txtAddHourlyRate);
            this.pnlAddInvestigator.Controls.Add(this.txtAddFirstName);
            this.pnlAddInvestigator.Controls.Add(this.txtAddLastName);
            this.pnlAddInvestigator.Location = new System.Drawing.Point(52, 134);
            this.pnlAddInvestigator.Name = "pnlAddInvestigator";
            this.pnlAddInvestigator.Size = new System.Drawing.Size(328, 356);
            this.pnlAddInvestigator.TabIndex = 19;
            this.pnlAddInvestigator.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cell Phone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hourly Rate:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Last Name:";
            // 
            // btnSaveCancle
            // 
            this.btnSaveCancle.Location = new System.Drawing.Point(174, 301);
            this.btnSaveCancle.Name = "btnSaveCancle";
            this.btnSaveCancle.Size = new System.Drawing.Size(128, 27);
            this.btnSaveCancle.TabIndex = 6;
            this.btnSaveCancle.Text = "Cancle";
            this.btnSaveCancle.UseVisualStyleBackColor = true;
            this.btnSaveCancle.Click += new System.EventHandler(this.btnSaveCancle_Click);
            // 
            // btnSaveInvestigator
            // 
            this.btnSaveInvestigator.Location = new System.Drawing.Point(29, 301);
            this.btnSaveInvestigator.Name = "btnSaveInvestigator";
            this.btnSaveInvestigator.Size = new System.Drawing.Size(128, 27);
            this.btnSaveInvestigator.TabIndex = 5;
            this.btnSaveInvestigator.Text = "Save Investigator";
            this.btnSaveInvestigator.UseVisualStyleBackColor = true;
            this.btnSaveInvestigator.Click += new System.EventHandler(this.btnSaveInvestigator_Click);
            // 
            // txtAddCellPhone
            // 
            this.txtAddCellPhone.Location = new System.Drawing.Point(96, 198);
            this.txtAddCellPhone.Name = "txtAddCellPhone";
            this.txtAddCellPhone.Size = new System.Drawing.Size(120, 22);
            this.txtAddCellPhone.TabIndex = 3;
            // 
            // txtAddHourlyRate
            // 
            this.txtAddHourlyRate.Location = new System.Drawing.Point(96, 153);
            this.txtAddHourlyRate.Name = "txtAddHourlyRate";
            this.txtAddHourlyRate.Size = new System.Drawing.Size(120, 22);
            this.txtAddHourlyRate.TabIndex = 2;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(96, 108);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(120, 22);
            this.txtAddFirstName.TabIndex = 1;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(96, 63);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(120, 22);
            this.txtAddLastName.TabIndex = 0;
            // 
            // pnlModifyInvestigator
            // 
            this.pnlModifyInvestigator.Controls.Add(this.chbModifyLicensed);
            this.pnlModifyInvestigator.Controls.Add(this.btnModifyCancle);
            this.pnlModifyInvestigator.Controls.Add(this.btnSaveModify);
            this.pnlModifyInvestigator.Controls.Add(this.txtModifyCellPhone);
            this.pnlModifyInvestigator.Controls.Add(this.label16);
            this.pnlModifyInvestigator.Controls.Add(this.txtModifyHourlyRate);
            this.pnlModifyInvestigator.Controls.Add(this.label15);
            this.pnlModifyInvestigator.Controls.Add(this.txtModifyFirstName);
            this.pnlModifyInvestigator.Controls.Add(this.label14);
            this.pnlModifyInvestigator.Controls.Add(this.txtModifyLastName);
            this.pnlModifyInvestigator.Controls.Add(this.label13);
            this.pnlModifyInvestigator.Location = new System.Drawing.Point(148, 63);
            this.pnlModifyInvestigator.Name = "pnlModifyInvestigator";
            this.pnlModifyInvestigator.Size = new System.Drawing.Size(328, 356);
            this.pnlModifyInvestigator.TabIndex = 20;
            this.pnlModifyInvestigator.Visible = false;
            // 
            // btnModifyCancle
            // 
            this.btnModifyCancle.Location = new System.Drawing.Point(174, 301);
            this.btnModifyCancle.Name = "btnModifyCancle";
            this.btnModifyCancle.Size = new System.Drawing.Size(128, 27);
            this.btnModifyCancle.TabIndex = 11;
            this.btnModifyCancle.Text = "Cancle";
            this.btnModifyCancle.UseVisualStyleBackColor = true;
            this.btnModifyCancle.Click += new System.EventHandler(this.btnModifyCancle_Click);
            // 
            // btnSaveModify
            // 
            this.btnSaveModify.Location = new System.Drawing.Point(29, 301);
            this.btnSaveModify.Name = "btnSaveModify";
            this.btnSaveModify.Size = new System.Drawing.Size(128, 27);
            this.btnSaveModify.TabIndex = 10;
            this.btnSaveModify.Text = "Update Investigator";
            this.btnSaveModify.UseVisualStyleBackColor = true;
            this.btnSaveModify.Click += new System.EventHandler(this.btnSaveModify_Click);
            // 
            // txtModifyCellPhone
            // 
            this.txtModifyCellPhone.Location = new System.Drawing.Point(96, 198);
            this.txtModifyCellPhone.Name = "txtModifyCellPhone";
            this.txtModifyCellPhone.Size = new System.Drawing.Size(120, 22);
            this.txtModifyCellPhone.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "Cell Phone:";
            // 
            // txtModifyHourlyRate
            // 
            this.txtModifyHourlyRate.Location = new System.Drawing.Point(96, 153);
            this.txtModifyHourlyRate.Name = "txtModifyHourlyRate";
            this.txtModifyHourlyRate.Size = new System.Drawing.Size(120, 22);
            this.txtModifyHourlyRate.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Hourly Rate:";
            // 
            // txtModifyFirstName
            // 
            this.txtModifyFirstName.Location = new System.Drawing.Point(96, 108);
            this.txtModifyFirstName.Name = "txtModifyFirstName";
            this.txtModifyFirstName.Size = new System.Drawing.Size(120, 22);
            this.txtModifyFirstName.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "First Name:";
            // 
            // txtModifyLastName
            // 
            this.txtModifyLastName.Location = new System.Drawing.Point(96, 63);
            this.txtModifyLastName.Name = "txtModifyLastName";
            this.txtModifyLastName.Size = new System.Drawing.Size(120, 22);
            this.txtModifyLastName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Last Name:";
            // 
            // chbAddLicensed
            // 
            this.chbAddLicensed.AutoSize = true;
            this.chbAddLicensed.Location = new System.Drawing.Point(99, 245);
            this.chbAddLicensed.Name = "chbAddLicensed";
            this.chbAddLicensed.Size = new System.Drawing.Size(79, 20);
            this.chbAddLicensed.TabIndex = 4;
            this.chbAddLicensed.Text = "Licensed";
            this.chbAddLicensed.UseVisualStyleBackColor = true;
            // 
            // chbModifyLicensed
            // 
            this.chbModifyLicensed.AutoSize = true;
            this.chbModifyLicensed.Location = new System.Drawing.Point(99, 245);
            this.chbModifyLicensed.Name = "chbModifyLicensed";
            this.chbModifyLicensed.Size = new System.Drawing.Size(79, 20);
            this.chbModifyLicensed.TabIndex = 8;
            this.chbModifyLicensed.Text = "Licensed";
            this.chbModifyLicensed.UseVisualStyleBackColor = true;
            // 
            // chbLicensed
            // 
            this.chbLicensed.AutoSize = true;
            this.chbLicensed.Enabled = false;
            this.chbLicensed.Location = new System.Drawing.Point(462, 274);
            this.chbLicensed.Name = "chbLicensed";
            this.chbLicensed.Size = new System.Drawing.Size(79, 20);
            this.chbLicensed.TabIndex = 13;
            this.chbLicensed.Text = "Licensed";
            this.chbLicensed.UseVisualStyleBackColor = true;
            // 
            // InvestigatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 515);
            this.Controls.Add(this.pnlModifyInvestigator);
            this.Controls.Add(this.pnlAddInvestigator);
            this.Controls.Add(this.chbLicensed);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteInvestigator);
            this.Controls.Add(this.btnModifyInvestigator);
            this.Controls.Add(this.btnAddInvestigator);
            this.Controls.Add(this.lblCellPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInvestigatorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstInvestigator);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InvestigatorForm";
            this.Text = "Investigator Maintenance";
            this.pnlAddInvestigator.ResumeLayout(false);
            this.pnlAddInvestigator.PerformLayout();
            this.pnlModifyInvestigator.ResumeLayout(false);
            this.pnlModifyInvestigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ListBox lstInvestigator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInvestigatorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Button btnAddInvestigator;
        private System.Windows.Forms.Button btnModifyInvestigator;
        private System.Windows.Forms.Button btnDeleteInvestigator;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddInvestigator;
        private System.Windows.Forms.Button btnSaveInvestigator;
        private System.Windows.Forms.TextBox txtAddCellPhone;
        private System.Windows.Forms.TextBox txtAddHourlyRate;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveCancle;
        private System.Windows.Forms.Panel pnlModifyInvestigator;
        private System.Windows.Forms.Button btnModifyCancle;
        private System.Windows.Forms.Button btnSaveModify;
        private System.Windows.Forms.TextBox txtModifyCellPhone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtModifyHourlyRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtModifyFirstName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtModifyLastName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chbAddLicensed;
        private System.Windows.Forms.CheckBox chbModifyLicensed;
        private System.Windows.Forms.CheckBox chbLicensed;
    }
}