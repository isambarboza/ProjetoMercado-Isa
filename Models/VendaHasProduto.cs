using Microsoft.EntityFrameworkCore;
using ProjetoMercado.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMercado.Models
{
    //[Keyless]
    [Table("VendaHasProduto")]
    public class VendaHasProduto
    {
        [Column("VendaHasProdutoId")]
        [Display(Name = "Código da Venda do Produto")]
        public int VendaHasProdutoId { get; set; }

        [ForeignKey("VendaHasProduto")]
        public int VendaId { get; set; }
        public Venda? Venda { get; set; }


        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }


        [Column("QntVendaHas")]
        [Display(Name = "Quantidade")]
        public int QntVendaHas { get; set; }
    }
}
