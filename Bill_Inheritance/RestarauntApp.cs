using System;

namespace Bill_Inheritance
{
    class RestarauntApp
    {
        static void Main(string[] args)
        {

            Bill bill = new Bill(15.80, 0.06);
            Pay(bill);
            Bill tippedBill = new TippableBill(2.00, 8.50, 0.06);
            Pay(tippedBill);
            
        }

        public static void Pay(Bill bill)
        {
            Console.WriteLine($"${bill.CalcTotal()}");
            
        }

    }
}
