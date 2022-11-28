using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InstallmentPayment
{
    internal class InstallmentPlan
    {
        private static DateTime dateTime;
        
        public static void Plandaily(int productprice, User myuser)
        {

       
            Console.WriteLine("Enter amount you wish to be paying daily ");
                int InitialAmount = Convert.ToInt32(Console.ReadLine());
                if (InitialAmount >= productprice)
                {
                    throw new ArgumentOutOfRangeException();
                }
                dateTime = DateTime.Now;
                for (int i = (int) InitialAmount; i <= productprice; i += InitialAmount)
                {
                    if (productprice - i >=InitialAmount)
                    {
                        Console.WriteLine($"{myuser.Name} You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {productprice - i} for {myuser.Product} ");

                    }
                    else
                    {
                        Console.WriteLine($"Payment will be Completed on {(dateTime.ToLongDateString())}");
                    }

                    dateTime = dateTime.AddDays(1);

                }
               
                   Console.WriteLine($"Total amount to be paid {productprice}");
        }
        public static void Planweekly (int productprice, User myuser)
        {


            Console.WriteLine("Enter amount you wish to be paying weekly ");
            int InitialAmount = Convert.ToInt32(Console.ReadLine());
            if (InitialAmount >= productprice)
            {
                throw new ArgumentOutOfRangeException();
            }
            dateTime = DateTime.Now;
            for (int i = (int)InitialAmount; i <= productprice; i += InitialAmount)
            {
                if (productprice - i >= InitialAmount)
                {
                    Console.WriteLine($"{myuser.Name} You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {productprice - i} for {myuser.Product} ");

                }
                else
                {
                    Console.WriteLine($"Payment will be Completed on {(dateTime.ToLongDateString())}");
                }

                dateTime = dateTime.AddDays(7);

            }

            Console.WriteLine($"Total amount to be paid {productprice}");
        }
        public static void PlanBiweekly(int productprice, User myuser)
        {


            Console.WriteLine("Enter amount you wish to be paying bi weekly");
            int InitialAmount = Convert.ToInt32(Console.ReadLine());
            if (InitialAmount >= productprice)
            {
                throw new ArgumentOutOfRangeException();
            }
            dateTime = DateTime.Now;
            for (int i = (int)InitialAmount; i <= productprice; i += InitialAmount)
            {
                if (productprice - i >= InitialAmount)
                {
                    Console.WriteLine($"{myuser.Name} You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {productprice - i} for {myuser.Product} ");

                }
                else
                {
                    Console.WriteLine($"Payment will be Completed on {(dateTime.ToLongDateString())}");
                }

                dateTime = dateTime.AddDays(14);

            }

            Console.WriteLine($"Total amount to be paid {productprice}");
        }
        public static void PlanMonthly(int productprice, User myuser)
        {


            Console.WriteLine("Enter amount you wish to be paying monthly");
            int InitialAmount = Convert.ToInt32(Console.ReadLine());
            if (InitialAmount >= productprice)
            {
                throw new ArgumentOutOfRangeException();
            }
            dateTime = DateTime.Now;
            for (int i = (int)InitialAmount; i <= productprice; i += InitialAmount)
            {
                if (productprice - i >= InitialAmount)
                {
                    Console.WriteLine($"{myuser.Name} You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {productprice - i} for {myuser.Product} ");

                }
                else
                {
                    Console.WriteLine($"Payment will be Completed on {(dateTime.ToLongDateString())}");
                }

                dateTime = dateTime.AddMonths(1);

            }

            Console.WriteLine($"Total amount to be paid {productprice}");
        }
        public static void PlansixMonth(int productprice, User myuser)
        {


            Console.WriteLine("Enter amount you wish to be paying in six months");
            int InitialAmount = Convert.ToInt32(Console.ReadLine());
            if (InitialAmount >= productprice)
            {
                throw new ArgumentOutOfRangeException();
            }
            dateTime = DateTime.Now;
            for (int i = (int)InitialAmount; i <= productprice; i += InitialAmount)
            {
                if (productprice - i >= InitialAmount)
                {
                    Console.WriteLine($"{myuser.Name} You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {productprice - i} for {myuser.Product} ");

                }
                else
                {
                    Console.WriteLine($"Payment will be Completed on {(dateTime.ToLongDateString())}");
                }

                dateTime = dateTime.AddMonths(6);

            }

            Console.WriteLine($"Total amount to be paid {productprice}");
        }
        public static void PlanYearly(int productprice, User myuser)
        {


            Console.WriteLine("Enter amount you wish to be paying yearly");
            int InitialAmount = Convert.ToInt32(Console.ReadLine());
            if (InitialAmount >= productprice)
            {
                throw new ArgumentOutOfRangeException();
            }
            dateTime = DateTime.Now;
            for (int i = (int)InitialAmount; i <= productprice; i += InitialAmount)
            {
                if (productprice - i >= InitialAmount)
                {
                    Console.WriteLine($"{myuser.Name} You will pay ${InitialAmount} on {(dateTime.ToLongDateString())} and remaining ${productprice - i} for {myuser.Product} ");

                }
                else
                {
                    Console.WriteLine($"Payment will be Completed on {(dateTime.ToLongDateString())}");
                }

                dateTime = dateTime.AddYears(1);

            }

            Console.WriteLine($"Total amount to be paid ${productprice}");
        }
    }
}
