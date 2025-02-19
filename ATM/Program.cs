using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.ბანკომატის სისტემა
            int val;
                int balance = 1000;
            int balanceOnHand = 200;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "transaction.txt");
            Console.WriteLine("Transactions will be logged to: " + filePath);



            do
            {
                Console.WriteLine("1. Check your balance");
                Console.WriteLine("2. Deposit money");
                Console.WriteLine("3. Withdraw money");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.WriteLine(balance);
                        LogTransaction(filePath, $"Checked balance {balance}");

                        break;

                    case "2":
                        Console.WriteLine("How many would you like to deposit?");
                        int deposit = int.Parse(Console.ReadLine());

                        if (balanceOnHand < deposit)
                        {
                            Console.WriteLine("You dont have enough money");
                        }
                        else
                        {
                            balance += deposit;
                            balanceOnHand -= deposit;
                            Console.WriteLine($"Balance now in bank account: {balance}");
                            LogTransaction(filePath, $"Deposited {deposit}");
                        }
                        break;

                    case "3":
                        Console.WriteLine("How many would you like to withdraw");
                        int withdraw = int.Parse(Console.ReadLine());
                        if (withdraw > balance)
                        {
                            Console.WriteLine("You dont have enough money in your bank account");
                        }
                        else
                        {
                            balance -= withdraw;
                            balanceOnHand += withdraw;
                            Console.WriteLine($"Balance now in bank account: {balance}");
                            LogTransaction(filePath, $"Withdraw {withdraw}");
                        }

                        break;
                }
                Console.WriteLine("Gsurt gagrdzeleba?");
                Console.WriteLine("1.Ki");
                Console.WriteLine("2.ara");
                val = int.Parse(Console.ReadLine());
            } while (val == 1);

        }
      //  ვლოგავთ შედეგებს ფაილში
            static void LogTransaction(string filePath, string transaction)
        {
            string logEntry = $"{DateTime.Now}: {transaction}";
            Console.WriteLine($"Logging transaction: {logEntry}");

            File.AppendAllText(filePath, logEntry + Environment.NewLine);

        }
    }
}
