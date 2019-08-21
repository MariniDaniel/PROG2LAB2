using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4";
            int numero = 1;
            int contador = 0;
            int acumulador = 0;

            while (contador < 4)
            {
                for (int i = 1; i != numero; i++)
                {

                    if (numero % i == 0)
                    {
                        acumulador = acumulador + i;
                    }
                }
                if (acumulador == numero)
                {
                    contador++;
                    Console.WriteLine("El numero {0} es perfecto", numero);

                }
                numero++;
                acumulador = 0;

            }


            Console.ReadLine();

        }
    }
}
