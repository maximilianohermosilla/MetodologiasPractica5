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
        OrdenEnAula1 ordenInicio;
        OrdenEnAula1 ordenAulaLlena;
        OrdenEnAula2 ordenLlegaAlumno;

        public int cuantos(){
			return this.datos.Count;
		}

        public bool isEmpty()
        {
            return this.datos.Count == 0;
        }
        public Comparable actual(int indice){
			return (Comparable)((ClaveValor)datos[indice]).getValor();
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
                if (this.isEmpty())
                {
                    Console.WriteLine("Aula vacia. Orden Inicio");
                    ordenInicio.ejecutar();
                }
                this.datos.Add(temp);

                if (this.cuantos() >= 40)
                {
                    Console.WriteLine("Alumnos=40. Orden Aula Llena");
                    ordenAulaLlena.ejecutar();
                }
                else
                {
                    Console.WriteLine("Orden llega alumno " + this.cuantos());
                    ordenLlegaAlumno.ejecutar((Comparable)valor);
                }
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
			if (it==null){
				it= new IteradorDiccionario<T>(this);}
			return it;
		}
		
		public void recorrer(){
			if (it == null){
				this.crearIterador();
			}
			if (this.datos.Count>0){
				while(!it.fin()){
						Console.WriteLine(it.actual());
						it.siguiente();
				}
			}
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
