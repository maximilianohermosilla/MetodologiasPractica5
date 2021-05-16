using System;
using System.Collections.Generic;

namespace Practica
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto<T>: Coleccionable, Iterable
	{
		private List<Comparable> datos = new List<Comparable>();
		IteradorConjunto<T> it;
		EstrategiaComparar comparador;
		
		public int cuantos(){
			return datos.Count;
		}
		
		public Comparable actual(){
			return datos[cuantos()-1];
		}
		
		public Comparable menor(){
			Comparable minimo = datos[0];
			foreach (Comparable elemento in datos){
				if (((Comparable)elemento).sosMenor(minimo)){
					minimo=elemento;
				}
			}
			return minimo;
		}
		
		public Comparable mayor(){
			Comparable maximo = datos[0];
			foreach (Comparable elemento in datos){
				if (((Comparable)elemento).sosMayor(maximo)){
					maximo=elemento;
				}
			}
			return maximo;
		}
		
		public void agregar(Comparable obj){
			if (!this.pertenece(obj)){
				this.datos.Add(obj);
			}
			else if (this.pertenece(obj)){
				Console.WriteLine("El objeto ya existe");
			}
			
		}
		
		public bool contiene(Comparable obj){
			bool existe=false;
			foreach (Comparable elemento in datos){
				if (elemento.sosIgual(obj)){
					existe=true;
				}
			}
			return existe;
		}
		
		public bool contieneNumero(string num){
			bool existe=false;
			foreach (Comparable elemento in datos){
				if (elemento.informar() == num.ToString()){
					existe=true;
				}
			}
			return existe;
		}
		
		public bool pertenece(Comparable obj){
			return this.contiene(obj);
		}
		
		public Iterador crearIterador(){
			//Console.WriteLine("\nCreo iterador");
			it= new IteradorConjunto<T>(this);
			return it;
		}
		
		public void recorrer(){
			//Console.WriteLine("Recorro iterador");
			if (this.datos.Count>0){
				while(!it.fin()){
					foreach(Comparable elem in datos){
						Console.WriteLine(elem);
						it.siguiente();
				    }
				}
			}
		}
		
		public void cambiarComparador(EstrategiaComparar comp){
			comparador=comp;
		}
	}
}