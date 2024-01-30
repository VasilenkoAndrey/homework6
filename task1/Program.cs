using System; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        
        char[,] rndArray = new char[4, 4]{ 
        {'$', 'h', 'e', 'l'}, 
        { '_', 'l', '0', 'w'}, 
        { '0', 'r', '!', 'd'}, 
        { '2', '*', '2', '4'}}; 
        string newString = " "; 
        for (int i = 0; i < rndArray.GetLength(0); i++) 
        { 
            for (int j = 0; j < rndArray.GetLength(1); j++) 
            { 
                newString += rndArray[i, j].ToString(); 
            } 
        } 
        Console.WriteLine(newString); 
    } 
}