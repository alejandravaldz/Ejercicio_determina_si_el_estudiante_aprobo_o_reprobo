// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculo de las nota del estudiante");
Console.WriteLine();

// nota del estudiante

int p1, p2, p3, p4;


Console.Write("Ingrese el p1: ");
p1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Ingrese el p2: ");
p2 = Convert.ToInt32(Console.ReadLine());



Console.Write("Ingrese el p3: ");
p3 = Convert.ToInt32(Console.ReadLine());



Console.Write("Ingrese el p4: ");
p4 = Convert.ToInt32(Console.ReadLine());



double p = (p1 + p2 + p3 + p4) / 4;


if (p >= 70)
{
    Console.WriteLine("aprobo la materia");
}
else
{
    Console.WriteLine("repropo la materia");
}
