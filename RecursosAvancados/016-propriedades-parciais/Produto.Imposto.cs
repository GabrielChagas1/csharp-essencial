using System;
using System.Collections.Generic;
using System.Text;

namespace _016_propriedades_parciais
{
    public partial class Produto
    {
        private decimal _taxaImposto = 0.18m; // Imposto de 18%

        public partial decimal ValorComImposto
		{
			get => Preco * (1 + _taxaImposto);
		}
	}
}
