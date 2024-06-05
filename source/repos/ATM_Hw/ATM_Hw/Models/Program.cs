using System.Data.SqlTypes;
using ATM_Hw.Models;

namespace ATM_Hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.UsersShow();

            while (true)
            {
                if (bank.loggedUser is null)
                {
                    login:
                    try
                    {
                        Console.WriteLine("PAN: ");
                        var pan = Console.ReadLine();
                        Console.WriteLine("PIN: ");
                        var pin = Console.ReadLine();
                        bank.Login(pan, pin);
                        Console.Clear();
                        Console.WriteLine($"{bank.loggedUser.Name} {bank.loggedUser.Surname} Welcome!");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto login;
                    }
                }
               
                Console.WriteLine("1. Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Transfer card to card");
                Console.WriteLine("4. Exit");
                Console.Write("Make choice: ");

                var choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine($"{bank.GetBalance()} AZN");
                }
                else if(choice == "2")
                {
                    Console.Clear();
                    withdraw:
                    Console.WriteLine("1. 10 AZN");
                    Console.WriteLine("2. 20 AZN");
                    Console.WriteLine("3. 50 AZN");
                    Console.WriteLine("4. 100 AZN");
                    Console.WriteLine("5. Other");

                    Console.Write("Make choice: ");
                    var amountChoice= Console.ReadLine();
                    if(amountChoice == "1")
                    {
                        Console.Clear();
                        try
                        {
                            bank.Withdraw(10);
                            Console.WriteLine("Withdraw successful");
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (amountChoice == "2")
                    {
                        Console.Clear();
                        try
                        {
                            bank.Withdraw(20);
                            Console.WriteLine("Withdraw successful");
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (amountChoice == "3")
                    {
                        Console.Clear();
                        try
                        {
                            bank.Withdraw(50);
                            Console.WriteLine("Withdraw successful");
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (amountChoice == "4")
                    {
                        Console.Clear();
                        try
                        {
                            bank.Withdraw(100);
                            Console.WriteLine("Withdraw successful");
                        }
                        
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    
                    else if (amountChoice == "5")
                    {
                        Console.Write("Enter amount of money to withdraw: ");
                        
                        var amount = int.Parse(Console.ReadLine());

                        try
                        {
                            bank.Withdraw(amount);
                            
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        goto withdraw;
                      
                    }
                }
                if (choice == "3")
                {
                    Console.Clear();
                    bank.UsersShow();
                    Console.Write("Input receiver PAN: ");
                    var receiverPan = Console.ReadLine();
                    Console.Write("Input amount of money: ");
                    var amount = int.Parse(Console.ReadLine());

                    try
                    {
                        bank.CardToCard(receiverPan, amount);
                        Console.Clear();
                        Console.WriteLine("Money sent");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if(choice == "4")
                {
                    break;
                }
                
            }
        }
    }
}
