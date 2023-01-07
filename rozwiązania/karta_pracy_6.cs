//2
int suma = 0;

for (int i = 100; i < 1000; i++)
{
	if (i % 8 == 0 && i % 16 != 0)
	{
		suma = suma + i;
	}
}

Console.WriteLine(suma);

//3

int dzielnik = 0;
int ilosc = 0;

for (int i = 0; i < 100; i++)
{
	if (i % 7 == 0)
	{
		dzielnik++;
	}
}

for (int j = 1000; j < 10000; j++)
{
	if (j % dzielnik == 0)
	{
		ilosc += 1;
	}
}

Console.WriteLine(dzielnik);
Console.WriteLine(ilosc);

//4 
int ilosc = 0;

for (int i = 10; i < 100; i++)
{
	if (i / 10 > 2 * (i % 10))
	{
		ilosc++;
	}
}
Console.WriteLine(ilosc);

//5
int suma = 0;
int ilosc = 0;

for (int i = 100; i < 1000; i++)
{
	if (i / 100 > ((i / 10) % 10 + i % 10))
	{
		ilosc++;
		suma = suma + i;
	}
}
Console.WriteLine(suma);
Console.WriteLine(ilosc);


