using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<Summary>class: MainForm
///Purpose: Setup the main menu of the application and allows the user to access all the forms and the report in the system and exit the application. 
///Author: Mitchell Yuan
///Date: 19/04/2016
///</Summary>

namespace BigEye
{
    public partial class MainForm : Form
    {
        private DataModule DM;
        private ClientForm frmClient;
        private InvestigatorForm frmInvestigator;
        private CaseForm frmCase;
        private EquipmentForm frmEquipment;
        private AssignmentForm frmAssignment;
        private InvoiceForm frmInvoice;

        ///<Summary> method : MainForm
        ///Class Constructor Method
        ///</Summary>
        public MainForm()
        {
            InitializeComponent();
        }

        ///<Summary> method : MainForm_Load
        ///Instantiate a DataModule object when the MainForm is loaded
        ///</Summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        ///<Summary> method : btnClientMaintenance_Click
        ///Open Client Maintenance Form and pass the reference of data module object to Client Maintenance Form
        ///</Summary>
        private void btnClientMaintenance_Click(object sender, EventArgs e)
        {
            if (frmClient == null)
            {
                frmClient = new ClientForm(DM, this);
            }

            frmClient.ShowDialog();
        }

        ///<Summary> method : btnInvestigatorMaintenance_Click
        ///Open Investigator Maintenance Form and pass the reference of data module object to Investigator Maintenance Form
        ///</Summary>
        private void btnInvestigatorMaintenance_Click(object sender, EventArgs e)
        {
            if (frmInvestigator == null)
            {
                frmInvestigator = new InvestigatorForm(DM, this);
            }

            frmInvestigator.ShowDialog();
        }

        ///<Summary> method : btnEquipmentMaintenance_Click
        ///Open Equipment Maintenance Form and pass the reference of data module object to Equipment Maintenance Form
        ///</Summary>
        private void btnEquipmentMaintenance_Click(object sender, EventArgs e)
        {
            if (frmEquipment == null)
            {
                frmEquipment = new EquipmentForm(DM,this);
            }

            frmEquipment.ShowDialog();
        }

        ///<Summary> method : btnCaseMaintenance_Click
        ///Open Case Maintenance Form and pass the reference of data module object to Case Maintenance Form
        ///</Summary>
        private void btnCaseMaintenance_Click(object sender, EventArgs e)
        {
            if (frmCase == null)
            {
                frmCase = new CaseForm(DM, this);
            }

            frmCase.ShowDialog();
        }

        ///<Summary> method : btnCaseAssignMaintenance_Click
        ///Open Case Assignment Maintenance Form and pass the reference of data module object to Case Assignment Maintenance Form
        ///</Summary>
        private void btnCaseAssignMaintenance_Click(object sender, EventArgs e)
        {
            if (frmAssignment == null)
            {
                frmAssignment = new AssignmentForm(DM,this);
            }

            frmAssignment.ShowDialog();
        }

        ///<Summary> method : btnInvoices_Click
        ///Open Invoice Form and pass the reference of data module object to Invoice Form
        ///</Summary>
        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new InvoiceForm(DM, this);
            }

            frmInvoice.ShowDialog();
        }

        ///<Summary> method : btnExit_Click
        ///Exit the program
        ///</Summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
