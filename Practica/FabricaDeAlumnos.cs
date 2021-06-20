
using System;

namespace Practica
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos: FabricaDeComparables
	{	
		static Random random = new Random();
		
		public override Comparable crearComparable(FabricaDeComparables fabrica){
			Console.WriteLine("\nFABRICA DE ALUMNOS \n****************** \n1) ALEATORIO \n2) POR TECLADO \n");
			LectorDeDatos lector=new LectorDeDatos();
			int indice = lector.numeroPorTeclado();
			if (indice == num){
				Console.WriteLine("ALUMNO ALEATORIO\n");
				return fabrica.crearAleatorio();
			}
			if (indice == alum){
				Console.WriteLine("INGRESAR ALUMNO\n");
				return fabrica.crearPorTeclado();
			}
			else{
				Console.WriteLine("Opcion incorrecta");
				return fabrica.crearAleatorio();
			}
		}
		
		public FabricaDeAlumnos(){
		}
		
		public override Comparable crearAleatorio(){
			
			string nombre;
			int dni, legajo;
			decimal promedio;
			string[] nombres=new string[]{"Maxi","Paula","Roberto","Nacho","Adrian","Diego","Lucia","Florencia","Cintia","Ana","Graciela","Yesica","Daiana","Carolina","Gaston","Luis","Jacinto","Ramona","Ignacia","Viviana"};
			nombre=nombres[random.Next(0,19)];
			dni=random.Next(12000000,40000000);
			legajo=random.Next(1,2000);
			promedio=decimal.Round((Convert.ToDecimal((random.NextDouble() + random.Next(1,10)))), 2);
			Comparable alumno = new Alumno(nombre,dni,legajo,promedio);
			//Console.WriteLine(alumno);
			return alumno;
		}
		
		public override Comparable crearPorTeclado(){
			LectorDeDatos lector=new LectorDeDatos();
			Console.WriteLine("NOMBRE");
			string nombre=lector.stringPorTeclado();
			Console.WriteLine("DNI");
			int dni=lector.numeroPorTeclado();
			Console.WriteLine("LEGAJO");			
			int legajo=lector.numeroPorTeclado();
			Console.WriteLine("PROMEDIO");
			decimal promedio=Convert.ToDecimal(lector.numeroPorTeclado());
			Comparable alumno=new Alumno(nombre,dni,legajo,promedio);
			return alumno;
		}

        public IAlumno crearProxy()
        {
            string nombre;
            string[] nombres = new string[] { "Maxi", "Paula", "Roberto", "Nacho", "Adrian", "Diego", "Lucia", "Florencia", "Cintia", "Ana", "Graciela", "Yesica", "Daiana", "Carolina", "Gaston", "Luis", "Jacinto", "Ramona", "Ignacia", "Viviana" };
            nombre = nombres[random.Next(0, 19)];
            IAlumno alumno = new ProxyAlumno(nombre);
            //Console.WriteLine(alumno);
            return alumno;
        }
    }

    public class FabricaDeAlumnosEstudiosos : FabricaDeComparables
    {
        static Random random = new Random();

        public override Comparable crearComparable(FabricaDeComparables fabrica)
        {
            Console.WriteLine("\nFABRICA DE ALUMNOS ESTUDIOSOS \n****************** \n1) ALEATORIO \n2) POR TECLADO \n");
            LectorDeDatos lector = new LectorDeDatos();
            int indice = lector.numeroPorTeclado();
            if (indice == num)
            {
                Console.WriteLine("ALUMNO ALEATORIO\n");
                return fabrica.crearAleatorio();
            }
            if (indice == alum)
            {
                Console.WriteLine("INGRESAR ALUMNO\n");
                return fabrica.crearPorTeclado();
            }
            else
            {
                Console.WriteLine("Opcion incorrecta");
                return fabrica.crearAleatorio();
            }
        }

        public FabricaDeAlumnosEstudiosos()
        {
        }

        public override Comparable crearAleatorio()
        {

            string nombre;
            int dni, legajo;
            decimal promedio;
            string[] nombres = new string[] { "Maxi", "Paula", "Roberto", "Nacho", "Adrian", "Diego", "Lucia", "Florencia", "Cintia", "Ana", "Graciela", "Yesica", "Daiana", "Carolina", "Gaston", "Luis", "Jacinto", "Ramona", "Ignacia", "Viviana" };
            nombre = nombres[random.Next(0, 19)];
            dni = random.Next(12000000, 40000000);
            legajo = random.Next(1, 2000);
            promedio = decimal.Round((Convert.ToDecimal((random.NextDouble() + random.Next(1, 10)))), 2);
            Comparable alumnoBase = new Alumno(nombre, dni, legajo, promedio);
            AlumnoMuyEstudioso alumno = new AlumnoMuyEstudioso((Alumno)alumnoBase);
            //Console.WriteLine(alumno);
            return alumno;
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos();
            Console.WriteLine("NOMBRE");
            string nombre = lector.stringPorTeclado();
            Console.WriteLine("DNI");
            int dni = lector.numeroPorTeclado();
            Console.WriteLine("LEGAJO");
            int legajo = lector.numeroPorTeclado();
            Console.WriteLine("PROMEDIO");
            decimal promedio = Convert.ToDecimal(lector.numeroPorTeclado());
            Comparable alumnoBase = new Alumno(nombre, dni, legajo, promedio);
            AlumnoMuyEstudioso alumno = new AlumnoMuyEstudioso((Alumno)alumnoBase);
            return alumno;
        }

        public IAlumno crearProxy()
        {
            string nombre;
            string[] nombres = new string[] { "Maxi", "Paula", "Roberto", "Nacho", "Adrian", "Diego", "Lucia", "Florencia", "Cintia", "Ana", "Graciela", "Yesica", "Daiana", "Carolina", "Gaston", "Luis", "Jacinto", "Ramona", "Ignacia", "Viviana" };
            nombre = nombres[random.Next(0, 19)];
            IAlumno alumno = new ProxyAlumnoEstudioso(nombre);
            //Console.WriteLine(alumno);
            return alumno;
        }
    }

    public class StudentsFactory: FabricaDeAlumnos
	{
        static Random random = new Random();
        public new IAlumno crearAleatorio()
		{
			IAlumno aluDec = (Alumno)base.crearAleatorio();
			
			aluDec = new LegajoDecorator(aluDec);
			aluDec = new LetrasDecorator(aluDec);
			aluDec = new PromocionDecorator(aluDec);
			aluDec = new NumeroDecorator(aluDec);
			aluDec = new CuadroDecorator(aluDec);
			
			return aluDec;
		}
        public new IAlumno crearProxy()
        {
            string nombre;
            string[] nombres = new string[] { "Maxi", "Paula", "Roberto", "Nacho", "Adrian", "Diego", "Lucia", "Florencia", "Cintia", "Ana", "Graciela", "Yesica", "Daiana", "Carolina", "Gaston", "Luis", "Jacinto", "Ramona", "Ignacia", "Viviana" };
            nombre = nombres[random.Next(0, 19)];
            IAlumno alumno = new ProxyAlumno(nombre);
            Console.WriteLine("Se creo el proxy base: "+ alumno.getNombre());
            return alumno;
        }
    }
	
	public class StudentsTopFactory: FabricaDeAlumnosEstudiosos
	{
        static Random random = new Random();
        
        public new IAlumno crearAleatorio()
		{
			IAlumno aluDec = new AlumnoMuyEstudioso((IAlumno)base.crearAleatorio());
						
			aluDec = new LegajoDecorator(aluDec);
			aluDec = new LetrasDecorator(aluDec);
			aluDec = new PromocionDecorator(aluDec);
			aluDec = new NumeroDecorator(aluDec);
			aluDec = new CuadroDecorator(aluDec);
			
			return aluDec;
		}

        public new IAlumno crearProxy()
        {
            string nombre;
            string[] nombres = new string[] { "Paula", "Roberto", "Nacho", "Adrian", "Diego", "Lucia", "Florencia", "Cintia", "Ana", "Graciela", "Yesica", "Daiana", "Carolina", "Gaston", "Luis", "Jacinto", "Ramona", "Ignacia", "Viviana", "Maxi" };
            nombre = nombres[random.Next(0, 19)];
            IAlumno alumno = new ProxyAlumnoEstudioso(nombre);
            Console.WriteLine("Se creo el proxy estudioso: " + alumno.getNombre());
            return alumno;
        }
    }

}
