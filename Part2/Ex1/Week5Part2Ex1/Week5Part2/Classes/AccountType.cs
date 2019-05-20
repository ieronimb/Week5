using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Part2.Interfaces;

namespace Week5Part2.Classes
{

    public abstract class AccountType : IDeposit //IComparable<DateTime>
    {
        //Campuri - initial imi denumisem si Customer, balance si interestRate, 
        //dar Visual Studio mi-a sugerat ca e de ajuns sa mi le declar in proprietati
        private DateTime openDate;

        //Constructor
        public AccountType(Customer client, decimal balance, decimal interestRate, DateTime openDate)
        {
            this.Client = client;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.openDate = openDate;
        }

        //Proprietati
        public Customer Client { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime OpenDate { get; set; }

        //Proprietate necesara pentru a afla numarul de luni de cand un cont e deschis pentru a calcula Interestrate
        public int PassedMonths
        {
            get
            {
                return (DateTime.Now.Year * 12 + DateTime.Now.Month) - (this.openDate.Year * 12 + this.openDate.Month);
            }
        }

        //Metoda necesara pentru interfata IDeposit
        public decimal DepositAmount(decimal amount)
        {
            return this.Balance += amount;
        }
        //Metoda virtuala pentru a fi instantiata/implementata in clasele derivate
        public virtual decimal CalculateInterestAmount()
        {
            return this.PassedMonths * this.InterestRate;
        }
        public override string ToString()
        {
            return string.Format("Owner: {0}\nAccount type: {1}\nBalance:$ {2}\nInterest:$ {3} ",
                this.Client.Name, this.GetType().Name, this.Balance, this.CalculateInterestAmount());
        }
    }
}
