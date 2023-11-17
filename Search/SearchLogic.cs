using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPrject.Search
{
    internal class SearchLogic
    {

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
            // gets the query and will return it to the SearchWindow to be added to the Datagrid
            DataSet ds = new DataSet();

            // will check what values have been saved validly to call the right sql statement for query. 

            return ds;
        }
    }
}
