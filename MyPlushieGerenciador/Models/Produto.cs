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

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("excluido")]
        public bool Excluido { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("valor_unitario")]
        public decimal ValorUnitario { get; set; }

        [Column("data_exclusao")]
        public DateTime? DataExclusao { get; set; }

        public List<CompraProduto> CompraProdutos { get; set; }
    }
}