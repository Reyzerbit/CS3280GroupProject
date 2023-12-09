using Assignment_6;
using GroupPrject.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GroupPrject.Main
{
    internal class MainLogic
    {
        /// <summary>
        /// Gets invoice from database
        /// </summary>
        /// <param name="invoiceNumber"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static Invoice GetInvoice(int invoiceNumber)
        {
            try
            {
                int results = 0;
                DataSet invoicesData = DataAccess.ExecuteSQLStatement(MainSQL.GetInvoiceData(invoiceNumber), ref results);
                if (results != 1) throw new Exception($"Multiple invoices in database with number {invoiceNumber}!");

                DataRowCollection row = invoicesData.Tables[0].Rows;
                return new Invoice(int.Parse(row[0].ToString()), row[1].ToString(), int.Parse(row[2].ToString()));
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

    }
}
