using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica
{

    public class StudentsFactory : FabricaDeAlumnos
    {
        static Random random = new Random();
        public new IAlumno crearAleatorio()
        {
            IAlumno aluDec = (Alumno)base.crearAleatorio();

            aluDec = new LegajoDecorator(aluDec);
            aluDec = new LetrasDecorator(aluDec);
            aluDec = new PromocionDecorator(aluDec);
            aluDec = new NumeroDecorator(aluDec);
            aluDec = new CuadroDecorator(aluDec);

            return aluDec;
        }
        public new IAlumno crearProxy()
        {
            string nombre;
            string[] nombres = new string[] { "Maxi", "Paula", "Roberto", "Nacho", "Adrian", "Diego", "Lucia", "Florencia", "Cintia", "Ana", "Graciela", "Yesica", "Daiana", "Carolina", "Gaston", "Luis", "Jacinto", "Ramona", "Ignacia", "Viviana" };
            nombre = nombres[random.Next(0, 19)];
            IAlumno alumno = new ProxyAlumno(nombre);
            Console.WriteLine("Se creo el proxy: " + alumno.getNombre());
            return alumno;
        }
    }

    public class StudentsTopFactory : FabricaDeAlumnosEstudiosos
    {
        static Random random = new Random();

        public new IAlumno crearAleatorio()
        {
            IAlumno aluDec = new AlumnoMuyEstudioso((IAlumno)base.crearAleatorio());

            aluDec = new LegajoDecorator(aluDec);
            aluDec = new LetrasDecorator(aluDec);
            aluDec = new PromocionDecorator(aluDec);
            aluDec = new NumeroDecorator(aluDec);
            aluDec = new CuadroDecorator(aluDec);

            return aluDec;
        }

        public new IAlumno crearProxy()
        {
            string nombre;
            string[] nombres = new string[] { "Paula", "Roberto", "Nacho", "Adrian", "Diego", "Lucia", "Florencia", "Cintia", "Ana", "Graciela", "Yesica", "Daiana", "Carolina", "Gaston", "Luis", "Jacinto", "Ramona", "Ignacia", "Viviana", "Maxi" };
            nombre = nombres[random.Next(0, 19)];
            IAlumno alumno = new ProxyAlumnoEstudioso(nombre);
            Console.WriteLine("Se creo el proxy estudioso: " + alumno.getNombre());
            return alumno;
        }
    }

}

