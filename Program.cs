using System.Security.Cryptography.X509Certificates;

namespace Intro
{
    internal class Program
    {
        static int money;

        static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.White;

           

            Console.WriteLine("Hello, Boss!");

            Console.WriteLine("Enter how much you want to get money");
            int a = int.Parse(Console.ReadLine());

            GiveMoney(a);

            Console.WriteLine("Enter product which you want to buy");

            
            GetProductList();
            int b = int.Parse(Console.ReadLine());

            Clear();

            switch (b)
            {

                case 1:
                    if (CheckMoney(120))
                    {
                        ChangeColor(ConsoleColor.Red);
                        Console.WriteLine("You successfully bought Coca Cola for 120$");
                        break;
                    }
                    ChangeColor(ConsoleColor.Red);
                    Console.WriteLine("You dont have enough money!");
                    break;
                case 2:
                    if (CheckMoney(100))
                    {
                        ChangeColor(ConsoleColor.Blue);
                        Console.WriteLine("You successfully bought Pepsi for 100$");
                        break;
                    }
                    ChangeColor(ConsoleColor.Red);
                    Console.WriteLine("You dont have enough money!");
                    break;
                case 3:
                    if (CheckMoney(80))
                    {
                        ChangeColor(ConsoleColor.Yellow);
                        Console.WriteLine("You successfully bought Fanta for 80$");
                        break;
                    }
                    ChangeColor(ConsoleColor.Red);
                    Console.WriteLine("You dont have enough money!");
                    break;
                default:
                    Console.WriteLine("This product not in list");
                    break;


            }

            Sleep(3000);
            Clear();
            Console.WriteLine($"You have left {money}$");

            Console.ReadLine();
        }

       static void GetProductList()

        {
            Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Coca Cola - 120$");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2. Pepsi - 100$");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("3. Fanta - 80$");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static bool CheckMoney(int cost)
        {
            if (money < cost) return false;



            var newmoney = money - cost;
            money = newmoney;
            return true; 
        }

        static void GiveMoney(int count)
        {
            Clear();
            money += count;
            
            Console.Write($"We succesfully transfer you"); 
            ChangeColor(ConsoleColor.Green);
            Console.Write($" {count}$");
            Sleep(2000);
            Clear();



        }

        static void ChangeColor(ConsoleColor color)
        {
            Console.ForegroundColor = color; 
        }       
        static void Sleep(int time)
        {
            Thread.Sleep((int)time);
        }
        static void Clear()
        { Console.Clear(); }
}
}
