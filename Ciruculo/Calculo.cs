using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciruculo
{
    internal class Calculo : DatosNumero
    {


       public  Calculo()
        {


        }

        public void CalcArea()
        {
            var area = Math.PI * Math.Pow(Radio,2);

            Console.WriteLine("El area del Circulo es: " + area);


        }

        public void CalcPerimetro()
        {

            var perimetro = Math.PI * Diametro;
            Console.WriteLine("El Perimetro del Circulo es: " + perimetro);


        }




    }
}
