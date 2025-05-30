using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {

            //int [] vector = {4,11,18,25};          //definir vector los corchetes [] indican que es un vector, luego se indica la variable
            // los valores indican todos los domingos de este mes, para saber que numero caen (CREARLO POR VALOR)

            //int[] vector = new int[30];            //Estoy creando un vector de 30 lugares (se inicializa en  0)


            int [] datos; //creo el vector
            int tamaño;   //creo una variable para guardar la cantidad de arcivos que entraran en el vector

            Console.WriteLine("Ingrese el tamaño de el vector"); //pedir el valor del vector al usuario
            tamaño = Convert.ToInt32(Console.ReadLine());        //el usuario ingresa el valor y se convierte a INT

            datos = new int[tamaño];      //se asigna el nuevo valor a datos en base a lo que ingreso el usuario

            for (int i = 0; i < tamaño; i++)    //se usa un for para ir contando la cantidad de lugares ocupados en el vector dependiendo el tamaño ingresado por el usuario
            {

                Console.Write($"Ingresa el {i + 1} valor");        //se pide el valor a guardar en el vector
                datos[i] = Convert.ToInt32(Console.ReadLine());  //se ingresa el valor y se asigna al espacio del vector

            }

            Console.WriteLine($"El promedio es {Promedio(datos):f2}");
            Console.WriteLine($"El promedio de los 3 primeros es {Promedio(datos)}");
            Console.WriteLine($"El mayor ingresado es {VerMayor(datos)}");
            Ordenar(datos);
            
            for (int i = 0; i < datos.Length; i++)
                Console.Write(datos[i]+"-");


            Console.ReadKey();

        }

        static double Promedio(int[] auxiliar) //se crea el metodo y se llama al vector (se llama distinto pero apunta a la misma direccion de memoria)
        {

            double resultado = 0;

            for (int i = 0; i < auxiliar.Length; i++) //length permite saber el tamaño de el vector
            { 
            
                resultado = resultado + auxiliar[i];

            }

            return resultado / auxiliar.Length;  //El metodo siempre se finaliza con un return (el resultado que se devuelve)
        }

        static double Promedio(int[] auxiliar, int cantidad)
        {
            double resultado = 0;
            int i;

            for (i = 0; i < cantidad; i++)
            {

                resultado = resultado + auxiliar[i];


            }

            return resultado / cantidad;

        }

        static int VerMayor(int[] pepe)
        {

            int mayor = pepe[0];
            for (int i = 1; i < pepe.Length; i++)
            {

                if (pepe[i] > mayor)
                mayor = pepe[i];
               
            }
            return mayor;
        }

        static void Ordenar (int[] datos)   //metodo para ordenar de manor a mayor
        {
            int auxiliar;

            for (int i = 0; i < datos.Length-1; i++)    
                for (int j = i+1; j < datos.Length; j++)
                
                    if (datos[j] > datos[i])
                    {

                        auxiliar = datos[j];
                        datos[j] = datos[i];    //reemplazar un valor
                        datos[i] = auxiliar; 

                    }

                

        }
    }
}
