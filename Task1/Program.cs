//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (3, 5 -> 243 (3⁵); 2, 4 -> 16)

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int count = 2;
int result = numberA;
while (count <= numberB)
{
    result = result * numberA;
    count++;
}

Console.WriteLine(result);

