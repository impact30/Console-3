
using System.Timers;
using ConsoleApp3;

Locomotora l = new Locomotora();
l.AgregaFinal(2);
l.AgregaFinal(10);
l.AgregaFinal(20);
l.AgregaFinal(40);
l.AgregaFinal(30);

Locomotora l2 = new Locomotora();
l2.AgregaFinal(99);
l2.AgregaFinal(100);
l2.AgregaFinal(200);
l.AgregaLEFinal(l2);

Console.WriteLine(l.VerVagones());

if (l.ExisteValor(50) == true)
{
    Console.WriteLine("El valor si existe en la lista");
}
else
{
    Console.WriteLine("El valor no existe en la lista");
}
