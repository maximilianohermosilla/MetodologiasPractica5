using System;

namespace Practica
{

    // Practica 4 - Ejercicio 3 //

    public class StudentAdapter: Student
    {
        public IAlumno estudiante;
        bool muyEstudioso=false;
        bool proxyMuyEstudioso = false;
        

        public StudentAdapter(IAlumno alumno)
        {
            if (alumno.GetType().ToString() == "Practica.AlumnoMuyEstudioso")
            {
                muyEstudioso = true;
            }
            else if (alumno.GetType().ToString() == "Practica.ProxyAlumnoEstudioso")
            {
                proxyMuyEstudioso = true;
            }
            estudiante = alumno;
        }

        public string getName()
        {
            return estudiante.getNombre();
        }

        public int yourAnswerIs(int question)
        {
            if (muyEstudioso)
            {
                return ((AlumnoMuyEstudioso)estudiante).responderPregunta(question);
            }
            else if (proxyMuyEstudioso)
            {
                return ((ProxyAlumnoEstudioso)estudiante).responderPregunta(question);
            }
            else
            {
            	return estudiante.responderPregunta(question);
            }
            
        }
        public void setScore(int score)
        {
        	estudiante.setCalificacion(score);
        }
        
        public string showResult()
        {
        	return (estudiante.mostrarCalificacion());
        }

        // Practica 4 - Ejercicio 5 //


        public int getCalification()
        {
            return estudiante.getCalificacion();
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