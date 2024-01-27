using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace q2
{
    public partial class Form4 : Form
    {
        int amount;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (amount>3000)
            {
                MessageBox.Show("Not enough balance");
            }
            else
            {
                MessageBox.Show("Money Transfered\nThankyou for using our services");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            amount = Int32.Parse(textBox2.Text);
        }

      
    }
}
