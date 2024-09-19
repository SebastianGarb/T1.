int placa;
string color;

Console.WriteLine("Ingrese el ultimo digito de las placas (Termine ingresando: F)");


while (placa )
{
    placa = Convert.ToInt32(Console.ReadLine());
    if (placa > 0 && placa <3)
    {
        color = "Verde";
    }
    if (placa > 3 && placa < 7)
    {
        color = "Azul";
    }
    if (placa > 6 && placa < 10)
    {
        color = "Rojo";
    }

    Console.WriteLine($"{color}, ");
}

Console.ReadKey();
