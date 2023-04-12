using System;

namespace New_All_Task

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите число, соответствующее заданию:");
            Console.WriteLine("1 - Посмтреть задачу номер 2");
            Console.WriteLine("2 - Посмотреть задачу номер 4");
            Console.WriteLine("3 - Посмотреть задачу номер 6");
            Console.WriteLine("4 - Посмтреть задачу номер 6");

            string input4 = Console.ReadLine();
            int menu = int.Parse(input4);

            if ( menu == 1)
            {
                Console.WriteLine("Привет! А сейчас я попробую определить максимальное число из введеных тобою трех чисел");
                Console.WriteLine("Введите первое число");
                string input = Console.ReadLine();
                int num1 = int.Parse(input);
                Console.WriteLine("Введите второе число");
                string input2 = Console.ReadLine();
                int num2 = int.Parse(input2);
                Console.WriteLine("Введите третье число");
                string input3 = Console.ReadLine();
                int num3 = int.Parse(input3);

                int max = num1;
                if (num1 > max) max = num1;
                if (num2 > max) max = num2;
                if (num3 > max) max = num3;

                Console.Write(max);
                Console.WriteLine(" - Максимальное число");
            }

            if (menu == 2)
            {
                Console.WriteLine("Привет! А сейчас я попробую определить максимальное число из введеных тобою трех чисел");
                Console.WriteLine("Введите первое число");
                string input = Console.ReadLine();
                int num1 = int.Parse(input);
                Console.WriteLine("Введите второе число");
                string input2 = Console.ReadLine();
                int num2 = int.Parse(input2);
                Console.WriteLine("Введите третье число");
                string input3 = Console.ReadLine();
                int num3 = int.Parse(input3);

                int max = num1;
                if (num1 > max) max = num1;
                if (num2 > max) max = num2;
                if (num3 > max) max = num3;

                Console.Write(max);
                Console.WriteLine(" - Максимальное число");
            }
            
            if (menu == 3)
            {
                Console.WriteLine("Введите число, а я определю, четное это число или нет");
                string input = Console.ReadLine();
                int num = int.Parse(input);

                if (num % 2 == 0) 
                {
                    Console.WriteLine("Введенное вами число - является четным");
                }
                else{
                Console.WriteLine("Введенное вами число - является нечетным");
                }
            }
            if (menu == 4)
            {
                Console.WriteLine("Введите число");
                string input = Console.ReadLine();
                int num = int.Parse(input);

                for (int n=0; n<=num; n++){
                if (n%2==0)
                {
                    Console.WriteLine(n);
                }
                }
            }
            else{
            Console.WriteLine("Вы набрали не на ту кнопку!");
            
            }
        }
    }
    }