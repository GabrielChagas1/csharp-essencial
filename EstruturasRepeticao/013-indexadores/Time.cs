using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_indexadores
{
    public class Time
    {
        //definir os limites do array
        string[] valor = new string[10];

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= valor.Length)
                {
                    throw new IndexOutOfRangeException("Índice fora dos limites do array.");
                }
                return valor[index];
            }
            set
            {
                if (index < 0 || index >= valor.Length)
                {
                    throw new IndexOutOfRangeException("Índice fora dos limites do array.");
                }
                valor[index] = value;
            }
        }
    }
}
