using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 2";

            int numero;
            string dato;
            bool booleano = false;


            do
            {
                Console.WriteLine("ingrese un numero : ");
                dato = Console.ReadLine();
                if(int.TryParse(dato,out numero) && numero>0)
                {
                    Console.WriteLine("Cuadrado: {0}", Math.Pow(numero,2));
                    Console.WriteLine("Cubo: {0}", Math.Pow(numero, 3));
                    booleano = false;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");

                    booleano = true;



                }
            } while (booleano);

            Console.ReadKey();
        }
    }
}
