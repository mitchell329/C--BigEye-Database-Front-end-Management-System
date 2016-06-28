using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<Summary> class: InvestigatorForm
///Purpose: Setup the Investigator Maintenance Form of the application and allows the user to view and maintenance Investigator information. 
///Author: Mitchell Yuan
///Date: 19/04/2016
///</Summary>
namespace BigEye
{
    public partial class InvestigatorForm : Form
    {
        private DataModule DM;
        private MainForm frmMain;
        private CurrencyManager cmInvestigator;

        ///<Summary> method : InvestigatorForm
        ///Class Constructor Method, initialize Investigator Maintenance Form and pass the references of Main Form and Data Module to this form.
        ///</Summary>
        public InvestigatorForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMain = mnu;
            BindControls();
            pnlAddInvestigator.Left = 363;
            pnlAddInvestigator.Top = 23;
            pnlModifyInvestigator.Left = 363;
            pnlModifyInvestigator.Top = 23;
        }

        /// <summary>method: BindControls
        /// Binding data from dataset to controls in the InvestigatorForm and display a list of Investigators and selected Investigator's details in the form.
        /// </summary>
        public void BindControls()
        {
            lblInvestigatorID.DataBindings.Add("Text", DM.dsBigEye, "T_Investigator.InvestigatorID");
            lblLastName.DataBindings.Add("Text", DM.dsBigEye, "T_Investigator.LastName");
            lblFirstName.DataBindings.Add("Text", DM.dsBigEye, "T_Investigator.FirstName");
            lblHourlyRate.DataBindings.Add("Text", DM.dsBigEye, "T_Investigator.HourlyRate");
            lblCellPhone.DataBindings.Add("Text", DM.dsBigEye, "T_Investigator.CellPhone");
            chbLicensed.DataBindings.Add("Checked", DM.dsBigEye, "T_Investigator.Licensed");
            lstInvestigator.DataSource = DM.dsBigEye;
            lstInvestigator.DisplayMember = "T_Investigator.LastName";
            lstInvestigator.ValueMember = "T_Investigator.InvestigatorID";
            cmInvestigator = (CurrencyManager)this.BindingContext[DM.dsBigEye, "T_Investigator"];
        }

