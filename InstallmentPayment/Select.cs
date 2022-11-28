using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentPayment
{
    internal class Select
    {
        public static void SwitchMode(User user)
        {
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
                                SwitchMode(user);
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
    }

