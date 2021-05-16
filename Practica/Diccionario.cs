using System;
using System.Collections.Generic;

namespace Practica
{
	/// <summary>
	/// Description of Diccionario.
	/// </summary>
	public class Diccionario<T>: Coleccionable, Iterable
	{
		private List<Comparable> datos = new List<Comparable>();
		Numero num;
		int indice=0;
		EstrategiaComparar comparador = new PorValor();
		IteradorDiccionario<T> it;
		
		public int cuantos(){
			return this.datos.Count;
		}
		
		public Comparable actual(){
			return datos[cuantos()-1];
		}
		
		public Comparable menor(){
			Comparable minimo = this.datos[0];
			foreach (Comparable elemento in datos){
				if (comparador.esMenor((ClaveValor)elemento, (ClaveValor)minimo)){
					minimo=elemento;
				}
			}
			return minimo;
		}
		
		public Comparable mayor(){
			Comparable maximo = this.datos[0];
			foreach (Comparable elemento in datos){
				if (comparador.esMayor((ClaveValor)elemento, (ClaveValor)maximo)){
					maximo=elemento;
				}
			}
			return maximo;
		}
	
		public bool pertenece(Comparable obj){
			bool existe=false;
			foreach (Comparable elemento in datos){
				if (elemento.sosIgual(obj)){
					existe=true;
				}
			}
			return existe;
		}
		
		
		public bool contiene(Comparable obj){
			bool existe=false;
			foreach (Comparable elemento in datos){
				if (comparador.esIgual((Comparable)elemento,(Comparable)obj)){
					existe=true;
				}
			}
			return existe;
		}
		
		public bool contieneNumero(string num){
			int numero=int.Parse(num);
			Numero number = new Numero(numero);
			bool existe=false;
			
			foreach (ClaveValor elemento in datos){
				if(((Numero)(elemento.getClave())).sosIgual(number)){
					existe=true;
				}
			}			
			return existe;
		}

		public void agregar(Comparable valor){
			EstrategiaComparar comparadorAgregar = new PorClave();
			num=new Numero(indice);
			Comparable claveTemp = new ClaveValor(num, valor);
			foreach (Comparable elemento in datos){
				if (comparadorAgregar.esMayor((ClaveValor)elemento, (ClaveValor)claveTemp)){
					((ClaveValor)claveTemp).setClave(((ClaveValor)elemento).getClave());
				}
			}
			indice=(((Numero)((ClaveValor)claveTemp).getClave()).getValor() + 1);
			num.setValor(indice);
			agregarClaveValor(num, valor);
		}
		
		public void agregarClaveValor(Comparable clave, Object valor){
			ClaveValor temp= new ClaveValor(clave, valor);
			EstrategiaComparar comparadorAgregar = new PorClave();
			bool existe=false;
			if (this.cuantos() > 0){
				foreach (ClaveValor elemento in this.datos){
					if (comparadorAgregar.esIgual((Comparable)elemento,(Comparable)temp)){
						((ClaveValor)elemento).setValor(valor);
						//Console.WriteLine("Modifico clave");
						existe=true;
					}
					else{existe=false;}
				}
			}
			if (!existe){
				//Console.WriteLine("Agrego clave");
				//Console.WriteLine((temp.getValor()).GetType() + " " + temp.getValor());
				datos.Add(temp);
			}
		}
		
		public object valorDe(Comparable clave){
			bool existe=false;
			
			foreach (ClaveValor elemento in datos){
				if(((Numero)(elemento.getClave())).sosIgual((Numero)clave)){
					existe=true;
					return elemento.getValor();
				}
			}
			if (!existe){
				Console.WriteLine("La clave no existe");
				return null;
			}
			return null;
			
		}
		
		public Iterador crearIterador(){
			//Console.WriteLine("\nCreo iterador");
			it= new IteradorDiccionario<T>(this);
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
