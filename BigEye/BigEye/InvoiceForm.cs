using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<Summary> class: InvoiceForm
///Purpose: Setup the report “Invoices” form of the application and allows the user to preview and print invoices of cases with status of Open. 
///Author: Mitchell Yuan
///Date: 20/04/2016
///</Summary>
namespace BigEye
{
    public partial class InvoiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMain;
        private CurrencyManager cmClient;
        private CurrencyManager cmCase;
        private CurrencyManager cmInvestigator;
        private int pagesPrinted, totalPages;
        DataRow[] casesForPrint;

        ///<Summary> method : InvoiceForm
        ///Class Constructor Method, initialize report “Invoices” Form and pass the references of Main Form and Data Module to this form.
        ///</Summary>
        public InvoiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMain = mnu;
            BindControls();
        }

        /// <summary>method: BindControls
        /// Binding context for the currency managers
        /// </summary>
        public void BindControls()
        {
            cmCase = (CurrencyManager)this.BindingContext[DM.dsBigEye, "T_Case"];
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBigEye, "T_Client"];
            cmInvestigator = (CurrencyManager)this.BindingContext[DM.dsBigEye, "T_Investigator"];
        }

        /// <summary>method: btnPreview_Click
        /// Call PrintPreviewDialog component to show a dialog that lets the user preview the print out
        /// </summary>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            pagesPrinted = 0;
            casesForPrint = DM.dtCase.Select("Status = 'Open'", "CaseID");  // Get cases records with a status of "Open"
            totalPages = casesForPrint.Length;

            invoicePreviewDlg.Document = printInvoices;
            invoicePreviewDlg.ShowDialog(); 
        }

        /// <summary>method: printInvoices_PrintPage
        /// PrintPage event handler of printInvoices object. Implement print code when invoked by PrintPreviewDialog component or Print() method of printInvoice object
        /// </summary>
        private void printInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            Brush myBrush = new SolidBrush(Color.Black);

            int lineSoFar = 0;
            int lineHeight = textFont.Height;

            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;

            string singleLine = "------------------------------------------------------------------------------------------------------------------------------";

            int caseTotal = 0;
            DataRow drCase = casesForPrint[pagesPrinted];
            int clientID = Convert.ToInt32(drCase["ClientID"].ToString());
            cmClient.Position = DM.clientView.Find(clientID);
            DataRow drClient = DM.dtClient.Rows[cmClient.Position]; //Get corresponding Client record

            string clientName = drClient["FirstName"].ToString() + " " + drClient["LastName"].ToString();
            string clientAddress = drClient["StreetAddress"].ToString() + ", " + drClient["Suburb"].ToString() + ", " + drClient["City"].ToString();

            //Print Case information
            g.DrawString("Case ID: " + drCase["CaseID"].ToString(), headingFont, myBrush, leftMargin, topMargin + (lineSoFar * lineHeight));
            lineSoFar++;
            g.DrawString("Description: " + drCase["Description"].ToString(), headingFont, myBrush, leftMargin, topMargin + (lineSoFar * lineHeight));
            lineSoFar++;
            g.DrawString("Date Opened: " + drCase["DateOpened"].ToString(), headingFont, myBrush, leftMargin, topMargin + (lineSoFar * lineHeight));
            lineSoFar++;
            lineSoFar++;
            lineSoFar++;

            //Print Client information
            g.DrawString("Client ID: " + drClient["ClientID"].ToString(), textFont, myBrush, leftMargin, topMargin + (lineSoFar * lineHeight));
            lineSoFar++;
            g.DrawString("Name: " + clientName, textFont, myBrush, leftMargin, topMargin + (lineSoFar * lineHeight));
            lineSoFar++;
            g.DrawString("Address: " + clientAddress, textFont, myBrush, leftMargin, topMargin + (lineSoFar * lineHeight));
            lineSoFar++;
            lineSoFar++;
            lineSoFar++;

            //Set position for the fields of an assignment and investigator information
            int nameAt = 220, rateAt = 380, hoursAt = 480, subtotalAt = 600;
            int posNameX = leftMargin + nameAt - MeasureDisplayStringWidth(g, "Name", headingFont);
            int posRateX = leftMargin + rateAt - MeasureDisplayStringWidth(g, "Hourly Rate", headingFont);
            int posHoursX = leftMargin + hoursAt - MeasureDisplayStringWidth(g, "Hours", headingFont);
            int posSubtotalX = leftMargin + subtotalAt - MeasureDisplayStringWidth(g, "Subtotal", headingFont);

            //Print head line for the assignment information
            g.DrawString("Investigator ID", headingFont, myBrush, leftMargin, topMargin + (lineSoFar * lineHeight));
            g.DrawString("Name", headingFont, myBrush, posNameX, topMargin + (lineSoFar * lineHeight));
            g.DrawString("Hourly Rate", headingFont, myBrush, posRateX, topMargin + (lineSoFar * lineHeight));
            g.DrawString("Hours", headingFont, myBrush, posHoursX, topMargin + (lineSoFar * lineHeight));
            g.DrawString("Subtotal", headingFont, myBrush, posSubtotalX, topMargin + (lineSoFar * lineHeight));
            lineSoFar++;
            g.DrawString(singleLine, textFont, myBrush, leftMargin, topMargin + (lineSoFar * lineHeight));
            lineSoFar++;

            //Print investigator information and subtotal fee of an assignment
            DataRow[] drAssignments = drCase.GetChildRows(DM.dtCase.ChildRelations["Case_Assignment"]);
            if (drAssignments.Length == 0)
            {
                g.DrawString("No investigator has been assigned to this case yet", textFont, myBrush, leftMargin, topMargin + (lineSoFar * lineHeight));
            }
            else
            {
                foreach (DataRow dr in drAssignments)
                {
                    int subTotal = 0;
                    cmInvestigator.Position = DM.investigatorView.Find(dr["InvestigatorID"]);
                    DataRow drInvestigator = DM.dtInvestigator.Rows[cmInvestigator.Position];

                    subTotal = Convert.ToInt32(dr["Hours"].ToString()) * Convert.ToInt32(drInvestigator["HourlyRate"].ToString());

                    string investigatorName = drInvestigator["FirstName"].ToString() + " " + drInvestigator["LastName"].ToString();
                    string strSubtotal = "$" + subTotal.ToString() + ".00";

                    int posANameX = leftMargin + nameAt - MeasureDisplayStringWidth(g, investigatorName, textFont) + 30;
                    int posARateX = leftMargin + rateAt - MeasureDisplayStringWidth(g, drInvestigator["HourlyRate"].ToString(), textFont);
                    int posAHoursX = leftMargin + hoursAt - MeasureDisplayStringWidth(g, dr["Hours"].ToString(), textFont);
                    int posASubtotalX = leftMargin + subtotalAt - MeasureDisplayStringWidth(g, strSubtotal, textFont);

                    g.DrawString(drInvestigator["InvestigatorID"].ToString(), textFont, myBrush, leftMargin + 50, topMargin + (lineSoFar * lineHeight));
                    g.DrawString(investigatorName, textFont, myBrush, posANameX, topMargin + (lineSoFar * lineHeight));
                    g.DrawString(drInvestigator["HourlyRate"].ToString(), textFont, myBrush, posARateX, topMargin + (lineSoFar * lineHeight));
                    g.DrawString(dr["Hours"].ToString(), textFont, myBrush, posAHoursX, topMargin + (lineSoFar * lineHeight));
                    g.DrawString(strSubtotal, textFont, myBrush, posASubtotalX, topMargin + (lineSoFar * lineHeight));
                    lineSoFar++;

                    caseTotal += subTotal;
                }

                lineSoFar++;
                string gross = "Gross:      " + "$" + caseTotal.ToString() + ".00";
                int posGross = leftMargin + subtotalAt - MeasureDisplayStringWidth(g, gross, headingFont);
                g.DrawString(gross, headingFont, myBrush, posGross, topMargin + (lineSoFar * lineHeight));
            }
            caseTotal = 0;
            pagesPrinted++;

            if (!(pagesPrinted == totalPages))
            {
                e.HasMorePages = true;
            }
            else
            {
                pagesPrinted = 0;
            }
        }

        /// <summary>method: btnPrint_Click
        /// Call Print() method of printInvoices object when the user clicks on "Print Invoices" button
        /// </summary>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            pagesPrinted = 0;
            casesForPrint = DM.dtCase.Select("Status = 'Open'", "CaseID");
            totalPages = casesForPrint.Length;

            printInvoices.Print();
        }

        /// <summary>method: btnReturn_Click
        /// Close the report "Invoices" Form and return to Main Menu
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>method: MeasureDisplayStringWidth
        /// a way of getting the exact width of a string display in pixels
        ///this is an improvement on the Graphics.MeasureString method since
        ///the Graphics.MeasureString method gives a value that is actually slightly
        ///longer than the width of the displayed string
        /// </summary>
        static public int MeasureDisplayStringWidth(Graphics graphics, string text, Font font)
        {
            System.Drawing.StringFormat format = new System.Drawing.StringFormat();
            System.Drawing.RectangleF rect = new System.Drawing.RectangleF(0, 0, 1000, 1000);
            System.Drawing.CharacterRange[] ranges = { new System.Drawing.CharacterRange(0, text.Length) };
            System.Drawing.Region[] regions = new System.Drawing.Region[1];

            format.SetMeasurableCharacterRanges(ranges);
            regions = graphics.MeasureCharacterRanges(text, font, rect, format);
            rect = regions[0].GetBounds(graphics);

            return (int)(rect.Right + 1.0f);
        }
    }
}
