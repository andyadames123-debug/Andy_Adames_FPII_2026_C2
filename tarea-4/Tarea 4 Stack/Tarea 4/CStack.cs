using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack009
{
    // Hacemos una implementacion basada en lista ligada
    class CStack
    {
        // Es el ancla o encabezado del stack
        private CNodo ancla;

        // Esta variable de referencia nos ayuda trabajar con el stack
        private CNodo trabajo;

        public CStack()
        {
            // Instanciamos el ancla
            ancla = new CNodo();

            // Como es un stack vacio su siguiente es null
            ancla.Siguiente = null;
        }
        // Push
        public void Push(int pDato)
        {
            // Creamos el nodo temporal
            CNodo temp = new CNodo();
            temp.Dato = pDato;

            // Conectamos el temporal a la lista
            temp.Siguiente = ancla.Siguiente;

            // Conectamos el ancla al temporal
            ancla.Siguiente = temp;
        }
        // Pop
        public int Pop()
        {
            // Esta version no contiene codigo de seguridad
            // Colocar una excepcion cuando se intente hacer un pop a un stack vacio

            int valor = 0;

            // Llevamos a cabo el trabajo solo si hay elementos en el stack
            if (ancla.Siguiente != null)
            {
                // Obtenemos el dato correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                // Lo sacamos del stack
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }

            return valor;
        }
        // Peek
        public int Peek()
        {
            // Esta version no contiene codigo de seguridad
            // Colocar una excepcion cuando se intente hacer un pop a un stack vacio

            int valor = 0;

            // Llevamos a cabo el trabajo solo si hay elementos en el stack
            if (ancla.Siguiente != null)
            {
                // Obtenemos el dato correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
            }

            return valor;
        }
        public void Transversa()
        {
            // Trabajo al inicio
            trabajo = ancla;

            // Recorremos hasta encontrar el final
            while (trabajo.Siguiente != null)
            {
                // Avanzamos trabajo
                trabajo = trabajo.Siguiente;

                // Obtenemos el dato y lo mostramos
                int d = trabajo.Dato;

                Console.WriteLine("[{0}]", d);
            }
        }
    }
}