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
        public Masajista(int id, int edad, string nombre, string apellidos, int aniosExperiencia,string titulacion, bool Viajar, bool Concentrarse) : base(id, edad, nombre, apellidos,Viajar, Concentrarse)
        {
            this.AniosExperencia = aniosExperiencia;
            this.Titulacion = titulacion;
        }

        public string MostrarDatosMasajista()
        {
            return base.MostrarDatos() + " Años de experiencia: " + AniosExperencia + " Titulación: " + Titulacion;
        }

        public void DarMasaje()
        {

        }
    }
}
