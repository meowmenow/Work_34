using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ИСП-23, Бирюков Георгий, 13.12.21.
//Вставить за каждой запятой слово «пожалуйста» и запятую.
//Подсчитать количество запятых в строке.
//Удалить из строки цифры «0».


namespace Адовые_коды__12__Практическая_намбер_твелв_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Отправьте мой 0 прах в космос, когда 0 я умру.", //Строка с текстом
            sub1 = "пожалуйста, "; //Пожалуйста
            int i, 
            x,
            koll = 0; //Кол-во запятых
            Console.WriteLine("Исходная строка");
            Console.WriteLine(str);
            int sub2 = str.IndexOf("когда"); //Стоп-слово
            str = str.Insert(sub2, sub1);
            for (i = 0; i < str.Length; i++) //Просмотр строки
            {
                if (str[i] == ',') //Если символ запятая
                {
                    koll++; //Увеличиваем счётчик
                }
            }
            //Удаляем все нули
            str = str.Replace("0 ", "");
            Console.WriteLine("Обработанная строка");
            Console.WriteLine(str);
            Console.WriteLine("Кол-во запятых");
            Console.WriteLine("" + koll);
            Console.ReadKey(); //Пауза

        }
    }
}
