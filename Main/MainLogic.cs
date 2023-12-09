using Assignment_6;
using GroupPrject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPrject.Main
{
    internal class MainLogic
    {
        public static Invoice GetInvoice(int invoiceNumber)
        {
            int results = 0;
            DataSet invoicesData = DataAccess.ExecuteSQLStatement(MainSQL.GetInvoiceData(invoiceNumber), ref results);
        }
    }
}
