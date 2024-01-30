using System;

class Program
{
    static void Main(string[] args)
{   
    string rndText = "шалаш";
    char[] reverseText = rndText.ToCharArray();
  
    Array.Reverse(reverseText);
    string finalText = new string(reverseText);
    
    if (rndText == finalText)
    {
        Console.WriteLine("Данная запись является палиндромом");
    }
    else
    {
        Console.WriteLine("Данная запись не является палиндромом");
    }
}
}