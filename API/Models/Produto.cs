using System;

namespace API.Models
{
    public class Produto
    {
        //Construtor
        public Produto() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }
        public int IdCategoria { get; set; }

        public override string ToString() =>
            $"Nome: {Nome} | Preço: {Preco.ToString("C2")} | Criado em: {CriadoEm}";
    }
}