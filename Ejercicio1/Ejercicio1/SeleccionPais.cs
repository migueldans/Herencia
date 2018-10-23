using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class SeleccionPais
    {
        private string nombrePais;
        private List<SeleccionFutbol> integrantes;
        //Variables estaticas que uso para contar entrenadores y masajistas que hay en SeleccionPais
        private static int numEntrenador, numMasajista;

        //Este construtor inicia una lista vacía
        public SeleccionPais(string nombrePais)
        {
            this.nombrePais = nombrePais;
            integrantes = new List<SeleccionFutbol>();
        }
        //Este constructor recibe una lista que has llenado previamente en el main
        public SeleccionPais(string nombrePais, List<SeleccionFutbol> integrantes)
        {
            this.nombrePais = nombrePais;
            this.integrantes = integrantes;
        }

        //Este metodo recibe un objeto del tipo SeleccionFutbol(puede ser: Entrenador, Masajista,Futbolista) y lo añade a la lista
        public void AñadirIntegrante(SeleccionFutbol i)
        {
            //Si el metodo MeterIntegrante nos devuelve true, añadiremos un integrante
            if (AltaSeleccion(i))
            {
                //Si el objeto que queremos meter es un entrenador, le añadimos uno al contador de entrenadores.
                if (i.GetType().Name == "Entrenador")
                {
                    numEntrenador++;
                }
                //Si el objeto que queremos meter es un masajista, le añadimos uno al contador de masajistas
                else if (i.GetType().Name == "Masajista")
                {
                    numMasajista++;
                }
                //Como hemos verificado que se puede meter, lo metemos
                Console.WriteLine("Integrante del tipo " + i.GetType().Name + " añadido.");
                integrantes.Add(i);
            }
        }

        //Es un getter para que te devuelva la lista de SeleccionPais
        public List<SeleccionFutbol> GetSeleccionPais()
        {
        return integrantes;
        }

        public Boolean AltaSeleccion(SeleccionFutbol i)
        {
            //Primero compruebo que la seleccionPais no está llena, el tope es de 30 integrantes
            if(integrantes.Count <30)
            {
                //si el integrante es un entrenador y no se supera el limite, se puede meter con return true
                if (i.GetType().Name == "Entrenador"&& numEntrenador <2)
                {
                    return true;
                }
                //si el integrante es un masajista y no se supera el limite, se puede meter con return true
                else if (i.GetType().Name=="Masajista" && numMasajista<4)
                {
                    return true;
                }
                //en el caso de futbolista se pueden meter sin limite hasta llegar al limite principal
                else if (i.GetType().Name=="Futbolista")
                {
                    return true;
                }
                return false;
            }
            Console.WriteLine("Ya has seleccionado suficientes " + i.GetType().Name + "s en la selección");
            //Console.ReadLine();
            return false;
        }
        public Boolean BajaSeleccion()
        {
            Console.WriteLine("\nIntroduzca el Id del integrante que desee eliminar: ");
            int baja = Convert.ToInt32(Console.ReadLine());

            foreach (SeleccionFutbol integrante in integrantes)
            {
                if (baja == integrante.GetId())
                {
                    if(integrante.GetType().Name == "Entrenador")
                    {
                        numEntrenador--;
                    }
                    else if (integrante.GetType().Name == "Masajista")
                    {
                        numMasajista--;
                    }
                    integrantes.Remove(integrante);
                    Console.WriteLine("Se ha borrado el integrante.");
                    return true;
                }
            }
            Console.WriteLine("El Id no existe.");
            return false;
        }

    }
}
