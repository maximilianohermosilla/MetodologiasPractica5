﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica
{
    interface OrdenEnAula1
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
