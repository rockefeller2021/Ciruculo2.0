// See https://aka.ms/new-console-template for more information
using Ciruculo;


DatosNumero ingresaNum = new DatosNumero();

Console.WriteLine("\n\nDigita el valor del radio del Circulo :  "); //metodo ingreso valor de la base
ingresaNum.Radio = (float)Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n\nDigita el valor del diametro del Circulo :  "); //metodo ingreso valor de la base
ingresaNum.Diametro = (float)Convert.ToInt32(Console.ReadLine());

Calculo dato = new Calculo();
dato.CalcArea();

dato.CalcPerimetro();