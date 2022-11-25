using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using InstallmentPayment;


namespace ATM_PROJECT
{

    public class App
    {
        private static DateTime dateTime;
        public static void Userrecords()
        {

            var users = new List<User>{
            new User {Name ="Stanley", Password = "1111", Balance = 5000, Account = "234532", Product ="Trouser",Initial = 0 },
            new User {Name ="Okonkwo", Password = "2222", Balance = 6000, Account = "145342", Product ="Handbag", Initial = 0 },
            new User {Name ="Paul", Password = "3333", Balance = 3000, Account = "765543",Product ="Shirt",Initial = 0 },
            new User {Name ="Bishop", Password = "4444",Balance = 2000, Account ="224422",  Product ="Shoe",Initial = 0  },
            new User {Name ="Allen", Password = "5555", Balance = 8000, Account = "345432", Product = "Boot", Initial = 0 },
            new User {Name ="Anita", Password = "6666", Balance = 8000, Account = "245421", Product = "Cap", Initial = 0 }

     };


            Console.WriteLine("Enter your 4 digit password");
            var enter_pin = Console.ReadLine();

            var user = users.FirstOrDefault(x => x.Password == enter_pin);
            if (user is not null)
            {
                while (true)
                {
                    if (user.Balance != user.Initial)
                    {
                        Console.WriteLine($"Welcome {user.Name} You are owing us ");

                    }
                    else
                    {
                        Console.WriteLine("You have no pending payment kudos!");

                        break;
                    }


                    Console.WriteLine("Press 1 to see pending, 2 to select payment plan 3 to exit");
                    var check_option = Console.ReadLine();
                    if (check_option == "1")
                    {


                        Console.WriteLine($"balance: ${user.Balance}");
                        Console.WriteLine("Press any key to go to main menu");

                        /*Console.ReadKey();
                        continue;*/
                    }
                    else if (check_option == "2")
                    {
                        Console.WriteLine("Press 1 for daily,2 to pay weekly,3 bi-weekly ");
                        var check_plan = Console.ReadLine();
                        if (check_plan == "1")
                        {
                            Dailyplan(user);

                        }
                        else if (check_plan == "2")
                        {
                            Weeklyplan(user);
                        }
                        else if (check_option == "3")
                        {
                            BiWeeklyplan(user);

                        }



                    }


                    else
                    {
                        Console.WriteLine("you selected invalid option");
                        Console.WriteLine("Press any key to go to main menu");

                        /*  Console.ReadKey();
                          continue;*/
                    }

                }
            }


        }

        private static void Dailyplan(User user)
        {
            Console.WriteLine("Enter amount");
            int InitialAmount = Convert.ToInt32(Console.ReadLine());
            dateTime = DateTime.Now;
            for (int i = InitialAmount; i <= user.Balance; i += InitialAmount)
            {


                Console.WriteLine($"You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {user.Balance - i} for {user.Product} ");


                dateTime = dateTime.AddDays(1);
                user.Initial += InitialAmount;

            }
            Console.WriteLine("Total amount {0}", user.Initial);

        }
        private static void Weeklyplan(User user)
        {
            Console.WriteLine("Enter amount");
            int InitialAmount = Convert.ToInt32(Console.ReadLine());
            dateTime = DateTime.Now;
            for (int i = InitialAmount; i <= user.Balance; i += InitialAmount)
            {



                Console.WriteLine($"You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {user.Balance - i} ");


                dateTime = dateTime.AddDays(7);
                user.Initial += InitialAmount;

            }
            Console.WriteLine("Total amount {0}", user.Initial);

        }
        private static void BiWeeklyplan(User user)
        {
            Console.WriteLine("Enter amount");
            int InitialAmount = Convert.ToInt32(Console.ReadLine());
            dateTime = DateTime.Now;
            for (int i = InitialAmount; i <= user.Balance; i += InitialAmount)
            {



                Console.WriteLine($"You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {user.Balance - i} ");


                dateTime = dateTime.AddDays(14);
                user.Initial += InitialAmount;

            }
            Console.WriteLine($"Total amount ${user.Initial}");

        }


       
    }
}