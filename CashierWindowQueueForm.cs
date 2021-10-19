using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace BasicQueingSystem
{
    public partial class CashierWindowQueueForm : Form
    {
        CustomerView customerView;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            customerView = new CustomerView();
            customerView.Show();
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.Columns[0].Width = listView1.Width - 4;
            try
            {
                customerView.changeServing(CashierClass.CashierQueue.Peek());
            }
            catch
            {
                customerView.changeServing("");
            }

            foreach (Object obj in CashierList)
            {
                listView1.Items.Add(obj.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String popped;
            CashierClass.CashierQueue.TryDequeue(out popped);

            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
