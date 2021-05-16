
using System;

namespace Practica
{
	/// <summary>
	/// Description of Vendedor.
	/// </summary>
	public class Vendedor: Persona
	{
		private double sueldoBasico;
		private double bonus=1;
		
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
		
	}
}
