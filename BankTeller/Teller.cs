using System;
using System.Collections.Generic;
using System.Text;

namespace BankTeller
{

public class Teller
    {
        public long AccountNumber { get; set; }
        public double AccountBalance { get; set; }

        void validate(char ch)
        {
            Customer customer = new Customer();

            if (ch == 'Y' || ch == 'y')
            {
                customer.CustomerDetails();
            }

            else if (ch == 'N' || ch == 'n')
            {
        
              Exit();
            }

            else
            {
                Console.WriteLine("Invalid Entry!!!");
            }


            DisplayOptions();
        }

        public void Exit()
        {
            Environment.Exit(1);
        }


        public void DisplayOptions()
        {
            char choice;
            Console.WriteLine("\t\tWelcome To Bank Teller Menu\nDo You Want to Perform Operation \nY: for Yes \nN: for No");
            choice = Console.ReadLine()[0];

            validate(choice);
        }


        public void AccountType()
        {
            char userOption;
            Console.WriteLine("Choose Your Account Type: ");
            Console.WriteLine("S: for Savings Account\nC: for Current Account\nK: for Kids Account\nV: for Virtual account");
            userOption = Console.ReadLine()[0];

            ValidateAccountOption(userOption);
        }

        public void ValidateAccountOption(char ch)
        {
            if (ch == 's' || ch == 'S')
            {
                Balance();
                SavingsAccountInterest();
            }

            else if (ch == 'C' || ch == 'c')
            {
                Balance();
                CurrentAccountInterest();

            }

            else if (ch == 'K' || ch == 'k')
            {
                Balance();
                KidsAccountInterest();
            }

            else if (ch == 'V' || ch == 'v')
            {
                Balance();
                VirtualAccountInterest();
            }

            else
            {
                Console.WriteLine("Invalid Entry!!!");
            }

            AccountType();
        }

        public void Balance()
        {
            string acctBalance;
            Console.WriteLine("Enter amount to Deposit");
            acctBalance =  Console.ReadLine();
            AccountBalance = Int32.Parse(acctBalance);
        }

        public void SavingsAccountInterest()
        {
            double annualRate = 3.75 / 100;
            double vat = 7.5;
            double time = 12;
            double a = AccountBalance * Math.Pow((1 + annualRate / 6), time)-vat;

            var months = new[]{ 6, 9, 12, 24, 60 };

            foreach (var i in months)
               {
                   Console.WriteLine($"Your Cummulative Amount for {i} months is: {a} ");
                   a = AccountBalance * Math.Pow((1 + annualRate / i), (time*i)) - vat;
               }
            Console.ReadKey();
            DisplayOptions();
        }

        public void CurrentAccountInterest()
        {
            double annualRate = 5.0 / 100;
            double vat = 7.5;
            double time = 12;
            double a = AccountBalance * Math.Pow((1 + annualRate / 6), time) - vat;

            var months = new[] { 6, 9, 12, 24, 60 };

            foreach (var i in months)
            {
                Console.WriteLine($"Your Cummulative Amount for {i} months is: {a} ");
                a = AccountBalance * Math.Pow((1 + annualRate / i), (time * i)) - vat;
            }
            Console.ReadKey();
            DisplayOptions();
        }

        public void KidsAccountInterest()
        {
            double annualRate = 6.31 / 100;
            double vat = 7.5;
            double time = 12;
            double a = AccountBalance * Math.Pow((1 + annualRate / 6), time) - vat;

            var months = new[] { 6, 9, 12, 24, 60 };

            foreach (var i in months)
            {
                Console.WriteLine($"Your Cummulative Amount for {i} months is: {a} ");
                a = AccountBalance * Math.Pow((1 + annualRate / i), (time * i)) - vat;
            }
            Console.ReadKey();
            DisplayOptions();
        }

        public void VirtualAccountInterest()
        {
            double annualRate = 8.27 / 100;
            double vat = 7.5;
            double time = 12;
            double a = AccountBalance * Math.Pow((1 + annualRate / 6), time) - vat;

            var months = new[] { 6, 9, 12, 24, 60 };

            foreach (var i in months)
            {
                Console.WriteLine($"Your Cummulative Amount for {i} months is: {a} ");
                a = AccountBalance * Math.Pow((1 + annualRate / i), (time * i)) - vat;
            }
            Console.ReadKey();
            DisplayOptions();
        }

    }


public class Customer
        {
            public string Name { get; set; }
            public long AccountNumber { get; set; }
            public string Address { get; set; }
            public int PhoneNumber { get; set; }

        public string CustomerDetails()
        {
            Teller teller = new Teller();
            string cellphone, numb;

            Console.WriteLine("What is Your name");
            Name = Console.ReadLine();

            Console.WriteLine("Enter your Account Number");
            numb = Console.ReadLine();
            AccountNumber = Int32.Parse(numb);

            Console.WriteLine("Enter your Address");
            Address = Console.ReadLine();

            Console.WriteLine("Enter your Phone Number");
            cellphone = Console.ReadLine();
            PhoneNumber = Int32.Parse(cellphone);

            teller.AccountType();
            return numb;
        }
    }
}