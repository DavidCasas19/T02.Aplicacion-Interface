using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Aplicacion_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Operacion Op = new Operacion();
            Op.Num1= rnd.Next(1, 10); ;
            Op.Num2 = rnd.Next(1, 10); ;
            Menu();


            void Menu()
            {
                Console.WriteLine("Bienvenido a la mejor calculadora del mundo");
             
                Console.WriteLine(Op.Numeros());
                Console.WriteLine("Elige una opcion");
                Console.WriteLine("1.-Sumar\n2.-Restar\n3.-Divicion\n4.-Multiplicacio\n5.-Salir");
                   
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("El resultado de la suma es: " + Op.SumaRes());
                        Console.ReadKey();
                        Console.Clear();
                        Menu();

                        break;
                    case "2":
                        Console.WriteLine("El resultado de la resta es: " + Op.RestaRes());
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;
                    case "3":
                        Console.WriteLine("El resultado de la divicion es: " + Op.DivicionRes());
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;
                    case "4":
                        Console.WriteLine("El resultado de la multiplicacion es: " + Op.MultiplicacionRes());
                        Console.ReadKey();
                        Console.Clear();
                        Menu();

                        break;
                     
                    case "5":
                        Console.WriteLine("Gracias por usar la calculadora");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                }




            }



        }
    
    }
}
