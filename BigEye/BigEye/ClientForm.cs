using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<Summary> class: ClientForm
///Purpose: Setup the Client Maintenance Form of the application and allows the user to view and maintenance Client information. 
///Author: Mitchell Yuan
///Date: 19/04/2016
///</Summary>
namespace BigEye
{
    public partial class ClientForm : Form
    {
        private DataModule DM;
        private MainForm frmMain;
        private CurrencyManager cmClient;

        ///<Summary> method : ClientForm
        ///Class Constructor Method, initialize Client Maintenance Form and pass the references of Main Form and Data Module to this form.
        ///</Summary>
        public ClientForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMain = mnu;
            BindControls();
            pnlAddClient.Left = 429;
            pnlAddClient.Top = 23;
            pnlModifyClient.Left = 429;
            pnlModifyClient.Top = 23;
        }

        /// <summary>method: BindControls
        /// Binding data from dataset to controls in the ClientForm and display a list of Clients and selected Client's details in the form.
        /// </summary>
        public void BindControls()
        {
            lblClientID.DataBindings.Add("Text", DM.dsBigEye, "T_Client.ClientID");
            lblLastName.DataBindings.Add("Text", DM.dsBigEye, "T_Client.LastName");
            lblFirstName.DataBindings.Add("Text", DM.dsBigEye, "T_Client.FirstName");
            lblStreetAddress.DataBindings.Add("Text", DM.dsBigEye, "T_Client.StreetAddress");
            lblSuburb.DataBindings.Add("Text", DM.dsBigEye, "T_Client.Suburb");
            lblCity.DataBindings.Add("Text", DM.dsBigEye, "T_Client.City");
            lblPhoneNumber.DataBindings.Add("Text", DM.dsBigEye, "T_Client.PhoneNumber");
            lstClients.DataSource = DM.dsBigEye;
            lstClients.DisplayMember = "T_Client.LastName";
            lstClients.ValueMember = "T_Client.LastName";
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBigEye, "T_Client"];
        }

        /// <summary>method: btnPrevious_Click
        /// Allows the user to navigate backward between Clients in the list.
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (cmClient.Position > 0)
            {
                cmClient.Position--;
            }
        }

        /// <summary>method: btnNext_Click
        /// Allows the user to navigate forward between Clients in the list.
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(cmClient.Position < cmClient.Count - 1)
            {
                cmClient.Position++;
            }
        }

        /// <summary>method: btnAddClient_Click
        /// Show a panel (with Save Client and Cancel buttons) allowing the user to enter new values for the Client’s last name, first name, street address, suburb, city and phone number.
        /// </summary>
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            btnModifyClient.Enabled = false;
            btnDeleteClient.Enabled = false;
            pnlAddClient.Show();
        }

        /// <summary>method: btnSaveClient_Click
        /// If the user enters valid data for all fields and clicks on the "Save Client" button then a new Client record is saved in the database.
        /// </summary>
        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            lblClientID.Text = null;
            DataRow newClientRecord = DM.dtClient.NewRow();

            if((txtAddLastName.Text == "") ||
               (txtAddFirstName.Text == "") ||
               (txtAddStreetAddress.Text == "") ||
               (txtAddSuburb.Text == "") ||
               (txtAddCity.Text == ""))
            {
                MessageBox.Show("You must type in all the fields except Phone Number.", "Error");
            }
            else
            {
                try
                {
                    newClientRecord["LastName"] = txtAddLastName.Text;
                    newClientRecord["FirstName"] = txtAddFirstName.Text;
                    newClientRecord["StreetAddress"] = txtAddStreetAddress.Text;
                    newClientRecord["Suburb"] = txtAddSuburb.Text;
                    newClientRecord["City"] = txtAddCity.Text;
                    if (txtAddPhoneNumber.Text != "")
                    {
                        newClientRecord["PhoneNumber"] = txtAddPhoneNumber.Text;
                    }

                    DM.dtClient.Rows.Add(newClientRecord);
                    DM.UpdateClient();
                    MessageBox.Show("Client added sucessfully!", "Success");

                    pnlAddClient.Hide();
                    btnModifyClient.Enabled = true;
                    btnDeleteClient.Enabled = true;
                    cmClient.Position = cmClient.Count - 1;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message + "\r\n", "Error");
                }
            }

            return;
        }

        /// <summary>method: btnSaveCancle_Click
        /// If the user clicks on the Cancel button then panel will disappear and the Modify Client and Delete Client buttons enabled.
        /// </summary>
        private void btnSaveCancle_Click(object sender, EventArgs e)
        {
            pnlAddClient.Hide();
            btnModifyClient.Enabled = true;
            btnDeleteClient.Enabled = true;
        }

        /// <summary>method: btnModifyClient_Click
        /// Show a panel (with Update Client and Cancel buttons) allowing the user to change the values for the Client’s last name, first name, street address, suburb, city or phone number.
        /// </summary>
        private void btnModifyClient_Click(object sender, EventArgs e)
        {
            btnAddClient.Enabled = false;
            btnDeleteClient.Enabled = false;
            pnlModifyClient.Show();

            txtModifyLastName.Text = DM.dtClient.Rows[cmClient.Position]["LastName"].ToString();
            txtModifyFirstName.Text = DM.dtClient.Rows[cmClient.Position]["FirstName"].ToString();
            txtModifyStreetAddress.Text = DM.dtClient.Rows[cmClient.Position]["StreetAddress"].ToString();
            txtModifySuburb.Text = DM.dtClient.Rows[cmClient.Position]["Suburb"].ToString();
            txtModifyCity.Text = DM.dtClient.Rows[cmClient.Position]["City"].ToString();
            txtModifyPhoneNumber.Text = DM.dtClient.Rows[cmClient.Position]["PhoneNumber"].ToString();
        }

        /// <summary>method: btnModifySave_Click
        /// If the user makes valid changes to any of the allowable fields and clicks on the Update Client button then the Client record is updated in the database.
        /// </summary>
        private void btnModifySave_Click(object sender, EventArgs e)
        {
            DataRow modifyClientRow = DM.dtClient.Rows[cmClient.Position];

            if ((txtModifyLastName.Text == "") ||
               (txtModifyFirstName.Text == "") ||
               (txtModifyStreetAddress.Text == "") ||
               (txtModifySuburb.Text == "") ||
               (txtModifyCity.Text == "") ||
               (txtModifyPhoneNumber.Text == ""))
            {
                MessageBox.Show("You must type in all the fields.", "Error");
            }
            else
            {
                try
                {
                    modifyClientRow["LastName"] = txtModifyLastName.Text;
                    modifyClientRow["FirstName"] = txtModifyFirstName.Text;
                    modifyClientRow["StreetAddress"] = txtModifyStreetAddress.Text;
                    modifyClientRow["Suburb"] = txtModifySuburb.Text;
                    modifyClientRow["City"] = txtModifyCity.Text;
                    modifyClientRow["PhoneNumber"] = txtModifyPhoneNumber.Text;

                    DM.UpdateClient();
                    MessageBox.Show("Client updated sucessfully!", "Success");

                    pnlModifyClient.Hide();
                    btnAddClient.Enabled = true;
                    btnDeleteClient.Enabled = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message + "\r\n", "Error");
                }
            }

            return;
        }

        /// <summary>method: btnModifyCancle_Click
        /// If the user clicks on the Cancel button then the panel will disappear and the Add Client and Delete Client buttons enabled.
        /// </summary>
        private void btnModifyCancle_Click(object sender, EventArgs e)
        {
            pnlModifyClient.Hide();
            btnAddClient.Enabled = true;
            btnDeleteClient.Enabled = true;
        }

        /// <summary>method: lstClients_Click
        /// If the user clicks on different items in the listbox then the value of controls in the panel will varify accordingly to allow user modify client information without return.
        /// </summary>
        private void lstClients_Click(object sender, EventArgs e)
        {
            if(lstClients.SelectedItem != null)
            {
                cmClient.Position = lstClients.SelectedIndex;
                txtModifyLastName.Text = DM.dtClient.Rows[cmClient.Position]["LastName"].ToString();
                txtModifyFirstName.Text = DM.dtClient.Rows[cmClient.Position]["FirstName"].ToString();
                txtModifyStreetAddress.Text = DM.dtClient.Rows[cmClient.Position]["StreetAddress"].ToString();
                txtModifySuburb.Text = DM.dtClient.Rows[cmClient.Position]["Suburb"].ToString();
                txtModifyCity.Text = DM.dtClient.Rows[cmClient.Position]["City"].ToString();
                txtModifyPhoneNumber.Text = DM.dtClient.Rows[cmClient.Position]["PhoneNumber"].ToString();
            }
        }

        /// <summary>method: btnDeleteClient_Click
        /// Delete client record according to the business policy
        /// </summary>
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            DataRow deleteClientRow = DM.dtClient.Rows[cmClient.Position];
            DataRow[] clientCaseRow = DM.dtCase.Select("ClientID = " + lblClientID.Text);

            if(clientCaseRow.Length == 0)
            {
                if(MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Clients who have no cases.", "Error");
                return;
            }
            DM.UpdateClient();
        }

        /// <summary>method: btnReturn_Click
        /// Close the Client Maintenance Form and return to Main Menu
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
