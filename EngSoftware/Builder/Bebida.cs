using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngSoftware.Builder
{
    class Bebida
    {
        private string _bebida;
        private Dictionary<string, string> _componentes = new Dictionary<string, string>();

        public Bebida(string bebida)
        {
            this._bebida = bebida;
        }

        public string this[string key]
        {
            get { return _componentes[key]; }
            set { _componentes[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("Bebida: {0}", _bebida);
            Console.WriteLine("Tipo : {0}", _componentes["tipo"]);
        }
    }
}
