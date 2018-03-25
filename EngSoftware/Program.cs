using EngSoftware.Builder;
using EngSoftware.Mediator;
using EngSoftware.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido Pedido = new Pedido();
            PizzaBuilder pizza;
            BebidaBuilder bebida;

            //Mediator
            Cliente Ruhan = new Promocao("Ruhan");
            Pedido.RealizarPedido(Ruhan);
            Console.WriteLine("Dados do pedido:");
            
            //Builder
            pizza = new MargueritaBuilder();
            bebida = new RefrigeranteBuilder();
            Pedido.PizzaConstrutor(pizza);
            Pedido.BebidaConstrutor(bebida);
            pizza.Pizza.Show();
            bebida.Bebida.Show();

            
            //Mediator
            Console.WriteLine("********************************");
            Ruhan.EnviarMensagem("Pizzaria", "Olá Ruhan, pedido confirmado!");

            //Proxy
            EntregaProxy proxy = new EntregaProxy();
            Ruhan.EnviarMensagem("Pizzaria", "O Valor do seu pedido ficou em " + proxy.ValorPedido(55, 8, 0) + " reais.");
            Ruhan.EnviarMensagem("Pizzaria", "O prazo de entrega do seu pedido é até " + proxy.PrazoEntrega(50));
            Console.WriteLine("********************************");

            //Mediator
            Cliente Maria = new SemPromocao("Maria");
            Pedido.RealizarPedido(Maria);
            Console.WriteLine("Dados do pedido:");

            //Builder
            pizza = new PepperoniBuilder();
            bebida = new CervejaBuilder();
            Pedido.PizzaConstrutor(pizza);
            Pedido.BebidaConstrutor(bebida);
            pizza.Pizza.Show();
            bebida.Bebida.Show();


            //Mediator
            Console.WriteLine("********************************");
            Maria.EnviarMensagem("Pizzaria", "Olá Maria, pedido confirmado!");

            //Proxy
            Maria.EnviarMensagem("Pizzaria", "O Valor do seu pedido ficou em " + proxy.ValorPedido(70, 11, 8) + " reais.");
            Maria.EnviarMensagem("Pizzaria", "O prazo de entrega do seu pedido é até " + proxy.PrazoEntrega(50));


            Console.ReadKey();
        }
    }
}


