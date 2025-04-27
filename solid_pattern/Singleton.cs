using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_pattern
{
    class Singleton
    {
        private static Singleton _instancia;
        private static readonly object _lock = new object();
        public List<Pedido> Pedidos { get; private set; }
        private Singleton() => Pedidos = new List<Pedido>();
        public static Singleton Instancia
        {
            get
            {
                lock (_lock)
                {
                    if (_instancia == null)
                    {
                        _instancia = new Singleton();
                    }
                    return _instancia;
                }
            }
        }
        public void AgregarPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }
    }
}
