using System;
using System.Collections.Generic;
using System.Text;

namespace _016_propriedades_parciais
{
        public partial class Produto
        {
            public int Id { get; set; }
            public string Nome { get; set; } = string.Empty;
            public decimal Preco { get; set; }

            public partial decimal ValorComImposto { get; }
        }
}
