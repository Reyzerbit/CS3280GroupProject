using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPrject.Search
{
    internal class SearchSQL
    {
        public SearchSQL() { }

        public string SearchNum(int num)
        {
            string sql = "SELECT * FROM Invoices WHERE InvoiceNum = " + num;
            return sql;
        }

        public string SearchDate(DateTime date)
        {
            string sql = "SELECT * FROM Invoices WHERE InvoiceDate = " + date.ToString();
            return sql;
        }

        public string SearchCharges(int charges) 
        {
            string sql = "SELECT * FROM Invoices WHERE Charges= " + charges;
            return sql;
        }

        public string SearchNumDate(int num, DateTime date)
        {
            string sql = "SELECT * FROM Invoices WHERE InvoiceNum=" + num+ " AND Date = " + date.ToString();
            return sql;
        }

        public string SearchNumCharges(int num, int charges)
        {
            string sql = "SELECT * FROM Invoices WHERE InvoiceNum= " + num+ " AND Charges = "+ charges;
            return sql;
        }

        public string SearchDateCharges(DateTime date, double[] charges)
        {
            string sql = "SELECT * FROM Invoices WHERE Date = " + date.ToString() + " AND Charges = " + charges;
            return sql;
        }

        public string SearchNumDateCharges(int num, DateTime date, int charges)
        {
            string sql = "SELECT * FROM Invoices WHERE InvoiceNum = " + num + " AND Date = " + date.ToString() + " AND Charges =" + charges;
            return sql;
        }



    }
}
