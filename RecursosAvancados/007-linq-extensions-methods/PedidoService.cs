namespace _007_linq_extensions_methods
{
    public static class PedidoService
    {
        public static List<Pedido> ObterPedidos() {             
            return new List<Pedido>
            {
                new() { Id = 1, Cliente = "Cliente A", TipoCliente = TipoCliente.Regular, Status = StatusPedido.Aprovado, Total = 100 },
                new(){ Id = 2, Cliente = "Cliente B", TipoCliente = TipoCliente.Premium, Status = StatusPedido.Pendente, Total = 200 },
                new(){ Id = 3, Cliente = "Cliente C", TipoCliente = TipoCliente.VIP, Status = StatusPedido.Aprovado, Total = 300 },
                new(){ Id = 4, Cliente = "Cliente D", TipoCliente = TipoCliente.Platinum, Status = StatusPedido.Cancelado, Total = 400 },
                new(){ Id = 5, Cliente = "Cliente E", TipoCliente = TipoCliente.Regular, Status = StatusPedido.Aprovado, Total = 500 },
                new(){ Id = 6, Cliente = "Cliente F", TipoCliente = TipoCliente.Premium, Status = StatusPedido.EmProcessamento, Total = 600 },
                new(){ Id = 7, Cliente = "Cliente G", TipoCliente = TipoCliente.VIP, Status = StatusPedido.Entregue, Total = 700 },
                new(){ Id = 8, Cliente = "Cliente H", TipoCliente = TipoCliente.Platinum, Status = StatusPedido.Aprovado, Total = 800 }
            };
        }
    }
}
