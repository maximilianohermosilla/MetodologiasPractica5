using System;

namespace Practica
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Practica 3 - Ejercicios 2, 3, 4 y 5
						
			
			Console.WriteLine("Practica 3 - Ejercicios 2, 3, 4 y 5");
			
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
			
					
			//********************************************************//
			// Practica 3 - Ejercicio 6
			// Practica 3 - Ejercicio 9
			
			Console.WriteLine("Practica 3 - Ejercicios 6 y 9");
			
			Coleccionable pila = new Pila<Comparable>();
			Coleccionable cola = new Cola<Comparable>();
			ColeccionMultiple multiple = new ColeccionMultiple(((Pila<Comparable>)pila), ((Cola<Comparable>)cola));
			

			Console.WriteLine("\nLISTA DE COMPARABLES \n********************** \n1) NUMERO \n2) ALUMNO \n3) VENDEDOR\n");
			int opcion = int.Parse(Console.ReadLine());
			
			llenar(pila, opcion);
			llenar(cola,opcion);
			
			
			if (opcion==1){
				cambiarEstrategia(pila, new PorValorNumero());
			}
			else if (opcion==2){
				cambiarEstrategia(pila, new PorDni());
			}
			else if (opcion==3){
				cambiarEstrategia(pila, new PorBonus());
			}
			else{
				Console.WriteLine("Opcion Incorrecta");
				Console.ReadKey();
			}
			Console.WriteLine("\nInformo Pila\n************\n");
			informar(pila, opcion);
			Console.WriteLine("\nInformo Cola\n************\n");
			informar(cola, opcion);
			Console.WriteLine("\nInformo Multiple\n************\n");
			informar(multiple, opcion);
			
			
			//****************************************************************************//
			// Practica 3 - Ejercicio 13
			
			
			Console.WriteLine("\nPractica 3 - Ejercicio 13\n");
			
			Coleccionable conjunto = new Conjunto<Comparable>();
			
			Console.WriteLine("LISTA DE VENDEDORES");
			llenar(conjunto,3);
			cambiarEstrategia(conjunto, new PorDniVendedor());
			Console.WriteLine("\nJORNADA DE VENTAS");
			jornadaDeVentas(conjunto);
			
			
			//****************************************************************************//
			// Practica 3 - Ejercicio 14
			
			
			Console.WriteLine("\nPractica 3 - Ejercicio 14\n");
			
			Coleccionable conjuntoVendedores = new Conjunto<Comparable>();
			llenar(conjuntoVendedores,3);
			Gerente gerente = new Gerente();
			agregarObservadorColeccion(conjuntoVendedores, gerente);
			Console.WriteLine("\nJORNADA DE VENTAS");
			jornadaDeVentas(conjuntoVendedores);
			Console.WriteLine("\nLISTA MEJORES VENDEDORES: ");
			gerente.cerrar();
			
			
			Console.ReadKey();
		}
		
		
		//    METODOS    //
		//***************//
		
		
	
		// Practica 3 - Ejercicio 6
		
		public static void llenar(Coleccionable lista, int opcion){
			Random random = new Random();
			for (int x=1; x<=20 ; x++){
				Comparable comp= FabricaDeComparables.crearAleatorio(opcion);
				((Coleccionable)lista).agregar(comp);
			}
		}
		
		// Practica 3 - Ejercicio 6
		
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
		
			
		// Practica 3 - Ejercicio 13
		
		public static void jornadaDeVentas(Coleccionable lista){
			Random random= new Random();
			Iterador ite = ((Iterable)lista).crearIterador();
			while(! ite.fin()){
				double monto=random.Next(1,7000);
				Console.Write((ite.actual()).ToString() + "\nVENTA: ");
				((Vendedor)(ite.actual())).venta(monto);
				if (monto>5000){
					((Vendedor)(ite.actual())).notificar(monto);
				}
				ite.siguiente();
			}
		}
		
		// Practica 3 - Ejercicio 14
		
		public static void agregarObservadorColeccion(Coleccionable lista, Observador observer){
			Iterador ite = ((Iterable)lista).crearIterador();
			while(!ite.fin()){
				((Observado)(ite.actual())).agregarObservador(observer);
				ite.siguiente();
			}
		}
			
			
		
		///////////////////////////////////////////////////////////////////////////////////
		
				
		
		// PRACTICA 2
		
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