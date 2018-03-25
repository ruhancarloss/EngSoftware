using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngSoftware.Mediator
{
    class Promocao : Cliente

    {
        public Promocao(string name)
          : base(name)
        {
            Console.WriteLine("O Cliente " + name + " tem direito a promoção de entrega grátis");
        }

        public override void Atribuir(string de, string mensagem)
        {
            base.Atribuir(de, mensagem);
        }
    }
}
