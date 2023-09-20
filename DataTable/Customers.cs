using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataGridSelecterdRowsBindigWinForms
{
    class Customers : List<Customer>
    {
        public Customers()
        {
            LoadData();
        }

        private void LoadData()
        {
            this.Add(new Customer() { CustomerID = 1, CustomerName = "CustomerName-1" });
            this.Add(new Customer() { CustomerID = 2, CustomerName = "CustomerName-2" });
            this.Add(new Customer() { CustomerID = 3, CustomerName = "CustomerName-3" });
        }

    }
}
