using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Aprendizaje_U3
{
    internal class Cola
    {
        private int[] elementos;
        private int frente, fondo, capacidad;

        public Cola(int tamaño)
        {
            capacidad = tamaño;
            elementos = new int[capacidad];
            frente = fondo = -1;
        }

        public void Encolar(int valor)
        {
            if ((fondo + 1) % capacidad == frente)
            {
                Console.WriteLine("La cola está llena.");
                return;
            }

            if (frente == -1) frente = 0;
            fondo = (fondo + 1) % capacidad;
            elementos[fondo] = valor;
        }

        public int Desencolar()
        {
            if (frente == -1)
            {
                Console.WriteLine("La cola está vacía.");
                return -1;
            }

            int valor = elementos[frente];
            if (frente == fondo)
            {
                frente = fondo = -1;
            }
            else
            {
                frente = (frente + 1) % capacidad;
            }

            return valor;
        }

        public bool EstaVacia()
        {
            return frente == -1;
        }
    }
}
