using System;

namespace Practica
{
	/// <summary>
	/// Description of Observado.
	/// </summary>
	public interface Observado
	{
		void agregarObservador(Observador obs);
		void quitarObservador(Observador obs);
		void notificar(double monto);
	}
}
