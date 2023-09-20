using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace DataGridSelecterdRowsBindigWinForms
{
    class CustomersData : INotifyPropertyChanged
    {
        private BindingList<Customer> customers;

        public BindingList<Customer> Customers
        {
            get => customers;
            set
            {
                customers = value;
                // OnPropertyChanged();
            }
        }

        public CustomersData()
        {
            
            Customers = new BindingList<Customer>();

            Customers.Add(new Customer { CustomerID = 1, CustomerName = "CustomerName-1" });
            Customers.Add(new Customer { CustomerID = 1, CustomerName = "CustomerName-1" });
            Customers.Add(new Customer { CustomerID = 1, CustomerName = "CustomerName-1" });
        }

        
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
