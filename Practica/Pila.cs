using System;
using System.Collections.Generic;

namespace Practica
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila<T> : Coleccionable, Iterable
	{
		private List<Comparable> datos = new List<Comparable>();
		IteradorPila<T> it;
		EstrategiaComparar comparador;
        OrdenEnAula1 ordenInicio;
        OrdenEnAula1 ordenAulaLlena;
        OrdenEnAula2 ordenLlegaAlumno;


        public void push(Comparable elem) {
			this.datos.Add(elem);
		}
	
		public Comparable pop() {
			Comparable temp = this.datos[(this.datos.Count-1)];
			this.datos.RemoveAt(this.datos.Count-1);
			return temp;
		}
		
		public Comparable top() {
			return this.datos[(this.datos.Count-1)]; 
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
				if (comparador.esMenor(elemento,minimo)){
					minimo=elemento;
				}
			}
			return minimo;
		}
		
		public Comparable mayor(){
			Comparable maximo = datos[0];
			foreach (Comparable elemento in datos){
				if (comparador.esMayor(elemento,maximo)){
					maximo=elemento;
				}
			}
			return maximo;
		}

        public void agregar(Comparable obj)
        {
            if (this.isEmpty())
            {
                Console.WriteLine("Aula vacia. Orden Inicio");
                ordenInicio.ejecutar();
            }
            this.datos.Add(obj);

            if (this.cuantos() >= 40)
            {
                Console.WriteLine("Alumnos=40. Orden Aula Llena");
                ordenAulaLlena.ejecutar();
            }
            else
            {
                Console.WriteLine("Orden llega alumno " + this.cuantos());
                ordenLlegaAlumno.ejecutar(obj);
            }
        }

        public bool contiene(Comparable obj){
			bool existe=false;
			if(this.datos.Count>0){
				foreach (Comparable elemento in datos){
					if (comparador.esIgual(elemento,obj)){
						existe=true;
					}
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
			it= new IteradorPila<T>(this);
			return it;
		}
		
		public void recorrer(){
			//Console.WriteLine("Recorro iterador");
			if (it == null){
				it= new IteradorPila<T>(this);
			}
			it.siguiente();
		}
		
		public void cambiarComparador(EstrategiaComparar comp){
			comparador=comp;
		}

        // METODOS ORDENABLE //
        public void setOrdenInicio(OrdenEnAula1 orden)
        {
            ordenInicio = orden;
        }

        public void setOrdenLlegadaAlumno(OrdenEnAula2 orden)
        {
            ordenLlegaAlumno = orden;
        }

        public void setOrdenAulaLLena(OrdenEnAula1 orden)
        {
            ordenAulaLlena = orden;
        }
    }
}