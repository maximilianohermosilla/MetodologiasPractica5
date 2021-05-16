
using System;

namespace Practica
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
		
		public int numeroPorTeclado(){
			Console.WriteLine("Ingrese un numero: ");
			int numero=int.Parse(Console.ReadLine());
			return numero;
		}
		
		public string stringPorTeclado(){
			Console.WriteLine("Ingrese texto: ");
			string cadena=Console.ReadLine();
			return cadena;
		}
	}
}
