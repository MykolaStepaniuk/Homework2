using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    enum TransactionType
    { Buy = 1, Sell = -1}
    internal class CurrentValue
    {
        static void Main(string[] args)
        {
            TransactionType trcType;
            Console.WriteLine("Input the Transaction Type of the trade:");
            string userInput1 = Console.ReadLine();
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput1, true);


            Console.WriteLine("Input the Nominal of the trade:");
            string userInput2 = Console.ReadLine();
            int nominal = int.Parse(userInput2);

            Console.WriteLine("Input the Price of the trade:");
            string userInput3 = Console.ReadLine();
            double price = Double.Parse(userInput3);

            var CurrentValue = (int)trcType * nominal * price;
            Console.WriteLine($"Portfolio Current Value is {CurrentValue}");


        }
    }
}
