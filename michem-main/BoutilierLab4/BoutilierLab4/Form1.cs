using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BoutilierLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Name: Michelle Boutilier
        * Date: November 17 2022
        * This program allows users to book a trip and calculates the price.*/

        /// <summary>
        /// function for Reset
        /// </summary>
        private void ResetTrip()
        {
            grpTripInformation.Visible = false;
            txtPeople.Text = "";
            radCuba.Checked = true;
            txtPeople.Focus();
            lblPrice.Text = "";
            radCreditCard.Checked = true;
        }
        /// <summary>
        /// function for SetFlight
        /// </summary>
        private void SetFlight()
        {
            (radFlorida.Checked)

                chkFlightIncluded.Checked = false;
            else
                chkFlightIncluded.Checked = true;
        }
        /// <summary>
        /// function for Display messages
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        private void DisplayMsg(string message, string title)
        {
            MessageBox.Show(message, title);
        }
        /// <summary>
        /// selecting the destination and validating if flight is included
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radFlorida_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }
        /// <summary>
        /// selecting the destination and validating if flight is included
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radCuba_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }
        /// <summary>
        /// selecting the destination and validating if flight is included
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radMexico_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }
        /// <summary>
        /// Loading the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTrip();
        }

        /// <summary>
        /// Clicking the reset button Resets the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTrip();
        }
        /// <summary>
        ///  Validating the input and calculating a price. And displaying the information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBook_Click(object sender, EventArgs e)
        {
            int people; bool validNumber;
            const decimal MEXICO_COST = 2300.79m;
            const decimal CUBA_FLORIDA_COST = 2150.50m;
            const decimal DISCOUNT = .10m;
            decimal totalPrice = 0;
            string country = "";
            validNumber = int.TryParse(txtPeople.Text, out people);
            string flight = "";
            string discount = "";
            // checking to see if the text entered for number of people is valid
            if (!validNumber)
            {
                txtPeople.Focus();
                txtPeople.SelectAll();
                DisplayMsg("People must be a whole number", "Input Error");
            }
            else if (people > 10 || people < 1)
            {
                txtPeople.Focus();
                txtPeople.SelectAll();
                DisplayMsg("People must be between 1-10", "Input Error");
            }
            else
            {
                if (radCuba.Checked)
                {
                    totalPrice = CUBA_FLORIDA_COST * people;
                    country = radCuba.Text;
                    flight = "Flight Included\n";
                }
                else if (radFlorida.Checked)
                {
                    totalPrice = CUBA_FLORIDA_COST * people;
                    country = radFlorida.Text;
                    flight = "";
                }
                if (radMexico.Checked)
                {
                    totalPrice = MEXICO_COST * people;
                    country = radMexico.Text;
                    flight = "Flight Included\n";

                }
                if (radCash.Checked)
                {
                    totalPrice = (totalPrice) + (totalPrice * DISCOUNT);
                    discount = "Cash Discount Applied\n";
                }
                else
                    discount = "";

                lblPrice.Text = totalPrice.ToString("c");
                grpTripInformation.Visible = true;
                lblTripInformation.Text = "Booked by Michelle Boutilier\n\nPeople:" + people.ToString("D2") + "\nLocation:" + country.ToUpper() + "\n"
                  + (flight) + (discount) + "Price:" + (lblPrice.Text);
                grpBook.Enabled = false;
               switch (people)
                {
                    case 1:
                    case 3:
                        DisplayMsg("Special when Booking single or triple.\n" +
                            "BOGO Special- Call 555-1212 to receive another person free!",
                            "Limited Time Offer"); break;
                    default: break;
                }
            }
        }

        /// <summary>
        /// Confirming the booking and reseting the form for use.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DisplayMsg(Trip booked and paid\nPrice:  + (lblPrice.Text), "Confirmation Email Sent");
            grpBook.Enabled = true;
            ResetTrip();
        }

    }
}
