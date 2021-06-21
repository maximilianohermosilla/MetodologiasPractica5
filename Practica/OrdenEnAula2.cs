using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//  Practica 5 - Ejercicios 6 y 7 //

namespace Practica
{
    public interface OrdenEnAula2
    {
        void ejecutar(Comparable comp);
    }

    public class OrdenLlegaAlumno: OrdenEnAula2
    {
        Aula aulaOrden;
        public OrdenLlegaAlumno(Aula aula)
        {
            aulaOrden = aula;
        }
         
        public void ejecutar(Comparable comp)
        {
            aulaOrden.nuevoAlumno((IAlumno)comp);
        }
    }


}
