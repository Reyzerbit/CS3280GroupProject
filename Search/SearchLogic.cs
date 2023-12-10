using Assignment_6;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GroupPrject.Search
{
    internal class SearchLogic
    {
        /*
         * NOTES TO PROFESSOR
         * 
         * This is not actually part of our submission,
         * it is more of a work space where we talked about
         * how our application would operate, and where things will go.
         * 
         * Please disreegard all contents of this file.
         */

        // GroupPrject.Common.clsInvoice inv;
        private int ID;
        private string Date;
        private int charge;


        public SearchLogic(int num = -1, string date = "", int price = -1)
        {
            // takes values from the UI elements and sets the class variables
            ID = num;
            Date = date;
            charge = price;
        }

        public DataSet ReturnQuery(int num = -1, string date = "0-0-0000", int total = -1)
        {
            try
            {
                // gets the query and will return it to the SearchWindow to be added to the Datagrid
                DataSet ds = new DataSet();

                //if num was passed (not date or total)
                if (num != -1 && date == "0-0-0000" && total == -1)
                {
                    //SearchNum(int num)
                    string query = SearchSQL.SearchNum(num);
                    int iRet = 0;
                    ds = DataAccess.ExecuteSQLStatement(query, ref iRet);
                }

                //if num and date were passed (not total)
                else if (num != -1 && date != "0-0-0000" && total == -1)
                {
                    //SearchNumDate int num string date
                    string query = SearchSQL.SearchNumDate(num, date);
                    int iRet = 0;
                    ds = DataAccess.ExecuteSQLStatement(query, ref iRet);
                }
                // if num and total wer passed (not date)
                else if (num != -1 && total != -1 && date == "0-0-0000")
                {
                    //SearchNumCharges
                    string query = SearchSQL.SearchNumCharges(num, total);
                    int iRet = 0;
                    ds = DataAccess.ExecuteSQLStatement(query, ref iRet);
                }
                //if num, date, and total wer passed
                else if (num != -1 && total != -1 && date != "0-0-0000")
                {
                    //SearchNumDateCharges(num, date, total)
                    string query = SearchSQL.SearchNumDateCharges(num, date, total);
                    int iRet = 0;
                    ds = DataAccess.ExecuteSQLStatement(query, ref iRet);
                }
                //if date and total were passed (not num)
                else if (num == -1 && date != "0-0-0000" && total != -1)
                {
                    //SearchDateCharges
                    string query = SearchSQL.SearchDateCharges(date, total);
                    int iRet = 0;
                    ds = DataAccess.ExecuteSQLStatement(query, ref iRet);
                }
                //if date was passed (not num or total)
                else if (date != "0-0-0000" && total == -1 && num == -1)
                {
                    //SearchDate
                    string query = SearchSQL.SearchDate(date);
                    int iRet = 0;
                    ds = DataAccess.ExecuteSQLStatement(query, ref iRet);
                }
                //if total was passed (not num or date)
                else if (total != -1 && date == "0-0-0000" && num == -1)
                {
                    //SearchCharges
                    string query = SearchSQL.SearchCharges(total);
                    int iRet = 0;
                    ds = DataAccess.ExecuteSQLStatement(query, ref iRet);
                }

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        public DataSet ReturnAll()
        {
            try
            {
                // gets the query and will return it to the SearchWindow to be added to the Datagrid
                DataSet ds = new DataSet();
                string ret = SearchSQL.SearchAll();
                int iRet = 0;
                ds = DataAccess.ExecuteSQLStatement(ret, ref iRet);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        public DataSet GetInvoiceNumList()
        {
            DataSet ds;
            try
            {
                string query = SearchSQL.SearchDistinctNum();
                int iRet = 0;
                ds = DataAccess.ExecuteSQLStatement(query, ref iRet);
                return ds;
            }
            catch (Exception ex)
            { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        public DataSet GetDates()
        {
            DataSet ds;
            try
            {
                string query = SearchSQL.SearchDistinctDate();
                int iRet = 0;
                ds = DataAccess.ExecuteSQLStatement(query, ref iRet);
                return ds;
            }
            catch (Exception ex)
            { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }

        }


        public DataSet GetTotals()
        {
            DataSet ds;
            try
            {
                string query = SearchSQL.SearchDistinctCost();
                int iRet = 0;
                ds = DataAccess.ExecuteSQLStatement(query, ref iRet);
                return ds;

            }
            catch(Exception ex)
            { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        

    }

}
