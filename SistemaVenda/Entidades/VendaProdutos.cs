using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Entidades
{
    public class VendaProdutos
    {
        //Atributos
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public double Qtde { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }

        //RELACIONAMENTOS
        //Amarra o Produto e a Venda com a tabela
        public Produtos Produto { get; set; }
        public Vendas Venda { get; set; }
    }
}
