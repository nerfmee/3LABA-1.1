using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3лаба
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int input = 0;
            while (x == 0)
            {
                //вводится целое двухзначное число в шестеричной системе счисления
                input = Int32.Parse(Console.ReadLine());

                string[] engDigits = { "Zero", "One", "Two", "Three", "Four", "Five", "Six" };
                string[] rusDigits = { "Ноль", "Один", "Два", "Три", "Четыре", "Пять", "Шесть" };



                if (input > 99 || input < 10)
                {
                    Console.WriteLine("Это не двузначное положительное число!");
                    Console.ReadKey();
                    
                    return;
                }

                int units = input % 10;
                int tens = (input - units) / 10;

                switch (tens)
                   {
                        case 6:
                            Console.WriteLine("Это не шестеричное число");
                            goto end_switch;
                            
                        case 7:
                            Console.WriteLine("Это не шестеричное число");
                            goto end_switch;
                        case 8:
                            Console.WriteLine("Это не шестеричное число");
                            goto end_switch;
                        case 9:
                            Console.WriteLine("Это не шестеричное число");
                            goto end_switch;


                    }
                
                
                switch (units)
                {
                    case 6:
                        Console.WriteLine("Это не шестеричное число");

                            goto end_switch;
                        case 7:
                        Console.WriteLine("Это не шестеричное число");
                            goto end_switch;
                        case 8:
                        Console.WriteLine("Это не шестеричное число");
                            goto end_switch;
                        case 9:
                        Console.WriteLine("Это не шестеричное число");
                            goto end_switch;

                    }

               

                if (tens == units * 3) //если старшая цифра больше в три раза младшей
                
                    Console.WriteLine(rusDigits[tens] + " , " + rusDigits[units]);
                
                else
                
                    Console.WriteLine(engDigits[tens] + " , " + engDigits[units]);
                
            
            }
        end_switch:;
            Console.ReadKey();
        }
    }
}
