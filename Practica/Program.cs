﻿using System;

namespace Practica
{
	class Program
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			// Practica 5 - Ejercicio 1 //

			Console.WriteLine("Practica 4 - Ejercicio 4");
			Console.WriteLine("************************\n");

			Teacher profesor = new Teacher();
			FabricaDeAlumnos fabricaAlumnos = new FabricaDeAlumnos();
			ProxyAlumno alumno;
			AlumnoMuyEstudioso alumnoEst;
			StudentAdapter estudiante;

			for (int i = 0; i < 20; i++)
			{
				alumno = (ProxyAlumno)fabricaAlumnos.crearProxy();
				if ((i % 2) == 0)
				{
					estudiante = new StudentAdapter(alumno);
				}
				else
				{
					alumnoEst = new AlumnoMuyEstudioso(alumno);
					estudiante = new StudentAdapter(alumnoEst);
				}
				Console.WriteLine(estudiante.estudiante.GetType());
				profesor.goToClass(estudiante);
			}

			profesor.teachingAClass();

			Console.ReadKey();

			// Practica 4 - Ejercicio 4 //
			/*
			Console.WriteLine("Practica 4 - Ejercicio 4");
			Console.WriteLine("************************\n");

			Teacher profesor = new Teacher();
			FabricaDeAlumnos fabricaAlumnos = new FabricaDeAlumnos();
			Alumno alumno;
			AlumnoMuyEstudioso alumnoEst;
			StudentAdapter estudiante;

			for (int i = 0; i < 20; i++)
            {
				alumno = (Alumno)fabricaAlumnos.crearAleatorio();
				if ((i%2) == 0)
                {
					estudiante = new StudentAdapter(alumno);
				}
                else
                {
					alumnoEst = new AlumnoMuyEstudioso(alumno);
					estudiante = new StudentAdapter(alumnoEst);
				}
				profesor.goToClass(estudiante);
            }

			profesor.teachingAClass();

			
			*/
			// Practica 4 - Ejercicio 6 //


			Console.WriteLine("Practica 4 - Ejercicio 6");
			Console.WriteLine("************************\n");

			Alumno alumnoDec = (Alumno)fabricaAlumnos.crearAleatorio();
			alumnoDec.setCalificacion(6);

			DecoratorCalificacion decorador = new Decorator(alumnoDec);
			Console.WriteLine("\nDECORATOR:");
			Console.WriteLine(decorador.mostrarCalificacion());

			LegajoDecorator legDec = new LegajoDecorator(decorador, alumnoDec);
			Console.WriteLine("\nLEGAJO DECORATOR:");
			Console.WriteLine(legDec.mostrarCalificacion());

			LetrasDecorator letrDec = new LetrasDecorator(legDec, alumnoDec);
			Console.WriteLine("\nLETRAS DECORATOR:");
			Console.WriteLine(letrDec.mostrarCalificacion());

			PromocionDecorator promDec = new PromocionDecorator(letrDec, alumnoDec);
			Console.WriteLine("\nPROMOCION DECORATOR:");
			Console.WriteLine(promDec.mostrarCalificacion());

			NumeroDecorator numDec = new NumeroDecorator(promDec, alumnoDec);
			Console.WriteLine("\nNUMERO DECORATOR:");
			Console.WriteLine(numDec.mostrarCalificacion());

			CuadroDecorator cuadroDec = new CuadroDecorator(numDec, alumnoDec);
			Console.WriteLine("\nCUADRO DECORATOR:");
			Console.WriteLine(cuadroDec.mostrarCalificacion());



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