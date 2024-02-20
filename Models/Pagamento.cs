using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMercado.Models
{
    [Table("Pagamento")]
    public class Pagamento
    {
        [Column("PagamentoId")]
        [Display(Name = "Código do pagamento")]
        public int PagamentoId { get; set; }

        [Column("FormaPagamento")]
        [Display(Name = "Forma de pagamento")]
        public string FormaPagamento { get; set; } = string.Empty;

    }
}