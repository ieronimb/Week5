using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Part2.Interfaces;

namespace Week5Part2.Classes
{
    public class Deposit : AccountType, IWithdraw
    {
        //Am trecut direct la constructori si metode pentru ca nu mai sunt necesare alte field uri sau proprietati, 
        //doar de metode de Interrest Rate si retragere numerar
        // Constructorul acceseaza base class (ctor)
        public Deposit(Customer customer, decimal balance, decimal interestRate, DateTime openDate): base(customer, balance, interestRate, openDate)
        {

        }        
        //Metoda override pentru a suprascrie metoda virtuala CalculateInterestAmount() din base class (AccountType) in caz de:
        //Deposit accounts have no interest if their balance is positive and less than 1000.
        public override decimal CalculateInterestAmount()
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterestAmount(); //daca e mai mare de 1000, se intanteaza metoda din base class
        }


        //Metoda implementata de interfata IWithdraw. Aceasta interfata va fi contractata numai in Deposit class
        //Deposit accounts are allowed to deposit and with draw money.
        //Loan and mortgage accounts can only deposit money.       

        public void WithDrawAmount(decimal withdrawedSum)
        {
            this.Balance -= withdrawedSum;
        }       
    }
}
