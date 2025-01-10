using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Produto
    {
        //Fields
        private string nome;
        private decimal preco;

        public string Fornecedor { get; set; }

        public decimal Preco
        {
            set
            {
                if (value >= 0)
                {
                    preco = value;
                }
                else
                {
                    preco = 0;
                }
            }
        }


        //Properties 
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (nome.Length < 3)
                {
                    nome = "!Error...";
                }
                else
                {
                    nome = value;
                }
            }
        }
    }
}
