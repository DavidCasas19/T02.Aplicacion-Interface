using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Aplicacion_Interface
{
    class Operacion:Principal,INumero,IOperacion
    {
        public double Suma { get; set; }
        public double Resta { get; set; }
        public double Divicion { get; set; }
        public double Multi { get; set; }

        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public override string Numeros()
        {
            return "El primer numero es:" + Num1 + "\n" + "El segundo numero es: " + Num2;
           

        }


        public double SumaRes()
        {    
            Suma = Num1 + Num2;
            return Suma = Num1 + Num2;
        }


        public double RestaRes()
        {
            Resta = Num1 - Num2;
            return Resta;
        }


        public double DivicionRes()
        {

            Divicion = Num1 / Num2;
            return Divicion;

        }


        public double MultiplicacionRes()
        {
            //realizacion de las operaciones


            Multi = Num1 * Num2;
            return Multi;

        }



    }

}
