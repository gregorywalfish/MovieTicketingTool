using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Theatre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Assign variables
            double regularprice = Convert.ToDouble(RegularPriceTxt.Text);
            double numadults = Convert.ToDouble(NumberAdultsTxt.Text);
            double numkids = Convert.ToDouble(NumberKidsTxt.Text);
            double numseniors = Convert.ToDouble(NumberSeniorsTxt.Text);


            // Adults Pricing:
            double adults = regularprice * numadults;
            AdultsPriceLbl.Text = adults.ToString();

            // Kids Pricing:
            double kids = regularprice * numkids * 0.75;
            KidsPriceLbl.Text = kids.ToString();

            //Seniors Pricing:
            double seniors = regularprice * numseniors * 0.5;
            SeniorsPriceLbl.Text = seniors.ToString();

            //Grand total price:
            double totalprice = seniors + kids + adults;
            GrandTotalPriceLbl.Text = totalprice.ToString();

            //Group discount if applicable:
            string GroupDiscountLblStr = GroupDiscountLbl.Text;
            if ((numadults + numkids + numseniors) > 0) ;
            {
                GroupDiscountLbl.Text = "0%";
            }
            if ((numadults + numkids + numseniors) >= 10) ;
            {
                GroupDiscountLbl.Text= "10%";
            }

            if ((numadults + numkids + numseniors) >= 20) ;
            {
                GroupDiscountLbl.Text = "20%";
            }
            if ((numadults + numkids + numseniors) >= 30) ;
            {
                GroupDiscountLbl.Text = "30%";
            }
           
            //Apply group discount:
            double discountedprice;
            if ((numadults + numkids + numseniors) > 0) ;
            {
                discountedprice = totalprice;
            }
            if ((numadults + numkids + numseniors) >= 10) ;
            {
                discountedprice = totalprice * 0.9;
            }

            if ((numadults + numkids + numseniors) >= 20) ;
            {
                discountedprice = totalprice * 0.8;
            }
            if ((numadults + numkids + numseniors) >= 30) ;
            {
                discountedprice = totalprice * 0.7;
            }
            TotalPriceAfterDiscountLbl.Text = discountedprice.ToString();
        }
    }
}
