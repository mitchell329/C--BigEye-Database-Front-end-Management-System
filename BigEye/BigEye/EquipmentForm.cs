using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<Summary> class: EquipmentForm
///Purpose: Setup the Equipment Maintenance Form of the application and allows the user to view and maintenance Equipment information. 
///Author: Mitchell Yuan
///Date: 19/04/2016
///</Summary>
namespace BigEye
{
    public partial class EquipmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMain;
        private CurrencyManager cmEquipment;

        ///<Summary> method : EquipmentForm
        ///Class Constructor Method, initialize Equipment Maintenance Form and pass the references of Main Form and Data Module to this form.
        ///</Summary>
        public EquipmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMain = mnu;
            BindControls();
            pnlAddEquipment.Left = 334;
            pnlAddEquipment.Top = 23;
            pnlModifyEquipment.Left = 334;
            pnlModifyEquipment.Top = 23;
        }

        /// <summary>method: BindControls
        /// Binding data from dataset to controls in the EquipmentForm and display a list of Equipment and selected Equipment's details in the form.
        /// </summary>
        public void BindControls()
        {
            lblEquipmentID.DataBindings.Add("Text", DM.dsBigEye, "T_Equipment.EquipmentID");
            lblDescription.DataBindings.Add("Text", DM.dsBigEye, "T_Equipment.Description");
            lblInvestigatorID.DataBindings.Add("Text", DM.dsBigEye, "T_Equipment.InvestigatorID");
            lstEquipment.DataSource = DM.dsBigEye;
            lstEquipment.DisplayMember = "T_Equipment.Description";
            lstEquipment.ValueMember = "T_Equipment.EquipmentID";
            cmEquipment = (CurrencyManager)this.BindingContext[DM.dsBigEye, "T_Equipment"];
        }

        /// <summary>method: btnAddEquipment_Click
        /// Show a panel (with Save Equipment and Cancel buttons) allowing the user to enter new values for the Equipment’s description (the investigator ID is set to null).
        /// </summary>
        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            btnModifyEquipment.Enabled = false;
            btnDeleteEquipment.Enabled = false;
            pnlAddEquipment.Show();
        }

        /// <summary>method: btnAddCancle_Click
        /// If the user clicks on the Cancel button then panel will disappear and the Modify Equipment and Delete Equipment buttons enabled.
        /// </summary>
        private void btnAddCancle_Click(object sender, EventArgs e)
        {
            btnModifyEquipment.Enabled = true;
            btnDeleteEquipment.Enabled = true;
            pnlAddEquipment.Hide();
        }

        /// <summary>method: btnPrevious_Click
        /// Allows the user to navigate backward between Equipment in the list.
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(cmEquipment.Position > 0)
            {
                cmEquipment.Position--;
            }
        }

        /// <summary>method: btnNext_Click
        /// Allows the user to navigate forward between Equipment in the list.
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(cmEquipment.Position < cmEquipment.Count - 1)
            {
                cmEquipment.Position++;
            }
        }

        /// <summary>method: btnSaveEquipment_Click
        /// If the user enters valid data for the description and clicks on the Save Equipment button then a new Equipment record is saved in the database.
        /// </summary>
        private void btnSaveEquipment_Click(object sender, EventArgs e)
        {
            lblEquipmentID.Text = null;
            DataRow newEquipmentRecord = DM.dtEquipment.NewRow();

            if(txtAddEquipment.Text == "")
            {
                MessageBox.Show("You must type in a description for the equipment", "Error");
            }
            else
            {
                try
                {
                    newEquipmentRecord["Description"] = txtAddEquipment.Text;
                    newEquipmentRecord["InvestigatorID"] = DBNull.Value;

                    DM.dtEquipment.Rows.Add(newEquipmentRecord);
                    DM.UpdateEquipment();
                    MessageBox.Show("Equipment added successfully!", "Success");
                    pnlAddEquipment.Hide();
                    btnModifyEquipment.Enabled = true;
                    btnDeleteEquipment.Enabled = true;
                    cmEquipment.Position = cmEquipment.Count - 1;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

            return;
        }

        /// <summary>method: btnModifyEquipment_Click
        /// Show a panel (with Update Equipment and Cancel buttons) allowing the user to change the values for the Equipment’s description and investigator (using a combo box).
        /// </summary>
        private void btnModifyEquipment_Click(object sender, EventArgs e)
        {
            btnAddEquipment.Enabled = false;
            btnDeleteEquipment.Enabled = false;
            pnlModifyEquipment.Show();

            DataRow currentRow = DM.dtEquipment.Rows[cmEquipment.Position];
            txtModifyDescription.Text = currentRow["Description"].ToString();
            cmbModifyInvestigator.DataSource = DM.dsBigEye;
            cmbModifyInvestigator.DisplayMember = "T_Investigator.InvestigatorID";
            cmbModifyInvestigator.ValueMember = "T_Investigator.InvestigatorID";
            cmbModifyInvestigator.Text = currentRow["InvestigatorID"].ToString();
        }

        /// <summary>method: lstEquipment_Click
        /// If the user clicks on different items in the listbox then the value of controls in the panel will varify accordingly to allow user modify Equipment information without return.
        /// </summary>
        private void lstEquipment_Click(object sender, EventArgs e)
        {
            cmEquipment.Position = lstEquipment.SelectedIndex;
            DataRow currentRow = DM.dtEquipment.Rows[cmEquipment.Position];
            txtModifyDescription.Text = currentRow["Description"].ToString();
            cmbModifyInvestigator.Text = currentRow["InvestigatorID"].ToString();
        }

        /// <summary>method: btnUpdateCancle_Click
        /// If the user clicks on the Cancel button then the panel will disappear and the Add Equipment and Delete Equipment buttons enabled.
        /// </summary>
        private void btnUpdateCancle_Click(object sender, EventArgs e)
        {
            pnlModifyEquipment.Hide();
            btnAddEquipment.Enabled = true;
            btnDeleteEquipment.Enabled = true;
        }

        /// <summary>method: btnUpdateSave_Click
        /// If the user makes valid changes to any of the allowable fields and clicks on the Update Equipment button then the Equipment record is updated in the database.
        /// </summary>
        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            DataRow updateEquipmentRecord = DM.dtEquipment.Rows[cmEquipment.Position];

            if (txtModifyDescription.Text == "")
            {
                MessageBox.Show("You must type in a description for the equipment", "Error");
            }
            else
            {
                try
                {
                    updateEquipmentRecord["Description"] = txtModifyDescription.Text;
                    if (cmbModifyInvestigator.Text != "")
                    {
                        updateEquipmentRecord["InvestigatorID"] = Convert.ToInt32(cmbModifyInvestigator.Text);
                    }
                    

                    DM.UpdateEquipment();
                    MessageBox.Show("Equipment updated successfully!", "Success");
                    pnlModifyEquipment.Hide();
                    btnAddEquipment.Enabled = true;
                    btnDeleteEquipment.Enabled = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + "Please use \"Remove Investigator\" button to delete Investigator ID.", "Error");
                }
            }

            return;
        }

        /// <summary>method: btnDeleteEquipment_Click
        /// Delete an Equipment record according to the business policy
        /// </summary>
        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            DataRow deleteEquipmentRecord = DM.dtEquipment.Rows[cmEquipment.Position];

            if(deleteEquipmentRecord["InvestigatorID"] == DBNull.Value)
            {
                if(MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEquipmentRecord.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Equipment that is not assigned to an investigator.", "Error");
            }

            DM.UpdateEquipment();
        }

        /// <summary>method: btnRemoveInvestigator_Click
        /// If the user clicks on the Remove Investigator button then selected Equipment has its investigator ID set to null.
        /// </summary>
        private void btnRemoveInvestigator_Click(object sender, EventArgs e)
        {
            DM.dtEquipment.Rows[cmEquipment.Position]["InvestigatorID"] = DBNull.Value;
            DM.UpdateEquipment();
        }

        /// <summary>method: btnReturn_Click
        /// Close the Equipment Maintenance Form and return to Main Menu
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
