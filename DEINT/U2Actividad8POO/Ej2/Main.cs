using System.Drawing;
using U2Actividad8POO;

Electrodomestico[] electrodomesticos =
    {new Electrodomestico(),
    new Television(),
    new Lavadora(),
    new Electrodomestico(34,25),
    new Television(34,45),
    new Lavadora(22,23),
    new Electrodomestico(59,"Rojo",'D',30),
    new Television(59,"Verde",'E',30,22,true),
    new Lavadora(12,"Blanco",'F',40,8),
    new Television(29,"Gris",'A',40,35,false),
};

double sumaElec=0, sumaLava=0, sumaTele = 0;
foreach (var elec in electrodomesticos)
{
    if (elec is Television) sumaTele += elec.PrecioFinal();
    else if (elec is Lavadora) sumaLava += elec.PrecioFinal();
    sumaElec += elec.PrecioFinal();
    Console.WriteLine(elec.PrecioFinal());
}
Console.WriteLine("Total de televisiones: " + sumaTele);
Console.WriteLine("Total de lavadoras: " + sumaLava);
Console.WriteLine("Total de electrodomésticos: " + sumaElec);