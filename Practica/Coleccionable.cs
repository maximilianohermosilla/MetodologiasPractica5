using System;
using System.Collections.Generic;

namespace Practica
{
	/// <summary>
	/// Description of Coleccionable.
	/// </summary>
	public interface Coleccionable
	{
		int cuantos();
		Comparable menor();
		Comparable mayor();
		void agregar(Comparable obj);
		bool contiene(Comparable obj);
		bool contieneNumero (string num);
		void cambiarComparador(EstrategiaComparar estrategia);
	}
}
