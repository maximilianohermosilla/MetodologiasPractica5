using System;

namespace Practica
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{
		public const int num=1;
		public const int alum=2;
		
		
		public static Comparable crearComparables(int tipoComparable){
			FabricaDeComparables fabrica = null;
			if (tipoComparable == num){
				fabrica = new FabricaDeNumeros();
			}
			else if (tipoComparable == alum){
				fabrica = new FabricaDeAlumnos();
			}
			else{
				return null;
			}
			return fabrica.crearComparable(fabrica);
		}
		
		public abstract Comparable crearComparable(FabricaDeComparables fact);
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
	}
}
