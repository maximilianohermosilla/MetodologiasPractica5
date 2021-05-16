using System;

namespace Practica
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorios.
	/// </summary>
	public class GeneradorDeDatosAleatorios
	{
		public GeneradorDeDatosAleatorios()
		{
		}
		
		public int numeroAleatorio(int max){
			Random rnd = new Random();
			int numero=rnd.Next(0,max);
			return numero;
		}
		
		public string stringAleatorio(int cant){
			Random rnd = new Random();
			char[] chars=new char[]{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
			//var chars= "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			var cadena=new char[cant];
			for (int i=0; i < cant ; i++){
				cadena[i]=chars[rnd.Next(0,chars.Length)];
			}
			string cadenaFinal= new string(cadena);
			return cadenaFinal;
			
		}
	}
}
