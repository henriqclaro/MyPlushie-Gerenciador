using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPlushieGerenciador.Models
{
    [Table("compra_produto")]
    public class CompraProduto
    {
        [ForeignKey("fk_compra")]
        public virtual Compra Compra { get; set; }

        [ForeignKey("fk_produto")]
        public virtual Produto Produto { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("valor_unitario")]
        public decimal ValorUnitario { get; set; }
    }
}