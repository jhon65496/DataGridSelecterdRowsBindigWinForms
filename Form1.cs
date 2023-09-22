using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridSelecterdRowsBindigWinForms
{
    public partial class Form1 : Form
    {
        private Customers customers;

        public Customers Customers
        {
            get { return customers; }
            set { customers = value; }
        }


        private Customer currentCustomer;

        public Customer CurrentCustomer
        {
            get { return currentCustomer; }
            set { currentCustomer = value; Debug.Print(currentCustomer?.CustomerName); }
        }

        private BindingManagerBase customersCurrencyManager;


        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customers = new Customers();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = customers;

            label1.DataBindings.Add("Text", customers, "CustomerName");

            customersCurrencyManager = this.BindingContext[customers];
            customersCurrencyManager.CurrentChanged += GetCurrentCustomer;
        }


        private void GetCurrentCustomer(object sender, EventArgs e)
        {
            CurrentCustomer = customersCurrencyManager?.Current as Customer;
        }



        private void btCreate_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer()
            {
                CustomerID = 5,
                CustomerName = "CustomerName-5"
            };

            customers.Create(cs);
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            // Customers = customers.Read(); 

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer()
            {
                CustomerID = 5,
                CustomerName = "CustomerName-5-Modifi"
            };

            customers.Update(cs);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer()
            {
                CustomerID = 5,
                CustomerName = "CustomerName-5-Modifi"
            };

            customers.Delete(cs);
        }
    }
}
