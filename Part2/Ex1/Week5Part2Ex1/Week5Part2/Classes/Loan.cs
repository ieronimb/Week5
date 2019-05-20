using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2.Classes
{
    public class Loan : AccountType
    {
        //Am trecut direct la constructori si metode pentru ca nu mai sunt necesare alte field uri sau proprietati, 
        //doar de metode de Interrest Rate si retragere numerar
        // Constructorul acceseaza base class (ctor)
        public Loan(Customer client, decimal balance, decimal interestRate, DateTime openDate) : base(client, balance, interestRate, openDate)
        {
        }

        //Metoda de a suprascrie CalculateInterestAmount din base class (Account type), in caz de:
        //Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
        public override decimal CalculateInterestAmount()
        {
            if(this.PassedMonths < 3 && this.Client.Type == Enum.CustomerType.Individual)
            {
                return 0;
            }
            if (this.PassedMonths < 2 && this.Client.Type == Enum.CustomerType.Company)
            {
                return 0;
            }
            else return base.CalculateInterestAmount();
        }


    }
}
