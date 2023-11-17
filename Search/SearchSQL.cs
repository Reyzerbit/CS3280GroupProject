using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace GroupPrject.Search
{
    internal class SearchSQL
    {
        public SearchSQL() { }

        public string SearchAll()
        {
            string sql = "SELECT * FROM Invoices";
            return sql;
        }

        public string SearchNum(int num)
        {
            string sql = "SELECT * FROM Invoices WHERE InvoiceNum = " + num;
            return sql;
        }

        public string SearchNumDate(int num, string date)
        {
           string sql = "SELECT * FROM Invoices WHERE InvoiceNum=" + num+ " AND InvoiceDate = #" + date+ "#"; 
           return sql;
        }

       public string SearchNumDateCharges(int num, string date, int charges)
        {
            string sql = "SELECT * FROM Invoices WHERE InvoiceNum = " + num + " AND InvoiceDate = #" + date + "# AND TotalCost = " + charges;
            return sql;
        }

        public string SearchCharges(int charges) 
        {
            string sql = "SELECT * FROM Invoices WHERE TotalCost = " + charges;
            return sql;
        }

        public string SearchDateCharges(string date, int charges)
        {
            string sql = "SELECT * FROM Invoices WHERE InvoiceDate = #" + date + "# AND TotalCost = " + charges;
            return sql;
        }

        public string SearchDate(string date)
        {
            string sql = "SELECT * FROM Invoices WHERE InvoiceDate = #" + date + "#";
            return sql;
        }

        public string SearchDistinctNum(int num)
        {
            string sql = "SELECT DISTINCT(InvoiceNum) From Invoices order by InvoiceNum";
            return sql;
        }

        public string SearchDistinctDate(string date)
        {
            string sql = "SELECT DISTINCT(InvoiceDate) From Invoices order by InvoiceDate";
            return sql;
        }

        public string SearchDistinctCost(int charges)
        {
            string sql = "SELECT DISTINCT(TotalCost) From Invoices order by TotalCost";
            return sql;
        }


 



    }
}
