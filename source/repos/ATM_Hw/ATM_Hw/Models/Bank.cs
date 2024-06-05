using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Hw.Models
{
    internal class Bank
    {
        private readonly User[] users = [
            new User("user1", "user1", 100, 3),
            new User("user2", "user2", 200, 3),
            new User("user3", "user3", 350, 5),
            new User("user4", "user4", 500, 4),
            new User("user5", "user5", 600, 4),
            ];

        public User? loggedUser = null;
        public void UsersShow()
        {
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }

        public void Login(string pan, string pin)
        {
            foreach(var user in users)
            {
                if(user.creditCard.PAN==pan && user.creditCard.PIN == pin)
                {
                    loggedUser = user;
                    return;
                }
            }
            throw new Exception("Wrong PAN or PIN");
        }

        public void Logout() => loggedUser = null;
        public void Withdraw(int amount)
        {
            if(loggedUser is null)
            {
                throw new Exception();
            }

            if (loggedUser.creditCard.Balance < amount)
            {
                throw new Exception("There is not enough money in balance");
            }
            loggedUser.creditCard.Balance -= amount;
        }

        public decimal GetBalance()
        {
            if(loggedUser is null)
            {
                throw new Exception();
            }
            return loggedUser.creditCard.Balance;
        }

        public void CardToCard(string receiverPan, int amount)
        {
            if (loggedUser is null)
            {
                throw new Exception();
            }

            if (loggedUser.creditCard.Balance < amount)
            {
                throw new Exception("There is not enough money in balance");
            }

            foreach(var user in users)
            {
                if (user.creditCard.PAN == receiverPan)
                {
                    user.creditCard.Balance += amount;
                    loggedUser.creditCard.Balance-= amount;
                    return;
                }
            }
            throw new Exception("Receiver not found");
        }
    }
}
