using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasLibrary
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string dos;
        
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            set
            {
                apellido = value;
            }
            get
            {
                return apellido;
            }
        }
               
        public virtual void Resultado()
        {
            Console.WriteLine("La persona se llama: " + nombre +apellido);
        }
    }
}
