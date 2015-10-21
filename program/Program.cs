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
                        else if  (age > 20)
                        {
                            Console.Clear();
                            Console.WriteLine(" it is impossible age for cats");
                        }
                        else
                        {

                            var cat1 = new Cat(age, 5, "green", "white");
                            while (menu != 0)
                            {
                                if (cat1.Health != 0)
                                {
                                    Console.Clear();
                                    if (string.IsNullOrEmpty(cat1.Name) == false)
                                        Console.WriteLine(string.Format("\ncat's name is " + cat1.Name));
                                    Console.WriteLine(string.Format("cat's age is " + cat1.Age));
                                    if (string.IsNullOrEmpty(cat1.CurrentColor) == false)
                                        Console.WriteLine(string.Format("cat's current color is " + cat1.CurrentColor));
                                    //Console.WriteLine(string.Format("cat's age is " + cat1.Age));
                                    Console.WriteLine(string.Format("cat's current HP is " + cat1.Health));
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
                                                while(submenu != 0)
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
                                                int numbcolor;
                                                Console.Clear();
                                                Console.WriteLine("1 - set the cat's healthy color");
                                                Console.WriteLine("2 - set the cat's sick color");
                                                Console.WriteLine("0 - exit");
                                                submenu = Convert.ToInt32(Console.ReadLine());
                                                switch (submenu)
                                                {
                                                    case 1:
                                                        Console.Clear();
                                                        Console.WriteLine("1-red");
                                                        Console.WriteLine("2-green");
                                                        Console.WriteLine("3-blue");
                                                        Console.WriteLine("4-yellow");
                                                        Console.WriteLine("5-pink");
                                                        Console.WriteLine("6-purple");
                                                        Console.WriteLine("7-black");
                                                        Console.WriteLine("8-white");
                                                        numbcolor = Convert.ToInt32(Console.ReadLine());
                                                        switch (numbcolor)
                                                        {
                                                            case 1:
                                                                cat1.Color.HealthyColor = "red";
                                                                break;
                                                            case 2:
                                                                cat1.Color.HealthyColor = "green";
                                                                break;
                                                            case 3:
                                                                cat1.Color.HealthyColor = "blue";
                                                                break;
                                                            case 4:
                                                                cat1.Color.HealthyColor = "yellow";
                                                                break;
                                                            case 5:
                                                                cat1.Color.HealthyColor = "pink";
                                                                break;
                                                            case 6:
                                                                cat1.Color.HealthyColor = "purple";
                                                                break;
                                                            case 7:
                                                                cat1.Color.HealthyColor = "black";
                                                                break;
                                                            case 8:
                                                                cat1.Color.HealthyColor = "white";
                                                                break;
                                                        }
                                                        break;
                                                    case 2:
                                                        Console.Clear();
                                                        Console.WriteLine("1-red");
                                                        Console.WriteLine("2-green");
                                                        Console.WriteLine("3-blue");
                                                        Console.WriteLine("4-yellow");
                                                        Console.WriteLine("5-pink");
                                                        Console.WriteLine("6-purple");
                                                        Console.WriteLine("7-black");
                                                        Console.WriteLine("8-white");
                                                        numbcolor = Convert.ToInt32(Console.ReadLine());
                                                        switch (numbcolor)
                                                        {
                                                            case 1:
                                                                cat1.Color.SickColor = "red";
                                                                break;
                                                            case 2:
                                                                cat1.Color.SickColor = "green";
                                                                break;
                                                            case 3:
                                                                cat1.Color.SickColor = "blue";
                                                                break;
                                                            case 4:
                                                                cat1.Color.SickColor = "yellow";
                                                                break;
                                                            case 5:
                                                                cat1.Color.SickColor = "pink";
                                                                break;
                                                            case 6:
                                                                cat1.Color.SickColor = "purple";
                                                                break;
                                                            case 7:
                                                                cat1.Color.SickColor = "black";
                                                                break;
                                                            case 8:
                                                                cat1.Color.SickColor = "white";
                                                                break;
                                                        }
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
                                                if (cat1.Health > 1)
                                                {
                                                    Console.Clear();
                                                    cat1.Punish();
                                                    Console.WriteLine("cat has been successfully punished");
                                                    Console.WriteLine("enter 0 to exit");
                                                    submenu = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }

                                                if (cat1.Health == 1)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("you can kill the cat if continue punishing, do you like to continue? ");
                                                    Console.WriteLine("enter 1 to continue or 0 to exit");
                                                    submenu = Convert.ToInt32(Console.ReadLine());
                                                    if (submenu == 1)
                                                        cat1.Punish();
                                                }
                                                if (submenu == 1)
                                                    submenu = 0;
                                            }
                                            submenu = 4;
                                            break;

                                        case 4:                                           
                                            while (submenu != 0)
                                            {
                                                if (cat1.Health >= 1 && cat1.Health < 5)
                                                {
                                                    Console.Clear();
                                                    cat1.Feed();
                                                    Console.WriteLine("cat has been successfully fed");
                                                    Console.WriteLine("enter 0 to exit");
                                                    submenu = Convert.ToInt32(Console.ReadLine());
                                                }
                                                if (submenu > 1)
                                                {
                                                    if (cat1.Health == 5)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("XP are fuel, you don't need to feed the cat");
                                                        Console.WriteLine("enter 0 to exit");
                                                        submenu = Convert.ToInt32(Console.ReadLine());
                                                    }
                                                } 
                                            }
                                            submenu = 4;
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("you have killed the cat.");
                                    menu = 0;
                                }
                            }
                        }
                        break;
                    }
                }  
            }
        }
    }
