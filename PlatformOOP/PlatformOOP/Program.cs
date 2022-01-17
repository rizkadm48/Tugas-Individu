using System;

namespace PlatformOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tax tax = new Tax();
           
            EditDelete td = new EditDelete();
            int Package;

            PlatformMenu();

            void PlatformMenu()
            {
                Console.Clear();
                int Menu = 0;
                Console.WriteLine("==Menu Platform Premium==");
                Console.WriteLine("1. Google Drive");
                Console.WriteLine("2. LinkedIn");
                Console.WriteLine("3. WPS Office");
                Console.WriteLine("4. Tap Scanner");
                Console.WriteLine("5. Getcontact");
                Console.WriteLine("6. View Transaction");
                Console.WriteLine("7. Edit Transaction");
                Console.WriteLine("8. Delete Transaction");
                Console.WriteLine("9. Exit");
                Console.Write("Choose: ");
                Menu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                switch (Menu)
                {
                    case 1:
                        Gdrive();
                        break;
                    case 2:
                        Linkedin();
                        break;
                    case 3:
                        Wps();
                        break;
                    case 4:
                        Tapscanner();
                        break;
                    case 5:
                        Getcontact();
                        break;
                    case 6:
                        td.DoTransaction();
                        Console.WriteLine(" ");
                        Console.Write("Are you sure want to back in main menu? [yes|no] : ");
                        string exit = Convert.ToString(Console.ReadLine());
                        switch (exit)
                        {
                            case "yes":
                                PlatformMenu();
                                break;
                            case "no":
                                Environment.Exit(1);
                                break;
                        }
                        break;
                     case 7:
                        td.Edit();
                        Console.WriteLine(" ");
                        PlatformMenu();
                        break;
                     case 8:
                        td.Delete();
                        Console.WriteLine(" ");
                        PlatformMenu();
                        break;
                     case 9:
                        Exit();
                        break;
                }
            }
            void Exit()
            {
                Console.Write("Are you sure want to exit? [yes|no] : ");
                
                try
                {
                    string exit = Convert.ToString(Console.ReadLine());
                    switch (exit)
                    {
                        case "yes":
                            Environment.Exit(1);
                            break;
                        case "no":
                            PlatformMenu();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please input correctly....");
                }
                
            }
            void Gdrive()
            {
                Console.Clear();
                Console.WriteLine("==Google Drive==");
                Console.WriteLine("1. Monthly");
                Console.WriteLine("2. Annual");
                Console.Write("Choose: ");
                Package = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                switch (Package)
                {
                    case 1:
                        Console.WriteLine("1. 100 GB - IDR 29,000.00/month");
                        Console.WriteLine("2. 200 GB - IDR 43,000.00/month");
                        Console.WriteLine("3. 2 TB - IDR 135,000.00/month");
                        Console.Write("Choose: ");
                        Package = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        switch (Package)
                        {
                            case 1:
                                tax.Tax_MonthYear(29000);
                                break;
                            case 2:
                                tax.Tax_MonthYear(43000);
                                break;
                            case 3:
                                tax.Tax_MonthYear(135000);
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("1. 100 GB - IDR 269,000.00/year");
                        Console.WriteLine("2. 200 GB - IDR 430,000.00/year");
                        Console.WriteLine("3. 2 TB - IDR 1,350,000.00/year");
                        Console.Write("Choose: ");
                        Package = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        switch (Package)
                        {
                            case 1:
                                tax.Tax_MonthYear(269000);
                                break;
                            case 2:
                                tax.Tax_MonthYear(430000);
                                break;
                            case 3:
                                tax.Tax_MonthYear(1350000);
                                break;
                        }
                        break;
                }
                tax.PaymentMethode();
                PlatformMenu();
            }

            void Linkedin()
            {
                Console.Clear();
                Console.WriteLine("================LinkedIn================");
                Console.WriteLine("1. Premium Learning - IDR 385,300.00/month");
                Console.WriteLine("2. Premium Career - IDR 462,400.00/month");
                Console.WriteLine("3. Premium Business - IDR 925,000.00/month");
                Console.WriteLine("4. Sales Navigator - IDR 131,8000.00/month");
                Console.WriteLine("5. Recruiter Lite - IDR 1,849,600.00/month");
                Console.Write("Choose: ");
                Package = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                switch (Package)
                {
                    case 1:
                        tax.Tax_MonthYear(385300);
                        break;
                    case 2:
                        tax.Tax_MonthYear(462400);
                        break;
                    case 3:
                        tax.Tax_MonthYear(925000);
                        break;
                    case 4:
                        tax.Tax_MonthYear(1318000);
                        break;
                    case 5:
                        tax.Tax_MonthYear(18496600);
                        break;
                }
                tax.PaymentMethode();
                PlatformMenu();
            }
            void Wps()
            {
                Console.Clear();
                Console.WriteLine("========WPS=========");
                Console.WriteLine("1. IDR 56,000.00/Month");
                Console.WriteLine("2. IDR 69,0000.00/Year");
                Console.Write("Choose: ");
                Package = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                switch (Package)
                {
                    case 1:
                        tax.Tax_MonthYear(56000);
                        break;
                    case 2:
                        tax.Tax_MonthYear(690000);
                        break;
                }
                tax.PaymentMethode();
                PlatformMenu();
            }
            void Tapscanner()
            {
                Console.Clear();
                Console.WriteLine("==Tap Scanner==");
                Console.WriteLine("IDR 690,000.00/Year");
                Console.WriteLine(" ");

                tax.Tax_MonthYear(690000);
                tax.PaymentMethode();
                PlatformMenu();
            }
            void Getcontact()
            {
                Console.Clear();
                Console.WriteLine("===Getcontact===");
                Console.WriteLine("IDR 29,000.00/Month");
                Console.WriteLine(" ");

                tax.Tax_MonthYear(29000);
                tax.PaymentMethode();
                PlatformMenu();
            }
            


        }
    }
}
