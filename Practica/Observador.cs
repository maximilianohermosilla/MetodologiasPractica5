using System;

namespace Practica
{
	/// <summary>
	/// Description of Observador.
	/// </summary>
	public interface Observador
	{
		void actualizar(double monto, Observado obs);
	}
}
