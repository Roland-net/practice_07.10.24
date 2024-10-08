using System;
using System.Security.Cryptography.X509Certificates;

namespace fournumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Выберите задание: \n 1 - среднее арифметическое\n 2 - калькулятор\n 3 - градусы\n 4 - найти нужный файл\n 5 - самое длинное слово в предложение\n 6 - счетчик массивов\n 7 - макс/мин число\n 8 - пирамида");
            int numberOfTasks = Convert.ToInt32(Console.ReadLine());
            if (numberOfTasks == 1)
            {
                Console.WriteLine("введите первое число:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите второе число:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите третье число:");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите четвертое число:");
                int d = Convert.ToInt32(Console.ReadLine());
                double summ = Convert.ToDouble(a + b + c + d) / 4;
                Console.WriteLine($"Среднее значение {a}, {b}, {c}, {d} равно: " + summ);
            }
            //2
            if (numberOfTasks == 2)
            {
                float one, two, result;
                char sign;
                Console.WriteLine("вам необходимо ввести значения, используя знаки: +, -, *, /");
                Console.Write("введите первое число: ");
                one = Convert.ToSingle(Console.ReadLine());
                Console.Write("введите знак действия : ");
                sign = Convert.ToChar(Console.ReadLine());
                Console.Write("введите второе число: ");
                two = Convert.ToSingle(Console.ReadLine());
                if (sign == '+')
                {
                    result = one + two;
                    Console.WriteLine("сумма ваших чисел равна " + result);
                    Console.WriteLine("для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
                else if (sign == '-')
                {
                    result = one - two;
                    Console.WriteLine("разность ваших чисел равна " + result);
                    Console.WriteLine("для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
                else if (sign == '*')
                {
                    result = one * two;
                    Console.WriteLine("произведение ваших чисел равно " + result);
                    Console.WriteLine("для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
                else if (sign == '/')
                {
                    if (two == 0)
                    {
                        Console.WriteLine("делитель не может быть равнен нулю.");
                        Console.WriteLine("для выхода нажмите любую клавишу...");
                        Console.ReadKey();
                    }
                    else
                    {
                        result = one / two;
                        Console.WriteLine("частное ваших чисел равна " + result);
                        Console.WriteLine("для выхода нажмите любую клавишу...");
                        Console.ReadKey();
                    }


                }
                else
                {
                    Console.WriteLine("вы ввели неверный знак.");
                    Console.WriteLine("для выхода нажмите любую клавишу...");
                    Console.ReadKey();

                }
                //3
                if (numberOfTasks == 3)
                {
                    int Degrees = Convert.ToInt32(Console.ReadLine()); 
                    if (Degrees == 1)
                    {
                        Console.Write("Введите показатель температура (градусы)\n"); 
                        double IndicatorС = Convert.ToDouble(Console.ReadLine()); 
                        Console.Write("Выберите тип шкалы для конвертации:\r\n1. Цельсий\r\n2. Кельвин\r\n3. Фаренгейт\n");
                        int Variant = Convert.ToInt32(Console.ReadLine()); 
                        if (Variant == 1)
                        {
                            Console.Write("Вы не можете конвертировать один и тот же тип градусов\n");
                            Console.WriteLine(IndicatorС);
                        }
                        if (Variant == 2)
                        {
                            double Answer = Convert.ToDouble(IndicatorС + 273.15);
                            Console.WriteLine(Answer);
                        }
                        if (Variant == 3)
                        {
                            double Answer = Convert.ToDouble((IndicatorС * 9 / 5) + 32);
                            Console.WriteLine(Answer);
                        }
                    }
                    if (Degrees == 2)
                    {
                        Console.Write("Введите показатель температура (градусы)\n"); 
                        double IndicatorС = Convert.ToDouble(Console.ReadLine()); 
                        Console.Write("Выберите тип шкалы для конвертации:\r\n1. Цельсий\r\n2. Кельвин\r\n3. Фаренгейт\n");
                        int Variant = Convert.ToInt32(Console.ReadLine()); 
                        if (Variant == 1)
                        {
                            double Answer = Convert.ToDouble(IndicatorС - 273.15);
                            Console.WriteLine(Answer);
                        }
                        if (Variant == 2)
                        {
                            Console.Write("Вы не можете конвертировать один и тот же тип градусов\n");
                            Console.WriteLine(IndicatorС);
                        }
                        if (Variant == 3)
                        {
                            double Answer = Convert.ToDouble((IndicatorС - 273.15) * 9 / 5 + 32);
                            Console.WriteLine(Answer);
                        }
                    }
                    if (Degrees == 3)
                    {
                        Console.Write("Введите показатель температура (градусы)\n"); 
                        double IndicatorС = Convert.ToDouble(Console.ReadLine()); 
                        Console.Write("Выберите тип шкалы для конвертации:\r\n1. Цельсий\r\n2. Кельвин\r\n3. Фаренгейт\n");
                        int Variant = Convert.ToInt32(Console.ReadLine()); 
                        if (Variant == 1)
                        {
                            double Answer = Convert.ToDouble((IndicatorС - 32) * 5 / 9); 
                            Console.WriteLine(Answer);
                        }
                        if (Variant == 2)
                        {
                            double Answer = Convert.ToDouble((IndicatorС - 32) * 5 / 9 + 273.15); 
                            Console.WriteLine(Answer);
                        }
                        if (Variant == 3)
                        {
                            Console.Write("Вы не можете конвертировать один и тот же тип градусов\n"); 
                            Console.WriteLine(IndicatorС);
                        }
                        //4
                        if (numberOfTasks == 4)
                        {
                            try
                            {
                                Console.WriteLine("enter ur path");
                                string str = Console.ReadLine();
                                string[] parts = str.Split('/');
                                Console.WriteLine(parts[parts.Length - 1]);
                            }
                            catch
                            {
                                Console.WriteLine("u entered the wrong value");
                            }
                            
                        }
                    }
                }
            }
            //5
            if (numberOfTasks == 5)
            {   
                Console.WriteLine("напишите любое предложение");
                var s = Console.ReadLine();
                Console.WriteLine("исходное предложение: {0}", s);
                var words = s.Split(new[] { ' ', ',', ';', '.' });
                string maxWord = "";
                foreach (var word in words)
                {
                    if (word.Length > maxWord.Length)
                        maxWord = word;
                }
                Console.WriteLine("самое длинное слово: {0} его длина: {1}", maxWord, maxWord.Length);
                Console.WriteLine();                                                                          
            }
            //6
            if (numberOfTasks == 6)
            {
                Random r = new Random();
                int[,] array = new int[2, 2];
                int[,] array2 = new int[2, 2];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = r.Next(-10, 10);
                        Console.Write(" {0,2}", array[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("{0,4}", "*");
                for (int i = 0; i < array2.GetLength(0); i++)
                {
                    for (int j = 0; j < array2.GetLength(1); j++)
                    {
                        array2[i, j] = r.Next(-10, 10);
                        Console.Write("{0,2}", array2[i, j]);
                    }
                    Console.WriteLine() ;
                }
                Console.WriteLine("{0,4}", "=");
                for (int i = 0; i < array2.GetLength(0); i++)
                {
                    for (int j = 0; j < array2.GetLength(1); j++)
                    {
                        Console.Write("{0,2}", array[i, j] * array2[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            //7
            try
            {
                Console.WriteLine("enter ur five numbers separated be space");
                string str = Console.ReadLine();
                string[] parts = str.Split(' ');

                int maxnum = -999999999;
                int minnum = 999999999;

                for (int i = 0;i < parts.Length; i++)
                {
                    if (maxnum < Convert.ToInt32(parts[i]))
                    {
                        maxnum = Convert.ToInt32(parts[i]);
                    }
                }
                for (int i = 0; i < parts.Length; i++)
                {
                    if (minnum > Convert.ToInt32(parts[i]))
                    {
                        minnum = Convert.ToInt32(parts[i]);
                    }
                }
                Console.WriteLine($"the max number is {maxnum}");
                Console.WriteLine($"the min number is {minnum}");
            }
            catch
            {
                Console.WriteLine("u entered the wrong value");
            }
            //8
            try
            {
                Console.WriteLine("enter the number of steps");
                int steps = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                string pyromid = "";
                for (int i = 1; i <= steps; i++)
                {
                    pyromid += i;
                    Console.WriteLine(pyromid);
                }
            }
            catch
            {
                Console.WriteLine("u entered the wrong value");
            }
            
        }
    }
}


