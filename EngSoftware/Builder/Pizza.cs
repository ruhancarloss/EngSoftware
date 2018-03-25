using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngSoftware.Builder
{
    class Pizza
    {
        private string _pizza;
        private Dictionary<string, string> _componentes =
          new Dictionary<string, string>();

        public Pizza(string pizza)
        {
            this._pizza = pizza;
        }

        public string this[string key]
        {
            get { return _componentes[key]; }
            set { _componentes[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("Pizza: {0}", _pizza);
            Console.WriteLine(" Ingrediente : {0}", _componentes["ingrediente"]);
            Console.WriteLine(" Borda : {0}", _componentes["borda"]);
            Console.WriteLine(" Massa: {0}", _componentes["massa"]);
        }
    }
}
