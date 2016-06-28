namespace BigEye
{
    partial class CaseForm
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
            this.lstCase = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCaseID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCaseType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDateOpened = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.btnCloseCase = new System.Windows.Forms.Button();
            this.btnAddCase = new System.Windows.Forms.Button();
            this.btnModifyCase = new System.Windows.Forms.Button();
            this.btnDeleteCase = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddCase = new System.Windows.Forms.Panel();
            this.btnAddCancle = new System.Windows.Forms.Button();
            this.btnSaveCase = new System.Windows.Forms.Button();
            this.cmbAddClientID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpAddDateOpened = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAddCaseType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlModifyCase = new System.Windows.Forms.Panel();
            this.txtModifyCaseID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnUpdateCancle = new System.Windows.Forms.Button();
            this.btnUpdateCase = new System.Windows.Forms.Button();
            this.cmbModifyClientID = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpModifyDateOpened = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbModifyCaseType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtModifyStatus = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtModifyDescription = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlAddCase.SuspendLayout();
            this.pnlModifyCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCase
            // 
            this.lstCase.FormattingEnabled = true;
            this.lstCase.ItemHeight = 16;
            this.lstCase.Location = new System.Drawing.Point(23, 23);
            this.lstCase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCase.Name = "lstCase";
            this.lstCase.Size = new System.Drawing.Size(248, 356);
            this.lstCase.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Case ID:";
            // 
            // lblCaseID
            // 
            this.lblCaseID.BackColor = System.Drawing.SystemColors.Info;
            this.lblCaseID.Location = new System.Drawing.Point(429, 38);
            this.lblCaseID.Name = "lblCaseID";
            this.lblCaseID.Size = new System.Drawing.Size(50, 20);
            this.lblCaseID.TabIndex = 4;
            this.lblCaseID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(343, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description:";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.SystemColors.Info;
            this.lblDescription.Location = new System.Drawing.Point(429, 78);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(173, 40);
            this.lblDescription.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Info;
            this.lblStatus.Location = new System.Drawing.Point(429, 138);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(173, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Case Type:";
            // 
            // lblCaseType
            // 
            this.lblCaseType.BackColor = System.Drawing.SystemColors.Info;
            this.lblCaseType.Location = new System.Drawing.Point(429, 178);
            this.lblCaseType.Name = "lblCaseType";
            this.lblCaseType.Size = new System.Drawing.Size(173, 20);
            this.lblCaseType.TabIndex = 10;
            this.lblCaseType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date Opened:";
            // 
            // lblDateOpened
            // 
            this.lblDateOpened.BackColor = System.Drawing.SystemColors.Info;
            this.lblDateOpened.Location = new System.Drawing.Point(429, 216);
            this.lblDateOpened.Name = "lblDateOpened";
            this.lblDateOpened.Size = new System.Drawing.Size(173, 20);
            this.lblDateOpened.TabIndex = 12;
            this.lblDateOpened.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Client ID:";
            // 
            // lblClientID
            // 
            this.lblClientID.BackColor = System.Drawing.SystemColors.Info;
            this.lblClientID.Location = new System.Drawing.Point(429, 252);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(50, 20);
            this.lblClientID.TabIndex = 14;
            this.lblClientID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCloseCase
            // 
            this.btnCloseCase.Location = new System.Drawing.Point(429, 352);
            this.btnCloseCase.Name = "btnCloseCase";
            this.btnCloseCase.Size = new System.Drawing.Size(173, 27);
            this.btnCloseCase.TabIndex = 15;
            this.btnCloseCase.Text = "Mark Case as Closed";
            this.btnCloseCase.UseVisualStyleBackColor = true;
            this.btnCloseCase.Click += new System.EventHandler(this.btnCloseCase_Click);
            // 
            // btnAddCase
            // 
            this.btnAddCase.Location = new System.Drawing.Point(328, 403);
            this.btnAddCase.Name = "btnAddCase";
            this.btnAddCase.Size = new System.Drawing.Size(110, 27);
            this.btnAddCase.TabIndex = 16;
            this.btnAddCase.Text = "Add Case";
            this.btnAddCase.UseVisualStyleBackColor = true;
            this.btnAddCase.Click += new System.EventHandler(this.btnAddCase_Click);
            // 
            // btnModifyCase
            // 
            this.btnModifyCase.Location = new System.Drawing.Point(448, 403);
            this.btnModifyCase.Name = "btnModifyCase";
            this.btnModifyCase.Size = new System.Drawing.Size(110, 27);
            this.btnModifyCase.TabIndex = 17;
            this.btnModifyCase.Text = "Modify Case";
            this.btnModifyCase.UseVisualStyleBackColor = true;
            this.btnModifyCase.Click += new System.EventHandler(this.btnModifyCase_Click);
            // 
            // btnDeleteCase
            // 
            this.btnDeleteCase.Location = new System.Drawing.Point(569, 403);
            this.btnDeleteCase.Name = "btnDeleteCase";
            this.btnDeleteCase.Size = new System.Drawing.Size(110, 27);
            this.btnDeleteCase.TabIndex = 18;
            this.btnDeleteCase.Text = "Delete Case";
            this.btnDeleteCase.UseVisualStyleBackColor = true;
            this.btnDeleteCase.Click += new System.EventHandler(this.btnDeleteCase_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(569, 457);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 27);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddCase
            // 
            this.pnlAddCase.Controls.Add(this.btnAddCancle);
            this.pnlAddCase.Controls.Add(this.btnSaveCase);
            this.pnlAddCase.Controls.Add(this.cmbAddClientID);
            this.pnlAddCase.Controls.Add(this.label11);
            this.pnlAddCase.Controls.Add(this.dtpAddDateOpened);
            this.pnlAddCase.Controls.Add(this.label10);
            this.pnlAddCase.Controls.Add(this.cmbAddCaseType);
            this.pnlAddCase.Controls.Add(this.label9);
            this.pnlAddCase.Controls.Add(this.txtAddStatus);
            this.pnlAddCase.Controls.Add(this.label8);
            this.pnlAddCase.Controls.Add(this.txtAddDescription);
            this.pnlAddCase.Controls.Add(this.label7);
            this.pnlAddCase.Location = new System.Drawing.Point(328, 23);
            this.pnlAddCase.Name = "pnlAddCase";
            this.pnlAddCase.Size = new System.Drawing.Size(351, 323);
            this.pnlAddCase.TabIndex = 20;
            this.pnlAddCase.Visible = false;
            // 
            // btnAddCancle
            // 
            this.btnAddCancle.Location = new System.Drawing.Point(198, 281);
            this.btnAddCancle.Name = "btnAddCancle";
            this.btnAddCancle.Size = new System.Drawing.Size(120, 27);
            this.btnAddCancle.TabIndex = 11;
            this.btnAddCancle.Text = "Cancle";
            this.btnAddCancle.UseVisualStyleBackColor = true;
            this.btnAddCancle.Click += new System.EventHandler(this.btnAddCancle_Click);
            // 
            // btnSaveCase
            // 
            this.btnSaveCase.Location = new System.Drawing.Point(31, 281);
            this.btnSaveCase.Name = "btnSaveCase";
            this.btnSaveCase.Size = new System.Drawing.Size(120, 27);
            this.btnSaveCase.TabIndex = 10;
            this.btnSaveCase.Text = "Save Case";
            this.btnSaveCase.UseVisualStyleBackColor = true;
            this.btnSaveCase.Click += new System.EventHandler(this.btnSaveCase_Click);
            // 
            // cmbAddClientID
            // 
            this.cmbAddClientID.FormattingEnabled = true;
            this.cmbAddClientID.Location = new System.Drawing.Point(104, 240);
            this.cmbAddClientID.Name = "cmbAddClientID";
            this.cmbAddClientID.Size = new System.Drawing.Size(47, 24);
            this.cmbAddClientID.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Client ID:";
            // 
            // dtpAddDateOpened
            // 
            this.dtpAddDateOpened.Location = new System.Drawing.Point(104, 200);
            this.dtpAddDateOpened.Name = "dtpAddDateOpened";
            this.dtpAddDateOpened.Size = new System.Drawing.Size(173, 22);
            this.dtpAddDateOpened.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Date Opened:";
            // 
            // cmbAddCaseType
            // 
            this.cmbAddCaseType.FormattingEnabled = true;
            this.cmbAddCaseType.Location = new System.Drawing.Point(104, 156);
            this.cmbAddCaseType.Name = "cmbAddCaseType";
            this.cmbAddCaseType.Size = new System.Drawing.Size(173, 24);
            this.cmbAddCaseType.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Case Type:";
            // 
            // txtAddStatus
            // 
            this.txtAddStatus.Enabled = false;
            this.txtAddStatus.Location = new System.Drawing.Point(104, 113);
            this.txtAddStatus.Name = "txtAddStatus";
            this.txtAddStatus.Size = new System.Drawing.Size(173, 22);
            this.txtAddStatus.TabIndex = 3;
            this.txtAddStatus.Text = "Open";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Status:";
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(104, 52);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(173, 40);
            this.txtAddDescription.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Description:";
            // 
            // pnlModifyCase
            // 
            this.pnlModifyCase.Controls.Add(this.txtModifyCaseID);
            this.pnlModifyCase.Controls.Add(this.label17);
            this.pnlModifyCase.Controls.Add(this.btnUpdateCancle);
            this.pnlModifyCase.Controls.Add(this.btnUpdateCase);
            this.pnlModifyCase.Controls.Add(this.cmbModifyClientID);
            this.pnlModifyCase.Controls.Add(this.label16);
            this.pnlModifyCase.Controls.Add(this.dtpModifyDateOpened);
            this.pnlModifyCase.Controls.Add(this.label15);
            this.pnlModifyCase.Controls.Add(this.cmbModifyCaseType);
            this.pnlModifyCase.Controls.Add(this.label14);
            this.pnlModifyCase.Controls.Add(this.txtModifyStatus);
            this.pnlModifyCase.Controls.Add(this.label13);
            this.pnlModifyCase.Controls.Add(this.txtModifyDescription);
            this.pnlModifyCase.Controls.Add(this.label12);
            this.pnlModifyCase.Location = new System.Drawing.Point(23, 74);
            this.pnlModifyCase.Name = "pnlModifyCase";
            this.pnlModifyCase.Size = new System.Drawing.Size(351, 323);
            this.pnlModifyCase.TabIndex = 21;
            this.pnlModifyCase.Visible = false;
            // 
            // txtModifyCaseID
            // 
            this.txtModifyCaseID.Enabled = false;
            this.txtModifyCaseID.Location = new System.Drawing.Point(104, 11);
            this.txtModifyCaseID.Name = "txtModifyCaseID";
            this.txtModifyCaseID.Size = new System.Drawing.Size(47, 22);
            this.txtModifyCaseID.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "Case ID:";
            // 
            // btnUpdateCancle
            // 
            this.btnUpdateCancle.Location = new System.Drawing.Point(198, 281);
            this.btnUpdateCancle.Name = "btnUpdateCancle";
            this.btnUpdateCancle.Size = new System.Drawing.Size(120, 27);
            this.btnUpdateCancle.TabIndex = 11;
            this.btnUpdateCancle.Text = "Cancle";
            this.btnUpdateCancle.UseVisualStyleBackColor = true;
            this.btnUpdateCancle.Click += new System.EventHandler(this.btnUpdateCancle_Click);
            // 
            // btnUpdateCase
            // 
            this.btnUpdateCase.Location = new System.Drawing.Point(31, 281);
            this.btnUpdateCase.Name = "btnUpdateCase";
            this.btnUpdateCase.Size = new System.Drawing.Size(120, 27);
            this.btnUpdateCase.TabIndex = 10;
            this.btnUpdateCase.Text = "Update Case";
            this.btnUpdateCase.UseVisualStyleBackColor = true;
            this.btnUpdateCase.Click += new System.EventHandler(this.btnUpdateCase_Click);
            // 
            // cmbModifyClientID
            // 
            this.cmbModifyClientID.Enabled = false;
            this.cmbModifyClientID.FormattingEnabled = true;
            this.cmbModifyClientID.Location = new System.Drawing.Point(104, 240);
            this.cmbModifyClientID.Name = "cmbModifyClientID";
            this.cmbModifyClientID.Size = new System.Drawing.Size(47, 24);
            this.cmbModifyClientID.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Client ID:";
            // 
            // dtpModifyDateOpened
            // 
            this.dtpModifyDateOpened.Location = new System.Drawing.Point(104, 200);
            this.dtpModifyDateOpened.Name = "dtpModifyDateOpened";
            this.dtpModifyDateOpened.Size = new System.Drawing.Size(173, 22);
            this.dtpModifyDateOpened.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Date Opened:";
            // 
            // cmbModifyCaseType
            // 
            this.cmbModifyCaseType.FormattingEnabled = true;
            this.cmbModifyCaseType.Location = new System.Drawing.Point(104, 156);
            this.cmbModifyCaseType.Name = "cmbModifyCaseType";
            this.cmbModifyCaseType.Size = new System.Drawing.Size(173, 24);
            this.cmbModifyCaseType.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Case Type:";
            // 
            // txtModifyStatus
            // 
            this.txtModifyStatus.Enabled = false;
            this.txtModifyStatus.Location = new System.Drawing.Point(104, 113);
            this.txtModifyStatus.Name = "txtModifyStatus";
            this.txtModifyStatus.Size = new System.Drawing.Size(173, 22);
            this.txtModifyStatus.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Status:";
            // 
            // txtModifyDescription
            // 
            this.txtModifyDescription.Location = new System.Drawing.Point(104, 52);
            this.txtModifyDescription.Multiline = true;
            this.txtModifyDescription.Name = "txtModifyDescription";
            this.txtModifyDescription.Size = new System.Drawing.Size(173, 40);
            this.txtModifyDescription.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Description:";
            // 
            // CaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 515);
            this.Controls.Add(this.pnlModifyCase);
            this.Controls.Add(this.pnlAddCase);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteCase);
            this.Controls.Add(this.btnModifyCase);
            this.Controls.Add(this.btnAddCase);
            this.Controls.Add(this.btnCloseCase);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDateOpened);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCaseType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCaseID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstCase);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CaseForm";
            this.Text = "Case Maintenance";
            this.pnlAddCase.ResumeLayout(false);
            this.pnlAddCase.PerformLayout();
            this.pnlModifyCase.ResumeLayout(false);
            this.pnlModifyCase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCase;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCaseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCaseType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateOpened;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Button btnCloseCase;
        private System.Windows.Forms.Button btnAddCase;
        private System.Windows.Forms.Button btnModifyCase;
        private System.Windows.Forms.Button btnDeleteCase;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddCase;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAddCaseType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpAddDateOpened;
        private System.Windows.Forms.ComboBox cmbAddClientID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddCancle;
        private System.Windows.Forms.Button btnSaveCase;
        private System.Windows.Forms.TextBox txtAddStatus;
        private System.Windows.Forms.Panel pnlModifyCase;
        private System.Windows.Forms.TextBox txtModifyDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUpdateCancle;
        private System.Windows.Forms.Button btnUpdateCase;
        private System.Windows.Forms.ComboBox cmbModifyClientID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpModifyDateOpened;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbModifyCaseType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtModifyStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtModifyCaseID;
        private System.Windows.Forms.Label label17;
    }
}