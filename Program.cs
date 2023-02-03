using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Arreglos_Cristhian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint valor1 = 0;

            //----------------------------- ARREGLOS Y MATRICES
            //  Declaracion de arreglo musico (5 valores)
            String[] musico = new String[5];
            
            //  Asignacion de valores a cada posicion del arreclo
            musico[0] = "Frédéric Chopin";
            musico[1] = "Johann Sebastian Bach";
            musico[2] = "Ludwig van Beethoven";
            musico[3] = "Piotr Ilich Tchaikovskin";
            musico[4] = "Wolfgang Amadeus Mozar";

            //  Declaracion de arreglo edad (5 valores)
            int[] edad = new int[] { 11, 30, 27, 57, 40 };
             
            //  Declaracion de arreglo salario (5 valores)
            float[] salario = new float[] { 1000, 6000, 2700, 7900, 10000 };


            //  Bucle FOR para imprimir en consola la informacion de cada musico
            for (int i = 0; i < 4; i++)
            {
                float IVA = 0;
                IVA = salario[i] * 0.13f;
                Console.WriteLine($"\n------------------------------------------\nNombre del Musico: {musico[i]} \nSalario: {salario[i]} + IVA (13%): {IVA}\n------------------------------------------\n");
            }

            Console.ReadLine();
        }
    }
}
