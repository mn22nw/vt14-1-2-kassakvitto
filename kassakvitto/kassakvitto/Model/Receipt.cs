using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kassakvitto.Model
{
    public class Receipt
    {
        private double _subtotal;

        public double DiscountRate { get; set; }
        public double MoneyOff { get; set; }
        public double Subtotal {
            get { return _subtotal; }
            set {
                if (value <= 0)
                    {
                        throw new ArgumentOutOfRangeException(); 
                    }
                _subtotal = value; }
        
        }
        public double Total { get; set; }

 
        public void Calculate(double subtotal)
        {            
             Subtotal = subtotal;
   
            if (Subtotal > 499 && Subtotal < 1000)
                 {
                     DiscountRate = 0.05;
                 }

             if (Subtotal > 999 && Subtotal < 5000)
                 {
                     DiscountRate = 0.1;
                 }

             if (Subtotal >= 5000)
                 {
                     DiscountRate = 0.1;
                 }

             var rabatt = Subtotal * DiscountRate;
             MoneyOff = rabatt;
 
        }

        public Receipt(double subtotal)
        {
            subtotal = _subtotal; 
        }
    }
}