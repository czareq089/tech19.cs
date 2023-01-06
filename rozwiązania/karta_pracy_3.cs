/*//1
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine(Math.Pow(i, 3) + 3);
}
Console.WriteLine();

//2
for (int i = 105; i < 1000; i += 15)
{
    Console.WriteLine(i);
}
Console.WriteLine();


//3
int p = int.Parse(Console.ReadLine());
for (int i = 1; i < p + 1; i++)
{
    if (p % i == 0)
    {
        Console.WriteLine(i);
    }
}

//4
int suma = 0;
for (int c = 10; c < 100; c++)
{
    suma += c;
}
Console.WriteLine(suma);

//5
int n = int.Parse(Console.ReadLine());
int suma = n * (n+1) / 2;
int m;
for (int i = 1; i < n; i++)
{
    m = int.Parse(Console.ReadLine());
    suma = suma - m;
}
Console.WriteLine(suma);*/


//6
int n = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
int c = 0;
for (int i = 0; i < 2; i++)
{
    Console.WriteLine(i);
}
for (int j = 0; j < n-2; j++)
{
    c = a + b;
    Console.WriteLine(c);
    a = b;
    b = c;
}