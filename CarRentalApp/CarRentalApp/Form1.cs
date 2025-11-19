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

            /*
            string curtomerName = tbCustomerName.Text;
            string dateRented = dtpDateRented.Value.ToString();
            string dateReturned = dtpDateReturned.Value.ToString();
            var typeOfCar = cbTypeOfBox.SelectedItem.ToString();
            */

            try {
                double cost = Convert.ToDouble(tbCost.Text);

                DateTime dateRented1 = dtpDateRented.Value;
                DateTime dateReturned1 = dtpDateReturned.Value;
                bool isValid = true;
                var errorMessage = "";

                if (dateReturned1 < dateRented1)
                {
                    isValid = false;
                    errorMessage += "Return date cannot be earlier than rented date.\n";
                    //MessageBox.Show("Return date cannot be earlier than rented date.");
                    //return;
                }

                if (string.IsNullOrWhiteSpace(tbCustomerName.Text) || string.IsNullOrWhiteSpace(cbTypeOfBox.Text) ||
                    string.IsNullOrWhiteSpace(dtpDateReturned.Text) || string.IsNullOrWhiteSpace(dtpDateRented.Text))
                {
                    isValid = false;
                    errorMessage += "Please fill all required fills.\n";
                    //MessageBox.Show("Please fill all required fills.");
                    //return;
                }

                if(isValid)
                {
                    MessageBox.Show($"Your order is :\n" +
                   $"Date Rented: {dtpDateRented.Text}\n" +
                   $"Day of return: {dtpDateReturned.Text}\n" +
                   $"Type of Car: {cbTypeOfBox.Text}\n" +
                   $"Cost: ${cost}\n" +
               $"Thank you {tbCustomerName.Text} for Renting a Car with us");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }

               
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return;
                //Throw;
            }
        }  
    }
}
