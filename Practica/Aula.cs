using System;


// Practica 5 - Ejercicio 3 //

namespace Practica
{
    public class Aula
    {
        Teacher profesor;

        public Aula()
        {

        }

        public void comenzar()
        {
            Console.WriteLine("Nueva Aula. Asignando profesor...");
            profesor = new Teacher();
        }

        public void nuevoAlumno(Alumno alumno)
        {
            StudentAdapter estudiante = new StudentAdapter(alumno);
            profesor.goToClass(estudiante);
        }

        public void claseLista()
        {
            profesor.teachingAClass();
        }



    }
}
