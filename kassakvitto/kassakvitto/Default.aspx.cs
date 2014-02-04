using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kassakvitto.Model; 

namespace kassakvitto
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Summa.Focus();
        }

        protected void Sendbutton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    var sum = double.Parse(Summa.Text);

                    var test = new Receipt(sum);

                    test.Calculate(sum); 

                    Outputkvitto.Visible = true;
                    Totalt.Text = String.Format("{0,10}{1,10:c}", "Totalt: ", test.Subtotal);
                    Rabattsats.Text = String.Format("{0,10}{1,10}%", "Rabattsats: ", test.DiscountRate * 100);
                    Rabatt.Text += String.Format("{0,10}{1,10:c}", "Rabatt: ", test.MoneyOff);
                    Slutsumma.Text += String.Format("{0,10}{1,10:c}", "Att betala: ", (sum - test.MoneyOff));

                }

                catch(Exception ex)
                {
                    var error = new CustomValidator
                    {
                        IsValid = false,
                        ErrorMessage = ex.Message 
                    };
                }
            }
        }
    }
}