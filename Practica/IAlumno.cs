using System;
using System.Collections.Generic;


// Practica 4 - Ejercicio 6 //

namespace Practica
{
	public interface IAlumno
    {
		string getNombre();
		int getLegajo();
		int getCalificacion();
		string getNotaLetras();
		string getPromocion();
		decimal getPromedio();
		int getDni();
		int responderPregunta(int pregunta);
		void setCalificacion(int calificacion);
				
        string mostrarCalificacion();
    }
}
