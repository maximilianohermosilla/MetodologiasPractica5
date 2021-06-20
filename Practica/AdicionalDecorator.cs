
using System;

// Practica 4 - Ejercicio 6 //

namespace Practica
{
    public abstract class AdicionalDecorator : IAlumno
    {
    	protected IAlumno adicional;
        
        protected AdicionalDecorator(IAlumno a)
        {
            adicional = a;
        }
        
    	public string getNombre() { return adicional.getNombre(); }
    	
    	public int getLegajo() { return adicional.getLegajo(); }
    	
    	public int getCalificacion() { return adicional.getCalificacion(); }
    	
    	public string getNotaLetras() {	return adicional.getNotaLetras(); }
    	
    	public string getPromocion() { return adicional.getPromocion();	}
    	
    	public decimal getPromedio() { return adicional.getPromedio(); }
    	
    	public int getDni()	{ return adicional.getDni(); }
    	
    	public int responderPregunta(int pregunta) 	{ return adicional.responderPregunta(pregunta); }
    	
    	public void setCalificacion(int calificacion) {	adicional.setCalificacion(calificacion); }
        
                
        virtual public string mostrarCalificacion()
        {
            if (adicional != null)
            	return adicional.mostrarCalificacion();
            else
                return "No existe";
        }
    }


    public class LegajoDecorator : AdicionalDecorator
    {
        public LegajoDecorator(IAlumno a): base(a)
        {
        	
        }
        
        override public string mostrarCalificacion()
        {
        	return (base.getNombre() +" (" + base.getLegajo() +")\t\t" + base.mostrarCalificacion());
        }
    }

    public class LetrasDecorator : AdicionalDecorator
    {


        public LetrasDecorator(IAlumno a) : base(a)
        {
        }
        override public string mostrarCalificacion()
        {
        	return (base.mostrarCalificacion() + "(" + base.getNotaLetras() +")");
        }
    }

    public class PromocionDecorator : AdicionalDecorator
    {


        public PromocionDecorator(IAlumno a) : base(a)
        {
        }
        override public string mostrarCalificacion()
        {
        	return (base.mostrarCalificacion() + "(" + base.getPromocion() + ")");
        }
    }

    public class CuadroDecorator : AdicionalDecorator
    {


        public CuadroDecorator(IAlumno a) : base(a)
        {
        }
        override public string mostrarCalificacion()
        {
            return ("****************************************************************\n" +
                    "*\t" + base.mostrarCalificacion() + "\t*\n" +
                    "****************************************************************\n");
        }
    }

    public class NumeroDecorator : AdicionalDecorator
    {
        int indice;

        public NumeroDecorator(IAlumno a) : base(a)
        {
            indice = 0;
        }

        public void setIndice(int ind)
        {
            indice = ind;
        }
        override public string mostrarCalificacion()
        {
            return (indice.ToString() +") "+base.mostrarCalificacion());

        }
    }
	
}
