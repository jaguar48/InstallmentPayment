using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstallmentPayment;


namespace INSTALLMENT_APP
{
 /*   var SelectPlan = Console.ReadLine();

    var myplans = check_option switch
    {
        "1" => user.Balance,

        "2" => SelectPlan switch
        {
            "1" => Dailyplan(user),
            "2" => Weeklyplan(user),


            _ => throw new NotImplementedException(),
        },

        _ => throw new NotImplementedException(),
    };
*/
    public class App
    {

        public static void Installment()
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
            var EnterPassword = Console.ReadLine();
            if (string.IsNullOrEmpty(EnterPassword))
            {
                Console.WriteLine("Password can't be empty! Input your pasword once more");
                EnterPassword = Console.ReadLine();
            }


            var user = users.FirstOrDefault(x => x.Password == EnterPassword);
            if (user is not null)
            {
                while (true)
                {
                    if (user.Balance != user.Initial && user.Balance >= user.Initial)
                    {
                        Console.WriteLine($"Welcome {user.Name} You are owing us ${user.Balance - user.Initial} for {user.Product}");

                    }
                    else
                    {
                        Console.WriteLine("You have no pending payment kudos!");

                        break;
                    }

                    try
                    {
                        Console.WriteLine("Press 1 to select payment plan 2 to exit");
                        var SelectOption = Convert.ToInt32(Console.ReadLine());

                        switch (SelectOption)
                        {

                            case 1:
                                Console.WriteLine("Press 1 for daily,2 to pay weekly,3 bi-weekly,4 monthly \n 5 Six month, 6 One year plan ");
                                var SelectPlan = Convert.ToInt32(Console.ReadLine());
                                switch (SelectPlan)
                                {

                                    case 1:

                                        PaymentPlan.Dailyplan(user);
                                        break;
                                    case 2:
                                        PaymentPlan.Weeklyplan(user);
                                        break;
                                    case 3:
                                        PaymentPlan.BiWeeklyplan(user);
                                        break;
                                    case 4:
                                        PaymentPlan.Monthlyplan(user);
                                        break;
                                    case 5:
                                        PaymentPlan.SixMonthplan(user);
                                        break;
                                    case 6:
                                        PaymentPlan.Yearplan(user);
                                        break;

                                    default:
                                        Console.WriteLine("invalid option");
                                        break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("Goodbye buddy!");
                                Environment.Exit(1);

                                break;

                        }

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }



                }
            }
            else
            {
                Createaccount.Register();

            }


        }

        private static void exit(int v)
        {
            throw new NotImplementedException();
        }

       
    }

}