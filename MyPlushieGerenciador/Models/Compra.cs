using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPlushieGerenciador.Models
{
    [Table("compra")]
    public class Compra
    {
        [Key]
        [Column("id_compra")]
        public int Id { get; set; }

        [ForeignKey("fk_usuario")]
        public virtual Usuario Usuario { get; set; }
        
        [Column("data")]
        public DateTime Data { get; set; }

        [Column("acrescimo_total")]
        public decimal AcrescimoTotal { get; set; }

        [Column("sessao")]
        public string Sessao { get; set; }

        public List<CompraProduto> CompraProdutos { get; set; }
    }
}