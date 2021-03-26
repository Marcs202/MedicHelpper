using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicHelpper
{
    class Paciente
    {
        private int prioridad;
        private string tarjetaPaciente;
        private string nombre;
        private string apellido;
        private string fechaCita;

        public string TarjetaPaciente
        {
            get { return tarjetaPaciente; }
            set { tarjetaPaciente = value; }
        }
        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FechaCita { get => fechaCita; set => fechaCita = value; }
    }
}
