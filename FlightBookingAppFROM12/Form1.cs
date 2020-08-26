using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingAppFROM12
{
    public partial class Form1 : Form
    {
        public static Boolean Passport, IDcard;
        public static string TO, FROM, STARTtripDATE, ENDtripDATE, fName, lName, DocumentNO, IssuDate, ExpiryDate,WeightBaggage;

        
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Book_Click(object sender, EventArgs e)
        {
            TO = txt_TO.Text;
            FROM = txt_FROM.Text;
            
            STARTtripDATE = monthCalendar1.SelectionStart.ToString("dd MMM yyyy");
            ENDtripDATE = monthCalendar1.SelectionEnd.ToString("dd MMM yyyy");
            
            fName = txt_FirstName.Text;
            lName = txt_LastName.Text;
            DocumentNO = txt_DocumentsNo.Text;

            IssuDate=dateTimePicker1.Value.ToString("dd MMM yyyy");
            ExpiryDate=dateTimePicker2.Value.ToString("dd MMM yyyy");

            WeightBaggage = numericUpDown1.Value.ToString();
            this.Hide();
            FlightBooking2 FB = new FlightBooking2();
            FB.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.ShowToday = true;
            numericUpDown1.Increment = 5;
            numericUpDown1.ReadOnly = true;


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txt_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_LastName_Click(object sender, EventArgs e)
        {

        }

        private void rdb_IDcard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_IDcard.Checked)
            {
                lbl_DocumentNO.Text = "ID Card No:";
                lbl_documentISSUEdate.Text = "ID Card Issue Date:";
                lbl_documentEXPIRYdate.Text = "ID Card Expiry Date:";
              IDcard  = true;
            }
            else
            {
                IDcard = false;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }

        private void rdb_Passport_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_Passport.Checked)
            {
                lbl_DocumentNO.Text = "Passport No:";
                lbl_documentISSUEdate.Text = "Passport Issue Date:";
                lbl_documentEXPIRYdate.Text = "Passport Expiry Date:";
                Passport = true;
            }
            else
            {
                Passport = false;
            }
        }
    }
}
