using EngSoftware.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngSoftware.Builder
{
    class Pedido : AbstractPedido
    {
        private Dictionary<string, Cliente> _cliente = new Dictionary<string, Cliente>();

        //Builder
        public void BebidaConstrutor(BebidaBuilder BebidaBuilder)
        {
            BebidaBuilder.Tipo();
        }

        public void PizzaConstrutor(PizzaBuilder PizzaBuilder)
        {
            PizzaBuilder.Ingrediente();
            PizzaBuilder.Borda();
            PizzaBuilder.Massa();
        }

        //Mediator
        public override void RealizarPedido(Cliente cliente)
        {
            if (!_cliente.ContainsValue(cliente))
            {
                _cliente[cliente.Nome] = cliente;
            }

            cliente.Pedido = this;
        }

        public override void EnviarMensagem(string de, string para, string mensagem)
        {
            Cliente cliente = _cliente[de];

            if (cliente != null)
            {
                cliente.Atribuir(para, mensagem);
            }
        }
    }
}
