using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio3";
            int numero;
            int i;
            Boolean condicion = true;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Los numeros primos son: ");
                    if (numero > 0)
                    {
                        for (i = 0; i != numero; i++)
                        {
                            if (i % 2 != 0)
                            {

                                Console.WriteLine(i);
                            }
                        }
                    }
                    else
                    {
                        for (i = 0; i != numero; i--)
                        {
                            if (i % 2 != 0)
                            {
                                Console.WriteLine(i);
                            }

                        }

                    }
                    condicion = false;

                }
                else
                {
                    Console.WriteLine("Usted ingreso una letra");

                }

            } while (condicion);
            Console.ReadLine();
        }
    }
}
