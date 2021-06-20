using System;
using System.Collections.Generic;

// Practica 5 - Ejercicio 1 //

namespace Practica
{
    public class ProxyAlumno : IAlumno, Comparable
    {
        Alumno alumnoReal = null;
        string nombre;
        FabricaDeAlumnos fabricaAlumnos = new FabricaDeAlumnos();
        
        public ProxyAlumno()
        {
        }

        public ProxyAlumno(string nom)
        {
            nombre = nom;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int responderPregunta(int pregunta)
        {
            if (alumnoReal == null)
            {
                Console.WriteLine("Creo el alumno a traves del proxy");
                alumnoReal = (Alumno)fabricaAlumnos.crearAleatorio();
                ((Alumno)alumnoReal).setNombre(nombre);
            }
            return alumnoReal.responderPregunta(pregunta);
        }

        // METODOS INTERFACE IALUMNO //
        public int getCalificacion() { return alumnoReal.getCalificacion(); }

        public int getDni() { return alumnoReal.getDni(); }

        public int getLegajo() { return alumnoReal.getLegajo(); }

        public string getNotaLetras() { return alumnoReal.getNotaLetras(); }

        public decimal getPromedio() { return alumnoReal.getPromedio(); }

        public string getPromocion() { return alumnoReal.getPromocion(); }

        public string mostrarCalificacion() { return alumnoReal.mostrarCalificacion(); }

        public void setCalificacion(int calificacion) { alumnoReal.setCalificacion(calificacion); }


        // METODOS INTERFACE COMPARABLE //
        public bool sosIgual(Comparable obj) { return alumnoReal.sosIgual(obj); }

        public bool sosMenor(Comparable obj) { return alumnoReal.sosMenor(obj); }

        public bool sosMayor(Comparable obj) { return alumnoReal.sosMayor (obj); }

        public string informar() { return alumnoReal.informar(); }
    }

    public class ProxyAlumnoEstudioso: IAlumno, Comparable
    {
        AlumnoMuyEstudioso alumnoRealEstudioso = null;
        private string nombreEstudioso;
        FabricaDeAlumnosEstudiosos fabricaAlumnos = new FabricaDeAlumnosEstudiosos();

        public ProxyAlumnoEstudioso()
        {
        }

        public ProxyAlumnoEstudioso(string name)
        {
            nombreEstudioso=name;
        }

        public  int responderPregunta(int pregunta)
        {
            
            if (alumnoRealEstudioso == null)
            {
                Console.WriteLine("Creo el alumno estudioso a traves del proxy");
                alumnoRealEstudioso = (AlumnoMuyEstudioso)fabricaAlumnos.crearAleatorio();
                ((AlumnoMuyEstudioso)alumnoRealEstudioso).setNombre(nombreEstudioso);
            }
            return ((AlumnoMuyEstudioso)alumnoRealEstudioso).responderPregunta(pregunta);
        }

        // METODOS INTERFACE IALUMNO //
        public  int getCalificacion() { return alumnoRealEstudioso.getCalificacion(); }

        public  int getDni() { return alumnoRealEstudioso.getDni(); }

        public  int getLegajo() { return alumnoRealEstudioso.getLegajo(); }

        public  string getNotaLetras() { return alumnoRealEstudioso.getNotaLetras(); }

        public  decimal getPromedio() { return alumnoRealEstudioso.getPromedio(); }

        public  string getPromocion() { return alumnoRealEstudioso.getPromocion(); }

        public  string mostrarCalificacion() { return alumnoRealEstudioso.mostrarCalificacion(); }

        public  void setCalificacion(int calificacion) { alumnoRealEstudioso.setCalificacion(calificacion); }

        public  string getNombre() { return nombreEstudioso; }

        // METODOS INTERFACE COMPARABLE //
        public bool sosIgual(Comparable obj)  { return alumnoRealEstudioso.sosIgual(obj); }

        public bool sosMenor(Comparable obj) { return alumnoRealEstudioso.sosMenor(obj); }

        public bool sosMayor(Comparable obj) { return alumnoRealEstudioso.sosMayor(obj); }

        public string informar() { return alumnoRealEstudioso.informar(); }
    }
}
