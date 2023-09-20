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
        public Form1()
        {
            InitializeComponent();

            CustomersViewModel customersVM = new CustomersViewModel();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;            
            // dataGridView1.DataBindings.Add("DataSource", customers2, "CustomersProp");
            dataGridView1.DataSource = customersVM.CustomersProp;            
            label1.DataBindings.Add("Text",
                                customersVM.CustomersProp,
                                "CustomerName");
            //label1.DataBindings.Add("Text",
            //                    customers2.CustomersProp,
            //                    "CustomerName",
            //                    false,
            //                    DataSourceUpdateMode.OnPropertyChanged);

        }
    }
}
