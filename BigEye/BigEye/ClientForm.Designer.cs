namespace BigEye
{
    partial class ClientForm
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
            this.lstClients = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnModifyClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddClient = new System.Windows.Forms.Panel();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddStreetAddress = new System.Windows.Forms.TextBox();
            this.txtAddSuburb = new System.Windows.Forms.TextBox();
            this.txtAddCity = new System.Windows.Forms.TextBox();
            this.txtAddPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.btnSaveCancle = new System.Windows.Forms.Button();
            this.pnlModifyClient = new System.Windows.Forms.Panel();
            this.btnModifyCancle = new System.Windows.Forms.Button();
            this.btnModifySave = new System.Windows.Forms.Button();
            this.txtModifyPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtModifyCity = new System.Windows.Forms.TextBox();
            this.txtModifySuburb = new System.Windows.Forms.TextBox();
            this.txtModifyStreetAddress = new System.Windows.Forms.TextBox();
            this.txtModifyFirstName = new System.Windows.Forms.TextBox();
            this.txtModifyLastName = new System.Windows.Forms.TextBox();
            this.pnlAddClient.SuspendLayout();
            this.pnlModifyClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.ItemHeight = 16;
            this.lstClients.Location = new System.Drawing.Point(23, 23);
            this.lstClients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(263, 356);
            this.lstClients.TabIndex = 0;
            this.lstClients.Click += new System.EventHandler(this.lstClients_Click);
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
            this.btnNext.Location = new System.Drawing.Point(165, 403);
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
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client ID:";
            // 
            // lblClientID
            // 
            this.lblClientID.BackColor = System.Drawing.SystemColors.Info;
            this.lblClientID.Location = new System.Drawing.Point(429, 38);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(50, 20);
            this.lblClientID.TabIndex = 4;
            this.lblClientID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.SystemColors.Info;
            this.lblLastName.Location = new System.Drawing.Point(429, 78);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(122, 20);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.SystemColors.Info;
            this.lblFirstName.Location = new System.Drawing.Point(429, 118);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 20);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Street Address:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.BackColor = System.Drawing.SystemColors.Info;
            this.lblStreetAddress.Location = new System.Drawing.Point(429, 158);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(250, 40);
            this.lblStreetAddress.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Suburb:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.BackColor = System.Drawing.SystemColors.Info;
            this.lblSuburb.Location = new System.Drawing.Point(429, 218);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(122, 20);
            this.lblSuburb.TabIndex = 12;
            this.lblSuburb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "City:";
            // 
            // lblCity
            // 
            this.lblCity.BackColor = System.Drawing.SystemColors.Info;
            this.lblCity.Location = new System.Drawing.Point(429, 258);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(122, 20);
            this.lblCity.TabIndex = 14;
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Phone Number:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.lblPhoneNumber.Location = new System.Drawing.Point(429, 298);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(122, 20);
            this.lblPhoneNumber.TabIndex = 16;
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(328, 403);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(110, 27);
            this.btnAddClient.TabIndex = 17;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnModifyClient
            // 
            this.btnModifyClient.Location = new System.Drawing.Point(448, 403);
            this.btnModifyClient.Name = "btnModifyClient";
            this.btnModifyClient.Size = new System.Drawing.Size(110, 27);
            this.btnModifyClient.TabIndex = 18;
            this.btnModifyClient.Text = "Modify Client";
            this.btnModifyClient.UseVisualStyleBackColor = true;
            this.btnModifyClient.Click += new System.EventHandler(this.btnModifyClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(569, 403);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(110, 27);
            this.btnDeleteClient.TabIndex = 19;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(569, 457);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 27);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddClient
            // 
            this.pnlAddClient.Controls.Add(this.btnSaveCancle);
            this.pnlAddClient.Controls.Add(this.btnSaveClient);
            this.pnlAddClient.Controls.Add(this.txtAddPhoneNumber);
            this.pnlAddClient.Controls.Add(this.txtAddCity);
            this.pnlAddClient.Controls.Add(this.txtAddSuburb);
            this.pnlAddClient.Controls.Add(this.txtAddStreetAddress);
            this.pnlAddClient.Controls.Add(this.txtAddFirstName);
            this.pnlAddClient.Controls.Add(this.txtAddLastName);
            this.pnlAddClient.Location = new System.Drawing.Point(132, 60);
            this.pnlAddClient.Name = "pnlAddClient";
            this.pnlAddClient.Size = new System.Drawing.Size(250, 356);
            this.pnlAddClient.TabIndex = 21;
            this.pnlAddClient.Visible = false;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(0, 54);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(122, 22);
            this.txtAddLastName.TabIndex = 0;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(0, 94);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(122, 22);
            this.txtAddFirstName.TabIndex = 1;
            // 
            // txtAddStreetAddress
            // 
            this.txtAddStreetAddress.Location = new System.Drawing.Point(0, 132);
            this.txtAddStreetAddress.Multiline = true;
            this.txtAddStreetAddress.Name = "txtAddStreetAddress";
            this.txtAddStreetAddress.Size = new System.Drawing.Size(250, 44);
            this.txtAddStreetAddress.TabIndex = 2;
            // 
            // txtAddSuburb
            // 
            this.txtAddSuburb.Location = new System.Drawing.Point(0, 194);
            this.txtAddSuburb.Name = "txtAddSuburb";
            this.txtAddSuburb.Size = new System.Drawing.Size(122, 22);
            this.txtAddSuburb.TabIndex = 3;
            // 
            // txtAddCity
            // 
            this.txtAddCity.Location = new System.Drawing.Point(0, 234);
            this.txtAddCity.Name = "txtAddCity";
            this.txtAddCity.Size = new System.Drawing.Size(122, 22);
            this.txtAddCity.TabIndex = 4;
            // 
            // txtAddPhoneNumber
            // 
            this.txtAddPhoneNumber.Location = new System.Drawing.Point(0, 274);
            this.txtAddPhoneNumber.Name = "txtAddPhoneNumber";
            this.txtAddPhoneNumber.Size = new System.Drawing.Size(122, 22);
            this.txtAddPhoneNumber.TabIndex = 5;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Location = new System.Drawing.Point(0, 326);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(110, 27);
            this.btnSaveClient.TabIndex = 6;
            this.btnSaveClient.Text = "Save Client";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // btnSaveCancle
            // 
            this.btnSaveCancle.Location = new System.Drawing.Point(140, 326);
            this.btnSaveCancle.Name = "btnSaveCancle";
            this.btnSaveCancle.Size = new System.Drawing.Size(110, 27);
            this.btnSaveCancle.TabIndex = 7;
            this.btnSaveCancle.Text = "Cancle";
            this.btnSaveCancle.UseVisualStyleBackColor = true;
            this.btnSaveCancle.Click += new System.EventHandler(this.btnSaveCancle_Click);
            // 
            // pnlModifyClient
            // 
            this.pnlModifyClient.Controls.Add(this.btnModifyCancle);
            this.pnlModifyClient.Controls.Add(this.btnModifySave);
            this.pnlModifyClient.Controls.Add(this.txtModifyPhoneNumber);
            this.pnlModifyClient.Controls.Add(this.txtModifyCity);
            this.pnlModifyClient.Controls.Add(this.txtModifySuburb);
            this.pnlModifyClient.Controls.Add(this.txtModifyStreetAddress);
            this.pnlModifyClient.Controls.Add(this.txtModifyFirstName);
            this.pnlModifyClient.Controls.Add(this.txtModifyLastName);
            this.pnlModifyClient.Location = new System.Drawing.Point(69, 120);
            this.pnlModifyClient.Name = "pnlModifyClient";
            this.pnlModifyClient.Size = new System.Drawing.Size(250, 356);
            this.pnlModifyClient.TabIndex = 22;
            this.pnlModifyClient.Visible = false;
            // 
            // btnModifyCancle
            // 
            this.btnModifyCancle.Location = new System.Drawing.Point(140, 326);
            this.btnModifyCancle.Name = "btnModifyCancle";
            this.btnModifyCancle.Size = new System.Drawing.Size(110, 27);
            this.btnModifyCancle.TabIndex = 7;
            this.btnModifyCancle.Text = "Cancle";
            this.btnModifyCancle.UseVisualStyleBackColor = true;
            this.btnModifyCancle.Click += new System.EventHandler(this.btnModifyCancle_Click);
            // 
            // btnModifySave
            // 
            this.btnModifySave.Location = new System.Drawing.Point(0, 326);
            this.btnModifySave.Name = "btnModifySave";
            this.btnModifySave.Size = new System.Drawing.Size(110, 27);
            this.btnModifySave.TabIndex = 6;
            this.btnModifySave.Text = "Update Client";
            this.btnModifySave.UseVisualStyleBackColor = true;
            this.btnModifySave.Click += new System.EventHandler(this.btnModifySave_Click);
            // 
            // txtModifyPhoneNumber
            // 
            this.txtModifyPhoneNumber.Location = new System.Drawing.Point(0, 274);
            this.txtModifyPhoneNumber.Name = "txtModifyPhoneNumber";
            this.txtModifyPhoneNumber.Size = new System.Drawing.Size(122, 22);
            this.txtModifyPhoneNumber.TabIndex = 5;
            // 
            // txtModifyCity
            // 
            this.txtModifyCity.Location = new System.Drawing.Point(0, 234);
            this.txtModifyCity.Name = "txtModifyCity";
            this.txtModifyCity.Size = new System.Drawing.Size(122, 22);
            this.txtModifyCity.TabIndex = 4;
            // 
            // txtModifySuburb
            // 
            this.txtModifySuburb.Location = new System.Drawing.Point(0, 194);
            this.txtModifySuburb.Name = "txtModifySuburb";
            this.txtModifySuburb.Size = new System.Drawing.Size(122, 22);
            this.txtModifySuburb.TabIndex = 3;
            // 
            // txtModifyStreetAddress
            // 
            this.txtModifyStreetAddress.Location = new System.Drawing.Point(0, 132);
            this.txtModifyStreetAddress.Multiline = true;
            this.txtModifyStreetAddress.Name = "txtModifyStreetAddress";
            this.txtModifyStreetAddress.Size = new System.Drawing.Size(250, 44);
            this.txtModifyStreetAddress.TabIndex = 2;
            // 
            // txtModifyFirstName
            // 
            this.txtModifyFirstName.Location = new System.Drawing.Point(0, 94);
            this.txtModifyFirstName.Name = "txtModifyFirstName";
            this.txtModifyFirstName.Size = new System.Drawing.Size(122, 22);
            this.txtModifyFirstName.TabIndex = 1;
            // 
            // txtModifyLastName
            // 
            this.txtModifyLastName.Location = new System.Drawing.Point(0, 54);
            this.txtModifyLastName.Name = "txtModifyLastName";
            this.txtModifyLastName.Size = new System.Drawing.Size(122, 22);
            this.txtModifyLastName.TabIndex = 0;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 515);
            this.Controls.Add(this.pnlModifyClient);
            this.Controls.Add(this.pnlAddClient);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnModifyClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstClients);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClientForm";
            this.Text = "Client Maintenance";
            this.pnlAddClient.ResumeLayout(false);
            this.pnlAddClient.PerformLayout();
            this.pnlModifyClient.ResumeLayout(false);
            this.pnlModifyClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnModifyClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddClient;
        private System.Windows.Forms.Button btnSaveCancle;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.TextBox txtAddPhoneNumber;
        private System.Windows.Forms.TextBox txtAddCity;
        private System.Windows.Forms.TextBox txtAddSuburb;
        private System.Windows.Forms.TextBox txtAddStreetAddress;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Panel pnlModifyClient;
        private System.Windows.Forms.Button btnModifyCancle;
        private System.Windows.Forms.Button btnModifySave;
        private System.Windows.Forms.TextBox txtModifyPhoneNumber;
        private System.Windows.Forms.TextBox txtModifyCity;
        private System.Windows.Forms.TextBox txtModifySuburb;
        private System.Windows.Forms.TextBox txtModifyStreetAddress;
        private System.Windows.Forms.TextBox txtModifyFirstName;
        private System.Windows.Forms.TextBox txtModifyLastName;
    }
}