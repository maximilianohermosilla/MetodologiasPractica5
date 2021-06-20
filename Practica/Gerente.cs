
using System;

namespace Practica
{
	
	
	// Practica 3 - Ejercicio 11
	// Practica 3 - Ejercicio 12 (Observer)
	
	public class Gerente: Observador
	{
		Conjunto<Comparable> listaMejores = new Conjunto<Comparable>();
		
		public Gerente()
		{
			listaMejores.cambiarComparador(new PorDniVendedor());
		}
		
		public Coleccionable mejores(){
			return listaMejores;
		}
		
		public void cerrar(){
			if (listaMejores.cuantos() > 0){
				this.listaMejores.recorrer();
			}
			else{
				Console.WriteLine("La lista de mejores vendedores está vacia");
			}
		}
		
		public void venta(double monto, Vendedor vendedor){
			if (monto>5000){
				vendedor.aumentaBonus();
				if (!listaMejores.contiene(vendedor)){
					listaMejores.agregar(vendedor);
				}
			}
		}
		
		// METODO OBSERVADOR //
		
		public void actualizar(double monto, Observado obs){
			this.venta(monto, (Vendedor)obs);
		}
	}
}
