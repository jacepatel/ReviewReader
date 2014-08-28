using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReviewReader;

namespace TextReader
{
    public partial class Form1 : Form
    {
        string filePath = "";
        public Form1()
        {
            InitializeComponent();
            
        }


        private void fileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Open Amazon Reviews Txt File";

            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fDialog.FileName.ToString();
                MessageBox.Show(fDialog.FileName.ToString());
            }

        }

        private void loadDb_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                MessageBox.Show("This may take up to 30 minutes, will be faster soon");
                Program.ReadFile(filePath);
            }
            else
            {
                MessageBox.Show("Please Select a file first");
            }
        }
    }
}
