using System.Reflection.Metadata;

namespace Card_ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[5];

            users[0] = new User
            {
                Name = "User1",
                Surname = "Surname1",
                UserCard = new Card
                {
                    PAN = "1234567801234567",
                    PIN = "1234",
                    CVC = "123",
                    ExpireDate = "08/09",
                    Balance = 1000m
                }
            };

            users[1] = new User
            {
                Name = "User2",
                Surname = "Surname2",
                UserCard = new Card
                {
                    PAN = "1234567801234560",
                    PIN = "5678",
                    CVC = "456",
                    ExpireDate = "07/09",
                    Balance = 2000m
                }
            };

            users[2] = new User
            {
                Name = "User3",
                Surname = "Surname3",
                UserCard = new Card
                {
                    PAN = "1234567801234569",
                    PIN = "0123",
                    CVC = "113",
                    ExpireDate = "05/09",
                    Balance = 3000m
                }
            };

            users[3] = new User
            {
                Name = "User4",
                Surname = "Surname4",
                UserCard = new Card
                {
                    PAN = "1234567801234555",
                    PIN = "9876",
                    CVC = "112",
                    ExpireDate = "05/09",
                    Balance = 4000m
                }
            };

            users[4] = new User
            {
                Name = "User4",
                Surname = "Surname4",
                UserCard = new Card
                {
                    PAN = "1234567812345678",
                    PIN = "1233",
                    CVC = "115",
                    ExpireDate = "07/09",
                    Balance = 4500m
                }
            };


            bool pinValid = false;
            bool optionUser = false;
            User inUser = null;

            while (!pinValid)
            {
                Console.Write("Enter PIN: ");
                string enteredPin = Console.ReadLine();

                foreach (var user in users)
                {

                    if (user.UserCard.PIN == enteredPin)
                    {
                        Console.WriteLine($"Welcome {user.Name} {user.Surname}.");
                        inUser = user;
                        pinValid = true;
                        break;
                    }
                }

                if (!pinValid)
                {
                    Console.WriteLine("Invalid PIN. Try again ..");
                }
            }

            bool choiceUser = false;

            while (!choiceUser)
            {
                Console.WriteLine("1. Balance");
                Console.WriteLine("2. Cash");
                Console.WriteLine("3. Card to card transfer");
                Console.Write("Make choice: ");
                string inputUser = Console.ReadLine();

                if (inputUser == "1")
                {
                    Console.WriteLine($"Your balance is: {inUser.UserCard.Balance} AZN");
                    optionUser = true;
                }

                if (inputUser == "2")
                {
                    Console.WriteLine("1. 10 AZN");
                    Console.WriteLine("2. 20 AZN");
                    Console.WriteLine("3. 50 AZN");
                    Console.WriteLine("4. 100 AZN");
                    Console.WriteLine("5. Other");
                    Console.Write("Choose amount: ");

                    string userAmount = Console.ReadLine();
                }




            }
        }
    }
}

