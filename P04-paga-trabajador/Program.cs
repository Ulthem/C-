// Calcular la paga de un total de un trabajo

string nombre;
int horas;
float paga, tasa, impuesto, pagabruta, paganeta;

Console.WriteLine("Calculando la paga de un trabajador:");

Console.WriteLine("Nombre: ");
nombre=Console.ReadLine();
Console.WriteLine("Horas: ");
horas=int.Parse(Console.ReadLine());
Console.WriteLine("Paga: ");
paga=float.Parse(Console.ReadLine());

tasa=0.10f;

pagabruta=horas*paga;
impuesto=pagabruta*tasa;
paganeta=pagabruta-impuesto;

Console.WriteLine("Resumen de pagos: \n");
Console.WriteLine($"El trabajador(a) {nombre} trabajo {horas} horas con una paga de {paga}");
Console.WriteLine($"Paga bruta: {pagabruta} \n");
Console.WriteLine($"Impuesto: {impuesto} \n");
Console.WriteLine($"Paga neta: {paganeta} \n");


