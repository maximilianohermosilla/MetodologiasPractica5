using System;
using System.Collections.Generic;

namespace Practica
{
	
	// Practica 3 - Ejercicio 8
	// Practica 3 - Ejercicio 12 (Observado)
	
	public class Vendedor: Persona, Observado
	{
		private double sueldoBasico;
		private double bonus=1;
		List<Observador> listaObservadores = new List<Observador>();
		
		public Vendedor(string nombre, int dni, double sueldoBasico)
		{
			this.nombre=nombre;
			this.dni=dni;
			this.sueldoBasico=sueldoBasico;
			
		}
		
		public void venta(double monto){
			Console.WriteLine(monto);
		}
		
		public void aumentaBonus(){
			bonus=bonus+0.1;
		}
		
		public double getBonus(){
			return bonus;
		}
		public override string ToString()
		{
			return string.Format("DNI:{0} , NOMBRE:{1} , SUELDO:{2} , BONUS:{3}",dni,nombre,sueldoBasico,bonus);
		}
		
		// METODOS OBSERVADO //
		
		public void agregarObservador(Observador obs){
			listaObservadores.Add(obs);
		}
		
		public void quitarObservador(Observador obs){
			listaObservadores.Remove(obs);
		}
		
		public void notificar(double monto){
			foreach(Observador observer in listaObservadores){
				observer.actualizar(monto, (Observado)this);
			}
		}
	}
}
