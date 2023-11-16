using Assignment_6;
using GroupPrject.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GroupPrject.Items
{
    internal class ItemsLogic
    {
        //GetAllItems returns List<clsItems>
        //AddItem(clsItem)
        //EditItem(clsItem OldItem, clsItem NewItem)
        //DeleteItem(clsItem ItemToDelete)
        //IsItemOnInvoice(clsItem)

        /// <summary>
        /// Returns all items from the Item table in a list of clsItems to display in a datagrid
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// 
        public List<clsItem> GetAllItems()
        {
            try
            {
                List<clsItem> Items = new List<clsItem>();
                int i = 0;
                DataSet ds = new DataSet();
                ds = DataAccess.ExecuteSQLStatement(ItemsSQL.GetItems(), ref i);

                DataTable ItemTable = ds.Tables[0];

                foreach (DataRow row in ItemTable.Rows)
                {
                    clsItem Item = new clsItem();
                    Item.ItemCode = row[0].ToString();
                    Item.ItemDesc = row[1].ToString();
                    Item.Cost = row[2].ToString();

                    Items.Add(Item);
                }
                return Items;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
