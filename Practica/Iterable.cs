using System;

namespace Practica
{
	/// <summary>
	/// Description of Iterable.
	/// </summary>
	public interface Iterable
	{
		Iterador crearIterador();
		void recorrer();
	}
}
