using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPlushieGerenciador.Models
{
    [Table("produto")]
    public class Produto
    {
        [Key]
        [Column("id_produto")]
        public int IdProduto { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("valor_unitario")]
        public decimal ValorUnitario { get; set; }

        [Column("data_exclusao")]
        public DateTime? DataExclusao { get; set; } // DateTime? para permitir valores nulos

        // Propriedade de navegação para as compras que contêm este produto
        public virtual ICollection<CompraProduto> CompraProdutos { get; set; }
    }
}