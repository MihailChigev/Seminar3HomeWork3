// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

void TableCubes(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        Console.Write(count * count * count + " ");
        count++;
    }
    Console.WriteLine();

}

TableCubes("Введите число N: ");
