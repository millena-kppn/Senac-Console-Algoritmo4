using System.Globalization;
//variaveis
double largura, comprimento, area, valoMetro, valorTerreno;
//entrada
largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
valoMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//calculo
area = largura * comprimento;
valorTerreno = area * valoMetro;
//saida
Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PRECO = " + valorTerreno.ToString("F2", CultureInfo.InvariantCulture));
