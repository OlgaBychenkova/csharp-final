// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null) 
        {
            if (i < arr.Length - 1) Console.Write($"{arr[i]},");
            else Console.Write($"{arr[i]}");
        }
        
    }
    Console.WriteLine("]");
}

string[] array = new string[] { "Hello", "2", "world", ":-)"};
string[] array1 = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        array1[i] = array[i];
    }
}
PrintArray(array1);
