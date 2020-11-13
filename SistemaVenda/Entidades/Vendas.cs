using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Entidades
{
    public class Vendas : Entity
    {
        //Atributos
        public DateTime Data { get; set; }
        [ForeignKey("Clientes")]
        public int ClienteId { get; set; }
        public decimal Total { get; set; }

        //RELACIONAMENTOS
        //Amarra a Venda com o Cliente
        public Clientes Cliente { get; set; }
        //Amarra a list de Produtos pertencentes a venda
        public ICollection<VendaProdutos> VendaProdutos { get; set; }
    }
}
