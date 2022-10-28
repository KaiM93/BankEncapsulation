using static System.Formats.Asn1.AsnWriter;
using System;

namespace BankEncapsulation
{
    public class Program
    { 
        static void Main(string[] args)
        {
             var kaisAccount = new Bank_Account();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            kaisAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you, your balance is now {kaisAccount.GetBalance()}");
            
        }
    }
}
