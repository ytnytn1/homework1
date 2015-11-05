using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {

            int menu;
            int age;
            int submenu = 4;
            Console.WriteLine("\n1 - buy a cat");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            while (true)
            {
                switch (menu)
                {
                    case 1:

                        Console.WriteLine("\nset age of the cat");
                        Console.WriteLine("\nremember u can set the age only once");
                        age = Convert.ToInt32(Console.ReadLine());
                        if (age == 0)
                        {
                            Console.Clear();
                            Console.WriteLine(" u can't buy cat with the age of 0");
                        }
                        else
                        {

                            var cat1 = new Cat(age, 5, "green", "white");
                            while (menu != 0)
                            {

                                Console.Clear();
                                if (string.IsNullOrEmpty(cat1.Name) == false)
                                    Console.WriteLine(string.Format("\ncat's name is " + cat1.Name));
                                Console.WriteLine(string.Format("cat's age is " + cat1.Age));
                                if (string.IsNullOrEmpty(cat1.CurrentColor) == false)
                                    Console.WriteLine(string.Format("cat's current color is " + cat1.CurrentColor));
                                Console.WriteLine("................................................................");
                                Console.WriteLine("1 - set the name of the cat ");
                                Console.WriteLine("2 - set the color of the cat ");
                                Console.WriteLine("3 - punish the cat ");
                                Console.WriteLine("4 - feed the cat ");
                                menu = Convert.ToInt32(Console.ReadLine());
                                switch (menu)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("set the cat's name");
                                        Console.WriteLine("\nremember u can set the name only once");
                                        if (string.IsNullOrEmpty(cat1.Name) == true)
                                            cat1.Name = Console.ReadLine();
                                        else
                                        {
                                            while (submenu != 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("you have already set the cat's name");
                                                Console.WriteLine("press 0 to exit");
                                                submenu = Convert.ToInt32(Console.ReadLine());
                                            }
                                            submenu = 4;
                                        }
                                        break;
                                    case 2:
                                        submenu = 4;
                                        while (submenu != 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("1 - set the cat's healthy color");
                                            Console.WriteLine("2 - set the cat's sick color");
                                            Console.WriteLine("0 - exit");
                                            submenu = Convert.ToInt32(Console.ReadLine());
                                            switch (submenu)
                                            {
                                                case 1:
                                                    cat1.Color.HealthyColor = Console.ReadLine();
                                                    break;
                                                case 2:
                                                    cat1.Color.SickColor = Console.ReadLine();
                                                    break;

                                                case 0:
                                                    break;
                                            }
                                        }
                                        submenu = 4;
                                        break;

                                    case 3:
                                        while (submenu != 0)
                                        {
                                           
                                            Console.Clear();
                                            cat1.Punish();
                                            Console.WriteLine("cat has been successfully punished");
                                            Console.WriteLine("enter 0 to exit");
                                            submenu = Convert.ToInt32(Console.ReadLine());
                                            break;
                                      
                                        }
                                        submenu = 4;
                                        break;

                                    case 4:
                                        while (submenu != 0)
                                        {
                                            Console.Clear();
                                            cat1.Feed();
                                            Console.WriteLine("cat has been successfully fed");
                                            Console.WriteLine("enter 0 to exit");
                                            submenu = Convert.ToInt32(Console.ReadLine());
                                        }
                                        submenu = 4;
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}
   
