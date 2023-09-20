using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridSelecterdRowsBindigWinForms
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {

        private BindingList<Customer> customers; 

        public BindingList<Customer> Customers
        {
            get => customers;
            set
            {
                customers = value;
                OnPropertyChanged();
            }
        }

        public Form1()
        {
            InitializeComponent();

            CustomersData customersData = new CustomersData();
            Customers = customersData.Customers;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataBindings.Add("DataSource", this, nameof(Customers));

            BindingManagerBase myBindingManagerBase;

            //// Adds delegates to the CurrentChanged and PositionChanged events.
            //myBindingManagerBase.PositionChanged +=
            //new EventHandler(BindingManagerBase_PositionChanged);
            //myBindingManagerBase.CurrentChanged +=
            //new EventHandler(BindingManagerBase_CurrentChanged);
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
