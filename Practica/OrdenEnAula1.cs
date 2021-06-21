using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Practica 5 - Ejercicios 4 y 5 //

namespace Practica
{
    public interface OrdenEnAula1
    {
        void ejecutar();
    }

    public class OrdenInicio: OrdenEnAula1
    {
        Aula aulaOrden;

        public OrdenInicio(Aula aula)
        {
            aulaOrden = aula;
        }
        public void ejecutar()
        {
            aulaOrden.comenzar();
        }
    }

    public class OrdenAulaLlena : OrdenEnAula1
    {
        Aula aulaOrden;

        public OrdenAulaLlena(Aula aula)
        {
            aulaOrden = aula;
        }
        public void ejecutar()
        {
            aulaOrden.claseLista();
        }
    }

}
