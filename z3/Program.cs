Console.Write("Введите число, обозначающее длинну массива -> ");
int sizeArray = int.Parse(Console.ReadLine());
Console.Write("Введите последовательно два числа, обозначющие интервал -> ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

int[] result = GetBinaryArray(sizeArray, number1, number2); 
Console.WriteLine($"[{String.Join("; ", result)}]");

int[] GetBinaryArray(int size, int A, int B)
{   
    int[] array = new int[size];    
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(A,B); 
    }
    return array;
}
