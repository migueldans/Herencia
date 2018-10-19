using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Futbolista : SeleccionFutbol
    {
        private int Dorsal;
        private string Demarcacion;

        public Futbolista()
        {

        }

        public Futbolista(int id, int edad, string nombre, string apellidos, int dorsal, string demarcacion, bool Viajar, bool Concentrarse) :base(id,edad,nombre,apellidos, Viajar, Concentrarse)
        {
            this.Dorsal = dorsal;
            this.Demarcacion = demarcacion;
        }

        public string MostrarDatosFutbolista()
        {
            return base.MostrarDatos() + " Dorsal: " + Dorsal + " Demarcacion: " + Demarcacion;
        }

        public void JugarPartido()
        {

        }

        public void Entrenar()
        {

        }
    }
}
