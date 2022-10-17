// Написать программу, которая из имеющегося массива строк формирует массив строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//["hello","2","world",":-)"]->["2",":-)"]
//["1234","1567","-2","computer scinece"]->["-2"]
//["Russia","Denmark","Kazan"]->[]

using System;

Console.WriteLine("Введите любую строку разделяя слова пробелом, запятой или '/'");
string[] userString = Console.ReadLine()!.Split(' ', ',', '/');

string[] selectionArray = new string[CreateArray(userString)];

FillArray(userString, selectionArray);
PrintArray(selectionArray);



int CreateArray(string[] userArray) //определяем размер второго массива
{
    int sum = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
            sum++;
    }
    return sum;
}

void FillArray(string[] userArray, string[] selectionArray) //выполняем условие задачи
{
    int j = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
        {
            selectionArray[j] = userArray[i];
            j++;
        }
    }
}

void PrintArray(string[] Array) // выводим результат
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"{Array[i]}, ");
    }
}
