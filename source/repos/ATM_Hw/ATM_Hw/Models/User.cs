using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Hw.Models
{
    internal class User
    {
        public string Name {  get; set; }
        public string Surname {  get; set; }
        public Card creditCard { get; set; }

        public User(string name, string surname, int amount,int year)
        {
            Name = name;
            Surname = surname;
            creditCard = new Card(amount, year);    
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {creditCard}";
        }


    }
}
