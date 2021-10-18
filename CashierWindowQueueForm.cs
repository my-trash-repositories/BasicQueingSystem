using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BasicQueingSystem
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.Columns[0].Width = listView1.Width - 4;
            foreach (Object obj in CashierList)
            {
                listView1.Items.Add(obj.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
