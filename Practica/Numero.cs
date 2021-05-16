using System;

namespace Practica
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	public class Numero: Comparable
	{
		private int valor;
		
		public Numero(){
			
		}
		
		public Numero (int v){
			valor=v;
		}
		
		public int getValor(){
			return valor;
		}
		
		public void setValor(int valor){
			this.valor=valor;
		}
		
		public bool sosIgual(Comparable obj){
			bool esIgual=false;
			if (valor==((Numero)obj).getValor()){
				esIgual=true;
		}
			return esIgual;
		}
		
		public bool sosMenor(Comparable obj){
			bool esMenor=false;
			if (valor<((Numero)obj).getValor()){
				esMenor=true;
		}
			return esMenor;
		}
		
		public bool sosMayor(Comparable obj){
			bool esMayor=false;
			if (valor>((Numero)obj).getValor()){
				esMayor=true;
		}
			return esMayor;
		}
		
		public string informar(){
			return this.ToString();
		}
		
		public override string ToString()
		{
			return string.Format("{0}", valor);
		}
 
	}
}
