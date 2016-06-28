using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

///<Summary> class: DataModule
///Purpose: Hold all the data management objects on a single form and create a shared dataset. 
///Author: Mitchell Yuan
///Date: 19/04/2016
///</Summary>
namespace BigEye
{
    public partial class DataModule : Form
    {
        public DataTable dtClient;
        public DataTable dtInvestigator;
        public DataTable dtEquipment;
        public DataTable dtCase;
        public DataTable dtAssignment;

        public DataView clientView;
        public DataView investigatorView;
        public DataView equipmentView;
        public DataView caseView;
        public DataView assignmentView;

        ///<Summary> method : DataModule
        ///Class Constructor Method, initialize data management objects.
        ///</Summary>
        public DataModule()
        {
            InitializeComponent();
            dsBigEye.EnforceConstraints = false;

            daClient.Fill(dsBigEye);
            daInvestigator.Fill(dsBigEye);
            daCase.Fill(dsBigEye);
            daEquipment.Fill(dsBigEye);
            daAssignment.Fill(dsBigEye);
            daCaseType.Fill(dsBigEye, "T_CaseType");    //Generate a Case Type table in the memory containing only one column named "CaseType" which holds existing case types. Each case type has only one record.
            daAssignedCase.Fill(dsBigEye, "T_AssignedCase");

            dtClient = dsBigEye.Tables["T_Client"];
            dtInvestigator = dsBigEye.Tables["T_Investigator"];
            dtEquipment = dsBigEye.Tables["T_Equipment"];
            dtCase = dsBigEye.Tables["T_Case"];
            dtAssignment = dsBigEye.Tables["T_Assignment"];

            clientView = new DataView(dtClient);
            clientView.Sort = "ClientID";

            investigatorView = new DataView(dtInvestigator);
            investigatorView.Sort = "InvestigatorID";

            caseView = new DataView(dtCase);
            caseView.Sort = "CaseID";

            equipmentView = new DataView(dtEquipment);
            equipmentView.Sort = "EquipmentID";

            assignmentView = new DataView(dtAssignment);
            assignmentView.Sort = "CaseID";

            dsBigEye.EnforceConstraints = true;
        }

        ///<Summary> method : UpdateClient
        ///Update "T_Client" table in the database.
        ///</Summary>
        internal void UpdateClient()
        {
            daClient.Update(dtClient);
        }

        ///<Summary> method : daClient_RowUpdated
        ///Generate a new key value for the main key of "T_Client" table when insert a new record.
        ///</Summary>
        private void daClient_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBigEye);

            if(e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ClientID"] = newID;
            }
        }

        ///<Summary> method : UpdateInvestigator
        ///Update "T_Investigator" table in the database.
        ///</Summary>
        internal void UpdateInvestigator()
        {
            daInvestigator.Update(dtInvestigator);
        }

        ///<Summary> method : daInvestigator_RowUpdated
        ///Generate a new key value for the main key of "T_Investigator" table when insert a new record.
        ///</Summary>
        private void daInvestigator_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBigEye);

            if(e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["InvestigatorID"] = newID;
            }
        }

        ///<Summary> method : UpdateEquipment
        ///Update "T_Equipment" table in the database.
        ///</Summary>
        internal void UpdateEquipment()
        {
            daEquipment.Update(dtEquipment);
        }

        ///<Summary> method : daEquipment_RowUpdated
        ///Generate a new key value for the main key of "T_Equipment" table when insert a new record.
        ///</Summary>
        private void daEquipment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBigEye);

            if(e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EquipmentID"] = newID;
            }
        }

        ///<Summary> method : UpdateCase
        ///Update "T_Case" table in the database.
        ///</Summary>
        internal void UpdateCase()
        {
            daCase.Update(dtCase);
        }

        ///<Summary> method : daCase_RowUpdated
        ///Generate a new key value for the main key of "T_Case" table when insert a new record.
        ///</Summary>
        private void daCase_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBigEye);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["CaseID"] = newID;
            }
        }

        ///<Summary> method : UpdateAssignment
        ///Update "T_Assignment" table in the database.
        ///</Summary>
        internal void UpdateAssignment()
        {
            daAssignment.Update(dtAssignment);
        }
    }
}
