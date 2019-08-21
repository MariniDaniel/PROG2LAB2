using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo= int.MaxValue;
            int maximo= int.MinValue;
            int contador = 0;
            int promedio=0;
            string dato;
                
            for(int i=0 ;i<5 ;i++ )
            {
                Console.WriteLine("Porfavor ingrese 1 numero: ");
                dato = Console.ReadLine();   //Para asignar valor que lee
                if (int.TryParse(dato, out numero))
                {
                    promedio += numero;
                    contador++;

                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    else if(numero > maximo)
                     {
                        maximo = numero;
                     }
                }             
            }
       
            Console.WriteLine("Su numero maximo es: {0}",maximo);
            Console.WriteLine("Su numero minimo es: {0}", minimo);
            Console.WriteLine("Su promedio es: {0}",((float)promedio/5) );
            Console.ReadKey();

        }
    }
}
