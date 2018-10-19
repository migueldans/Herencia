using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Entrenador:SeleccionFutbol
    {
        string IdFederacion;

        public Entrenador()
        {

        }

        public Entrenador(int id, int edad, string nombre, string apellidos,  string idFederacion, bool Viajar, bool Concentrarse) : base(id, edad, nombre, apellidos,Viajar,Concentrarse)
        {
            this.IdFederacion = idFederacion;
        }


        public string MostrarDatosEntrenador()
        {
            return base.MostrarDatos() + " IdFederacion: " + IdFederacion;
        }

        public void DirigirPartido()
        {
            
        }

        public void DirigirEntrenamiento()
        {
            
        }

    }
}
