using System;

namespace Practica
{
	
	// Practica 4 - Ejercicio 2 //
	
	public class AlumnoMuyEstudioso: Alumno
	{
		public AlumnoMuyEstudioso(Alumno alumno)
		{
            this.nombre = alumno.getNombre();
			this.legajo = alumno.getLegajo();
			this.promedio = alumno.getPromedio();
			this.dni = alumno.getDni();
		}
		
		public new int responderPregunta(int pregunta){
			return (pregunta % 3);
		}
	}
}
