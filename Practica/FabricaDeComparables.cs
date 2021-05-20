using System;

namespace Practica
{
	
	/// Practica 3 - Ejercicio 4
	
	public abstract class FabricaDeComparables
	{
		public const int num=1;
		public const int alum=2;
		public const int vend=3;
		
		
		public static Comparable crearComparables(int tipoComparable){
			FabricaDeComparables fabrica = null;
			if (tipoComparable == num){
				fabrica = new FabricaDeNumeros();
			}
			else if (tipoComparable == alum){
				fabrica = new FabricaDeAlumnos();
			}
			else if (tipoComparable == vend){
				fabrica = new FabricaDeVendedores();
			}
			else{
				return null;
			}
			return fabrica.crearComparable(fabrica);
		}
		
		public static Comparable crearAleatorio(int tipoComparable){
			FabricaDeComparables fabrica = null;
			if (tipoComparable == num){
				fabrica = new FabricaDeNumeros();
			}
			else if (tipoComparable == alum){
				fabrica = new FabricaDeAlumnos();
			}
			else if (tipoComparable == vend){
				fabrica = new FabricaDeVendedores();
			}
			else{
				return null;
			}
			return fabrica.crearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int tipoComparable){
			FabricaDeComparables fabrica = null;
			if (tipoComparable == num){
				fabrica = new FabricaDeNumeros();
			}
			else if (tipoComparable == alum){
				fabrica = new FabricaDeAlumnos();
			}
			else if (tipoComparable == vend){
				fabrica = new FabricaDeVendedores();
			}
			else{
				return null;
			}
			return fabrica.crearPorTeclado();
		}
		
		public abstract Comparable crearComparable(FabricaDeComparables fact);
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
	}
}
