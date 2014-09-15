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
using MySql.Data.MySqlClient;


namespace TextReader
{
    public partial class Form1 : Form
    {
        string filePath = "";
        public Form1()
        {
            InitializeComponent();
            fillUserComboBox();
            
        }

        void fillUserComboBox()
        {
            string constring = "datasource=localhost; port=3306; username=root; password=";
            string query = " select DISTINCT ReviewerId from inb302.reviews ORDER BY ReviewerId;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader dataReader;

            try
            {
                conDataBase.Open();
                dataReader = cmdDataBase.ExecuteReader();
                while (dataReader.Read())
                {
                    string reviewerId = dataReader.GetString("ReviewerId");
                    userComboB.Items.Add(reviewerId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillTableComboBox()
        {

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



        private void textFileGenButton_Click(object sender, EventArgs e)
        {

        }

        private void minRevTableGen_Click(object sender, EventArgs e)
        {

        }

        private void maxRevTableGen_Click(object sender, EventArgs e)
        {

        }

        private void minRatTableGen_Click(object sender, EventArgs e)
        {

        }

        private void maxRatTableGen_Click(object sender, EventArgs e)
        {

        }

        private void voteGoodTableGen_Click(object sender, EventArgs e)
        {

        }

        private void unhelpfulVoteTableGen_Click(object sender, EventArgs e)
        {

        }

        private void noRatingGen_Click(object sender, EventArgs e)
        {

        }

        private void tableGen_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=";
            string query = " select * from inb302.items;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                tableDisplay.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void userComboB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





    }
}
