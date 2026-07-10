using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Queue011
{
    class CNodo
    {
        // Aqui colocamos el dato o datos que guarda el nodo
        private int dato;

        // Esta variable de refencia es usada para apuntar al nodo siguiente
        private CNodo siguiente = null;

        // Propiedades que usaremos
        public int Dato { get => dato; set => dato = value; }
        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }

        // Para su facil impresion
        public override string ToString()
        {
            // El video se corta aquí, pero normalmente retornaría el dato:
            return dato.ToString();
        }
    }
}