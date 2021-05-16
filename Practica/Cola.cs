using System;
using System.Collections.Generic;

namespace Practica
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola<T> : Coleccionable, Iterable
	{
		private List<Comparable> datos = new List<Comparable>();
		IteradorCola<T> it;
		EstrategiaComparar comparador;
		
		public void push(Comparable elem) {
			this.datos.Add(elem);
		}
	
		public Comparable pop() {
			Comparable temp = this.datos[0];
			this.datos.RemoveAt(0);
			return temp;
		}
		
		public Comparable top() {
			return this.datos[0]; 
		}
		
		public bool isEmpty() {
				return this.datos.Count == 0;
		}
		
	
		public int cuantos(){
			return datos.Count;
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
			this.datos.Add(obj);
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
		
		public Iterador crearIterador(){
			//Console.WriteLine("\nCreo iterador");
			it= new IteradorCola<T>(this);
			return it;
		}
		
		public void recorrer(){
			//Console.WriteLine("Recorro iterador");
			it.siguiente();
		}
		
		public void cambiarComparador(EstrategiaComparar comp){
			comparador=comp;
		}
	}
}
