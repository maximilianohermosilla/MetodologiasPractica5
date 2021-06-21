using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Practica 5 - Ejercicio 8 //

namespace Practica
{
    public interface Ordenable
    {
        void setOrdenInicio(OrdenEnAula1 ordenInicio);
        void setOrdenLlegadaAlumno(OrdenEnAula2 ordenLlegada);
        void setOrdenAulaLLena(OrdenEnAula1 ordenAulaLlena);

    }
}
