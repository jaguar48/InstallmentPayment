using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentPayment
{
    internal class PaymentPlan
    {
        private static DateTime dateTime;
        public static void Dailyplan(User user)
        {
            try
            {
                Console.WriteLine("Enter amount you wish to be paying daily ");
                int InitialAmount = Convert.ToInt32(Console.ReadLine());
                if (InitialAmount >= user.Balance)
                {
                    throw new ArgumentOutOfRangeException();
                }
                dateTime = DateTime.Now;
                for (int i = (int)InitialAmount; i <= user.Balance; i += InitialAmount)
                {
                    if (user.Balance - i >= InitialAmount)
                    {

                        Console.WriteLine($"You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {user.Balance - i} for {user.Product} ");
                    }
                    else
                    {
                        Console.WriteLine($"Payment will be Completed on {(dateTime.ToLongDateString())}");
                    }

                    dateTime = dateTime.AddDays(1);
                    user.Initial += InitialAmount;

                }
                Console.WriteLine("Total amount to be paid {0}", user.Initial);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public static void Weeklyplan(User user)
        {
            try
            {
                Console.WriteLine("Enter amount you wish to be paying Weekly ");
                int InitialAmount = Convert.ToInt32(Console.ReadLine());
                if (InitialAmount >= user.Balance)
                {
                    throw new ArgumentOutOfRangeException();
                }
                dateTime = DateTime.Now;

                for (int i = InitialAmount; i <= user.Balance; i += InitialAmount)
                {

                    if (user.Balance - i >= InitialAmount)
                    {

                        Console.WriteLine($"You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {user.Balance - i} for {user.Product} ");
                    }
                    else
                    {
                        Console.WriteLine($"Payment will be Completed on {(dateTime.ToLongDateString())}");
                    }


                    dateTime = dateTime.AddDays(7);
                    user.Initial += InitialAmount;

                }

                Console.WriteLine("Total amount to be paid {0}", user.Initial);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public static void BiWeeklyplan(User user)
        {
            try
            {


                Console.WriteLine("Enter amount you wish to be paying Bi-Weekly ");
                int InitialAmount = Convert.ToInt32(Console.ReadLine());
                if (InitialAmount >= user.Balance)
                {
                    throw new ArgumentOutOfRangeException();
                }
                dateTime = DateTime.Now;
                for (int i = InitialAmount; i <= user.Balance; i += InitialAmount)
                {

                    if (user.Balance - i >= InitialAmount)
                    {

                        Console.WriteLine($"You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {user.Balance - i} for {user.Product} ");
                    }
                    else
                    {
                        Console.WriteLine($"Payment will be Completed on {(dateTime.ToLongDateString())}");
                    }


                    dateTime = dateTime.AddDays(14);
                    user.Initial += InitialAmount;

                }
                Console.WriteLine($"Total amount to be paid ${user.Initial}");
                Console.Clear();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public static void Monthlyplan(User user)
        {
            try
            {


                Console.WriteLine("Enter amount you wish to be paying Monthly ");
                int InitialAmount = Convert.ToInt32(Console.ReadLine());
                if (InitialAmount >= user.Balance)
                {
                    throw new ArgumentOutOfRangeException();
                }
                dateTime = DateTime.Now;
                for (int i = InitialAmount; i <= user.Balance; i += InitialAmount)
                {



                    if (user.Balance - i >= InitialAmount)
                    {

                        Console.WriteLine($"You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {user.Balance - i} for {user.Product} ");
                    }
                    else
                    {
                        Console.WriteLine($"Payment will be Completed on {(dateTime.ToLongDateString())}");
                    }


                    dateTime = dateTime.AddMonths(1);
                    user.Initial += InitialAmount;

                }
                Console.WriteLine($"Total amount ${user.Initial}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void SixMonthplan(User user)
        {
            try
            {


                Console.WriteLine("Enter amount you wish to be paying in Six months ");
                int InitialAmount = Convert.ToInt32(Console.ReadLine());
                if (InitialAmount >= user.Balance)
                {
                    throw new ArgumentOutOfRangeException();
                }
                dateTime = DateTime.Now;
                for (int i = InitialAmount; i <= user.Balance; i += InitialAmount)
                {

                    if (user.Balance - i >= InitialAmount)
                    {

                        Console.WriteLine($"You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {user.Balance - i} for {user.Product} ");
                    }
                    else
                    {
                        Console.WriteLine($"Payment will be Completed on {(dateTime.ToLongDateString())}");
                    }


                    dateTime = dateTime.AddMonths(6);
                    user.Initial += InitialAmount;

                }
                Console.WriteLine($"Total amount ${user.Initial}");

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public static void Yearplan(User user)
        {
            try
            {
                Console.WriteLine("Enter amount you wish to be paying Yearly ");
                int InitialAmount = Convert.ToInt32(Console.ReadLine());
                if (InitialAmount >= user.Balance)
                {
                    throw new ArgumentOutOfRangeException();
                }
                dateTime = DateTime.Now;
                for (int i = InitialAmount; i <= user.Balance; i += InitialAmount)
                {

                    if (user.Balance - i >= InitialAmount)
                    {

                        Console.WriteLine($"You will pay {InitialAmount} on {(dateTime.ToLongDateString())} and remaining {user.Balance - i} for {user.Product} ");
                    }
                    else
                    {
                        Console.WriteLine($"Payment will be Completed on {(dateTime.ToLongDateString())}");
                    }


                    dateTime = dateTime.AddYears(1);
                    user.Initial += InitialAmount;

                }
                Console.WriteLine($"Total amount ${user.Initial}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
