using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngSoftware.Proxy
{
    public interface IEntrega
    {
        DateTime PrazoEntrega(int Prazo);
        double ValorPedido(double Pizza, double Bebida, double TxEntrega);
    }
}
