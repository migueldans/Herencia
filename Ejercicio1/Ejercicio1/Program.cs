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
            Entrenador e1 = new Entrenador(1, 56, "Jose", "Cahembra", "oriundo",true,true);
            
            Masajista m1 = new Masajista(1, 34, "Bill", "Cosby", 10, "Medico", true, true);
            Masajista m2 = new Masajista(2, 54, "Juan", "Jose", 40, "Chaman", true, false);

            Futbolista f1 = new Futbolista(1, 19, "Pepe", "Ruiz", 9, "delantero", true, true);
            Futbolista f2 = new Futbolista(2, 29, "Bobe", "Bobeto", 9, "medio", true, false);
            Futbolista f3 = new Futbolista(3, 16, "Vincent", "Vincenzo", 9, "defensa", true, true);
            Futbolista f4 = new Futbolista(4, 34, "Fran", "Roche", 9, "portero", true, true);

            List<Entrenador> ListaEntrenador = new List<Entrenador>
            {
                e1
            };
            List<Futbolista> ListaFutbolista = new List<Futbolista>
            {
                f1,
                f2,
                f3,
                f4
            };
            List<Masajista> ListaMasajista = new List<Masajista>
            {
                m1,
                m2
            };

            foreach(Entrenador x in ListaEntrenador)
            {
                Console.WriteLine(x.MostrarDatosEntrenador());
            }
            foreach (Futbolista x in ListaFutbolista)
            {
                Console.WriteLine(x.MostrarDatosFutbolista());
            }
            foreach (Masajista x in ListaMasajista)
            {
                Console.WriteLine(x.MostrarDatosMasajista());
            }

            Console.ReadLine();
        }
    }
}
