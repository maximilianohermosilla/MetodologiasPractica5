using System;

namespace Practica
{
	class Program
	{
		public static void Main(string[] args)
		{
			
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
		
			
			
			/*Console.WriteLine("Ejercicio 8\n***********\n");
			
			Coleccionable pila = new Pila<Comparable>();
			Coleccionable cola = new Cola<Comparable>();
			Coleccionable conjunto = new Conjunto<Comparable>();
			Diccionario<Comparable> dictionary = new Diccionario<Comparable>();
			
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			llenarAlumnos(conjunto);
			llenarAlumnos(dictionary);
			
			Console.WriteLine("IMPRIMO PILA\n------------");
			imprimirElementos(pila);
			Console.WriteLine("\nIMPRIMO COLA\n------------");
			imprimirElementos(cola);
			Console.WriteLine("\nIMPRIMO CONJUNTO\n----------------");
			imprimirElementos(conjunto);
			Console.WriteLine("\nIMPRIMO DICCIONARIO\n-------------------");
			imprimirElementos(dictionary);
			
			
			
			Console.WriteLine("\nEjercicio 10\n***********\n");
			
			Coleccionable pila2 = new Pila<Comparable>();
			llenarAlumnos(pila2);
			Console.WriteLine("\nIMPRIMO PILA POR NOMBRE\n-----------------------");
			cambiarEstrategia(pila2, new PorNombre());
			informar(pila2);
			
			Console.WriteLine("\nIMPRIMO PILA POR LEGAJO\n-----------------------");
			cambiarEstrategia(pila2, new PorLegajo());
			informar(pila2);
			
			Console.WriteLine("\nIMPRIMO PILA POR PROMEDIO\n-----------------------");
			cambiarEstrategia(pila2, new PorPromedio());
			informar(pila2);
			
			Console.WriteLine("\nIMPRIMO PILA POR DNI\n-----------------------");
			cambiarEstrategia(pila2, new PorDni());
			informar(pila2);
			
			Console.WriteLine("\nIMPRIMO ELEMENTOS\n-----------------------");
			imprimirElementos(pila2);
			
			/*
			Coleccionable cola = new Cola<Comparable>();
			Coleccionable pila = new Pila<Comparable>();
					
			llenar(cola);
			Console.WriteLine("Informar Cola: \n--------------");
			informar(cola);
			
			llenar(pila);
			Console.WriteLine("\nInformar Pila: \n--------------");
			informar(pila);
						
			
			ColeccionMultiple multiple = new ColeccionMultiple(((Pila<Comparable>)pila), ((Cola<Comparable>)cola));
			Console.WriteLine("\nInformar ColeccionMultiple: \n---------------------------");
			informar(multiple);
			
			imprimirElementos(pila);
			imprimirElementos(cola);
			
			Coleccionable colaPersonas = new Cola<Comparable>();
			llenarPersonas(colaPersonas);
			Coleccionable pilaPersonas = new Pila<Comparable>();
			llenarPersonas(pilaPersonas);
			
			
			ColeccionMultiple multiplePersonas = new ColeccionMultiple(((Pila<Comparable>)pilaPersonas), ((Cola<Comparable>)colaPersonas));
			Console.WriteLine("\nInformar ColeccionMultiplePersonas: \n-----------------------------------");
			informar(multiplePersonas);
			
			imprimirElementos(pilaPersonas);
			imprimirElementos(colaPersonas);
			
			Coleccionable colaAlumnos = new Cola<Comparable>();
			llenarAlumnos(colaAlumnos);
			Coleccionable pilaAlumnos = new Pila<Comparable>();
			llenarAlumnos(pilaAlumnos);
			
			ColeccionMultiple multipleAlumnos = new ColeccionMultiple(((Pila<Comparable>)pilaAlumnos), ((Cola<Comparable>)colaAlumnos));
			Console.WriteLine("\nInformar ColeccionMultipleAlumnos: \n----------------------------------");
			informar(multipleAlumnos);	
			
			imprimirElementos(pilaAlumnos);
			imprimirElementos(colaAlumnos);

			Diccionario<Comparable> dictionary = new Diccionario<Comparable>();
			Numero number = new Numero(3);
			Numero number2 = new Numero(2);
			
			dictionary.agregarClaveValor(number,"avion");
			dictionary.agregarClaveValor(number,"casa");
			dictionary.agregarClaveValor(number2,"perro");

			ClaveValor valorVacio = new ClaveValor("gato");
			dictionary.agregar(valorVacio);
			
			
			Console.WriteLine("\n");
			
			
			Console.WriteLine("\nInformar Diccionario: \n---------------------");
			informar(dictionary);
						
			Console.WriteLine("\nIngrese clave: ");
			int insertNum = int.Parse(Console.ReadLine());
			Numero checkClave = new Numero(insertNum);
			Console.WriteLine(dictionary.valorDe(checkClave));
			
			imprimirElementos(dictionary);
			*/
			
			Console.ReadKey();
		}
		
		public static void llenar(Coleccionable lista){
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
			/*Console.Write("Ingrese número: ");
			string num = Console.ReadLine();
			if (lista.contieneNumero(num)){
				Console.WriteLine("El elemento leído está en la colección");
			}
			else{
				Console.WriteLine("El elemento leído NO está en la colección");
			}*/
			}
			catch(FormatException){
				Console.WriteLine("* Numero invalido *");
				Console.ReadKey(true);
			}
		}
		
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