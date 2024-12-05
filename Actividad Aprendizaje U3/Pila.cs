using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Aprendizaje_U3
{
    internal class Pila
    {
        private int[] elementos;
        private int tope;
        private int capacidad;

        public Pila(int tamaño)
        {
            capacidad = tamaño;
            elementos = new int[capacidad];
            tope = -1;
        }

        public void Apilar(int valor)
        {
            if (tope == capacidad - 1)
            {
                Console.WriteLine("La pila está llena.");
                return;
            }
            elementos[++tope] = valor;
        }

        public int Desapilar()
        {
            if (tope == -1)
            {
                Console.WriteLine("La pila está vacía.");
                return -1;
            }
            return elementos[tope--];
        }

        public int Cima()
        {
            if (tope == -1)
            {
                Console.WriteLine("La pila está vacía.");
                return -1;
            }
            return elementos[tope];
        }

        public bool EstaVacia()
        {
            return tope == -1;
        }
    }
}
