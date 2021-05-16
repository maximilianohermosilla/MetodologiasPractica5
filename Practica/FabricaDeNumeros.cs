
using System;

namespace Practica
{
	/// <summary>
	/// Description of FabricaDeNumeros.
	/// </summary>
	public class FabricaDeNumeros: FabricaDeComparables
	{
		public const int aleatorio=1;
		public const int porTeclado=2;
		
				
		public override Comparable crearComparable(FabricaDeComparables fabrica){
			Console.WriteLine("\nFABRICA DE NUMEROS \n****************** \n1) ALEATORIO \n2) POR TECLADO \n");
			LectorDeDatos lector=new LectorDeDatos();
			int indice = lector.numeroPorTeclado();
			if (indice == num){
				Console.WriteLine("NUMERO ALEATORIO\n");
				return fabrica.crearAleatorio();
			}
			if (indice == alum){
				Console.WriteLine("INGRESAR NUMERO\n");
				return fabrica.crearPorTeclado();
			}
			else{
				Console.WriteLine("Opcion incorrecta");
				return fabrica.crearAleatorio();
			}
		}
		
		override public Comparable crearAleatorio(){
			Random random = new Random();
			Numero numRandom = new Numero();
			numRandom.setValor(random.Next(1,100));
			return numRandom;
		}
		
		override public Comparable crearPorTeclado(){
			LectorDeDatos lector=new LectorDeDatos();
			Numero numTeclado = new Numero();
			numTeclado.setValor(lector.numeroPorTeclado());
			return numTeclado;
		}
	}
}
