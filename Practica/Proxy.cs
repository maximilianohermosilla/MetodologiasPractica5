using System;
using System.Collections.Generic;

// Practica 5 - Ejercicio 1 //

namespace Practica
{
    public class ProxyAlumno : Alumno
    {
        Alumno alumnoReal = null;
        FabricaDeAlumnos fabricaAlumnos = new FabricaDeAlumnos();
        
        public ProxyAlumno(string nom)
        {
            nombre = nom;
        }

        public new string getNombre()
        {
            return nombre;
        }

        public new int responderPregunta(int pregunta)
        {
            if (alumnoReal == null)
            {
                Console.WriteLine("Creo el alumno a traves del proxy");
                alumnoReal = (Alumno)fabricaAlumnos.crearAleatorio();
                alumnoReal.setNombre(nombre);
            }
            return alumnoReal.responderPregunta(pregunta);
        }

        


    }
}
