using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2.Classes
{
    public class Mortgage: AccountType
    {
        //Am trecut direct la constructori si metode pentru ca nu mai sunt necesare alte field uri sau proprietati, 
        //doar de metode de Interrest Rate si retragere numerar
        // Constructorul acceseaza base class (ctor)
        public Mortgage(Customer client, decimal balance, decimal interestRate, DateTime openDate): base (client, balance, interestRate, openDate)
        {                
        }
        //Metoda de a suprascrie CalculateInterestAmount din base class (Account type), in caz de:
        //Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
        public override decimal CalculateInterestAmount()
        {
            if (this.PassedMonths <= 12 && this.Client.Type == Enum.CustomerType.Company)
            {
                return base.CalculateInterestAmount() / 2;
            }
            if (this.PassedMonths <= 6 && this.Client.Type == Enum.CustomerType.Individual)
            {
                return 0;
            }
            else return base.CalculateInterestAmount();
        }

    }
}
