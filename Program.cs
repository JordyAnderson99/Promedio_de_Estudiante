﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Promedio_de_estudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0; //cantidad de alumnos
            int salones = 0; //cantidad de salones

            int n = 0; //variable de control de ciclo de alumnos
            int m = 0; //variable de control de ciclo de salones
            string valor = "";

            float suma = 0.0f, promedio = 0.0f; //vaiable para el promedio
            float minima = 69.0f; //vatiable para calificacion minima
            float maxima = 70.0f; //variable para calificacion maxima

            //Pedimos la cantidad de salones
            Console.WriteLine("Digite la cantidad de salones");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);

            //creamos el arreglo
            float[][] calif= new float[salones][];

            // Pedimpos la cantidad de alumnos por salon
            for(n =0; n<salones; n++)
            {
                Console.WriteLine("Digite la Cantidad de Alumnos para el salon {0}",n);
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);

                calif[n] = new float[cantidad];
            }

            // Capturamos la informacion
            for(n=0; n<salones; n++)
            {
                Console.WriteLine("\nSalon {0}",n);
                for(m=0; m<calif[n].GetLength(0); m++)
                {
                    Console.WriteLine("Dame La Calificacion");
                    valor = Console.ReadLine();
                    calif[n][m] = Convert.ToSingle(valor);

                }
                

            }

            //Desplegamos la informacion
            Console.WriteLine("\n__Informacion__");
            for(n=0; n<salones; n++)
            {
                Console.WriteLine("Salon {0}",n);

                for(m=0; m<calif[n].GetLength(0); m++)
                {
                    Console.WriteLine("El Alumno {0} tiene {1}", m, calif[n][m]);

                }
            }

           //Encontramos el promedio
           for(n=0; n<salones; n++)
            {
                for(m=0; m<calif[n].GetLength(0); m++)
                {
                    suma +=  calif[n][m];

                    promedio = suma / (cantidad * salones);

                }
            }
            Console.WriteLine("El Promedio es {0}", promedio);
        }
    }
}
