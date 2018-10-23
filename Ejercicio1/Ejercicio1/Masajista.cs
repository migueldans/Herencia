using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Masajista : SeleccionFutbol
    {
        int AniosExperencia;
        string Titulacion;

        public Masajista()
        {

        }
        public Masajista(int id, int edad, string nombre, string apellidos, int aniosExperiencia,string titulacion) : base(id, edad, nombre, apellidos)
        {
            this.AniosExperencia = aniosExperiencia;
            this.Titulacion = titulacion;
        }

        public override string ToString()
        {
            return base.ToString() + "\nAños de experiencia: " + AniosExperencia + "\nTitulación: " + Titulacion;
        }

        public void DarMasaje()
        {
            Console.WriteLine("Está dando masajes");
        }
        public override void Accion()
        {
            base.Accion();
            DarMasaje();
        }
        public override void PrepararPartido()
        {
            base.PrepararPartido();
            DarMasaje();
        }
        public override void JugarPartido()
        {
            base.JugarPartido();
            DarMasaje();
        }
    }
}
