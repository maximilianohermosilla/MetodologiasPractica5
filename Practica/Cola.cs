using System;
using System.Collections.Generic;

namespace Practica
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola<T> : Coleccionable, Iterable, Ordenable
	{
		private List<Comparable> datos = new List<Comparable>();
		IteradorCola<T> it;
		EstrategiaComparar comparador;
        OrdenEnAula1 ordenInicio;
        OrdenEnAula1 ordenAulaLlena;
        OrdenEnAula2 ordenLlegaAlumno;
		
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
                Console.WriteLine("Orden llega alumno "+this.cuantos());
                ordenLlegaAlumno.ejecutar(obj);
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
		
		public Iterador crearIterador(){
			//Console.WriteLine("\nCreo iterador");
			it= new IteradorCola<T>(this);
			return it;
		}
		
		public void recorrer(){
			//Console.WriteLine("Recorro iterador");
			if (it == null){
				it= new IteradorCola<T>(this);
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
