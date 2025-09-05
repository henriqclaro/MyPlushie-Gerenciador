using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPlushieGerenciador.Models
{
    [Table("compra_produto")]
    public class CompraProduto
    {
        [Column("id_compra")]
        public int IdCompra { get; set; }

        [Column("id_produto")]
        public int IdProduto { get; set; }

        [ForeignKey("IdCompra")]
        public virtual Compra Compra { get; set; }

        [ForeignKey("IdProduto")]
        public virtual Produto Produto { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("valor_unitario")]
        public decimal ValorUnitario { get; set; }
    }
}