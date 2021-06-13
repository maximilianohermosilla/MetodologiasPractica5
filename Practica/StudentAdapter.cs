using System;

namespace Practica
{

    // Practica 4 - Ejercicio 3 //

    public class StudentAdapter: Student
    {
        public Comparable estudiante;
        bool muyEstudioso=false;
        bool proxy = false;
        

        public StudentAdapter(Alumno alumno)
        {
            if (alumno.GetType().ToString() == "Practica.AlumnoMuyEstudioso")
            {
                muyEstudioso = true;
            }
            estudiante = alumno;
        }

        public StudentAdapter(ProxyAlumno alumno)
        {
            if (alumno.GetType().ToString() == "Practica.ProxyAlumno")
            {
                proxy = true;
            }
            estudiante = alumno;
        }

        public string getName()
        {
            return ((Alumno)estudiante).getNombre();
        }

        public int yourAnswerIs(int question)
        {
            if (muyEstudioso)
            {
                return ((AlumnoMuyEstudioso)estudiante).responderPregunta(question);
            }
            else if (proxy)
            {
                return ((ProxyAlumno)estudiante).responderPregunta(question);

            }
            else
            {
                return ((Alumno)estudiante).responderPregunta(question);
            }
            
        }
        public void setScore(int score)
        {
            ((Alumno)estudiante).setCalificacion(score);
        }
        public string showResult()
        {

            // Practica 4 - Ejercicio 7 //
   

            DecoratorCalificacion decorador = new Decorator((Alumno)estudiante);
            LegajoDecorator legDec = new LegajoDecorator(decorador, (Alumno)estudiante);
            LetrasDecorator letrDec = new LetrasDecorator(legDec, (Alumno)estudiante);
            NumeroDecorator numDec = new NumeroDecorator(letrDec, (Alumno)estudiante);
            PromocionDecorator promDec = new PromocionDecorator(numDec, (Alumno)estudiante);
            CuadroDecorator cuadroDec = new CuadroDecorator(promDec, (Alumno)estudiante);
            return (cuadroDec.mostrarCalificacion());
        }

        // Practica 4 - Ejercicio 5 //


        public int getCalification()
        {
            return ((Alumno)estudiante).getCalificacion();
        }

        public bool equals(Student student)
        {
            return this.getCalification() == ((StudentAdapter)student).getCalification();
        }

        public bool lessThan(Student student)
        {
            return this.getCalification() < ((StudentAdapter)student).getCalification();
        }

        public bool greaterThan(Student student)
        {
            return this.getCalification() > ((StudentAdapter)student).getCalification();
        }

    }
    

}