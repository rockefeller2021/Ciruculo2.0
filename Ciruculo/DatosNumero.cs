using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciruculo
{
    internal class DatosNumero
    {

        
            static public float radio;
            static public float diametro;


            //Constructor
            public DatosNumero()
            {


            }

            public float Radio
            {
                set { radio = value; }
                get { return radio; }


            }

            public float Diametro
            {
                set { diametro = value; }
                get { return diametro; }

            }

        }
    }



