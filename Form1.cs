using System;
using System.Collections.Generic;
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

        private DataGridViewSelectedRowCollection selectedRows;

        public DataGridViewSelectedRowCollection SelectedRows
        {
            get { return selectedRows; }
            set 
            { 
                selectedRows = value;

                
                if (value.Count == 0)                
                    return;

                Debug.WriteLine("SelectedRows : " + value.Count.ToString());                
                label1.Text = selectedRows[0].Cells[1].Value.ToString();
            }
        }


        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomersDataTable customersDataTable = new CustomersDataTable();
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = customersDataTable.table;
            
            SelectedRows = dataGridView1.SelectedRows;
        }
    }
}
