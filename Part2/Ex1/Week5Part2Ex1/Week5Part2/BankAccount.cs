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
            Console.WriteLine(FirstBank);

            //>>Depozit
            //Depozit cont sub 1000 (nu exista dobanda)
            Customer FirstCustomer = new Customer("Popescu Iulian", CustomerType.Individual);
            Deposit FirstDeposit = new Deposit(FirstCustomer, 980, 12.5m, new DateTime(2018, 01, 01));
            Console.WriteLine(FirstDeposit);
            decimal depositAmount = 400m;
            FirstDeposit.DepositAmount(depositAmount);
            Console.WriteLine("After we deposited new amount:$ {0}, the new balance is:{1}",depositAmount, FirstDeposit);

            //Depozit cont peste 1000 (exista dobanda)
            Customer SecondCustomer = new Customer("SC SA", CustomerType.Company);
            Deposit SecondDeposit = new Deposit(SecondCustomer, 1234, 12.5m, new DateTime(2018, 01, 01));           
            Console.WriteLine(SecondDeposit);
            decimal wirthdraw = 400m;
            FirstDeposit.WithDrawAmount(wirthdraw);
            Console.WriteLine("After we deposited new amount:$ {0}, the new balance is:{1}", wirthdraw, SecondDeposit);

            //>>Loan
            //Loan facut de recent (sub 2 sau 3 luni
            Customer ThirdCustomer = new Customer("SC SNC", CustomerType.Company);
            Loan FirstLoan = new Loan(ThirdCustomer, 43567, 2.00m, new DateTime(2019, 05, 06));            
            Console.WriteLine(FirstLoan);
            //Loan facut dupa 3 luni
            Customer FourthCustomer = new Customer("Iulia Dumitrescu", CustomerType.Individual);
            Loan SecondLoan = new Loan(FourthCustomer, 5467, 7.50m, new DateTime(2019, 01, 01));
            Console.WriteLine(SecondLoan);

            //>>Mortgage
            //Mortgage dupa 12 luni
            Customer SixthCustomer = new Customer("SC SNC", CustomerType.Company);
            Mortgage FirstMortgage = new Mortgage(SixthCustomer, 1245, 4.65m, new DateTime(2017, 05, 06));
            Console.WriteLine(FirstMortgage);
            //Mortgage inainte de 6 luni
            Customer SeventhCustomer = new Customer("Iulia Dumitrescu", CustomerType.Individual);
            Mortgage SecondMortgage = new Mortgage(SeventhCustomer, 345, 10.67m, new DateTime(2019, 01, 01));
            Console.WriteLine(SecondMortgage);
      
            Console.ReadLine();
        }
    }
}

