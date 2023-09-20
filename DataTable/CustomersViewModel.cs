using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataGridSelecterdRowsBindigWinForms
{
    class Customers2
    {
        private List<Customer> customers;

        public List<Customer> CustomersProp
        {
            get { return customers; }
            set { customers = value; }
        }


        public Customers2()
        {
            LoadData();            
        }

        private void LoadData()
        {
            CustomersProp = new List<Customer>
            {
                new Customer() { CustomerID = 1, CustomerName = "CustomerName-1" },
                new Customer() { CustomerID = 2, CustomerName = "CustomerName-2" },
                new Customer() { CustomerID = 3, CustomerName = "CustomerName-3" }
            };
        }


    }
}
