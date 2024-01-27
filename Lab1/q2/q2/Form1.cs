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
    public partial class Form1 : Form
    {
        String name;
        String gender;
        String reg;
        String roll;
        String date;
        String hobby;
        String Class;
        String Branch;
        String Sem;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
                {
                    gender="Female";
                }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                hobby = "Public Speaking";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
                {
                    gender="Male";
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name + "\nRegisteration number:" + reg + "\nRoll number:" + roll + "\nGender:" + gender + "\nClass:" + Class + "\nSemester:" + Sem + "\nBranch:" + Branch + "\nHobby:" + hobby + "\nDOB:" + date);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           date =monthCalendar1.SelectionRange.Start.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            reg = textBox4.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            roll = textBox2.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            hobby = "Sports";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
                hobby = "Music";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
                hobby = "Coding";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                hobby = "Gym";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
                hobby = "Singing";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Branch = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sem = comboBox3.Text;
        }
    }
}
