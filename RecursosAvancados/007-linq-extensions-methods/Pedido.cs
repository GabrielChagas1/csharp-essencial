using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_linq_extensions_methods
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public TipoCliente? TipoCliente { get; set; }
        public StatusPedido? Status { get; set; }
        public decimal Total { get; set; }

    }
}
