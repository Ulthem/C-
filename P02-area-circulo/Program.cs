// Area del circulo

double area, radio;

Console.WriteLine("Calculando el area de un circulo: \n");
Console.Write("Dame el radio: ");
radio=double.Parse(Console.ReadLine());

area=Math.PI*Math.Pow(radio,2);

Console.WriteLine($"El circulo con radio de {radio} tiene un area de {area}\n");

Console.WriteLine("El tipo de dato de las varibles es:");
Console.WriteLine(radio.GetType());
Console.WriteLine(area.GetType());

