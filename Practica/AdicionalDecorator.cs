using System;

// Practica 4 - Ejercicio 6 //

namespace Practica
{
    public abstract class AdicionalDecorator : DecoratorCalificacion
    {
        protected DecoratorCalificacion adicional;
        protected Alumno alumno;

        public AdicionalDecorator(DecoratorCalificacion a, Alumno alu)
        {
            adicional = a;
            alumno = alu;
        }
       virtual public string mostrarCalificacion()
        {
            if (adicional != null)
                return adicional.mostrarCalificacion();
            else
                return "No existe";
        }
    }

    public class Decorator : DecoratorCalificacion
    {
        protected Alumno alumno;
        public Decorator(Alumno alu)
        {
            alumno = alu;
        }
        public string mostrarCalificacion()
        {
            return (alumno.getCalificacion().ToString());
        }

    }

    public class LegajoDecorator : AdicionalDecorator
    {
        

        public LegajoDecorator(DecoratorCalificacion a, Alumno alu): base(a,alu)
        {
        }
        override public string mostrarCalificacion()
        {
            return (base.alumno.getNombre() +" (" + base.alumno.getLegajo() +")\t\t" + base.mostrarCalificacion());
        }
    }

    public class LetrasDecorator : AdicionalDecorator
    {


        public LetrasDecorator(DecoratorCalificacion a, Alumno alu) : base(a,alu)
        {
        }
        override public string mostrarCalificacion()
        {
            return (base.mostrarCalificacion() + "(" + base.alumno.getNotaLetras() +")");
        }
    }

    public class PromocionDecorator : AdicionalDecorator
    {


        public PromocionDecorator(DecoratorCalificacion a, Alumno alu) : base(a, alu)
        {
        }
        override public string mostrarCalificacion()
        {
            return (base.mostrarCalificacion() + "(" + base.alumno.getPromocion() + ")");
        }
    }

    public class CuadroDecorator : AdicionalDecorator
    {


        public CuadroDecorator(DecoratorCalificacion a, Alumno alu) : base(a,alu)
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

        public NumeroDecorator(DecoratorCalificacion a, Alumno alu) : base(a, alu)
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

    public class NotaFinalDecorator : AdicionalDecorator
    {


        public NotaFinalDecorator(DecoratorCalificacion a, Alumno alu) : base(a,alu)
        {
        }
        override public string mostrarCalificacion()
        {
            return (base.mostrarCalificacion());
        }
    }
}
