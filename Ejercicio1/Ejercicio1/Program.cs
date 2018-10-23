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
            Entrenador e2 = new Entrenador(12, 33, "Jisus", "Kraist", "Salvator");
            Entrenador e3 = new Entrenador(13, 34, "Pigeon", "Colombus", "Seeker");

            Masajista m1 = new Masajista(21, 34, "Bill", "Cosby", 10, "Medico");
            Masajista m2 = new Masajista(22, 54, "Juan", "Jose", 40, "Chamán");
            Masajista m3 = new Masajista(21, 34, "Bill", "Cosby", 10, "Medico");
            Masajista m4 = new Masajista(22, 54, "Juan", "Jose", 40, "Chamán");
            Masajista m5 = new Masajista(21, 34, "Bill", "Cosby", 10, "Medico");

            Futbolista f1 = new Futbolista(31, 19, "Pepe", "Ruiz", 9, "Delantero");
            Futbolista f2 = new Futbolista(32, 29, "Bobe", "Bobeto", 9, "Medio");
            Futbolista f3 = new Futbolista(33, 16, "Vincent", "Vincenzo", 9, "Defensa");
            Futbolista f4 = new Futbolista(34, 34, "Fran", "Roche", 9, "Portero");
            Futbolista f5 = new Futbolista(35, 19, "Pepe", "Ruiz", 9, "Delantero");
            Futbolista f6 = new Futbolista(36, 29, "Bobe", "Bobeto", 9, "Medio");
            Futbolista f7 = new Futbolista(37, 16, "Vincent", "Vincenzo", 9, "Defensa");
            Futbolista f8 = new Futbolista(38, 34, "Fran", "Roche", 9, "Portero");
            Futbolista f9 = new Futbolista(39, 19, "Pepe", "Ruiz", 9, "Delantero");
            Futbolista f10 = new Futbolista(310, 29, "Bobe", "Bobeto", 9, "Medio");
            Futbolista f11 = new Futbolista(311, 16, "Vincent", "Vincenzo", 9, "Defensa");
            Futbolista f12 = new Futbolista(312, 34, "Fran", "Roche", 9, "Portero");
            Futbolista f13 = new Futbolista(313, 19, "Pepe", "Ruiz", 9, "Delantero");
            Futbolista f14 = new Futbolista(314, 29, "Bobe", "Bobeto", 9, "Medio");
            Futbolista f15 = new Futbolista(315, 16, "Vincent", "Vincenzo", 9, "Defensa");
            Futbolista f16 = new Futbolista(316, 34, "Fran", "Roche", 9, "Portero");
            Futbolista f17 = new Futbolista(317, 34, "Fran", "Roche", 9, "Portero");
            Futbolista f18 = new Futbolista(318, 19, "Pepe", "Ruiz", 9, "Delantero");
            Futbolista f19 = new Futbolista(319, 29, "Bobe", "Bobeto", 9, "Medio");
            Futbolista f20 = new Futbolista(320, 16, "Vincent", "Vincenzo", 9, "Defensa");
            Futbolista f21 = new Futbolista(321, 34, "Fran", "Roche", 9, "Portero");
            Futbolista f22 = new Futbolista(322, 16, "Vincent", "Vincenzo", 9, "Defensa");
            Futbolista f23 = new Futbolista(323, 34, "Fran", "Roche", 9, "Portero");
            Futbolista f24 = new Futbolista(324, 16, "Vincent", "Vincenzo", 9, "Defensa");
            Futbolista f25 = new Futbolista(325, 34, "Fran", "Roche", 9, "Portero");
            Futbolista f26 = new Futbolista(326, 16, "Vincent", "Vincenzo", 9, "Defensa");
            Futbolista f27 = new Futbolista(327, 34, "Fran", "Roche", 9, "Portero");

            //Aqui he creado la lista
            List<SeleccionFutbol> listaSeleccion = new List<SeleccionFutbol>
            {
                e1,e2,e3,m1,m2,f1,f2,f3,f4
            };

            //He pasado la lista llena y creado una SeleccionPais
            SeleccionPais p1 = new SeleccionPais("Selección A",listaSeleccion);

            //He creado una seleccion vacia
            SeleccionPais p2 = new SeleccionPais("Seleccion A");

            //Con el metodo AñadirIntegrante y pasandole el integrante que le quiero meter, lleno la seleccion
            p2.AñadirIntegrante(e1);
            p2.AñadirIntegrante(e2);
            p2.AñadirIntegrante(e3);
            p2.AñadirIntegrante(m1);
            p2.AñadirIntegrante(m2);
            p2.AñadirIntegrante(m3);
            p2.AñadirIntegrante(m4);
            p2.AñadirIntegrante(m5);
            p2.AñadirIntegrante(f1);
            p2.AñadirIntegrante(f2);
            p2.AñadirIntegrante(f3);
            p2.AñadirIntegrante(f4);
            p2.AñadirIntegrante(f5);
            p2.AñadirIntegrante(f6);
            p2.AñadirIntegrante(f7);
            p2.AñadirIntegrante(f8);
            p2.AñadirIntegrante(f9);
            p2.AñadirIntegrante(f10);
            p2.AñadirIntegrante(f11);
            p2.AñadirIntegrante(f12);
            p2.AñadirIntegrante(f13);
            p2.AñadirIntegrante(f14);
            p2.AñadirIntegrante(f15);
            p2.AñadirIntegrante(f16);
            p2.AñadirIntegrante(f17);
            p2.AñadirIntegrante(f18);
            p2.AñadirIntegrante(f19);
            p2.AñadirIntegrante(f20);
            p2.AñadirIntegrante(f21);
            p2.AñadirIntegrante(f22);
            p2.AñadirIntegrante(f23);
            p2.AñadirIntegrante(f24);
            p2.AñadirIntegrante(f25);
            p2.AñadirIntegrante(f26);
            p2.AñadirIntegrante(f27);

            foreach (SeleccionFutbol integrante in p2.GetSeleccionPais())
            {
                Console.WriteLine(integrante.GetType().Name.ToUpper());
                Console.WriteLine(integrante.ToString());
                integrante.PrepararPartido();
                integrante.JugarPartido();
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine("Número de integrantes: " + p2.GetSeleccionPais().Count);

            p2.BajaSeleccion();
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
