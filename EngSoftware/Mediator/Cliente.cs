using EngSoftware.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngSoftware.Mediator
{
    class Cliente
    {
        private Pedido _Pedido;
        private string _nome;


        public Cliente(string nome)
        {
            this._nome = nome;
        }

        public string Nome
        {
            get { return _nome; }
        }

        public Pedido Pedido
        {
            set { _Pedido = value; }
            get { return _Pedido; }
        }

        public void EnviarMensagem(string para, string message)
        {
            _Pedido.EnviarMensagem(_nome, para, message);
        }

        public virtual void Atribuir(string de, string para)
        {
            Console.WriteLine("{0} para {1}: '{2}'", de, Nome, para);
        }
    }
}
