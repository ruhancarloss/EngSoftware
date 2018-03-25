using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngSoftware.Mediator
{
    abstract class AbstractPedido
    {
        public abstract void RealizarPedido(Cliente cliente);
        public abstract void EnviarMensagem(string de, string para, string mensagem);
    }
}
