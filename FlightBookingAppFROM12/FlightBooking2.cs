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
    public partial class FlightBooking2 : Form
    {
        public FlightBooking2()
        {
            InitializeComponent();
        }

        

        private void FlightBooking2_Load(object sender, EventArgs e)
        {
            if(Form1.Passport)
            {
                lbl_CHANGEdocumentNO.Text = "Passport No:";
                lbl_CHANGEdocumentEXPIRYdate.Text = "Passport expiry date:";
            }
            if (Form1.IDcard)
            {
                lbl_CHANGEdocumentNO.Text = "ID card No:";
                lbl_CHANGEdocumentEXPIRYdate.Text = "ID card expiry date:";
            }
            lbl_FName.Text = Form1.fName + "  " + Form1.lName;
            lbl_Dcity.Text = Form1.TO;
            lbl_desCITY.Text = Form1.FROM;
            lbl_Tdate.Text = Form1.STARTtripDATE +"  to  "+ Form1.ENDtripDATE;
            lbl_Dno.Text = Form1.DocumentNO;
            lbl_DED.Text = Form1.ExpiryDate;
            lbl_BWeight.Text = Form1.WeightBaggage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
