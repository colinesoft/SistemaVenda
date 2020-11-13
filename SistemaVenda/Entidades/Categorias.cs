using System.Collections.Generic;

namespace SistemaVenda.Entidades
{
    public class Categorias : Entity
    {
        //Atributos
        public string Descricao { get; set; }

        //RELACIONAMENTOS
        //Obtem a coleção de Produtos dessa categoria
        public ICollection<Produtos> Produtos { get; set; }
    }
}