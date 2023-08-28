string Original = "El gato juega en el jardin";
string[] palabrasOriginales = Original.Split(' ');
string[] Oculta = new string[palabrasOriginales.Length];

for (int i = 0; i < palabrasOriginales.Length; i++)
{
	if (palabrasOriginales[i] == "gato" || palabrasOriginales[i] == "juega" || palabrasOriginales[i] == "jardin")
	{
		Oculta[i] = "_____";
	}
	else
	{
		Oculta[i] = palabrasOriginales[i];
	}
}

List<string> Adivinadas = new List<string>();
int intentos = 10;

Console.WriteLine("Adivina las palabras ocultas en la siguiente frase:");
Console.WriteLine(string.Join(" ", Oculta));

while (intentos > 0)
{
	Console.WriteLine($"Intentos restantes: {intentos}");
	Console.Write("Ingresa una palabra: ");
	string palabraIng = Console.ReadLine().ToLower();

	if (Adivinadas.Contains(palabraIng))
	{
		Console.WriteLine("Ya adivinaste esa palabra antes. Intenta con otra.");
		intentos--;
	}
	else if (palabraIng == "gato" || palabraIng == "juega" || palabraIng == "jardin")
	{
		Console.WriteLine("Correcto, Has adivinado una palabra.");
		Adivinadas.Add(palabraIng);

		// Reemplazar la palabra adivinada en la frase oculta
		for (int i = 0; i < palabrasOriginales.Length; i++)
		{
			if (palabrasOriginales[i] == palabraIng)
			{
				Oculta[i] = palabraIng;
			}
		}

		Console.WriteLine(string.Join(" ", Oculta));

		// Verificar si se adivinaron todas las palabras
		if (Adivinadas.Count == 3)
		{
			Console.WriteLine("¡Felicidades! Has adivinado todas las palabras.");
			break;
		}
	}
	else
	{
		Console.WriteLine("Incorrecto. Esa palabra no está en la frase oculta.");
		intentos--;
	}
}

if (intentos == 0 && Adivinadas.Count < 3)
{
	Console.WriteLine("Agotaste tus intentos. Has perdido.");
}