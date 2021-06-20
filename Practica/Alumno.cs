using System;

namespace Practica
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno: Persona, IAlumno
	{
		
		protected int legajo, calificacion;
		protected decimal promedio;
		EstrategiaComparar comparador = new PorDni();
		static Random aleatorio = new Random();


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
        public void setNombre(string n)
        {
            this.nombre = n;
        }
        public decimal getPromedio(){
			return promedio;
		}

		public int getCalificacion()
		{
			return calificacion;
		}

		public new string informar(){
			return this.ToString();
		}
		
		
		// METODOS COMPARABLE //
		
		public override bool sosIgual(Comparable obj){
			return comparador.esIgual(this, (Alumno)obj);
		}
		
		public override bool sosMenor(Comparable obj){
			return comparador.esMenor(this, (Alumno)obj);
		}
		
		public override bool sosMayor(Comparable obj){
			return comparador.esMayor(this, (Alumno)obj);
		}
		
		//-------------------//
		
		public override string ToString()
		{
			return string.Format("LEGAJO:{0} , DNI:{1} , NOMBRE:{2} , PROMEDIO:{3}", legajo,dni,nombre,promedio);
		}
		
		// METODO COMPARAR //
		
		public void cambiarComparador(EstrategiaComparar comp){
			comparador=comp;
		}
		
		// Practica 4 - Ejercicio 1 //
		
		public int responderPregunta (int pregunta){
			return (aleatorio.Next(1,3));
		}
		
		public string mostrarCalificacion(){
			//return string.Format("{0}	{1}",nombre, calificacion);
			return string.Format("{0}",calificacion);
		}
		
		public void setCalificacion(int calificacion)
        {
			this.calificacion = calificacion;
        }

		public string getNotaLetras()
        {
			string[] notas = new string[] { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
			return notas[calificacion];
        }

		public string getPromocion()
        {
			if (calificacion >= 7)
				return "PROMOCION";
			else if (calificacion < 7 & calificacion >= 4)
				return "APROBADO";
			else
				return "DESAPROBADO";
        }
 
	}
}
