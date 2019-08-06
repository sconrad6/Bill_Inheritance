using System;
namespace Bill_Inheritance
{
    public class TippableBill : Bill
    {
        public double Tip { get; set; }

        public TippableBill()
        {

        }

        public TippableBill(double tip, double subtotal, double taxRate)
        {
            Tip = tip;
            Subtotal = subtotal;
            TaxRate = taxRate;
        }

        public override double CalcTotal()
        {
            return Subtotal * (1 + TaxRate) + Tip;
        }

    }
}
