using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMercado.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("ProdutoId")]
        [Display(Name = "Código do produto")]
        public int ProdutoId { get; set; }

        [Column("NomeProduto")]
        [Display(Name = "Nome do produto")]
        public string NomeProduto { get; set; } = string.Empty;

        [Column("PrecoProduto")]
        [Display(Name = "Preço do Produto")]
        public double PrecoProduto { get; set; }

        [Column("QntEstoqueProduto")]
        [Display(Name = "Estoque do Produto")]
        public int QntEstoqueProduto { get; set; }

        [Column("NumeroDoCodigo")]
        [Display(Name = "Código do Produto")]
        public int NumeroDoCodigo { get; set; }

        [ForeignKey("Id_Categoria")]
         public int IdCategoria { get; set; }
         public Categoria? Categoria { get; set; }

         [ForeignKey("Id_Fornecedor")]
         public int IdFornecedor { get; set; }
         public Fornecedor? Fornecedor { get; set; }
    }
}
