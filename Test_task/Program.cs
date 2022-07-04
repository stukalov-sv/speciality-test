/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/

// Метод возвращающий вводимый пользователем массив строк, заданного размера
string[] InitArray(int length)
{
    string[] array = new string[length];

    for (int i = 0; i < length; i++)
    {
        if (i < length - 1)
        {
            Console.Write($"Enter {i + 1} element of array: ");
            array[i] = Convert.ToString(Console.ReadLine());
        }
        else
        {
            Console.Write($"Enter last element of array: ");
            array[i] = Convert.ToString(Console.ReadLine());
        }
    }
    return array;
}

// Метод, формирующий массив из элементов задаваемого массива, длина, которых меньше или равна 3 символам
string[] ArrayTaskTransformation(string[] array)
{
    string[] tempArray = new string[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) 
        {
            tempArray[i] = array[i];
            count++;
        }
        else
            tempArray[i] = "0000";
    }
   
    string[] resultArray = new string[count];
    int index = 0;
    int j = 0;

    while (j < count)
    {
        if (tempArray[index] == "0000")
        { 
            index++;
        }
        else
        {
            resultArray[j] = tempArray[index];
            index++;
            j++;
        }
    }
    return resultArray;
}

// Метод, выводящий массивы строк

void PrintArray(string[] array)
{
    Console.Write("[");

    for(int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) 
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }

    Console.Write("]");
}

Console.WriteLine("Enter array size: ");
int length = int.Parse(Console.ReadLine());
string[] array = InitArray(length);

Console.WriteLine("Original array: ");
PrintArray(array);

string[] result = ArrayTaskTransformation(array);

Console.WriteLine();
Console.WriteLine("Result array: ");
PrintArray(result);