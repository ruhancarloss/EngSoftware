using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngSoftware.Builder
{
    abstract class PizzaBuilder

    {
        protected Pizza pizza;

        public Pizza Pizza
        {
            get { return pizza; }
        }

        public abstract void Ingrediente();
        public abstract void Borda();
        public abstract void Massa();
    }


    class MargueritaBuilder : PizzaBuilder

    {
        public MargueritaBuilder()
        {
            pizza = new Pizza("Marguerita");
        }

        public override void Ingrediente()
        {
            pizza["ingrediente"] = "Tomate e manjericão";
        }

        public override void Borda()
        {
            pizza["borda"] = "Recheada";
        }

        public override void Massa()
        {
            pizza["massa"] = "Fina";
        }

    }

    class PepperoniBuilder : PizzaBuilder

    {
        public PepperoniBuilder()
        {
            pizza = new Pizza("Pepperoni");
        }

        public override void Ingrediente()
        {
            pizza["ingrediente"] = "Pepperoni";
        }

        public override void Borda()
        {
            pizza["borda"] = "Normal";
        }

        public override void Massa()
        {
            pizza["massa"] = "Grossa";
        }
    }
}
