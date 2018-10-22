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

        public Entrenador(int id, int edad, string nombre, string apellidos,  string idFederacion) : base(id, edad, nombre, apellidos)
        {
            this.IdFederacion = idFederacion;
        }


        public override string ToString()
        {
            return base.ToString() + "\nIdFederacion: " + IdFederacion;
        }

        public void DirigirPartido()
        {
            Console.WriteLine("Está dirigiendo el partido");
        }

        public void DirigirEntrenamiento()
        {
            Console.WriteLine("Está dirigiendo el entrenamiento");
        }
        public override void Accion()
        {
            base.Accion();
            DirigirEntrenamiento();
        }
    }
}
