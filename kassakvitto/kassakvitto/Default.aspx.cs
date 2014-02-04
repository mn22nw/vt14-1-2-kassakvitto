using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                var sum = double.Parse(Summa.Text);
               
                Model.Receipt.Calculate(sum);

                /*
              
                var rabattsats = 0.0;

                if (sum > 499 && sum < 1000)
                {
                    rabattsats = 0.05;
                }

                if (sum >= 999 && sum < 5000)
                {
                    rabattsats = 0.1;
                }

                if (sum >= 5000)
                {
                    rabattsats = 0.1;
                }

                var rabatt = Convert.ToInt32(sum * rabattsats);

                Totalt.Text = String.Format("{0,10}{1,10:c}", "Totalt:", sum);
                Rabatt.Text += String.Format("{0,10}{1,10}%", "Rabatt:", rabatt);
                Slutsumma.Text += String.Format("{0,10}{1,10:c}", "Att betala:", (sum - rabatt)); */
            }
        }
    }
}