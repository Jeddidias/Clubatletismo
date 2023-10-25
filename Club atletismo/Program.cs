using System;

namespace Club_atletismo
{
    class Program
    { /// <summary>
      /// Nombre del estudiante: Jorge Esteban Dawson
      /// Grupo: 140
      /// Ingenieria multimedia
      /// Problema Seleccionado: En un club de atletismo se deben indicar las premiaciones mediante un programa así:
      /// Usando ciclos debe pedir por consola el número de competidores
      /// Ingresar por teclado los tiempos de cada competidor.
      /// Mostrar en consola los tres mejores tiempos, acompañados con el texto primer, segundo y tercer puesto con su respectivo puntaje.
      /// </summary>
      /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero de participantes");
            int a = int.Parse(Console.ReadLine());
            while (a <= 0)
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero de participantes mayor a 1: ");
                a = int.Parse(Console.ReadLine());
            }
            int b = 3;
            double sumi = 0;
            double[,] tiempo = new double[a, b];
            Console.Clear();

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("participante {0}", i + 1);
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine("tiempo cerra {0}", j + 1);
                    tiempo[i, j] = double.Parse(Console.ReadLine());
                    while (tiempo[i, j] < 0 || tiempo[i, j] <= 0)
                    {
                        tiempo[i, j] = double.Parse(Console.ReadLine());
                    }
                } Console.Clear();
            }
            Console.Clear();
            Console.Clear();
            double minimo = 999999999;
            double corredorminimo = 0;

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("\nTiempo de participante {0} ", i + 1);
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine("Tiempo carrera {0} : {1}", j + 1, tiempo[i, j]);
                    sumi = sumi + tiempo[i, j];
                }
                Console.WriteLine("Promedio: {0}",sumi / 3);

                {
                    if (sumi < minimo)
                    {
                        minimo = sumi;corredorminimo = i;
                    }
                }
                sumi = 0;
            }
            Console.WriteLine("\n Ganador es el corredor " + (corredorminimo + 1));
            Console.WriteLine("\n Sutiempo es: " + minimo);

            Console.ReadKey();
        }
    }
}
