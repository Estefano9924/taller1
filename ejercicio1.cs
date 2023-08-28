// calculadora de fracciones

float n1, d1, n2, d2;
string op;

Console.Write("Ingrese el primer numerador: ");
n1 = Int32.Parse(Console.ReadLine());

Console.Write("Ingrese el primer denominador: ");
d1 = Int32.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numerador: ");
n2 = Int32.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo denominador: ");
d2 = Int32.Parse(Console.ReadLine());


Console.WriteLine("Ingrese + para suma");
Console.WriteLine("Ingrese - para resta");
Console.WriteLine("Ingrese * para multiplicacion");
Console.WriteLine("Ingrese / para division");
Console.Write("Ingrese operador  de la operacion a realizar: ");
op =Console.ReadLine();

if (d1 == 0 || d2 == 0)
{
	Console.WriteLine("no se puede realizar operacion dado que no se puede dividir por 0");
}
else
{
	switch (op)
	{
		case "+":
			Console.WriteLine($"{n1}/{d1} + {n2}/{d2} = "+(((n1*d2)+(n2*d1))/(d1*d2)));
			break;
		case "-":
			Console.WriteLine($"{n1}/{d1} - {n2}/{d2} = "+(((n1*d2)-(n2*d1))/(d1*d2)));
			break;
		case "*":
			Console.WriteLine($"{n1}/{d1} * {n2}/{d2} = "+((n1*n2)/(d1*d2)));
			break;
		case "/":
			Console.WriteLine($"{n1}/{d1} / {n2}/{d2} = "+((n1*d2)/(n2*d1)));
			break;
		default:
			Console.WriteLine("Operacion no existe");
			break;
	}
}
