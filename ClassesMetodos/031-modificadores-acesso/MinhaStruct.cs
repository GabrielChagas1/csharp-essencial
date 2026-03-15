using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_modificadores_acesso
{
    internal struct MinhaStruct
    {
        int meuCmpo; // campo privado por padrão
            string minhaPropriedade { get; set; } // propriedade privada por padrão
            void MeuMetodo() // método privado por padrão
            {
                Console.WriteLine("Este é um método privado.");
        }
    }
}
