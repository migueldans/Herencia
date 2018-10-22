using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Entrenador e1 = new Entrenador(11, 56, "Jose", "Cahembra", "Oriundo");

            Masajista m1 = new Masajista(21, 34, "Bill", "Cosby", 10, "Medico");
            Masajista m2 = new Masajista(22, 54, "Juan", "Jose", 40, "Chamán");

            Futbolista f1 = new Futbolista(31, 19, "Pepe", "Ruiz", 9, "Delantero");
            Futbolista f2 = new Futbolista(32, 29, "Bobe", "Bobeto", 9, "Medio");
            Futbolista f3 = new Futbolista(33, 16, "Vincent", "Vincenzo", 9, "Defensa");
            Futbolista f4 = new Futbolista(34, 34, "Fran", "Roche", 9, "Portero");

            //Aqui he creado la lista
            List<SeleccionFutbol> listaSeleccion = new List<SeleccionFutbol>
            {
                e1,m1,m2,f1,f2,f3,f4
            };

            //He pasado la lista llena y creado una SeleccionPais
            SeleccionPais p1 = new SeleccionPais("Selección A",listaSeleccion);

            //He creado una seleccion vacia
            SeleccionPais p2 = new SeleccionPais("Seleccion A");

            //Con el metodo AñadirIntegrante y pasandole el coche que le quiero meter, lleno la seleccion
            p2.AñadirIntegrante(e1);
            p2.AñadirIntegrante(m1);
            p2.AñadirIntegrante(m2);
            p2.AñadirIntegrante(f1);
            p2.AñadirIntegrante(f2);
            p2.AñadirIntegrante(f3);
            p2.AñadirIntegrante(f4);

            foreach(SeleccionFutbol seleccion in p2.GetSeleccionPais())
            {
                Console.WriteLine(seleccion.GetType().Name.ToUpper());
                Console.WriteLine(seleccion.ToString());
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine("Número de integrantes: " + p1.GetSeleccionPais().Count);
            Console.ReadLine();


            //foreach (SeleccionFutbol seleccion in listaSeleccion)
            //{
            //    Console.WriteLine(seleccion.GetType().Name.ToUpper());
            //    Console.WriteLine(seleccion.ToString());
            //    seleccion.Accion();
            //    seleccion.Viajar();
            //    seleccion.Concentrarse();
            //    Console.WriteLine("----------------------------------");

            //}

        }
    }
}
