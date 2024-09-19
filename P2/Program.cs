int placa = 0;
string color;

Console.WriteLine("Ingrese los colores de las placas");
color = Console.ReadLine().ToUpper().Trim();
while (color == "F")
{
    color = Console.ReadLine().ToUpper().Trim();
    if (color == "VERDE")
    {
        for (placa++; placa < 3 && placa > 0;) ;
    }
    else if (color == "AZUL")
    {
        for (placa++ ; placa < 6 && placa > 4;) ;
    }
    else if (color == "ROJO")
    {
        for (placa++ ; placa > 7 && placa < 9;) ;
    }
   
        
        for (Console.WriteLine($"{placa++}, "); color == "F";);
        
    
}
Console.ReadKey();
