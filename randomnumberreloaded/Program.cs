using System;
using System.Timers;

namespace randomnumberreloaded
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"███╗   ██╗██╗   ██╗███╗   ███╗██████╗ ███████╗██████╗     ██████╗ ██╗██████╗ ██████╗ ██╗     ███████╗
████╗  ██║██║   ██║████╗ ████║██╔══██╗██╔════╝██╔══██╗    ██╔══██╗██║██╔══██╗██╔══██╗██║     ██╔════╝
██╔██╗ ██║██║   ██║██╔████╔██║██████╔╝█████╗  ██████╔╝    ██████╔╝██║██║  ██║██║  ██║██║     █████╗  
██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██╗██╔══╝  ██╔══██╗    ██╔══██╗██║██║  ██║██║  ██║██║     ██╔══╝  
██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██████╔╝███████╗██║  ██║    ██║  ██║██║██████╔╝██████╔╝███████╗███████╗
╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝    ╚═╝  ╚═╝╚═╝╚═════╝ ╚═════╝ ╚══════╝╚══════╝
                                                                                                     ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Made by Dijar (Github: YungBeatz / Discord: yungbeatz#0295) \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guess the number! (Hint: the number is between 1 and 100)");


            Random rd = new Random();
            int rand_num = rd.Next(1, 100);
            int attempts = 0;
            Console.WriteLine(rand_num);
            bool found = false;

            while (found == false)
            {
                string userinput = Console.ReadLine();
                attempts++;
                if (int.TryParse(userinput, out int test))
                {
                    int usernumber = int.Parse(userinput);
                    if (usernumber == rand_num)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{rand_num} was the right number! GG!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"It took you {attempts} attempts to find out the right number!");
                        found = true;
                    }
                    else
                    {

                        if (usernumber < rand_num)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Your number is too small!");
                            Console.ForegroundColor = ConsoleColor.White;
                            attempts++;
                        }
                        else if (usernumber > rand_num)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Your number is too big!");
                            Console.ForegroundColor = ConsoleColor.White;
                            attempts++;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("An Error occured! Make sure to type in a number!");
                    Console.ForegroundColor = ConsoleColor.White;
                    attempts++;
                }
               
            }
        }
    }
}
