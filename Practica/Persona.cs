using System;

namespace Practica
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona: Comparable
	{
		protected string nombre;
		protected int dni;
		
		public Persona(){
		}
		
		public Persona(int d)
		{
			dni=d;
		}
		
		public Persona(string n, int d)
		{
			nombre=n;
			dni=d;
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public int getDni(){
			return dni;
		}
		
		public virtual bool sosIgual(Comparable obj){
			bool esIgual=false;
			if (dni==((Persona)obj).getDni()){
				esIgual=true;
		}
			return esIgual;
		}
		
		public virtual bool sosMenor(Comparable obj){
			bool esMenor=false;
			if (dni<((Persona)obj).getDni()){
				esMenor=true;
		}
			return esMenor;
		}
		
		public virtual bool sosMayor(Comparable obj){
			bool esMayor=false;
			if (dni>((Persona)obj).getDni()){
				esMayor=true;
		}
			return esMayor;
		}
		
		public virtual string informar(){
			return this.ToString();
		}
		
		public override string ToString()
		{
			return string.Format("{0}", dni);
		}
 
	}
}
