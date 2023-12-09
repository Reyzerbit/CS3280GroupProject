using Assignment_6;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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
            charge= price;
        }

        public DataSet ReturnQuery()
        {
            try
            {
                // gets the query and will return it to the SearchWindow to be added to the Datagrid
                DataSet ds = new DataSet();
                string ret = SearchSQL.SearchAll();
                // will check what values have been saved validly to call the right sql statement for query. 

                return ds;
            }
            catch(Exception ex)
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
    }
}
