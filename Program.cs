//**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

Console.WriteLine();
Console.WriteLine("Final HomeWork");
Console.WriteLine();


string [] words = {"Do", "No", "Make", "your", "job", "well", "!!!"};

string[] LongWords(string[] array)
{   
     
    for (int i = 0; i < array.Length; i++)
        if(array[i].Length >= 3) Console.Write(array[i] + " ");
        return array;
}

LongWords(words);
Console.WriteLine();