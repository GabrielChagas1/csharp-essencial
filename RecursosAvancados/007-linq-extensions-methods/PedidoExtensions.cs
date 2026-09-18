namespace _007_linq_extensions_methods
{
    public static class PedidoExtensions
    {
        public static IEnumerable<Pedido> ApenasAprovados(this IEnumerable<Pedido> pedidos)
        {
            return pedidos.Where(p => p.Status == StatusPedido.Aprovado);
        }
        public static IEnumerable<Pedido> ApenasClientesEspeciais(this IEnumerable<Pedido> pedidos)
        {
            return pedidos.Where(
                p => p.TipoCliente == TipoCliente.VIP || 
                p.TipoCliente == TipoCliente.Platinum || 
                p.TipoCliente == TipoCliente.Premium
            );
        }
        public static IEnumerable<Pedido> ComValorMinimo(this IEnumerable<Pedido> pedidos, decimal valorMinimo)
        {
            return pedidos.Where(p => p.Total >= valorMinimo);
        }

        public static IEnumerable<Pedido> OrdenadosPorValorDescrescente(this IEnumerable<Pedido> pedidos)
        {
            return pedidos.OrderByDescending(p => p.Total);
        }
    }
}
