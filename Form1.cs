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
            
            // LoadData
            CustomersData customersData = new CustomersData();
            Customers = customersData.Customers;

            // Controls            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataBindings.Add("DataSource", this, nameof(Customers));
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;


        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
                        
            if (dgv.SelectedRows.Count > 0)
                Debug.WriteLine(dgv.SelectedRows[0].Cells[1].Value.ToString());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
