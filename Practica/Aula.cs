using System;


// Practica 5 - Ejercicio 3 //

namespace Practica
{
    public class Aula
    {
        Teacher profesor;
        StudentAdapter estudiante;

        public Aula()
        {
        }

        public void comenzar()
        {
            Console.WriteLine("Nueva Aula. Asignando profesor...");
            profesor = new Teacher();
        }

        public void nuevoAlumno(IAlumno alumno)
        {
            estudiante = new StudentAdapter(alumno);
            profesor.goToClass(estudiante);
        }

        public void claseLista()
        {
            profesor.teachingAClass();
        }



    }
}
