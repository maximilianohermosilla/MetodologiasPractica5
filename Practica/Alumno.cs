using System;

namespace Practica
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno: Persona
	{
		private int legajo;
		private decimal promedio;
		EstrategiaComparar comparador = new PorDni();
		
		public Alumno(){
		}
		
		public Alumno(int legajo)
		{
			this.legajo=legajo;
		}
		
		public Alumno(decimal promedio)
		{
			this.promedio=promedio;
		}
		
		public Alumno(string nombre, int dni, int legajo, decimal promedio)
		{
			this.legajo=legajo;
			this.promedio=promedio;
			this.nombre=nombre;
			this.dni=dni;	
		}
		
		public int getLegajo(){
			return legajo;
		}
		
		public decimal getPromedio(){
			return promedio;
		}
		
		public override bool sosIgual(Comparable obj){
			return comparador.esIgual(this, (Alumno)obj);
		}
		
		public override bool sosMenor(Comparable obj){
			return comparador.esMenor(this, (Alumno)obj);
		}
		
		public override bool sosMayor(Comparable obj){
			return comparador.esMayor(this, (Alumno)obj);
		}
		
		public new string informar(){
			return this.ToString();
		}
		
		public override string ToString()
		{
			return string.Format("LEGAJO:{0} , DNI:{1} , NOMBRE:{2} , PROMEDIO:{3}", legajo,dni,nombre,promedio);
		}
		
		public void cambiarComparador(EstrategiaComparar comp){
			comparador=comp;
		}
 
	}
}
