
using System;

namespace Practica
{
	
	/// Practica 3 - Ejercicio 3 
	
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
