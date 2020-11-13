using System.Collections.Generic;

namespace SistemaVenda.Entidades
{
    public class Clientes : Entity
    {
        //Atributos
        public string Nome      { get; set; }
        public string CNPJ_CPF  { get; set; }
        public string Email     { get; set; }
        public string Celular   { get; set; }

        //RELACIONAMENTOS
        //Amarra o Cliente com as Vendas
        public ICollection<Vendas> Vendas { get; set; }
    }
}