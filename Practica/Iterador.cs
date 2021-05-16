using System;
using System.Collections.Generic;

namespace Practica
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	public interface Iterador
	{
		Comparable actual();
		void siguiente();
		bool fin();
	}
	
	public class IteradorPila<T>: Iterador
	{
		Pila<T> pila;
		
		public IteradorPila(Pila<T> p){
			pila = p;
		}
		
		public Comparable actual(){
			if (!this.fin()){
				return pila.top();
			}
			else{
				return null;
			}
		}
		
		public void siguiente(){
			while (!this.fin()){
				Console.WriteLine(pila.pop());	
			}
		}
		
		public bool fin(){
			return pila.isEmpty();
		}
	}
	
	public class IteradorCola<T>: Iterador
	{
		Cola<T> cola;
		
		public IteradorCola(Cola<T> c){
			cola=c;	
		}
		
		public Comparable actual(){
			if (!this.fin()){
				return cola.top();
			}
			else{
				return null;
			}
		}
		
		public void siguiente(){
			while (!this.fin()){
				Console.WriteLine(cola.pop());	
			}
		}
		
		public bool fin(){
			return cola.isEmpty();
		}
	}
	
	public class IteradorConjunto<T>: Iterador
	{
		Conjunto<T> conj;
		int indice;
		
		public IteradorConjunto(Conjunto<T> c){
			conj=c;
			indice=0;
		}
		
		public Comparable actual(){
			return conj.actual();
		}
		
		public void siguiente(){
			indice++;
		}
		
		public bool fin(){
			return (conj.cuantos()<=indice);
		}
	}
	
	public class IteradorDiccionario<T>: Iterador
	{
		Diccionario<T> dict;
		int indice;
		
		public IteradorDiccionario(Diccionario<T> d){
			dict=d;
			indice=0;
		}
		public Comparable actual(){
			return dict.actual();
		}
		
		public void siguiente(){
			indice++;
		}
		
		public bool fin(){
			return (dict.cuantos()<=indice);
		}
	}
}
