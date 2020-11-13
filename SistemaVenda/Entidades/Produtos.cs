using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Entidades
{
    public class Produtos : Entity
    {
        //Atributos
        public string Descricao { get; set; }
        public double Qtde { get; set; }
        public decimal Valor { get; set; }
        [ForeignKey("Categorias")] //Informar a tabela de origem
        public int CategoriaId { get; set; } //Nome do campo que é a ForeignKey

        //RELACIONAMENTOS
        //Amarra com a categoria
        public Categorias Categoria { get; set; }
        //Amarra com todas as vendas
        public ICollection<VendaProdutos> VendaProdutos { get; set; }

    }
}
