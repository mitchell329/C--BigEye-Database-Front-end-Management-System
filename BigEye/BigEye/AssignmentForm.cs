using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<Summary> class: AssignmentForm
///Purpose: Setup the Case Assignment Maintenance Form of the application and allows the user to view and maintenance Case Assignment information. 
///Author: Mitchell Yuan
///Date: 19/04/2016
///</Summary>
namespace BigEye
{
    public partial class AssignmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMain;
        private CurrencyManager cmCase;
        private CurrencyManager cmCaseAssignment;
        private CurrencyManager cmAssignment;

        ///<Summary> method : AssignmentForm
        ///Class Constructor Method, initialize Case Assignment Maintenance Form and pass the references of Main Form and Data Module to this form.
        ///</Summary>
        public AssignmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMain = mnu;
            BindControls();
            pnlAssignInvestigator.Left = 258;
            pnlAssignInvestigator.Top = 131;
            pnlModifyAssignment.Left = 258;
            pnlModifyAssignment.Top = 131;
        }

        /// <summary>method: BindControls
        /// Binding data from dataset to controls in the AssignmentForm and display a selected case’s details (along with the client’s full name and the full names of each investigator assigned) in a read-only datagridview object.
        /// </summary>
        public void BindControls()
        {
            lstAssignedCase.DataSource = DM.dsBigEye;
            lstAssignedCase.DisplayMember = "T_Case.CaseID";
            lstAssignedCase.ValueMember = "T_Case.CaseID";
            lblClientID.DataBindings.Add("Text", DM.dsBigEye, "T_Case.ClientID");

            // Bind the datagridview object to the relationship between Cases and Assignments.
            dgvAssignment.DataSource = DM.dsBigEye;
            dgvAssignment.DataMember = "T_Case.Case_Assignment";

            cmCase = (CurrencyManager)this.BindingContext[DM.dsBigEye, "T_Case"];
            cmCase.CurrentChanged += CmCase_CurrentChanged;     // Creat a CurrentChanged event that belong to the Currency Managers that run when the current row changes.
            cmCaseAssignment = (CurrencyManager)this.BindingContext[DM.dsBigEye, "T_Case.Case_Assignment"];
            cmCaseAssignment.CurrentChanged += new EventHandler(CmCaseAssignment_CurrentChanged);   // Creat a CurrentChanged event that belong to the Currency Managers that run when the current row changes.
            cmAssignment = (CurrencyManager)this.BindingContext[DM.dsBigEye, "T_Assignment"];
        }

        /// <summary>method: CmCaseAssignment_CurrentChanged
        /// If selected case has assignments, display Investigator's name of selected assignment and enable "Modify Assignment" and "Remove Investigator" buttons. Otherwise, disable "Modify Assignment" and "Remove Investigator" buttons.
        /// </summary>
        private void CmCaseAssignment_CurrentChanged(object sender, EventArgs e)
        {
            if (cmCaseAssignment.Count != 0)
            {
                DataRowView row = (DataRowView)cmCaseAssignment.Current;
                int investigatorKey = Convert.ToInt32(row["InvestigatorID"]);
                DataRow drInvestigator = DM.dtInvestigator.Rows[DM.investigatorView.Find(investigatorKey)];
                lblInvestigatorName.Text = drInvestigator["FirstName"].ToString() + " " + drInvestigator["LastName"].ToString();
                btnModifyAssignment.Enabled = true;
                btnRemoveInvestigator.Enabled = true;
            }
            else
            {
                lblInvestigatorName.Text = "";
                btnModifyAssignment.Enabled = false;
                btnRemoveInvestigator.Enabled = false;
            }
        }

        /// <summary>method: CmCase_CurrentChanged
        /// When selected item changed in Cases list box, display the full name of corresponding Client.
        /// </summary>
        private void CmCase_CurrentChanged(object sender, EventArgs e)
        {
            int clientKey = Convert.ToInt32(lblClientID.Text);
            DataRow drClient = DM.dtClient.Rows[DM.clientView.Find(clientKey)];
            lblClientFullName.Text = drClient["FirstName"].ToString() + " " + drClient["LastName"].ToString();
        }

        /// <summary>method: btnPrevious_Click
        /// Allows the user to navigate backward between Cases in the list.
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (cmCase.Position > 0)
            {
                cmCase.Position--;
            }
        }

        /// <summary>method: btnNext_Click
        /// Allows the user to navigate forward between Cases in the list.
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmCase.Position < cmCase.Count - 1)
            {
                cmCase.Position++;
            }
        }

        /// <summary>method: btnAssignInvestigator_Click
        /// If the user clicks on the Assign Investigator button and the selected case has a status of Open then the Modify Assignment and Remove Investigator buttons are disabled and a panel appears (showing Save Assignment and Cancel buttons) allowing the user to enter new values for the Investigator(using a combo box), date(using a date picked) and hours.
        /// </summary>
    private void btnAssignInvestigator_Click(object sender, EventArgs e)
        {
            string caseStatus = DM.dtCase.Rows[cmCase.Position]["Status"].ToString();

            if (caseStatus == "Open")
            {
                btnModifyAssignment.Enabled = false;
                btnRemoveInvestigator.Enabled = false;

                // "Previous" button, "Next" button and Cases list is disabled to prevent user to navigate between cases when Assing Investigator panel is showing.
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                lstAssignedCase.Enabled = false;
                pnlAssignInvestigator.Show();

                // Load data to Investigator ID combo box.
                cmbInvestigatorID.DataSource = DM.dsBigEye;
                cmbInvestigatorID.DisplayMember = "T_Investigator.InvestigatorID";
                cmbInvestigatorID.ValueMember = "T_Investigator.InvestigatorID";
            }
            else
            {
                MessageBox.Show("Cannot assign investigators to closed cases", "Error");
            }
        }

        /// <summary>method: btnSaveAssignment_Click
        /// If the user enters valid data for all fields and clicks on the Save Assignment button then a new assignment record is saved in the database. If the Investigator has already existed, display an Error message.
        /// </summary>
        private void btnSaveAssignment_Click(object sender, EventArgs e)
        {
            if (cmbInvestigatorID.Text == "" || txtHoursAssigned.Text == "")
            {
                MessageBox.Show("You must select or type in a investigator's ID and a number for assigned hours", "Error");
            }
            else
            {
                bool investigatorExist = false;     // Define a label variable to check whether the investigator has already been assigned to selected case.
                DataRow[] caseAssignmentRecord = DM.dtCase.Rows[cmCase.Position].GetChildRows(DM.dtCase.ChildRelations["Case_Assignment"]);

                // Loop through the detail records and mark the label variable as true if there's a record with "InvestigatorID" matching the string in Investigator ID combo box.
                foreach (DataRow dr in caseAssignmentRecord)
                {
                    if (dr["InvestigatorID"].ToString() == cmbInvestigatorID.Text)
                    {
                        investigatorExist = true;
                        break;
                    }
                }
                
                if (investigatorExist)
                {
                    MessageBox.Show("This Investigator has already been assigned to this case", "Error");
                }
                else
                {
                    try
                    {
                        DataRow newAssignmentRow = DM.dtAssignment.NewRow();

                        newAssignmentRow["CaseID"] = DM.dtCase.Rows[cmCase.Position]["CaseID"];
                        newAssignmentRow["InvestigatorID"] = Convert.ToInt32(cmbInvestigatorID.Text);
                        newAssignmentRow["Hours"] = Convert.ToInt32(txtHoursAssigned.Text);
                        newAssignmentRow["DateAssigned"] = Convert.ToDateTime(dtpDateAssigned.Text);

                        DM.dtAssignment.Rows.Add(newAssignmentRow);
                        DM.UpdateAssignment();
                        MessageBox.Show("Case assigned successfully", "Success");
                        pnlAssignInvestigator.Hide();
                        btnModifyAssignment.Enabled = true;
                        btnRemoveInvestigator.Enabled = true;
                        btnPrevious.Enabled = true;
                        btnNext.Enabled = true;
                        lstAssignedCase.Enabled = true;
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message + "\r\n" + "Please enter numbers for Investigator ID and Hours", "Error");
                    }
                }
            }
        }

        /// <summary>method: btnSaveCancel_Click
        /// If the user clicks on the Cancel button then panel will disappear and the Modify Assignment, Remove Investigator, Previous, and Next buttons and Cases list enabled.
        /// </summary>
        private void btnSaveCancel_Click(object sender, EventArgs e)
        {
            pnlAssignInvestigator.Hide();
            btnModifyAssignment.Enabled = true;
            btnRemoveInvestigator.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            lstAssignedCase.Enabled = true;
        }

        /// <summary>method: btnModifyAssignment_Click
        /// If the Status of selected case is "Open", show a panel (with Update Assignment and Cancel buttons) allowing the user to change the values for the assignment’s number of hours and date (using a date picker). Otherwise, show an Error message.
        /// </summary>
        private void btnModifyAssignment_Click(object sender, EventArgs e)
        {
            string caseStatus = DM.dtCase.Rows[cmCase.Position]["Status"].ToString();

            if (caseStatus == "Open")
            {
                btnAssignInvestigator.Enabled = false;
                btnRemoveInvestigator.Enabled = false;
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                lstAssignedCase.Enabled = false;
                pnlModifyAssignment.Show();
            }
            else
            {
                MessageBox.Show("Cannot modify Investigators on a closed Case", "Error");
            }
        }

        /// <summary>method: btnUpdateInvestigator_Click
        /// If the user makes a valid change to the number of hours or date and clicks on the Update Investigator button then the Case Investigator record is updated in the database.
        /// </summary>
        private void btnUpdateInvestigator_Click(object sender, EventArgs e)
        {
            if (txtHourUpdate.Text == "")
            {
                MessageBox.Show("You must type in a number for the assignment's hours", "Error");
            }
            else
            {
                try
                {
                    if (Convert.ToInt32(txtHourUpdate.Text) == 0)
                    {
                        MessageBox.Show("Cannot reset an assignment's hours to zero", "Error");
                    }
                    else
                    {
                        DataRowView row = (DataRowView)cmCaseAssignment.Current;

                        // Loop through Assignment table to find the record which has the same Case ID with selected case and same Investigator ID with selected assignment.
                        for (int i = 0; i < cmAssignment.Count; i++)
                        {
                            if (DM.dtAssignment.Rows[i]["CaseID"].ToString() == DM.dtCase.Rows[cmCase.Position]["CaseID"].ToString() && DM.dtAssignment.Rows[i]["InvestigatorID"].ToString() == row["InvestigatorID"].ToString())
                            {
                                DataRow updateInvestigatorAssignment = DM.dtAssignment.Rows[i];
                                updateInvestigatorAssignment["Hours"] = Convert.ToInt32(txtHourUpdate.Text);
                                updateInvestigatorAssignment["DateAssigned"] = Convert.ToDateTime(dtpDateUpdate.Text);
                                DM.UpdateAssignment();
                                MessageBox.Show("Investigator assignment updated successfully", "Success");
                                pnlModifyAssignment.Hide();
                                btnAssignInvestigator.Enabled = true;
                                btnRemoveInvestigator.Enabled = true;
                                btnPrevious.Enabled = true;
                                btnNext.Enabled = true;
                                lstAssignedCase.Enabled = true;
                                break;
                            }
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + "Please enter a number for assignment's hours", "Error");
                }
            }
        }

        /// <summary>method: btnUpdateCancle_Click
        /// If the user clicks on the Cancel button then the panel will disappear and the Assign Investigator, Remove Investigator, Previous and Next buttons and Cases list enabled.
        /// </summary>
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlModifyAssignment.Hide();
            btnAssignInvestigator.Enabled = true;
            btnRemoveInvestigator.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            lstAssignedCase.Enabled = true;
        }

        /// <summary>method: btnRemoveInvestigator_Click
        /// If the user clicks on the Remove Investigator button and the selected Case has a status of Open then  the Case Investigator record is deleted in condition the user confirms.
        /// </summary>
        private void btnRemoveInvestigator_Click(object sender, EventArgs e)
        {
            string caseStatus = DM.dtCase.Rows[cmCase.Position]["Status"].ToString();

            if (caseStatus == "Open")
            {
                if (MessageBox.Show("Are you sure you want to remove this investigator from the case?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataRowView row = (DataRowView)cmCaseAssignment.Current;

                    for (int i = 0; i < cmAssignment.Count; i++)
                    {
                        if (DM.dtAssignment.Rows[i]["CaseID"].ToString() == DM.dtCase.Rows[cmCase.Position]["CaseID"].ToString() && DM.dtAssignment.Rows[i]["InvestigatorID"].ToString() == row["InvestigatorID"].ToString())
                        {
                            DataRow removeInvestigatorAssignment = DM.dtAssignment.Rows[i];
                            removeInvestigatorAssignment.Delete();
                            DM.UpdateAssignment();
                            MessageBox.Show("The Investigator has been removed from the case", "Success");
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You may only remove Investigators from open cases", "Error");
            }
        }

        /// <summary>method: btnReturn_Click
        /// Close the Case Assignment Maintenance Form and return to Main Menu
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
