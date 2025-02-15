using ConsoleApp9.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static List<Book> books = new List<Book>();
        static void Main(string[] args)

        {


            ////// 1. კალკულატორი
            int val;
            //do
            //{
            //    Console.WriteLine("Sheiyvanet pirveli ricxvi");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Sheiyvanet Shemdegi ricxvi");
            //    int num2 = int.Parse(Console.ReadLine());


            //    Console.WriteLine("1.Mimateba");
            //    Console.WriteLine("2.Gamokleba");
            //    Console.WriteLine("3.Gayofa");
            //    Console.WriteLine("4.Gamravleba");

            //    Console.WriteLine("Airchiet moqmedeba");
            //    string res = Console.ReadLine();

            //    //  სვიჩ ქეისით ვაკეთებთ კალკულატორის მეინიუს
            //    switch (res)
            //    {
            //        case "1":
            //            Console.WriteLine($"Shedegi {num1 + num2}");
            //            break;

            //        case "2":
            //            Console.WriteLine($"Shedegi {num1 - num2}");
            //            break;

            //        case "3":
            //            if (num2 != 0)
            //                Console.WriteLine($"Shedegi {num1 / num2}");
            //            break;

            //        case "4":
            //            Console.WriteLine($"Shedegi {num1 * num2}");
            //            break;

            //        default:
            //            break;
            //    }
            //    //  რათა განმეორდეს ისევ
            //    Console.WriteLine("Gsurt gagrdzeleba?");
            //    Console.WriteLine("1.Ki");
            //    Console.WriteLine("2.ara");
            //    val = int.Parse(Console.ReadLine());
            //} while (val == 1);

            //2.ბანკომატის სისტემა
            //    int balance = 1000;
            //    int balanceOnHand = 200;
            //    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //    string filePath = Path.Combine(desktopPath, "transaction.txt");
            //    Console.WriteLine("Transactions will be logged to: " + filePath);



            //    do
            //    {
            //        Console.WriteLine("1. Check your balance");
            //        Console.WriteLine("2. Deposit money");
            //        Console.WriteLine("3. Withdraw money");

            //        string menu = Console.ReadLine();

            //        switch (menu)
            //        {
            //            case "1":
            //                Console.WriteLine(balance);
            //                LogTransaction(filePath, $"Checked balance {balance}");

            //                break;

            //            case "2":
            //                Console.WriteLine("How many would you like to deposit?");
            //                int deposit = int.Parse(Console.ReadLine());

            //                if (balanceOnHand < deposit)
            //                {
            //                    Console.WriteLine("You dont have enough money");
            //                }
            //                else
            //                {
            //                    balance += deposit;
            //                    balanceOnHand -= deposit;
            //                    Console.WriteLine($"Balance now in bank account: {balance}");
            //                    LogTransaction(filePath, $"Deposited {deposit}");
            //                }
            //                break;

            //            case "3":
            //                Console.WriteLine("How many would you like to withdraw");
            //                int withdraw = int.Parse(Console.ReadLine());
            //                if (withdraw > balance)
            //                {
            //                    Console.WriteLine("You dont have enough money in your bank account");
            //                }
            //                else
            //                {
            //                    balance -= withdraw;
            //                    balanceOnHand += withdraw;
            //                    Console.WriteLine($"Balance now in bank account: {balance}");
            //                    LogTransaction(filePath, $"Withdraw {withdraw}");
            //                }

            //                break;
            //        }
            //        Console.WriteLine("Gsurt gagrdzeleba?");
            //        Console.WriteLine("1.Ki");
            //        Console.WriteLine("2.ara");
            //        val = int.Parse(Console.ReadLine());
            //    } while (val == 1);

            //}
            // ვლოგავთ შედეგებს ფაილში
            //static void LogTransaction(string filePath, string transaction)
            //{
            //    string logEntry = $"{DateTime.Now}: {transaction}";
            //    Console.WriteLine($"Logging transaction: {logEntry}");

            //    File.AppendAllText(filePath, logEntry + Environment.NewLine);

            //3. რიცხვის გამოცნობა

            //Random rand = new Random();
            //int randomnum = rand.Next(1, 11);
            //int yournum = 0;
            //int mcdeloba = 0;
            //Console.WriteLine("Sheiyvanet ricxvi ertidan atamde");
            //while (randomnum != yournum)
            //{

            //     yournum = int.Parse(Console.ReadLine());
            //    if (yournum > randomnum)
            //    {
            //        Console.WriteLine("Airchie ufro dabali ricxvi");
            //    }
            //    else if (yournum < randomnum)
            //    {
            //        Console.WriteLine("Airchie ufro magali ricxvi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Shen gamoicani!");
            //        Console.WriteLine($"Pasuxi iko: {randomnum}");
            //    }
            //    mcdeloba++;
            //    Console.WriteLine($"Sheni mcdeloba: {mcdeloba}");
            //}

            BookManager manager = new BookManager();
           

            books.Add(new Book("wigni1", new Author("avtori1", "1900", "qveyana1"), 1900));
            books.Add(new Book("To Kill a Mockingbird", new Author("Harper Lee", "1926", "USA"), 1960));
        

            while (true)
            {
                Console.WriteLine("Book Manager");
                Console.WriteLine("1 Daamate wigni");
                Console.WriteLine("2 Daatvaliere wignebi");
                Console.WriteLine("3 Modzebne wigni sataurit");
                Console.WriteLine("4 Dasruleba");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        manager.AddBook();
                        break;
                    case "2":
                        manager.LoadPreAddedBooks();
                        manager.DisplayAllbooks();
                       

                        break;
                    case "3":
                        manager.SearchByTitle();
                        break;
                        case "4":
                        return;
                }
            }
        }



    }


        


    }





