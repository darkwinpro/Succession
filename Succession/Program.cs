using System;

public class Program
{
    public static void Main()
    {
        var startChar = Convert.ToChar(Console.ReadLine());     //начальный символ
        var endChar = Convert.ToChar(Console.ReadLine());       //конечный символ
        char[] chars = new char[endChar - startChar + 1];       // инициализируем массив символов, включая endChar
        
        for (var i = 0; i < chars.Length; i++)              //заполняем массив символами
        {
            chars[i] = (char)(startChar + i); 
        }

        foreach (var element1 in chars)                 //обход всех вариантов в 3м цикле
        {
            foreach (var element2 in chars)
            {
                foreach (var element3 in chars)
                {
                    Console.WriteLine(String.Concat(element1, element2, element3)); // вывод строки из символов
                }
            }
        }
    }
}