using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPrject.Common
{
    internal class clsInvoice
    {
        /// <summary>
        /// Invoice Identification number 
        /// </summary>
        private int InvNum;

        /// <summary>
        /// Date of Invoice Submission
        /// </summary>
        private string InvDate;

        /// <summary>
        /// Array of Total charges (prices for individual items) for Invoice 
        /// </summary>
        private int InvCharge;


        public clsInvoice( int Id, DateTime date, int charges)
        {
            // set class variables 
            SetInvNum(Id);
            SetInvDate(date);
            SetInvCharge(charges);

        }


        #region Invoice Number Get Set

        /// <summary>
        /// Sets the class variable of the Invoice number
        /// </summary>
        /// <param name="Id">Invoice Number</param>
         private void SetInvNum(int Id)
         {
            InvNum = Id;
         }

        /// <summary>
        /// Getter for Invoice Number
        /// </summary>
        /// <returns>Invoice Number</returns>
         public int GetInvNum() { return InvNum;}
        #endregion

        #region Invoice Date Get Set

        /// <summary>
        /// Sets the class variable for the Invoice Date as a string with the format "dd, mm, yyyy"
        /// </summary>
        /// <param name="date">DateTime parameter to set class variable</param>
        private void SetInvDate(DateTime date)
        {
            InvDate = date.ToString("dd, mm, yyyy");
        }

        /// <summary>
        /// Getter for the class variable Invoice Date
        /// </summary>
        /// <returns>String of a date in the format "dd, mm, yyyy"</returns>
         public string GetInvDate() { return InvDate; }

        #endregion

        #region Inventory Charges Get Set

        /// <summary>
        /// Sets the class variable int total charges for an invoice.
        /// </summary>
        /// <param name="charges">int for invoice total price</param>
         private void SetInvCharge(int charges)
         {
            InvCharge = charges;
         }
           
         public int GetInvCharges() { return InvCharge;}

        #endregion
       
    }
}
