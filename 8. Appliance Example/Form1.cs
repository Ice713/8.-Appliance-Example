using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.Appliance_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WashingMachine myWasher  = new WashingMachine();

            string statusMessage = myWasher.TurnOn();

            statusMessage += "\n" + myWasher.Wash();

            MessageBox.Show(statusMessage, "Appliance Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
