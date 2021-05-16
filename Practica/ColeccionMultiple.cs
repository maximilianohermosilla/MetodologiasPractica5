using System;

namespace Practica
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple: Coleccionable
	{
		Cola<Comparable> cola;
		Pila<Comparable> pila;
		EstrategiaComparar comparador;
		
		public ColeccionMultiple(Pila<Comparable> p, Cola<Comparable> c)
		{
			cola=c;
			pila=p;
		}
		
		public int cuantos(){
			return (pila.cuantos() + cola.cuantos());
		}
	
		public Comparable menor(){
			if (((Comparable)pila.menor()).sosMenor(cola.menor())){
				return pila.menor();
			}
			else{
				return cola.menor();
			}
		}
		
		public Comparable mayor(){
			if (((Comparable)pila.mayor()).sosMayor(cola.mayor())){
				return pila.mayor();
			}
			else{
				return cola.mayor();
			}
		}
		
		public void agregar(Comparable obj){
			
		}
		
		public bool contiene(Comparable obj){
			bool existe=false;
			if (pila.contiene(obj) | cola.contiene(obj)){
				existe=true;
			}
			return existe;
		}
		
		public bool contieneNumero(string num){
			bool existe=false;
			if (pila.contieneNumero(num) | cola.contieneNumero(num)){
				existe=true;
			}
			return existe;
		}
		
		public void cambiarComparador(EstrategiaComparar comp){
			comparador=comp;
		}
	}
}
