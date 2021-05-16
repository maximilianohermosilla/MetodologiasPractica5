
using System;

namespace Practica
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos: FabricaDeComparables
	{	
		
		public override Comparable crearComparable(FabricaDeComparables fabrica){
			Console.WriteLine("\nFABRICA DE ALUMNOS \n****************** \n1) ALEATORIO \n2) POR TECLADO \n");
			LectorDeDatos lector=new LectorDeDatos();
			int indice = lector.numeroPorTeclado();
			if (indice == num){
				Console.WriteLine("ALUMNO ALEATORIO\n");
				return fabrica.crearAleatorio();
			}
			if (indice == alum){
				Console.WriteLine("INGRESAR ALUMNO\n");
				return fabrica.crearPorTeclado();
			}
			else{
				Console.WriteLine("Opcion incorrecta");
				return fabrica.crearAleatorio();
			}
		}
		
		public FabricaDeAlumnos(){
		}
		
		public override Comparable crearAleatorio(){
			Random random = new Random();
			string nombre;
			int dni, legajo;
			decimal promedio;
			string[] nombres=new string[]{"Maxi","Paula","Roberto","Nacho","Adrian","Diego","Lucia","Florencia","Cintia","Ana","Graciela","Yesica","Daiana","Carolina","Gaston","Luis","Jacinto","Ramona","Ignacia","Viviana"};
			nombre=nombres[random.Next(0,19)];
			dni=random.Next(12000000,40000000);
			legajo=random.Next(1,2000);
			promedio=decimal.Round((Convert.ToDecimal((random.NextDouble() + random.Next(1,10)))), 2);
			Comparable alumno = new Alumno(nombre,dni,legajo,promedio);
			return alumno;
		}
		
		public override Comparable crearPorTeclado(){
			LectorDeDatos lector=new LectorDeDatos();
			Console.WriteLine("NOMBRE");
			string nombre=lector.stringPorTeclado();
			Console.WriteLine("DNI");
			int dni=lector.numeroPorTeclado();
			Console.WriteLine("LEGAJO");			
			int legajo=lector.numeroPorTeclado();
			Console.WriteLine("PROMEDIO");
			decimal promedio=Convert.ToDecimal(lector.numeroPorTeclado());
			Comparable alumno=new Alumno(nombre,dni,legajo,promedio);
			return alumno;
		}
	}
}
