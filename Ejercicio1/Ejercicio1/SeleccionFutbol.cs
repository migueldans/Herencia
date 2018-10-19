using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class SeleccionFutbol
    {
        private int Id, Edad,cont;
        private string Nombre, Apellidos;
        bool Viajar=false;
        bool Concentrarse=false;

        public SeleccionFutbol()
        {
            cont=cont++;
        }

        public SeleccionFutbol(int id, int edad,string nombre,string apellidos,bool Viajar, bool Concentrarse)
        {
            this.Id = id;
            this.Edad = edad;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Viajar=false;
            this.Concentrarse = false;
            cont = cont++;
        }

        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            this.Id = id;
        }
        public int GetEdad()
        {
            return Edad;
        }
        public void SetEdad(int edad)
        {
            this.Edad = edad;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public void SetNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public string GetApellidos()
        {
            return Apellidos;
        }
        public void SetApellidos(string apellidos)
        {
            this.Apellidos = apellidos;
        }

        public string MostrarDatos()
        {
            return "Id: " + Id + " Edad: " + Edad + " Nombre: " + Nombre + " Apellidos: " + Apellidos+" y "+ Viajar+ " y está "+Concentrarse;
        }
        public void SetConcentrarse(bool concentrarse)
        {
            this.Concentrarse = concentrarse;
        }
        public string GetConcentrarse()
        {
            return "Concentrado";
        }

        public void SetViajar(bool viajar)
        {
            this.Viajar = viajar;
        }

        public string GetViajar()
        {
            return "Ha viajado";

        }
        public int Cont (int cont)
        {
            return cont;
        }
    }
}
