using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment1
{
    class Program
    {

        static int AccountNumberGen(int inc)
        {
            int start = 999;
            int an = start + inc;
            return an;
        }
        static void Main(string[] args)
        {
            bool flag = true;
            int num;

            //Console.WriteLine("How many accounts do you want to create? ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Bank ourBank = new Bank("Developer's bank", num);

            // Bank ourBank = new Bank("Developer's bank", num);

            Console.WriteLine("How many accounts do you want to create? ");
            num = Convert.ToInt32(Console.ReadLine());
            Bank ourBank = new Bank("Developer's bank", num);

            while (flag)
            {
                Console.WriteLine("1) Create Account \n2) Deposit \n3) Withdraw \n4) Transfer \n5) Delete \n6) Print \n7) Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:


                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine("\nAccount " + (i + 1));
                            Console.WriteLine("Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Ammount: ");
                            double ammount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("House no: ");
                            int houseNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Road no: ");
                            int roadNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("City: ");
                            string city = Console.ReadLine();
                            Console.WriteLine("Country: ");
                            string country = Console.ReadLine();

                            ourBank.AddAccount(new Account(name, ammount, AccountNumberGen(i), new Address(houseNo, roadNo, city, country)));

                        }
                        break;
                    case 2:
                        ourBank.Transaction(2, 100.0);
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        Console.WriteLine("House no: ");
                        int delAC = Convert.ToInt32(Console.ReadLine());
                        ourBank.DeleteAccount(delAC);
                        break;
                    case 6:
                        ourBank.PrintAllAccounts();
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nPlease Select between 1 to 7\n");
                        continue;



                }




            }



        }



       

    }
}
