﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasLibrary
{
    public class Directivo : Persona
    {
        public void Cargo()
        {
            dos = "Directivo";
        }

        public override void Resultado()
        {
            Console.WriteLine("La persona es: " + nombre + " " + apellido + " es un : " + dos);
        }
    }
}
