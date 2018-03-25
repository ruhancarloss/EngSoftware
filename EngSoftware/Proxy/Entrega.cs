using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngSoftware.Proxy
{
    public class Entrega : IEntrega
    {
        public DateTime PrazoEntrega(int Prazo) { return DateTime.Now.AddMinutes(Prazo); }
        public double ValorPedido(double Pizza, double Bebida, double TxEntrega) { return Pizza + Bebida + TxEntrega; }
    }
}