        /// <summary>method: btnPrevious_Click
        /// Allows the user to navigate backward between Investigators in the list.
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(cmInvestigator.Position > 0)
            {
                cmInvestigator.Position--;
            }
        }

        /// <summary>method: btnNext_Click
        /// Allows the user to navigate forward between Investigators in the list.
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(cmInvestigator.Position < cmInvestigator.Count - 1)
            {
                cmInvestigator.Position++;
            }
        }

        /// <summary>method: btnAddInvestigator_Click
        /// Show a panel (with Save Investigator and Cancel buttons) allowing the user to enter new values for the Investigator’s last name, first name, hourly rate, cell phone and licensed status.
        /// </summary>
        private void btnAddInvestigator_Click(object sender, EventArgs e)
        {
            btnModifyInvestigator.Enabled = false;
            btnDeleteInvestigator.Enabled = false;
            pnlAddInvestigator.Show();
        }

        /// <summary>method: btnSaveInvestigator_Click
        /// If the user enters valid data for all fields and clicks on the "Save Investigator" button then a new Investigator record is saved in the database.
        /// </summary>
        private void btnSaveInvestigator_Click(object sender, EventArgs e)
        {
            lblInvestigatorID.Text = null;
            DataRow newInvestigatorRecord = DM.dtInvestigator.NewRow();

            if((txtAddLastName.Text == "") ||
               (txtAddFirstName.Text == "") ||
               (txtAddHourlyRate.Text == "") ||
               (txtAddCellPhone.Text == ""))
            {
                MessageBox.Show("You must type in all the fields.", "Error");
            }
            else
            {
                try
                {
                    newInvestigatorRecord["LastName"] = txtAddLastName.Text;
                    newInvestigatorRecord["FirstName"] = txtAddFirstName.Text;
                    newInvestigatorRecord["HourlyRate"] = Convert.ToInt32(txtAddHourlyRate.Text);
                    newInvestigatorRecord["CellPhone"] = txtAddCellPhone.Text;
                    newInvestigatorRecord["Licensed"] = chbAddLicensed.Checked;

                    DM.dtInvestigator.Rows.Add(newInvestigatorRecord);
                    DM.UpdateInvestigator();
                    MessageBox.Show("Investigator added successfully!", "Success");

                    pnlAddInvestigator.Hide();
                    btnModifyInvestigator.Enabled = true;
                    btnDeleteInvestigator.Enabled = true;
                    cmInvestigator.Position = cmInvestigator.Count - 1;
                }
                catch (FormatException ex)
                {
                        MessageBox.Show(ex.Message + "\r\n" + "Please enter a number for hourly rate.", "Error");
                }
            }

            return;
        }

        /// <summary>method: btnSaveCancle_Click
        /// If the user clicks on the Cancel button then panel will disappear and the Modify Investigator and Delete Investigator buttons enabled.
        /// </summary>
        private void btnSaveCancle_Click(object sender, EventArgs e)
        {
            pnlAddInvestigator.Hide();
            btnModifyInvestigator.Enabled = true;
            btnDeleteInvestigator.Enabled = true;
        }

        /// <summary>method: btnModifyInvestigator_Click
        /// Show a panel (with Update Investigator and Cancel buttons) allowing the user to change the values for the Investigator’s last name, first name, hourly rate, cell phone or licensed status (using a checkbox).
        /// </summary>
        private void btnModifyInvestigator_Click(object sender, EventArgs e)
        {
            btnAddInvestigator.Enabled = false;
            btnDeleteInvestigator.Enabled = false;
            pnlModifyInvestigator.Show();

            DataRow currentRow = DM.dtInvestigator.Rows[cmInvestigator.Position];
            txtModifyLastName.Text = currentRow["LastName"].ToString();
            txtModifyFirstName.Text = currentRow["FirstName"].ToString();
            txtModifyHourlyRate.Text = currentRow["HourlyRate"].ToString();
            txtModifyCellPhone.Text = currentRow["CellPhone"].ToString();
            chbModifyLicensed.Checked = Convert.ToBoolean(currentRow["Licensed"]);
        }

        /// <summary>method: btnSaveModify_Click
        /// If the user makes valid changes to any of the allowable fields and clicks on the Update Investigator button then the Investigator record is updated in the database.
        /// </summary>
        private void btnSaveModify_Click(object sender, EventArgs e)
        {
            DataRow modifyInvestigatorRow = DM.dtInvestigator.Rows[cmInvestigator.Position];

            if((txtModifyLastName.Text == "") ||
               (txtModifyFirstName.Text == "") ||
               (txtModifyHourlyRate.Text == "") ||
               (txtModifyCellPhone.Text == ""))
            {
                MessageBox.Show("You must type in all the fields.", "Error");
            }
            else
            {
                try
                {
                    modifyInvestigatorRow["LastName"] = txtModifyLastName.Text;
                    modifyInvestigatorRow["FirstName"] = txtModifyFirstName.Text;
                    modifyInvestigatorRow["HourlyRate"] = Convert.ToInt32(txtModifyHourlyRate.Text);
                    modifyInvestigatorRow["CellPhone"] = txtModifyCellPhone.Text;
                    modifyInvestigatorRow["Licensed"] = chbModifyLicensed.Checked;

                    DM.UpdateInvestigator();
                    MessageBox.Show("Investigator updated successfully!", "Success");

                    pnlModifyInvestigator.Hide();
                    btnAddInvestigator.Enabled = true;
                    btnDeleteInvestigator.Enabled = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + "Please enter a number for hourly rate.", "Error");
                }
            }

            return;
        }

        /// <summary>method: btnModifyCancle_Click
        /// If the user clicks on the Cancel button then the panel will disappear and the Add Investigator and Delete Investigator buttons enabled.
        /// </summary>
        private void btnModifyCancle_Click(object sender, EventArgs e)
        {
            pnlModifyInvestigator.Hide();
            btnAddInvestigator.Enabled = true;
            btnDeleteInvestigator.Enabled = true;
        }

        /// <summary>method: lstInvestigator_Click
        /// If the user clicks on different items in the listbox then the value of controls in the panel will varify accordingly to allow user modify Investigator information without return.
        /// </summary>
        private void lstInvestigator_Click(object sender, EventArgs e)
        {
            cmInvestigator.Position = lstInvestigator.SelectedIndex;
            DataRow currentRow = DM.dtInvestigator.Rows[cmInvestigator.Position];
            txtModifyLastName.Text = currentRow["LastName"].ToString();
            txtModifyFirstName.Text = currentRow["FirstName"].ToString();
            txtModifyHourlyRate.Text = currentRow["HourlyRate"].ToString();
            txtModifyCellPhone.Text = currentRow["CellPhone"].ToString();
            chbModifyLicensed.Checked = Convert.ToBoolean(currentRow["Licensed"]);
        }

        /// <summary>method: btnDeleteInvestigator_Click
        /// Delete an Investigator record according to the business policy
        /// </summary>
        private void btnDeleteInvestigator_Click(object sender, EventArgs e)
        {
            DataRow deleteInvestigatorRow = DM.dtInvestigator.Rows[cmInvestigator.Position];
            DataRow[] investigatorAssignmentRow = DM.dtAssignment.Select("InvestigatorID = " + lblInvestigatorID.Text);
            DataRow[] investigatorEquipmentRow = DM.dtEquipment.Select("InvestigatorID = " + lblInvestigatorID.Text);

            if(investigatorAssignmentRow.Length == 0 && investigatorEquipmentRow.Length == 0)
            {
                if(MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteInvestigatorRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else if(investigatorAssignmentRow.Length != 0)
            {
                MessageBox.Show("You may only delete Investigators who are not assigned to cases.", "Error");
            }
            else if(investigatorEquipmentRow.Length != 0)
            {
                MessageBox.Show("You may only delete Investigators who are not allocated equipment.", "Error");
            }

            DM.UpdateInvestigator();
        }

        /// <summary>method: btnReturn_Click
        /// Close the Investigator Maintenance Form and return to Main Menu
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
