using System;

namespace Practica
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Practica 3 - Ejercicio 6");
			Coleccionable pila = new Pila<Comparable>();
			Console.WriteLine("\nLISTA DE COMPARABLES \n********************** \n1) NUMERO \n2) ALUMNO \n");
			int opcion = int.Parse(Console.ReadLine());
			
			llenar(pila, opcion);
			
			if (opcion==1){
				cambiarEstrategia(pila, new PorValorNumero());
			}
			else if (opcion==2){
				cambiarEstrategia(pila, new PorDni());
			}
			else{
				Console.WriteLine("Opcion Incorrecta");
				Console.ReadKey();
			}
			informar(pila, opcion);

			/////////////////////////////////////////////////////////////
			
			Console.WriteLine("Practica 3 - Ejercicio 4 y 5");
			
			GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
			LectorDeDatos lector=new LectorDeDatos();
			
			Console.WriteLine("NUMERO ALEATORIO ENTRE 0 Y ...: ");
			Console.WriteLine(gen.numeroAleatorio(lector.numeroPorTeclado()));
			Console.WriteLine("STRING ALEATORIO - CANTIDAD DE CARACTERES: ");
			Console.WriteLine(gen.stringAleatorio(lector.numeroPorTeclado()));
			
			Console.WriteLine("\nFABRICA DE COMPARABLES \n********************** \n1) NUMERO \n2) ALUMNO \n");
			int tipoComparable = int.Parse(Console.ReadLine());
			Comparable nuevo = FabricaDeComparables.crearComparables(tipoComparable);
			Console.WriteLine(nuevo);
		
			
				
	/*llenar(coleccionable, opcion)
	repetir 20 veces
	comparable = fabrica.crearAleatorio(opcion)
	coleccionable.agregar(comparable)
	
	informar(coleccionable, opcion)
	imprimir (colecionable.cuantos())
	imprimir (colecionable.minimo())
	imprimir (colecionable.maximo())
	comparable = fabrica.crearPorTeclado(opcion)
	si (coleccionable.contiene(comparable))
	imprimir(“El elemento leído está en la colección”)
	sino
	imprimir(“El elemento leído no está en la colección”)
	Adapte, modifique y compruebe el correcto funcionamiento de los métodos main de los ejercicios 9 y 17 de la práctica 1. Unifique ambos métodos en un único main.
	*/
			
			
		}
		
		public static void llenar(Coleccionable lista, int opcion){
			Random random = new Random();
			for (int x=1; x<=20 ; x++){
				Comparable comp= FabricaDeComparables.crearAleatorio(opcion);
				((Coleccionable)lista).agregar(comp);
			}
		}
		
		public static void informar(Coleccionable lista, int opcion){
			try{
			Console.Write("Cantidad de elementos: ");
			Console.WriteLine(lista.cuantos());
			Console.Write("Mínimo: ");
			Console.WriteLine((lista.menor()).informar());
			Console.Write("Máximo: ");
			Console.WriteLine(lista.mayor().informar());
			Comparable compTemp = FabricaDeComparables.crearPorTeclado(opcion);
			if (lista.contiene(compTemp)){
				Console.WriteLine("El elemento leído está en la colección");
			}
			else{
				Console.WriteLine("El elemento leído NO está en la colección");
			}
			}
			catch(FormatException){
				Console.WriteLine("* Numero invalido *");
				Console.ReadKey(true);
			}
		}
		
		/*public static void llenar(Coleccionable lista){
			Random random = new Random();
			for (int x=1; x<=20 ; x++){
				Comparable numero = new Numero(random.Next(1,100));
				((Coleccionable)lista).agregar(numero);
			}		
		}
			
		public static void informar(Coleccionable lista){
			try{
			Console.Write("Cantidad de elementos: ");
			Console.WriteLine(lista.cuantos());
			Console.Write("Mínimo: ");
			Console.WriteLine((lista.menor()).informar());
			Console.Write("Máximo: ");
			Console.WriteLine(lista.mayor().informar());
			Console.Write("Ingrese número: ");
			string num = Console.ReadLine();
			if (lista.contieneNumero(num)){
				Console.WriteLine("El elemento leído está en la colección");
			}
			else{
				Console.WriteLine("El elemento leído NO está en la colección");
			}
			}
			catch(FormatException){
				Console.WriteLine("* Numero invalido *");
				Console.ReadKey(true);
			}
		}*/
		
		public static void llenarPersonas(Coleccionable lista){
			
			string nombre;
			int dni;
			string[] nombres=new string[]{"Maxi","Paula","Roberto","Nacho","Adrian","Diego","Lucia","Florencia","Cintia","Ana","Graciela","Yesica","Daiana","Carolina","Gaston","Luis","Jacinto","Ramona","Ignacia","Viviana"};
			for (int x=1; x<=20 ; x++){
				Random random = new Random();
				nombre=nombres[random.Next(0,19)];
				dni=random.Next(12000000,40000000);
				Comparable persona = new Persona(nombre,dni);
				((Coleccionable)lista).agregar(persona);
				//Console.Write(((Persona)persona).getNombre() + " " + ((Persona)persona).getDni().ToString() + "\n");
			}
		}
		
		public static void llenarAlumnos(Coleccionable lista){
			cambiarEstrategia(lista,new PorDni());
			Random random = new Random();
			string nombre;
			int dni, legajo;
			decimal promedio;
			string[] nombres=new string[]{"Maxi","Paula","Roberto","Nacho","Adrian","Diego","Lucia","Florencia","Cintia","Ana","Graciela","Yesica","Daiana","Carolina","Gaston","Luis","Jacinto","Ramona","Ignacia","Viviana"};
			
			if(lista.GetType() == Type.GetType("Practica.Diccionario`1[Practica.Comparable]")){
				cambiarEstrategia(lista,new PorValorAlumno());
			}
			
			for (int x=1; x<=20 ; x++){
				nombre=nombres[random.Next(0,19)];
				dni=random.Next(12000000,40000000);
				legajo=random.Next(1,2000);
				promedio=decimal.Round((Convert.ToDecimal((random.NextDouble() + random.Next(1,10)))), 2);
				Comparable alumno = new Alumno(nombre,dni,legajo,promedio);
				
				if (!lista.contiene(alumno)){
				    	(lista).agregar(alumno);}
				else{
					//Console.WriteLine("Ya existe el alumno");
				}
				//Console.Write(((Alumno)alumno).getNombre() + " " + ((Alumno)alumno).getDni().ToString() + " " + ((Alumno)alumno).getLegajo() + " " + ((Alumno)alumno).getPromedio().ToString() + "\n");
			}
		}	
		public static void imprimirElementos(Coleccionable colect){
			((Iterable)colect).crearIterador();
			((Iterable)colect).recorrer();
		}
		
		public static void cambiarEstrategia(Coleccionable coleccion, EstrategiaComparar estrategia){
			coleccion.cambiarComparador(estrategia);
		}
		
	}
}