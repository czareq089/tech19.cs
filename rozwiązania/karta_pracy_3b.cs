/*//1 
for (int i = 1; i < 31; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();

//2
for (int i = 1; i < 10; i += 2)
{
    Console.WriteLine(Math.Pow(i, 2));
}
Console.WriteLine();

//3 
for (int i = 1137; i < 10000; i += 379)
{
    Console.WriteLine(i);
}
Console.WriteLine();

//4
for (int i = 100; i < 1000; i++)
{
    if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0)
    {
        Console.WriteLine(i);
    }
}

//5
int n = int.Parse(Console.ReadLine());
int suma = 0;
int m;
for (int i = 0; i < n; i++)
{
    m = int.Parse(Console.ReadLine());
    suma = suma + m;
}
Console.WriteLine(suma);

//6 
int k = int.Parse(Console.ReadLine());
int suma = 0;

for (int i = 0; i < (k * 2) + 2; i++)
{
    if (i % 2 == 0)
    {
        suma = suma + i;
    }
}
Console.WriteLine(suma);



//7 

int suma = 0;
for (int i = 11; i < 101; i += 2)
{
    suma = suma + i;
}
Console.Write(suma);

//8
int kapPocz = int.Parse(Console.ReadLine());
int lataInw = int.Parse(Console.ReadLine());
double kapKon = 0;
suma = kapPocz;
for (int i = 0; i < lataInw * 12; i++)
{
    kapKon = suma * 0.06 * 1 / 12f;
    suma = (int)+kapKon;
}
Console.WriteLine(suma);

//9
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 21; i < n * 100; i += 100)
{
    suma = suma + i;
}
Console.WriteLine(suma);
*/
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