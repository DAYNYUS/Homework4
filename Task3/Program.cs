// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом 
//  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 
//  6, 1, 33 -> [6, 1, 33]
Console.Write("Введите количество элементов массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите массив: ");
int[] array = new int[N];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
}

PrintArray(array);