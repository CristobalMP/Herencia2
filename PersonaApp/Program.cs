using System;
using PersonasLibrary;

namespace PersonaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alu = new Alumno();
            alu.Nombre = "Juan";
            alu.Apellido = "Robles";
            alu.Cargo();
            alu.Resultado();

            Profesor pro = new Profesor();
            pro.Nombre = "Claudio";
            pro.Apellido = "Montoya";
            pro.Cargo();
            pro.Resultado();

            Administrativo adm = new Administrativo();
            adm.Nombre = "Javiera";
            adm.Apellido = "Saez";
            adm.Cargo();
            adm.Resultado();
            
            Directivo dir = new Directivo();
            dir.Nombre = "Morelia";
            dir.Apellido = "Salvo";
            dir.Cargo();
            dir.Resultado();


            Console.ReadKey();
        }
    }
}
