// Напишите программу которая принимает на вход пятизначное число и проявляет является ли оно палиндромом
// 14212 -> нет
// 12821 -> нет
// 23432 -> да


Console.Clear();

void DataEntry(string str)
{

    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int Digit1 = number / 10000;
    int Digit2 = number % 10;
    int Digit3 = (number / 1000) % 10;
    int Digit4 = (number / 10) % 10;

    if (Digit1 == Digit2 && Digit3 == Digit4)
    {
        Console.WriteLine(" Число " + number + " является полиндромом ");
    }
    else
    {
        Console.WriteLine(" Число " + number + "  не является полиндромом ");
    }
}
DataEntry("Введите число: ");
