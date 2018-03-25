using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngSoftware.Proxy
{
    public class EntregaProxy : IEntrega
    {
        private Entrega _Entrega = new Entrega();

        public DateTime PrazoEntrega(int Prazo)
        {
            return _Entrega.PrazoEntrega(Prazo);
        }

        public double ValorPedido(double Pizza, double Bebida, double TxEntrega)
        {
            return _Entrega.ValorPedido(Pizza, Bebida, TxEntrega);
        }
    }
}
