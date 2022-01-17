using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformOOP
{
    public class EditDelete : Tax
    {
        public void DoTransaction()
        {
            Console.Clear();
            if (TaxList.Count == 0)
            {
                Console.WriteLine("No Transaction...");
               
            }
            else
            {
                for (int i = 0; i < TaxList.Count; i++)
                {

                    Console.WriteLine("----Transaction Invoice----");
                    Console.WriteLine($"Transaction ID: {TaxList[i].Transaction_id}");
                    Console.WriteLine($"From Number Card: {TaxList[i].Number_card}");
                    Console.WriteLine($"Name: {TaxList[i].Name_card}");
                    Console.WriteLine($"Final Payment: {TaxList[i].Final}");
                    Console.Write($"Voucher Code: ");
                    Random();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                }
               
            }
        }
        public void Random()
        {
            //random
            Random random = new Random();
            int[] rand = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            for (int i = 0; i <= rand.Length; i++)
            {
                Code = random.Next(0, rand.Length);
                Console.Write(Code);
            }
        }
        public void Delete()
        {
            Console.Clear();
            DoTransaction();
            Console.WriteLine(" ");
            Console.Write("Input Transaction ID will be delete: ");
            Transaction_id = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i < TaxList.Count; i++)
            {
                
                TaxList.RemoveAt(i);
                Console.WriteLine("Transaction with that ID success deleted... ");
            }
        }
        public void Edit()
        {
            Console.Clear();
            DoTransaction();
            int a = 0;
            Console.Write("Input Transaction ID will be edit: ");
            Transaction_id = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < TaxList.Count; i++)
            {
                if(Transaction_id == TaxList[i].Transaction_id)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Send To Number Card: 123456789 and Name Card: Admin Platform");
                    Console.Write($"Transaction ID: {Transaction_id}");
                    Console.WriteLine(" ");
                    Console.Write("From Number Card: ");
                    TaxList[i].Number_card = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    TaxList[i].Name_card = Convert.ToString(Console.ReadLine());
                    Console.Write("Final Payment: ");
                    TaxList[i].Final = Convert.ToDouble(Console.ReadLine());
                }
                
            }
            
        }
          

    }
}
