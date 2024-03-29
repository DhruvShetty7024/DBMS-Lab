﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }



        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void file1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontAndColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog(); fd.Font = richTextBox1.SelectionFont;
            fd.Color = richTextBox1.SelectionColor; if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font; richTextBox1.SelectionColor = fd.Color;
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fName = saveFileDialog1.FileName; StreamWriter sw = new StreamWriter(fName); sw.Write(richTextBox1.Text);
            sw.Flush();
            sw.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog(); dlg.Title = "Open";
            dlg.ShowDialog();
            string fName = dlg.FileName;
            StreamReader sr = new StreamReader(fName); 
            richTextBox1.Text = sr.ReadToEnd(); sr.Close();
        }

        private void colourToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDlg.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDlg.Color;
            }  
        }
        }
    }
}
