using System;

namespace Practica
{
	/// <summary>
	/// Description of EstrategiaComparar.
	/// </summary>
	public interface EstrategiaComparar
	{
		bool esIgual(Comparable clave1, Comparable clave2);
		bool esMenor(Comparable clave1, Comparable clave2);
		bool esMayor(Comparable clave1, Comparable clave2);
	}
	
	//ESTRATEGIAS PARA ALUMNO
	//-----------------------
	
	public class PorNombre : EstrategiaComparar{
		public bool esIgual (Comparable clave1, Comparable clave2){
			bool igual=false;
			if (((Alumno)clave1).getNombre()==((Alumno)clave2).getNombre()){
				igual=true;
			}
			return igual;
		}
		
		public bool esMenor (Comparable clave1, Comparable clave2){
			bool menor=false;
			if ((((Alumno)clave1).getNombre()).GetHashCode() < ((((Alumno)clave2).getNombre())).GetHashCode()){
				menor=true;
			}
			return menor;
		}
		
		public bool esMayor (Comparable clave1, Comparable clave2){
			bool mayor=false;
			if ((((Alumno)clave1).getNombre()).GetHashCode() > ((((Alumno)clave2).getNombre())).GetHashCode()){
				mayor=true;
			}
			return mayor;
		}
	}
	
	public class PorDni : EstrategiaComparar{
		public bool esIgual (Comparable clave1, Comparable clave2){
			bool igual=false;
			if (((Alumno)clave1).getDni()==((Alumno)clave2).getDni()){
				igual=true;
			}
			return igual;
		}
		
		public bool esMenor (Comparable clave1, Comparable clave2){
			bool menor=false;
			if (((Alumno)clave1).getDni()<((Alumno)clave2).getDni()){
				menor=true;
			}
			return menor;
		}
		
		public bool esMayor (Comparable clave1, Comparable clave2){
			bool mayor=false;
			if (((Alumno)clave1).getDni()>((Alumno)clave2).getDni()){
				mayor=true;
			}
			return mayor;
		}
	}
	
	public class PorPromedio : EstrategiaComparar{
		public bool esIgual (Comparable clave1, Comparable clave2){
			bool igual=false;
			if (((Alumno)clave1).getPromedio()==((Alumno)clave2).getPromedio()){
				igual=true;
			}
			return igual;
		}
		
		public bool esMenor (Comparable clave1, Comparable clave2){
			bool menor=false;
			if (((Alumno)clave1).getPromedio()<((Alumno)clave2).getPromedio()){
				menor=true;
			}
			return menor;
		}
		
		public bool esMayor (Comparable clave1, Comparable clave2){
			bool mayor=false;
			if (((Alumno)clave1).getPromedio()>((Alumno)clave2).getPromedio()){
				mayor=true;
			}
			return mayor;
		}
	}
	
	public class PorLegajo : EstrategiaComparar{
		public bool esIgual (Comparable clave1, Comparable clave2){
			bool igual=false;
			if (((Alumno)clave1).getLegajo()==((Alumno)clave2).getLegajo()){
				igual=true;
			}
			return igual;
		}
		
		public bool esMenor (Comparable clave1, Comparable clave2){
			bool menor=false;
			if (((Alumno)clave1).getLegajo()<((Alumno)clave2).getLegajo()){
				menor=true;
			}
			return menor;
		}
		
		public bool esMayor (Comparable clave1, Comparable clave2){
			bool mayor=false;
			if (((Alumno)clave1).getLegajo()>((Alumno)clave2).getLegajo()){
				mayor=true;
			}
			return mayor;
		}
	}
	
	//ESTRATEGIAS PARA DICCIONARIO
	//----------------------------
	
	public class PorClave : EstrategiaComparar{
		public bool esIgual (Comparable clave1, Comparable clave2){
			bool igual=false;
			if (((Numero)((ClaveValor)clave1).getClave()).sosIgual((Numero)(((ClaveValor)clave2).getClave()))){
				igual=true;
			}
			return igual;
		}
		
		public bool esMenor (Comparable clave1, Comparable clave2){
			bool menor=false;
			if (((Numero)((ClaveValor)clave1).getClave()).sosMenor((Numero)(((ClaveValor)clave2).getClave()))){
				menor=true;
			}
			return menor;
		}
		
		public bool esMayor (Comparable clave1, Comparable clave2){
			bool mayor=false;
			if (((Numero)((ClaveValor)clave1).getClave()).sosMayor((Numero)(((ClaveValor)clave2).getClave()))){
				mayor=true;
			}
			return mayor;
		}
	}
	
	public class PorValor : EstrategiaComparar{
		public bool esIgual (Comparable clave1, Comparable clave2){
			bool igual=false;
			if (((ClaveValor)clave1).getValor()==((ClaveValor)clave2).getValor()){
				igual=true;
			}
			return igual;
		}
		
		public bool esMenor (Comparable clave1, Comparable clave2){
			bool menor=false;
			if ((((ClaveValor)clave1).getValor()).GetHashCode() < (((ClaveValor)clave2).getValor()).GetHashCode()){
				menor=true;
			}
			return menor;
		}
		
		public bool esMayor (Comparable clave1, Comparable clave2){
			bool mayor=false;
			if ((((ClaveValor)clave1).getValor()).GetHashCode() > (((ClaveValor)clave2).getValor()).GetHashCode()){
				mayor=true;
			}
			return mayor;
		}
	}
	
	public class PorValorAlumno : EstrategiaComparar{
		public bool esIgual (Comparable clave1, Comparable clave2){
			bool igual=false;
			if (((Alumno)(((ClaveValor)clave1).getValor())).getDni()==(((Alumno)clave2).getDni())){
				igual=true;
			}
			
			return igual;
		}
		
		public bool esMenor (Comparable clave1, Comparable clave2){
			bool menor=false;
			if (((Alumno)(((ClaveValor)clave1).getValor())).getDni() < (((Alumno)clave2).getDni())){
				menor=true;
			}
			return menor;
		}
		
		public bool esMayor (Comparable clave1, Comparable clave2){
			bool mayor=false;
			if (((Alumno)(((ClaveValor)clave1).getValor())).getDni() > (((Alumno)clave2).getDni())){
				mayor=true;
			}
			return mayor;
		}
	}
}
