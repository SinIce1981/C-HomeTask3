// Задача 23 Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

void Zadacha23()
{
    Console.WriteLine("Задача 23");
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int counter = 1;
    while (counter <= number)
    {
        Console.WriteLine($"{counter}x3 = {counter * counter * counter}");
        counter++;
    }
}
Zadacha23();

void Zadacha19()
{
    Console.WriteLine("___________________________");
    Console.WriteLine("Задача 19");
    Console.WriteLine("Введите пятизначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int cifra1 = number / 10000;
    int cifra2 = number / 1000 % 10;
    int cifra4 = number / 10 % 10;
    int cifra5 = number % 10;

    if (cifra1 == cifra5)
    {
        if (cifra2 == cifra4)
        {
            Console.WriteLine("Введеное число является полиндромом");
        }
    }
    else
    {
        Console.WriteLine("Введеное число не является полиндромом");
    }
}

Zadacha19();

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

void Zadacha21()
{
    Console.WriteLine("___________________________");
    Console.WriteLine("Задача 21");
    Console.WriteLine("Введите координаты точки А: ");
    Console.WriteLine("X: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Y: ");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Z: ");
    int az = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты точки B: ");
    Console.WriteLine("X: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Y: ");
    int by = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Z: ");
    int bz = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Расстояние между точками А и В: {Math.Sqrt((Math.Pow((bx - ax), 2)+ Math.Pow((by - ay), 2)) + Math.Pow((bz - az), 2))}");
}
Zadacha21();