﻿using System;

class Program
{
    static void Main(string[] args)
    {   // Создаем строку содержащую буквы разного регистра
        string stringOfLetters = "WoRdS";
        // Изменяем регистр букв в строке
        string result = stringOfLetters.ToLower();
        Console.WriteLine(result);
    }
}