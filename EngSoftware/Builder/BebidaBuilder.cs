using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngSoftware.Builder
{
    abstract class BebidaBuilder

    {
        protected Bebida bebida;

        public Bebida Bebida
        {
            get { return bebida; }
        }

        public abstract void Tipo();
    }



    class RefrigeranteBuilder : BebidaBuilder

    {
        public RefrigeranteBuilder()
        {
            bebida = new Bebida("Coca-Cola");
        }

        public override void Tipo()
        {
            bebida["tipo"] = "Zero";
        }
    }

    class CervejaBuilder : BebidaBuilder

    {
        public CervejaBuilder()
        {
            bebida = new Bebida("Therezopolis");
        }

        public override void Tipo()
        {
            bebida["tipo"] = "Weiss";
        }
    }

}
