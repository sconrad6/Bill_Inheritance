using System;
namespace Bill_Inheritance
{
    public class Bill
    {
        public double Subtotal { get; set; }
        public double TaxRate { get; set; }

        public Bill()
        {

        }

        public Bill(double subtotal, double taxRate)
        {
            Subtotal = subtotal;
            TaxRate = taxRate;
        }

        public virtual double CalcTotal()
        {
            return Subtotal * (1 + TaxRate);
        }
      
    }
}
