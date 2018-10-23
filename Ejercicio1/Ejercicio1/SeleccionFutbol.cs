using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class SeleccionFutbol
    {
        private int id, edad,cont;
        private string nombre, apellido;
        private bool viajar=true;
        private bool concentrarse=true;

        public SeleccionFutbol()
        {
            cont=cont++;
        }

        public SeleccionFutbol(int id, int edad,string nombre,string apellidos)
        {
            this.id = id;
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellidos;
            cont = cont++;
        }

        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetApellidos()
        {
            return apellido;
        }
        public void SetApellidos(string apellidos)
        {
            this.apellido = apellidos;
        }

        public override string ToString()
        {
            return "Id: " + id + " \nEdad: " + edad + " \nNombre: " + nombre + " \nApellidos: " + apellido+ "\n" +GetViajar() + " y " + GetConcentrarse();
        }

        public void Concentrarse()
        {
            this.concentrarse = true;
        }
        public void NoConcentrarse()
        {
            this.concentrarse = false;
        }

        public string GetConcentrarse()
        {
            if (concentrarse == true)
            {
                return "concentrado";
            }
            else
            {
                return "no concentrado";
            }
        }

        public void Viajar()
        {
            this.viajar = true;
        }

        public void NoViajar()
        {
            this.viajar = false;
        }

        public string GetViajar()
        {
            if (viajar == true)
            {
                return "Ha viajado";
            }
            else
            {
                return "No ha viajado";
            }
        }
        public virtual void Accion()
        {
           
        }
        public int Cont (int cont)
        {
            return cont;
        }
        public virtual void PrepararPartido()
        {
            Viajar();
            Concentrarse();
        }
        public virtual void JugarPartido()
        {

        }
    }
}
