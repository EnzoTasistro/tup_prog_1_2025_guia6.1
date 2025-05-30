using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVector
{
    class Program
    {
        static double Promedio(int[] aux)
        {
            return Promedio(aux, aux.Length);
        }

        static double Promedio(int[] aux, int cantidad)
        {
            double resultado = 0;
            int i;
            for (i = 0; i < cantidad; i++)
            {
                resultado += aux[i];
            }
            return resultado / cantidad;
        }
        static void Ordenar(int[] datos)
        {
            int aux;
            for (int i = 0; i < datos.Length - 1; i++)
                for (int j = i + 1; j < datos.Length; j++)
                    if (datos[j] > datos[i])
                    {
                        aux = datos[i];
                        datos[i] = datos[j];
                        datos[j] = aux;
                    }
        }
        static void Main(string[] args)
        {
            int opcion;
            int[] notas = new int[30];
            int cantidad = 0;

            do 
            {
                Console.Clear();
                Console.WriteLine("1- ingresar datos");
                Console.WriteLine("2- ordenar");
                Console.WriteLine("3- Ver datos");
                Console.WriteLine("4- Ver promedio");
                Console.WriteLine("5- Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch(opcion)
                {
                    case 1: {
                            if (cantidad < 30)
                            {
                                Console.WriteLine("ingrese valor");
                                notas[cantidad++] = Convert.ToInt32(Console.ReadLine());
                            }
                            else Console.WriteLine("vector lleno");
                            Console.ReadKey();
                        }break;
                    case 2: {
                            Ordenar(notas);//revisar
                        } break;
                    case 3: {
                            for (int i = 0; i < cantidad; i++)
                                Console.Write(notas[i] + " ");
                            Console.ReadKey();
                        } break;
                    case 4: {
                            Console.WriteLine($"El promedio es {Promedio(notas, cantidad)}");
                            Console.ReadKey();
                        } break;
                }
            } while (opcion != 5);





        }
    }
}
