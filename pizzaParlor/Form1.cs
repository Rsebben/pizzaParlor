using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaParlor
{
    public partial class pizzaParlor : Form
    {
        double basePrice = 7.00;
        double toppingPrice = 1.25;
        double desiredAmount = 0;
        double totalPrice = 0;
        
        public pizzaParlor()
        {
            InitializeComponent();
        }

        private void pizzaParlor_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //get inputs:  total = Convert.ToDouble(totalInput.Text);
            desiredAmount = Convert.ToDouble(toppingAmount.Text);

            //calc totalPrice
            totalPrice = (basePrice + toppingPrice * desiredAmount);

            //output the totalPice
            amount.Text = $"Your total is ${totalPrice}";
        }
    }
}
