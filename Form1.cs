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

            CustomersDataTable customersDataTable = new CustomersDataTable();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = customersDataTable.table;

            DataSet ds = new DataSet();
            ds.Tables.Add(customersDataTable.table);

            BindingManagerBase myBindingManagerBase = this.BindingContext[customersDataTable.table];

            // Adds delegates to the CurrentChanged and PositionChanged events.
            myBindingManagerBase.PositionChanged +=
            new EventHandler(BindingManagerBase_PositionChanged);
            myBindingManagerBase.CurrentChanged +=
            new EventHandler(BindingManagerBase_CurrentChanged);

        }

        private void BindingManagerBase_CurrentChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            

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
