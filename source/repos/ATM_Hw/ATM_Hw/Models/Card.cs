using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using ATM_Hw.Helpers;

namespace ATM_Hw
{
    internal class Card
    {
        public string PAN {  get; set; }
        public string PIN {  get; set; }
        public string CVC {  get; set; }
        public string expireDate {  get; set; }
        public decimal Balance { get; set; }

        public Card(decimal amount,int year)
        {
            PAN = RandomGenerator.GenerateString(16, Helpers.Type.Numeric);
            PIN = RandomGenerator.GenerateString(4, Helpers.Type.Numeric);
            CVC = RandomGenerator.GenerateString(3, Helpers.Type.Numeric);
            Balance = amount;
            expireDate = DateTime.Now.AddYears(year).ToString("MM.yy");
        }

        public override string ToString()
        {
            return $" PAN: {PAN} PIN: {PIN} CVC: {CVC} Date: {expireDate} Balance AZN: {Balance} ";
        }

    }
}
