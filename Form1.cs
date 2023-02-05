using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnectionPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDataSet.TravelRequests' table. You can move, or remove it, as needed.
            this.travelRequestsTableAdapter.Fill(this.travelDataSet.TravelRequests);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //validates and saves the changes to the data set
            try
            {
                this.Validate();
                this.travelRequestsBindingSource.EndEdit();
                this.travelRequestsTableAdapter.Update(this.travelDataSet);
            }
            catch (Exception ex)
            {
                //show error message
                MessageBox.Show(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //search database for any field
            this.travelRequestsTableAdapter.FillByname(this.travelDataSet.TravelRequests, "%" + searchTextBox.Text + "%", "%" +
                searchTextBox.Text + "%", "%" + searchTextBox.Text + "%", "%" + searchTextBox.Text + "%", "%" + 
                searchTextBox.Text + "%");
        }

        private void fillBynameToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.travelRequestsTableAdapter.FillByname(this.travelDataSet.TravelRequests, lastNameToolStripTextBox.Text, firstNameToolStripTextBox.Text, purposeforTravelToolStripTextBox.Text, locationToolStripTextBox.Text, tripDatesToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }
    }
}
