using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Part2.Classes;
using Week5Part2.Enum;


namespace Week5Part2
{
    class BankAccount
    {
        //2. Bank accounts
        //A bank holds differentQ types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.Customers could 
        //be individuals or companies.
        //All accounts have customer, balance and interest rate (monthly based).
        //Deposit accounts are allowed to deposit and with draw money.
        //Loan and mortgage accounts can only deposit money.
        //All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: 
        //number_of_months* interest_rate.
        //Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
        //Deposit accounts have no interest if their balance is positive and less than 1000.
        //Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
        //Your task is to write a program to model the bank system by classes and interfaces.
        //You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality 
        //through overridden methods.

        static void Main(string[] args)
        {
            //Numele bancii
            Bank FirstBank = new Bank("BRDE");

            //Depozit cont sub 1000 (nu exista dobanda)
            Customer FirstCustomer = new Customer("Popescu Iulian", CustomerType.Individual);
            Deposit FirstDeposit = new Deposit(FirstCustomer, 543, 12.5m, new DateTime(2018, 01, 01));
            //Depozit cont peste 1000 (exista dobanda)
            Customer SecondCustomer = new Customer("Iulia Popescu", CustomerType.Individual);
            Deposit SecondDeposit = new Deposit(SecondCustomer, 1234, 12.5m, new DateTime(2018, 01, 01));
            Console.WriteLine(FirstBank);
            Console.WriteLine(FirstDeposit);
            Console.WriteLine(SecondDeposit);

            Customer ThirdCustomer = new Customer("SC SRL", CustomerType.Company);
            Loan FirstMortgage = new Loan(ThirdCustomer, 345, 1.67m, new DateTime(2017, 05, 06));            
            Console.WriteLine(FirstMortgage);            

            Console.ReadLine();
        }
    }
}

