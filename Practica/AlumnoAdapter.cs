
using System;

namespace Practica
{
	/// <summary>
	/// Description of AlumnoAdapter.
	/// </summary>
	public class AlumnoAdapter: Alumno
	{

		Student estudiante;

		public AlumnoAdapter(Student alumno){
			estudiante = alumno;
		}

		public new string getNombre()
        {
			return estudiante.getName();
        }

		public new int responderPregunta(int question)
        {
			return estudiante.yourAnswerIs(question);
        }
		public new void setCalificacion(int score)
        {
			estudiante.setScore(score);
        }
		public new string mostrarCalificacion()
        {
			return estudiante.showResult();
        }

		public bool sosIgual(Student student)
        {
			return estudiante.equals(student);
        }

		public bool sosMenor(Student student)
        {
			return estudiante.lessThan(student);
        }

		public bool sosMayor(Student student)
        {
			return estudiante.greaterThan(student);
        }


	}
}
