using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorShop.Api.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        [MaxLength(100)]

        public string Nome { get; set; } = string.Empty;
        
        [MaxLength(200)]
        public string Descricao { get; set; } = string.Empty;

        [MaxLength(200)]
        public string ImagemUrl { get; set; } = string.Empty;

        [Column(TypeName ="decimal(10,2)")]
        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

        //Essa Propriedade será registrada no banco de dados como Foreign Key
        public int CategoriaId { get; set; }
        //Aqui está explicitando ainda mais o relacionamento de produto com categoria
        public Categoria? Categoria { get; set; }

        //Uma propriedade de navegação serve apenas para o EntityFramework saber o relacionamento entre as entidades
        public ICollection<CarrinhoItem> Itens { get; set; }
               = new List<CarrinhoItem>();
    }
}
