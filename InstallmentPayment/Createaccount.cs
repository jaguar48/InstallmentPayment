using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentPayment
{
    internal class Createaccount
    {
        public static void Register()
        {

            Console.WriteLine("Account does not exist, Create new account");
            Random rd = new Random();
            int productprice = rd.Next(532,3500);

            User myuser = new User();

            Console.WriteLine("Enter username");
            myuser.Name = Console.ReadLine();

            Console.WriteLine("Enter password");
            myuser.Password = Console.ReadLine();

            Console.WriteLine("Enter product");
            myuser.Product = Console.ReadLine();
            Console.WriteLine($"Hello you will pay {productprice} for {myuser.Product}");
            Console.WriteLine("Select plan");

            Console.WriteLine("Press 1 for daily,2 to pay weekly,3 bi-weekly,4 monthly \n 5 Six month, 6 One year plan ");
            var chooseOption = Convert.ToInt32(Console.ReadLine());
            switch (chooseOption)
            {
                case 1:
                    InstallmentPlan.Plandaily(productprice, myuser);
                    break;
                case 2:
                    InstallmentPlan.Planweekly(productprice, myuser);
                    break;
                case 3:
                    InstallmentPlan.PlanBiweekly(productprice, myuser);
                    break;
                case 4:
                    InstallmentPlan.PlanMonthly(productprice, myuser);
                    break;
                case 5:
                    InstallmentPlan.PlansixMonth(productprice, myuser);
                    break;
                case 6:
                    InstallmentPlan.PlanYearly(productprice, myuser);
                    break;
                default:

                    Console.WriteLine("Invalid selection");
                    break;


            }

            
            
        }
    }
}
