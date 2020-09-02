using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = "Color";
            string exit = "Exit";
            string clear = "Clear";
            string setPassword = "setPass";
            string password;
            string name = "Name";
            string writeName = "writeName";
            string maxTryPassword = "MaxTryPass";
            string userInput;
            bool enterOrExit = true;
            int maxTryPass = 3;

            Console.Write("Придумайте пароль : ");
            password = Console.ReadLine();
            while (enterOrExit)
            {
                Console.WriteLine($"{color} - изменить цвет консоли");
                Console.WriteLine($"{clear} - очистить консоль");
                Console.WriteLine($"{setPassword} - изменить пароль");
                Console.WriteLine($"{name} - установить имя");
                Console.WriteLine($"{writeName} - вывести имя");
                Console.WriteLine($"{maxTryPassword} - изменить максимальное кол-во ввода пароля неправильно");
                Console.WriteLine($"{exit} - выход ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "Color":
                        Console.WriteLine("Выберите желаемый цвет консоли : ");
                        Console.WriteLine("1 - Зеленый");
                        Console.WriteLine("2 - Красный");
                        Console.WriteLine("3 - Черный");
                        Console.WriteLine("4 - Желтый");
                        Console.WriteLine("5 - Синий");
                        userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();
                                break;

                            case "2":
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                break;

                            case "3":
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                break;

                            case "4":
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.Clear();
                                break;

                            case "5":
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                break;
                                
                }
                        
                        break;

                    case "Clear":
                        Console.Clear();
                        break;

                    case "setPass":
                        for (int i = 0; i < maxTryPass; i++)
                        {
                            Console.Write("Введите старый пароль : ");
                            userInput = Console.ReadLine();
                            if (userInput == password)
                            {
                                Console.WriteLine($"Введите новый пароль : ");
                                password = Console.ReadLine();                                
                            }
                            else
                            {
                                Console.WriteLine($"У вас осталось {maxTryPass - (i + 1)} попыток.");
                            }
                        }
                        break;

                    case "Name":
                        Console.Write("Введите ваше имя : ");
                        name = Console.ReadLine();
                        break;

                    case "MaxTryPass":
                        Console.Write("Введите кол-во ввода пароля неправильно : ");
                        maxTryPassword = Console.ReadLine();
                        break;

                    case "writeName":
                        for (int i = 0; i < maxTryPass; i++)
                        {
                            Console.Write("Введите пароль для вывода имени : ");
                            userInput = Console.ReadLine();
                            if (userInput == password)
                            {
                                Console.WriteLine($"Ваше имя {name}.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine($"У вас осталось {maxTryPass - (i + 1)} попыток.");
                            }
                        }
                        break;

                    case "Exit":
                        enterOrExit = false;                        
                        break;
                }
            }
        }
    }
}
