using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomoworkCSarp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //задание 1
            //Пользователь вводит с клавиатуры число в диапазоне от 1 до 100.Если число кратно 3(делится на 3 без
            //остатка) нужно вывести слово Fizz. Если число кратно 5
            //нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
            //вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
            //вывести само число.
            //Если пользователь ввел значение не в диапазоне от 1
            //до 100 требуется вывести сообщение об ошибке.

            //int num;
            //Console.WriteLine("Введите число в диапазоне от 1 до 100");
            //num = Convert.ToInt32(Console.ReadLine());
            //if (num >= 1 && num <= 100)
            //{
            //    if (num % 3 == 0 && num % 5 == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz");
            //    }else if (num % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }else if (num % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка");
            //}


            // задание 2

            //Пользователь вводит с клавиатуры два числа. Первое
            //число — это значение, второе число процент, который
            //необходимо посчитать. Например, мы ввели с клавиатуры
            //90 и 10.Требуется вывести на экран 10 процентов от 90.
            //Результат: 9.

            //int percent;
            //double number;
            //Console.WriteLine("Введите число и процент");
            //number  = Convert.ToDouble(Console.ReadLine());
            //percent = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Получилось " + ((number / 100) * percent));


            //задание 3

            //Пользователь вводит с клавиатуры четыре цифры. 
            //Необходимо создать число, содержащее эти цифры.Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
            //сформировать число 1578.

            //string number;
            //Console.WriteLine("Введите 4 числа");
            //number = Console.ReadLine();
            //number +=Console.ReadLine();
            //number += Console.ReadLine();
            //number += Console.ReadLine();
            //Console.WriteLine(number);

            //задание4

            //Пользователь вводит шестизначное число. После чего
            //пользователь вводит номера разрядов для обмена цифр.
            //Например, если пользователь ввёл один и шесть — это
            //значит, что надо обменять местами первую и шестую
            //цифры.
            //Число 723895 должно превратиться в 523897.
            //Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.


            //Console.WriteLine("Введите шестизначное число:");
            //string num = Console.ReadLine();
            //if(num.Length == 6)
            //{
            //    char[] n = num.ToCharArray();
            //    Console.WriteLine("Введите первую позицию:");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Введите вторую позицию позицию:");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    char temp = n[a];
            //    n[a] = n[b];
            //    n[b] = temp;                
            //    Console.WriteLine(n);
            //}
            //else
            //{
            //    Console.WriteLine("Не шестизначное число");
            //}

            //задание 5

            //Пользователь вводит с клавиатуры дату.Приложение должно отобразить название сезона и дня недели. 
            //Например, если введено 22.12.2021, приложение должно
            //отобразить Winter Wednesday.

            //DateTime day = Convert.ToDateTime(Console.ReadLine());
            //if(day.Month < 4)
            //{
            //    Console.WriteLine("Winter " + day.DayOfWeek);
            //}
            //else if(day.Month > 3 && day.Month < 6)
            //{
            //    Console.WriteLine("Spring " + day.DayOfWeek);
            //}
            //else if (day.Month > 3 && day.Month < 6)
            //{
            //    Console.WriteLine("Summer " + day.DayOfWeek);
            //}
            //else if (day.Month > 3 && day.Month < 6)
            //{
            //    Console.WriteLine("autumn " + day.DayOfWeek);
            //}
            //else
            //{
            //    Console.WriteLine("Не правильная дата");
            //}

            //задание 6

            //Пользователь вводит с клавиатуры показания температуры.В зависимости от выбора пользователя программа
            //переводит температуру из Фаренгейта в Цельсий
            //или наоборот

            //Console.WriteLine("Введите градусы в цельсиях");
            //double temper = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("По цельсию - " + temper);
            //Console.WriteLine("По фуренгейту - " + ((temper * 9 / 5) + 32));

            //задание 7

            //Пользователь вводит с клавиатуры два числа. Нужно
            //показать все четные числа в указанном диапазоне. Если
            //границы диапазона указаны неправильно требуется произвести нормализацию границ.Например, пользователь
            //ввел 20 и 11, требуется нормализация, после которой
            //начало диапазона станет равно 11, а конец 20

            int A, B, C, D;

            Console.WriteLine("Введите первое число - ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторе число - ");
            B = Convert.ToInt32(Console.ReadLine());
            C = (A > B) ? B : A;
            D = (A < B) ? B : A;
            
            for(int i = C; i <= D; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
