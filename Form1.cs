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

        private List<Customer> _customers;

        public List<Customer> CustomersProp
        {
            get { return _customers; }
            set 
            {
                _customers = value;             
            }
        }




        public Form1()
        {
            InitializeComponent();

            Customers customers = new Customers();
            CustomersProp = customers;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // dataGridView1.DataBindings.Add("DataSource", this, "customers");
             dataGridView1.DataBindings.Add("DataSource", this, "CustomersProp");
                
            // nameLabel.DataBindings.Add(new Binding("Text", bindingSource, "Name"));
            // label1.DataBindings.Add(new Binding("Text", CustomersProp, "Customer.CustomerName"));

            BindingManagerBase myBindingManagerBase = this.BindingContext[customers];

            // Adds delegates to the CurrentChanged and PositionChanged events.
            myBindingManagerBase.PositionChanged +=
            new EventHandler(BindingManagerBase_PositionChanged);
            myBindingManagerBase.CurrentChanged +=
            new EventHandler(BindingManagerBase_CurrentChanged);

        }

        private void BindingManagerBase_CurrentChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException();

            var Cur = ((BindingManagerBase)sender).Current; // DataRowView
            var Cus = (Customer)Cur; // DataRowView
            Debug.WriteLine("BindingManagerBase_CurrentChanged: " + ((BindingManagerBase)sender).Current);
        }

        private void BindingManagerBase_PositionChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            // Prints the new Position of the BindingManagerBase.
            Debug.WriteLine("Position Changed: " + ((BindingManagerBase)sender).Position);
            // var Pos = source[((BindingManagerBase)sender).Position]; // DataRowView
            var Cur = ((BindingManagerBase)sender).Current; // DataRowView
            var Cur2 = ((BindingManagerBase)sender).Current; // DataRowView
            var Cus = (Customer)Cur2;
            // var Cur = ((BindingManagerBase)sender).Current; // DataRowView

            // var row = (DataRow)Cur;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
