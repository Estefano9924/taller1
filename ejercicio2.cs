 // Tabla de multiplicar con reto


int n1, n2, o=0;

Console.Write("Ingrese la tabla menor: ");
n1 = Int32.Parse(Console.ReadLine());

Console.Write("Ingrese la tabla mayor: ");
n2 = Int32.Parse(Console.ReadLine());
Random random = new Random();

for (int i = n1; i <= n2; i++)
{
	Console.WriteLine($"\nEsta es la tabla del {i} ");
	int n = random.Next(1, 10);
	for (int j = 1; j <= 10; j++)
	{
		if (n == j)
		{
			Console.WriteLine($"{i} * ? = " + (i * j));
			o = j;
		}
		else
		{
			Console.WriteLine($"{i} * {j} = " + (i * j));
		}
	}
	Console.Write($"Ingrese el valor faltante: ");
	int r = Int32.Parse(Console.ReadLine());

	if (r == o)
	{
		Console.WriteLine($"Respuesta Correcta");
	}else
	{
		Console.WriteLine($"Respuesta Incorrecta");
	}

}