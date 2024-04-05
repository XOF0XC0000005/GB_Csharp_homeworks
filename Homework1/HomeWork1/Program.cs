using System;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Недопустимое количество аргументов.Требуется 3!");
                return;
            }

            if (int.TryParse(args[0], out int firstNum) && int.TryParse(args[2], out int secondNum))
            {
                switch (args[1])
                {
                    case "+":
                        Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
                        break;
                    case "-":
                        Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
                        break;
                    case "*":
                        Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
                        break;
                    case "/":
                        if (secondNum == 0)
                        {
                            Console.WriteLine("Попытка деления на 0.");
                            break;
                        }

                        Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
                        break;
                    default:
                        Console.WriteLine("Введите корректный знак!\nДоступные знаки: +, -, *, / \nЗнак должен идти вторым аргументом");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Операции могут быть произведены только с числами");
            }
        }
    }
}
