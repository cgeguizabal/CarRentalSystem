using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbCustomerName.Text) || string.IsNullOrWhiteSpace(cbTypeOfBox.Text) || 
                string.IsNullOrWhiteSpace(dtpDateReturned.Text) || string.IsNullOrWhiteSpace(dtpDateRented.Text) )
            {
                MessageBox.Show("Please fill all required fills.");
                return;
            }

            MessageBox.Show($"Your order is :\n" +
                $"Day of retal: {dtpDateRented.Text}\n" +
                $"Day of return: {dtpDateReturned.Text}\n" +
                $"Type of Car: {cbTypeOfBox.Text}\n" +
                $"Thank you {tbCustomerName.Text} for Renting a Car with us");
        }
    }
}
