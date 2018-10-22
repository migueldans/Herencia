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

        public Futbolista(int id, int edad, string nombre, string apellidos, int dorsal, string demarcacion) :base(id,edad,nombre,apellidos)
        {
            this.Dorsal = dorsal;
            this.Demarcacion = demarcacion;
        }

        public override string ToString()
        {
            return base.ToString() + "\nDorsal: " + Dorsal + "\nDemarcación: " + Demarcacion;
        }

        public void JugarPartido()
        {
            Console.WriteLine("Está jugando el partido");
        }

        public void Entrenar()
        {
            Console.WriteLine("Está entrenando");
        }
        public override void Accion()
        {
            base.Accion();
            Entrenar();
        }
    }
}
