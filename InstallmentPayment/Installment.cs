using InstallmentPayment;
using System.Text.RegularExpressions;

namespace INSTALLMENT_APP
{

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
                Console.WriteLine("You must enter pin");
            }
            User user;
            string mypassword = @"^[0-9]{4}$";

            Regex regpass = new Regex(mypassword);
           
            if (regpass.IsMatch(EnterPassword))
            {   
                Console.WriteLine("Pin validated");
                
            }
            else
            {
                Console.WriteLine("Wrong pin, enter again:");
                EnterPassword = Console.ReadLine();
            }

            user = users.FirstOrDefault(x => x.Password == EnterPassword);
            if (user is not null)
            {
                while (true)
                {
                    if (user.Balance != user.Initial && user.Balance >= user.Initial)
                    {
                        Console.WriteLine($"Welcome {user.Name} ");

                    }
                    else
                    {
                        Console.WriteLine("You have no pending payment kudos!");

                        break;
                    }

                    Select.SwitchMode(user);

                }
            }
            else
            {

                Random rd = new Random();
                int productprice = rd.Next(532, 3500);

                try
                {
                    Console.WriteLine("Sorry, Account does not exist, Create new account");
                    string userpattern = @"^[a-zA-Z]{6}$";
                    Regex userreg = new Regex(userpattern);
                    Console.WriteLine("Enter username");
                    var Name = Console.ReadLine();
                    if (userreg.IsMatch(Name))
                    {
                        Console.WriteLine("validated");
                    }
                    else
                    {
                        Console.WriteLine("Name must be alphabets only and not more than 6 characters");

                    }

                    Console.WriteLine("Enter password");
                    var Password = Console.ReadLine();

                    string mypattern = @"^[0-9]{4}$";
                    Regex reg = new Regex(mypattern);

                    if (string.IsNullOrEmpty(EnterPassword) || regpass.IsMatch(EnterPassword))
                    {
                        Console.WriteLine("validated ");
                    }
                    else
                    {
                        Console.WriteLine("invalid ");
                        Console.WriteLine("Enter password");
                        Password = Console.ReadLine();
                    }

                    Console.WriteLine("Enter product");

                    var Product = Console.ReadLine();
                    users.Add(new User { Name = Name, Password = Password, Balance = productprice, Account = "", Product = Product, Initial = 0 });
                    Console.WriteLine("Registration successful");
                    user = users.FirstOrDefault(x => x.Password == Password);


                    users.ForEach(user => Console.WriteLine($"usernames {user.Name} Password: {user.Password} Product: {user.Product} Balance: {user.Balance}"));
                    Console.WriteLine($"Welcome {user.Name} you are owing us {user.Balance}");
                    Select.SwitchMode(user);
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

        private static void exit(int v)
        {
            throw new NotImplementedException();
        }


    }

}