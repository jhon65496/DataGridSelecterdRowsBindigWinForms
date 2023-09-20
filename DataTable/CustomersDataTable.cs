using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataGridSelecterdRowsBindigWinForms
{
    class CustomersDataTable
    {
        public DataTable table;
        public CustomersDataTable()
        {
            // DataTable
              table = new DataTable("Customers");

            // Columns
            table.Columns.Add("CustomerID", typeof(int));
            table.Columns.Add("CustomerName");
            

            FillData();
        }

        public void FillData()
        {
            // table.Rows.Add(new Company(){1, "CompanyName-1"});
            table.Rows.Add(new object[] { 1, "CustomerName-1"});
            table.Rows.Add(new object[] { 2, "CustomerName-2"});
            table.Rows.Add(new object[] { 3, "CustomerName-3"});            
        }        

    }
}
