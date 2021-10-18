using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueingSystem
{
    public partial class QueingForm : Form
    {
        private CashierClass cashier;
        public QueingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = label2.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
