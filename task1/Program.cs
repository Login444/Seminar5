void ShowArray(int[] array) // способ  в котором функция просто показывает массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CreateRandomArray(int N, int start, int end)  // способ создания, в котором мы запросим у пользователя размерность и диапазон (генерируются рандомно)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
// int [] Array = CreateRandomArray(12, -9, 9);
// ShowArray(Array);

// int element = 0;

// for (int i=0; i < Array.Length; i++)
// {
//     Array[i] = Array[i]* -1;
// }

// ShowArray(Array);


// int [] Array = CreateRandomArray(12, -9, 9);
// ShowArray(Array);

// Console.WriteLine("Какое число ищем?");
// int figure = Convert.ToInt32(Console.ReadLine());
// int a = 0;

// for (int i = 0; i< Array.Length; i++)
// {
//     if (Array[i] == figure)
//     {
//         a = Array[i];
//     }
// }

// if (a !=0) 
// {
//     Console.WriteLine ($"Число {figure} присутствует в масиве");
// }
// else Console.WriteLine ($"Число {figure} отсутствует в масиве");

Console.Clear();
int [] Array = CreateRandomArray(123, -10, 123);
ShowArray(Array);
int count = 0;

 for (int i = 0; i< Array.Length; i++)
{
    if (Array[i]>=10 && Array[i]<=99)
    {
        count = count +1;
    }
}

Console.WriteLine($"В массиве ровно {count} чисел в диапазоне между 10 и 99");