using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing; 

namespace q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            private Font verdana10Font;  
            private StreamReader reader; 
            string filename = richTextBox1.Text.ToString();
            //Create a StreamReader object  
            reader = new StreamReader(filename);
            //Create a Verdana font with size 10  
            verdana10Font = new Font("Verdana", 10);
            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();
            //Add PrintPage event handler  
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            //Call Print Method  
            pd.Print();
            //Close the reader  
            if (reader != null)
                reader.Close();
            //Get the Graphics object  
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //Read margins from PrintPageEventArgs  
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            string line = null;
            //Calculate the lines per page on the basis of the height of the page and the height of the font  
            linesPerPage = ppeArgs.MarginBounds.Height / verdana10Font.GetHeight(g);
            //Now read lines one by one, using StreamReader  
            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                //Calculate the starting position  
                yPos = topMargin + (count * verdana10Font.GetHeight(g));
                //Draw text  
                g.DrawString(line, verdana10Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                //Move to next line  
                count++;
            }
            //If PrintPageEventArgs has more pages to print  
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }  
        }

    }
}
    
    

