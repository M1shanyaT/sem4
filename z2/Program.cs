// Задача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число -> ");
int N = int.Parse(Console.ReadLine());
int A = N;
int result = 0;   
if (N > 0)
{
    while (N > 0)
    {
        int number = N % 10;   //5
        result = number + result;   //11
        N = N /10;   //345
    }
    Console.WriteLine($"Сумма цифр числа {A} -> {result}");
}
else
{
    Console.WriteLine("Число отрицательное.");
}

