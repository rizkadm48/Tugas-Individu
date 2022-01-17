using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformOOP
{
    public class Tax 
    {
        public int Month_year { get; set; }
        public double Price_tax { get; set; }
        public double Total { get; set; }
        public double Final { get; set; }
        public int Card { get; set; }
        public int Number_card { get; set; }
        public string Name_card { get; set; }
        public int Code { get; set; }
        public int Transaction_id { get; set; }

        public static List<Tax> TaxList { get; set; } = new List<Tax>();
        

        public int Tax_MonthYear(double price)
        {
            Console.Write("How long: ");
            Month_year = Convert.ToInt32(Console.ReadLine());
            Price_tax = price * 0.1;
            Total = Month_year * price + Price_tax;
            Console.WriteLine(" ");
            Console.WriteLine($"Total + Tax 10%: IDR {Total}.00");

            Console.WriteLine("Admin Payment: IDR 10000.00");
            Final = Total + 10000;
            Console.WriteLine($"Final Payment: IDR {Final}.00");

            return 0;
        }
        
        public int Tax_MonthYear(int price)
        {
            Console.Write("How long: ");
            Month_year = Convert.ToInt32(Console.ReadLine());
            Price_tax = price * 0.1;
            Total = Month_year * price + Price_tax;
            Console.WriteLine(" ");
            Console.WriteLine($"Total + Tax 10%: IDR {Total}.00");

            Console.WriteLine("Admin Payment: IDR 10000.00");
            Final = Total + 10000;
            Console.WriteLine($"Final Payment: IDR {Final}.00");

            return 0;
        }
        public void TransactionID()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Send To Number Card: 123456789 and Name Card: Admin Platform");
            Console.Write("Transaction ID: ");
            Transaction_id = Convert.ToInt32(Console.ReadLine());
        }
        public void NumberCard()
        {
            Console.Write("From Number Card: ");
            Number_card = Convert.ToInt32(Console.ReadLine());
        }
        public void NameBuyer()
        {
            Console.Write("Name: ");
            Name_card = Convert.ToString(Console.ReadLine());
        }
        public void FinalPayment()
        {
            Console.Write("Final Payment: ");
            Final = Convert.ToDouble(Console.ReadLine());
        }
        public void AddTransaction()
        {
            Tax taxdata = new Tax();
            taxdata.TransactionID();
            taxdata.NumberCard();
            taxdata.NameBuyer();
            taxdata.FinalPayment();

            TaxList.Add(taxdata);
        }
        public void PaymentMethode()
        {
            List<String> app = new List<String>();
            app.Add("1. Debit Card");
            app.Add("2. Credit Card");
            app.Add("3. VISA");
            app.Add("4. ShopeePay");
            app.Add("5. GoPay");
            Console.WriteLine(" ");
            Console.WriteLine("===Payment===");

            foreach (string n in app)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(" ");
            Console.Write("Choose payment: ");
            Card = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            if (Card >= 1 && Card <= 5)
            {
                
                AddTransaction();
                
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
            Console.Clear();
        }



    }
}
