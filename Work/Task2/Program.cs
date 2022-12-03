// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();



int DataEntryXY(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return result;
}
int x1 = DataEntryXY("Введите координаты x1: ");
int y1 = DataEntryXY("Введите координаты y1: ");
int z1 = DataEntryXY("Введите координаты z1: ");
int x2 = DataEntryXY("Введите координаты x2: ");
int y2 = DataEntryXY("Введите координаты y2: ");
int z2 = DataEntryXY("Введите координаты z2: ");

double result = Distance(x1, x2, y1, y2, z1, z2);
Console.WriteLine("Растояние между точками: " + result);

