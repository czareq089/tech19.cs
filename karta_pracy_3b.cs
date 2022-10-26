/*
//1
for (int i = 1; i < 31; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();


//2
for (int i = 1; i < 100; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine($"{i}^2 = { Math.Pow(i, 2)}");
    }
}
Console.WriteLine();


//3
for (int i = 1000; i < 10000; i++)
{
    if (i % 379 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();


//4

for (int i = 100; i < 1000; i++)
{
    if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();


//5
Console.WriteLine("Ile liczb wypisac: ");
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 1; i < n+1; i++)
{
    int c = int.Parse(Console.ReadLine());
    suma = suma + i;
}
Console.WriteLine(suma);
Console.WriteLine();


//6
int k = int.Parse(Console.ReadLine());
suma = 0;
for (int i = 2; i < (k * 2) + 2; i += 2)
{
    suma =+ i;
}
Console.WriteLine(suma);


//7
int m = int.Parse(Console.ReadLine());
suma = 0;
for (int i = 11; i < (m * 2) + 2; i += 11)
{
    suma =+ i;
}
Console.WriteLine(suma);
Console.WriteLine();


//8
Console.Write("Kapital poczatkowy: ");
int kp = int.Parse(System.Console.ReadLine());
Console.Write("Lata inwestycji: ");
int li = int.Parse(System.Console.ReadLine());
suma = kp;
for (int i = 0; i < li * 12; i++)
{
    kk = 0;
    kk = suma * 0.06 * 1 / 12f;
    suma = (int)+ kapKon;
}
Console.WriteLine($"Końcowy kapitał wynosi: {(suma, 2)} zl");
Console.WriteLine();



//9
Console.Write("Ile liczb: ");
int a = int.Parse(Console.ReadLine());
int b = 21;
suma = 0;
for (int i = 0; i <= a; i++)
{
    for (int c = 0; c < i; c += b)
    {
        Console.WriteLine(b);
        suma += b;
        b += 100;
    }
}
Console.WriteLine(suma);
Console.WriteLine();


//10
for (int i = 1; i < 1000; i++)
{
    if (i % 10 == Math.Sqrt(i)) 
    {
        Console.WriteLine(i);
    }
    if (i % 100 == Math.Sqrt(i)) 
    {
        Console.WriteLine(i);
    }
}
