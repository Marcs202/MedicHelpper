using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicHelpper
{
    class Heap
    {
        private int capacidad;
        private int tamano;
        private Paciente[] elementos;


        public Heap(int pCapacidad)
        {
            capacidad = pCapacidad;
            elementos = new Paciente[capacidad + 1];
            Paciente elem = new Paciente();
            elementos[0] = elem;
        }
        public void Transversa()
        {
            int n = 0;

            for (n = 0; n <= tamano; n++)
            {
                MessageBox.Show("Nombre " + elementos[n].Nombre + " Prioridad " + elementos[n].Prioridad);
            }

        }
        public bool EstaLleno()
        {
            if (tamano >= capacidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Insertar(Paciente elemen)
        {
            int n = 0;

            if (EstaLleno())
            {
                MessageBox.Show("El Heap esta lleno");
            }
            else
            {
                for (n = tamano + 1; elementos[n / 2].Prioridad > elemen.Prioridad; n /= 2)
                {
                    elementos[n] = elementos[n / 2];
                }

                elementos[n] = elemen;
                tamano++;
            }
        }
        public Paciente BorrarMin()
        {

            Paciente n = new Paciente();
            Paciente hijo = new Paciente();
            Paciente elementoMenor = new Paciente();
            Paciente ultimoElemento = new Paciente();

            if (tamano <= 0)
            {
                MessageBox.Show("La cola se encuentra vacía");
                return null;
            }
            elementoMenor = elementos[1];
            ultimoElemento = elementos[tamano--];

            for (n.Prioridad = 1; n.Prioridad * 2 <= tamano; n.Prioridad = hijo.Prioridad)
            {
                //encontramos al menor
                hijo.Prioridad = n.Prioridad * 2;

                if (hijo.Prioridad != tamano && elementos[hijo.Prioridad + 1].Prioridad < elementos[hijo.Prioridad].Prioridad)
                {
                    hijo.Prioridad++;

                }
                //percolamos
                if (ultimoElemento.Prioridad > elementos[hijo.Prioridad].Prioridad)
                {
                    elementos[n.Prioridad] = elementos[hijo.Prioridad];
                }
                else
                {
                    break;
                }
            }
            elementos[n.Prioridad] = ultimoElemento;
            
            return elementoMenor;
        }
    }
}
