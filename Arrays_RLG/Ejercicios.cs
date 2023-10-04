using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_RLG
{
    internal class Ejercicios
    {
        public void MostrarValores()
        {
            int[] arreglo = { 1, 2, 3, 6, 10 };
            Console.WriteLine("La posicion 1 es: " + arreglo[0]);
            Console.WriteLine("La posicion 2 es: " + arreglo[1]);
            Console.WriteLine("La posicion 3 es: " + arreglo[2]);
            Console.WriteLine("La posicion 4 es: " + arreglo[3]);
            Console.WriteLine("La posicion 5 es: " + arreglo[4]);
        }
        public void MostrarValoresBucle()
        {
            int[] arreglo = new int[5];
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Ingresa un numero");
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i < arreglo.Length; i++)
            {
                Console.WriteLine("El numero en el puesto " + i +" es "+arreglo[i]);
            }
        }

        public void MediaArray()
        {
            int[] arreglo = new int[10];
            double suma = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Ingresa un numero");
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for(int i = 0; i < arreglo.Length; i++)
            {
                suma += arreglo[i];
            }
            Console.WriteLine("La media es "+ suma / 10);
        }

        public void ArrayMultiplo()
        {
            Console.WriteLine("Ingrese el tamaño del array(numero de multiplos del valor)");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Ingrese un numero al cual sacar el multiplo");
            int multiplo = Convert.ToInt32(Console.ReadLine());
            //siempre sera el valor inicial dado por multiplo
            int valor = multiplo;

            for (int i = 0;i < array.Length ; i++)
            {
                array[i] = multiplo;
                Console.WriteLine("El multiplo es " + array[i]);
                //se va sumando al valor inicial sin cambio de aumento en la variable valor
                multiplo += valor;
            }
        }

        public void LongitudNombre()
        {
            int size = 0;
            Console.WriteLine("Ingrese el tamaño del array(cuantos nombres quieres ver)");
            size = Convert.ToInt32(Console.ReadLine());
            //defines el tamaño del array     num
            string[] arrayNombre = new string[size];
            //tiene el mismo numero de posiciones por utilizar el size
            int[] arrayLength = new int[size];
            for (int i = 0; i < arrayNombre.Length ; i++)
            {
                Console.WriteLine("Ingrese un nombre");
                arrayNombre[i] = Console.ReadLine();
                //arrayLength guarda la longitud y [i] almacena la posicion
                arrayLength[i] = arrayNombre[i].Length;
            }
            //mostrara cada pocision por ejemplo 5 nombre
            for(int i = 0; i < arrayNombre.Length; i++)
            {
                Console.WriteLine("Nombre: "+ arrayNombre[i]+", longitud: "+ arrayLength[i]);
            }
        }



    }
}
