/* 1
Console.WriteLine("Wprowadź liczbę 1: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 2: ");
int b = int.Parse(Console.ReadLine());
    
if ((a + b) % 2 == 0)
        Console.WriteLine("liczba jest parzysta");
else
        Console.WriteLine("liczba nie jest parzysta");
*/

/* 2
 using System;

Console.WriteLine("Wprowadź liczbę 1: ");
int a = int.Parse(System.Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 2: ");
int g = int.Parse(System.Console.ReadLine());

if ((a+g)/ 2 > Math.Sqrt(a * g))
        Console.WriteLine("tak, średnia arytmetyczna jest większa");
else 
        Console.WriteLine("nie, średnia arytmetyczna jest mniejsza");
*/

/* 3
 using System;
Console.WriteLine("Wprowadź liczbę 1: ");
int k = int.Parse(System.Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 2: ");
int l = int.Parse(System.Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 3: ");
int m = int.Parse(System.Console.ReadLine());

if (k == l && l == m && k == m)
        Console.WriteLine("wszystkie liczby są równe");
else if (k == l)
        Console.WriteLine("Równa jest liczba 1 i liczba 2");
else if (l == m)
        Console.WriteLine("Równe są liczba 2 i liczba 3");
else if (k == m)
        Console.WriteLine("Równe są liczba 1 i liczba 3");   
*/

/* 4
 using System;

Console.WriteLine("Wprowadź liczbę 1: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 2: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 3: ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 4: ");
int d = int.Parse(Console.ReadLine());

if (a < b && a < c && a < d)
        Console.WriteLine("Najmniejsza jest liczba: " + a);

else if (b < a && b < c && b < d)
        Console.WriteLine("Najmniejsza jest liczba: " + b);

else if (c < a && c < b && c < d)
        Console.WriteLine("Najmniejsza jest liczba: " + c); 

else if (d < a && d < c && d < b)
        Console.WriteLine("Najmniejsza jest liczba: " + d); 
*/

/* 5
 using System;

Console.WriteLine("Wprowadź liczbę 1: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 2: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 3: ");
int c = int.Parse(Console.ReadLine());

if (b + c > a && a > b - c || a + c > b && a - c < b || a + b > c && c > a - b)
        Console.WriteLine("Te boki spełniają nierówność");
else 
        Console.WriteLine("Te boki nie spełniają nierówności");
*/

/* 6
 using System;

Console.WriteLine("Wprowadź liczbę 1: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 2: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Wprowadź liczbę 3: ");
int c = int.Parse(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
        System.Console.WriteLine("ten trójkąt może powstać");
        
        if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)

                System.Console.WriteLine("trójkat będzie prostokątny");

        else if (a * a + b * b < c * c || b * b + c * c < a * a || c * c + a * a < b * b)
        {
                System.Console.WriteLine("trójkąt będzie rozwartokątny");
        }
        else if (a * a + b * b > c * c || b * b + c * c > a * a || c * c + a * a > b * b)
        {
                System.Console.WriteLine("trójkąt będzie ostrokątny");
        }

        else
        {
                System.Console.WriteLine("ten trójkąt nie może postać");
        }
}  
*/    