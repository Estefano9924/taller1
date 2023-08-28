// ejercicio 3 numero especial

Console.Write("Ingrese el número a comprobar: ");
string n = Console.ReadLine();
int n1;
int sum = 0;
for (int i = 0; i < n.Length; i++)
{
	sum += Convert.ToInt32(n.Substring(i, 1));
}

n1 = Int32.Parse(n);
if (n1 % 5 == 0 && n1 % 2 != 0 && n1 % 3 != 0 && sum>=10)
{
	Console.WriteLine($"El número {n1} es especial");
}
else
{
	Console.WriteLine($"El número {n1} no es especial");
}