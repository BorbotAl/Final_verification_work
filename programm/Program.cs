// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] FillArray(int num)
{
    string[] array = new string[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Введите текст:");
        array[i] = Console.ReadLine();
    }
    return array;
}

int CountOfLessThree(string[] arr)
{
    int countOfLessThree = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) countOfLessThree++;
    }
    return countOfLessThree;
}

string[] ArrayOfLessThree(string[] arr, int count)
{
    string[] newArr = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }

    return newArr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите количество элементов массива:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    string[] array = FillArray(number);
    int count = CountOfLessThree(array);
    string[] newArray = ArrayOfLessThree(array, count);
    PrintArray(newArray);
}
else Console.WriteLine("Число должно быть натуральным");