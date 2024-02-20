using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMercado.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("FornecedorId")]
        [Display(Name = "Código do fornecedor")]
        public int FornecedorId { get; set; }

        [Column("NomeFornecedor")]
        [Display(Name = "Nome do fornecedor")]
        public string NomeFornecedor { get; set; } = string.Empty;

        [Column("CNPJFornecedor")]
        [Display(Name = "Cnpj do fornecedor")]
        public int CNPJFornecedor { get; set; } 
    }
}

