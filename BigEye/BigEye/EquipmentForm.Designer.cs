namespace BigEye
{
    partial class EquipmentForm
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
            this.lstEquipment = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInvestigatorID = new System.Windows.Forms.Label();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnModifyEquipment = new System.Windows.Forms.Button();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnRemoveInvestigator = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddEquipment = new System.Windows.Forms.Panel();
            this.btnAddCancle = new System.Windows.Forms.Button();
            this.btnSaveEquipment = new System.Windows.Forms.Button();
            this.txtAddEquipment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlModifyEquipment = new System.Windows.Forms.Panel();
            this.btnUpdateCancle = new System.Windows.Forms.Button();
            this.btnUpdateSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModifyDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbModifyInvestigator = new System.Windows.Forms.ComboBox();
            this.pnlAddEquipment.SuspendLayout();
            this.pnlModifyEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEquipment
            // 
            this.lstEquipment.FormattingEnabled = true;
            this.lstEquipment.ItemHeight = 16;
            this.lstEquipment.Location = new System.Drawing.Point(23, 23);
            this.lstEquipment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEquipment.Name = "lstEquipment";
            this.lstEquipment.Size = new System.Drawing.Size(248, 356);
            this.lstEquipment.TabIndex = 0;
            this.lstEquipment.Click += new System.EventHandler(this.lstEquipment_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(23, 403);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(120, 27);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(151, 403);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 27);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Equipment ID:";
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.BackColor = System.Drawing.SystemColors.Info;
            this.lblEquipmentID.Location = new System.Drawing.Point(498, 79);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(50, 20);
            this.lblEquipmentID.TabIndex = 4;
            this.lblEquipmentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description:";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.SystemColors.Info;
            this.lblDescription.Location = new System.Drawing.Point(498, 124);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 20);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Investigator ID:";
            // 
            // lblInvestigatorID
            // 
            this.lblInvestigatorID.BackColor = System.Drawing.SystemColors.Info;
            this.lblInvestigatorID.Location = new System.Drawing.Point(498, 169);
            this.lblInvestigatorID.Name = "lblInvestigatorID";
            this.lblInvestigatorID.Size = new System.Drawing.Size(50, 20);
            this.lblInvestigatorID.TabIndex = 8;
            this.lblInvestigatorID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(295, 403);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(128, 27);
            this.btnAddEquipment.TabIndex = 10;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnModifyEquipment
            // 
            this.btnModifyEquipment.Location = new System.Drawing.Point(429, 403);
            this.btnModifyEquipment.Name = "btnModifyEquipment";
            this.btnModifyEquipment.Size = new System.Drawing.Size(128, 27);
            this.btnModifyEquipment.TabIndex = 11;
            this.btnModifyEquipment.Text = "Modify Equipment";
            this.btnModifyEquipment.UseVisualStyleBackColor = true;
            this.btnModifyEquipment.Click += new System.EventHandler(this.btnModifyEquipment_Click);
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.Location = new System.Drawing.Point(563, 403);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(128, 27);
            this.btnDeleteEquipment.TabIndex = 12;
            this.btnDeleteEquipment.Text = "Delete Equipment";
            this.btnDeleteEquipment.UseVisualStyleBackColor = true;
            this.btnDeleteEquipment.Click += new System.EventHandler(this.btnDeleteEquipment_Click);
            // 
            // btnRemoveInvestigator
            // 
            this.btnRemoveInvestigator.Location = new System.Drawing.Point(429, 321);
            this.btnRemoveInvestigator.Name = "btnRemoveInvestigator";
            this.btnRemoveInvestigator.Size = new System.Drawing.Size(173, 27);
            this.btnRemoveInvestigator.TabIndex = 9;
            this.btnRemoveInvestigator.Text = "Remove Investigator";
            this.btnRemoveInvestigator.UseVisualStyleBackColor = true;
            this.btnRemoveInvestigator.Click += new System.EventHandler(this.btnRemoveInvestigator_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(563, 456);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(128, 27);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddEquipment
            // 
            this.pnlAddEquipment.Controls.Add(this.btnAddCancle);
            this.pnlAddEquipment.Controls.Add(this.btnSaveEquipment);
            this.pnlAddEquipment.Controls.Add(this.txtAddEquipment);
            this.pnlAddEquipment.Controls.Add(this.label2);
            this.pnlAddEquipment.Location = new System.Drawing.Point(334, 23);
            this.pnlAddEquipment.Name = "pnlAddEquipment";
            this.pnlAddEquipment.Size = new System.Drawing.Size(357, 280);
            this.pnlAddEquipment.TabIndex = 14;
            this.pnlAddEquipment.Visible = false;
            // 
            // btnAddCancle
            // 
            this.btnAddCancle.Location = new System.Drawing.Point(191, 216);
            this.btnAddCancle.Name = "btnAddCancle";
            this.btnAddCancle.Size = new System.Drawing.Size(128, 27);
            this.btnAddCancle.TabIndex = 5;
            this.btnAddCancle.Text = "Cancle";
            this.btnAddCancle.UseVisualStyleBackColor = true;
            this.btnAddCancle.Click += new System.EventHandler(this.btnAddCancle_Click);
            // 
            // btnSaveEquipment
            // 
            this.btnSaveEquipment.Location = new System.Drawing.Point(38, 216);
            this.btnSaveEquipment.Name = "btnSaveEquipment";
            this.btnSaveEquipment.Size = new System.Drawing.Size(128, 27);
            this.btnSaveEquipment.TabIndex = 4;
            this.btnSaveEquipment.Text = "Save Equipment";
            this.btnSaveEquipment.UseVisualStyleBackColor = true;
            this.btnSaveEquipment.Click += new System.EventHandler(this.btnSaveEquipment_Click);
            // 
            // txtAddEquipment
            // 
            this.txtAddEquipment.Location = new System.Drawing.Point(164, 100);
            this.txtAddEquipment.Name = "txtAddEquipment";
            this.txtAddEquipment.Size = new System.Drawing.Size(120, 22);
            this.txtAddEquipment.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            // 
            // pnlModifyEquipment
            // 
            this.pnlModifyEquipment.Controls.Add(this.cmbModifyInvestigator);
            this.pnlModifyEquipment.Controls.Add(this.btnUpdateCancle);
            this.pnlModifyEquipment.Controls.Add(this.btnUpdateSave);
            this.pnlModifyEquipment.Controls.Add(this.label7);
            this.pnlModifyEquipment.Controls.Add(this.txtModifyDescription);
            this.pnlModifyEquipment.Controls.Add(this.label6);
            this.pnlModifyEquipment.Location = new System.Drawing.Point(23, 90);
            this.pnlModifyEquipment.Name = "pnlModifyEquipment";
            this.pnlModifyEquipment.Size = new System.Drawing.Size(357, 280);
            this.pnlModifyEquipment.TabIndex = 15;
            this.pnlModifyEquipment.Visible = false;
            // 
            // btnUpdateCancle
            // 
            this.btnUpdateCancle.Location = new System.Drawing.Point(191, 216);
            this.btnUpdateCancle.Name = "btnUpdateCancle";
            this.btnUpdateCancle.Size = new System.Drawing.Size(128, 27);
            this.btnUpdateCancle.TabIndex = 5;
            this.btnUpdateCancle.Text = "Cancle";
            this.btnUpdateCancle.UseVisualStyleBackColor = true;
            this.btnUpdateCancle.Click += new System.EventHandler(this.btnUpdateCancle_Click);
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Location = new System.Drawing.Point(38, 216);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(128, 27);
            this.btnUpdateSave.TabIndex = 4;
            this.btnUpdateSave.Text = "Update Equipment";
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Investigator ID:";
            // 
            // txtModifyDescription
            // 
            this.txtModifyDescription.Location = new System.Drawing.Point(164, 100);
            this.txtModifyDescription.Name = "txtModifyDescription";
            this.txtModifyDescription.Size = new System.Drawing.Size(120, 22);
            this.txtModifyDescription.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Description:";
            // 
            // cmbModifyInvestigator
            // 
            this.cmbModifyInvestigator.FormattingEnabled = true;
            this.cmbModifyInvestigator.Location = new System.Drawing.Point(164, 145);
            this.cmbModifyInvestigator.Name = "cmbModifyInvestigator";
            this.cmbModifyInvestigator.Size = new System.Drawing.Size(120, 24);
            this.cmbModifyInvestigator.TabIndex = 3;
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 515);
            this.Controls.Add(this.pnlModifyEquipment);
            this.Controls.Add(this.pnlAddEquipment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveInvestigator);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.btnModifyEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.lblInvestigatorID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEquipmentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstEquipment);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EquipmentForm";
            this.Text = "Equipment Maintenance";
            this.pnlAddEquipment.ResumeLayout(false);
            this.pnlAddEquipment.PerformLayout();
            this.pnlModifyEquipment.ResumeLayout(false);
            this.pnlModifyEquipment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEquipment;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInvestigatorID;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnModifyEquipment;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnRemoveInvestigator;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddEquipment;
        private System.Windows.Forms.TextBox txtAddEquipment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCancle;
        private System.Windows.Forms.Button btnSaveEquipment;
        private System.Windows.Forms.Panel pnlModifyEquipment;
        private System.Windows.Forms.Button btnUpdateCancle;
        private System.Windows.Forms.Button btnUpdateSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModifyDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbModifyInvestigator;
    }
}