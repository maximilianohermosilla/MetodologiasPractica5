using System;

namespace Practica
{
	
	// Practica 4 - Ejercicio 2 //
	
	public class AlumnoMuyEstudioso: Alumno
	{
		public AlumnoMuyEstudioso()
		{
		}
		
		public new int responderPregunta(int pregunta){
			return (pregunta%3);
		}
	}
}
