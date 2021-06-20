
using System;

namespace Practica
{
	
	// Practica 3 - Ejercicio 9	
	
	public class FabricaDeVendedores: FabricaDeComparables
	{	
		static Random random = new Random();
		public override Comparable crearComparable(FabricaDeComparables fabrica){
			Console.WriteLine("\nFABRICA DE VENDEDORES \n****************** \n1) ALEATORIO \n2) POR TECLADO \n");
			LectorDeDatos lector=new LectorDeDatos();
			int indice = lector.numeroPorTeclado();
			if (indice == num){
				Console.WriteLine("VENDEDOR ALEATORIO\n");
				return fabrica.crearAleatorio();
			}
			if (indice == alum){
				Console.WriteLine("INGRESAR VENDEDOR\n");
				return fabrica.crearPorTeclado();
			}
			else{
				Console.WriteLine("Opcion incorrecta");
				return fabrica.crearAleatorio();
			}
		}
		
		public FabricaDeVendedores(){
		}
		
		public override Comparable crearAleatorio(){
			
			string nombre;
			int dni;
			double sueldoBasico;
			string[] nombres=new string[]{"Maxi","Paula","Roberto","Nacho","Adrian","Diego","Lucia","Florencia","Cintia","Ana","Graciela","Yesica","Daiana","Carolina","Gaston","Luis","Jacinto","Ramona","Ignacia","Viviana"};
			nombre=nombres[random.Next(0,19)];
			dni=random.Next(12000000,40000000);
			sueldoBasico=random.Next(20000,200000);
			Comparable vendedor = new Vendedor(nombre,dni,sueldoBasico);
			Console.WriteLine(vendedor);
			return vendedor;
		}
		
		public override Comparable crearPorTeclado(){
			LectorDeDatos lector=new LectorDeDatos();
			Console.WriteLine("NOMBRE");
			string nombre=lector.stringPorTeclado();
			Console.WriteLine("DNI");
			int dni=lector.numeroPorTeclado();
			Console.WriteLine("SUELDO");			
			int sueldo=lector.numeroPorTeclado();
			Comparable vendedor=new Vendedor(nombre,dni,sueldo);
			return vendedor;
		}
	}
}