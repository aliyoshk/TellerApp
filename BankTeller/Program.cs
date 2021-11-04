using System;

namespace BankTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    double total = 0, interestRate, years, annualCompound, amount;

                Console.WriteLine("Enter the initail Amount: ");
                amount = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the Rate of interest: ");
                interestRate = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the Number of years: ");
                years = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the Number of time the interest will be compound: ");
                annualCompound = Convert.ToDouble(Console.ReadLine());

                for(int i = 1; i<years + 1; i++)
                {
                    total = amount * Math.Pow((1 + interestRate / annualCompound), (annualCompound * i));

                    Console.WriteLine("Your total for year {0} "+ "is {1:10}. \n", i, total);


                }
                Console.ReadLine();*/

            Teller teller = new Teller();
            teller.DisplayOptions();
        }
    }
}
