// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow (int number1, int number2)    //4, 5 =  4 4 4 4 4
{
    int numPow = 1;
    for (int i = 0; i < number2; i++)
    {
        numPow = numPow * number1;
    }
    return numPow;
}

Console.Write("Введите число, которое хотите возвести в степень -> ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число, которое будет обозначать степень -> ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"{Pow(A,B)}");
