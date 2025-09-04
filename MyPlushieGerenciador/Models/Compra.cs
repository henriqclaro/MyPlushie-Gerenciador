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
        [Column("id")]
        public int Id { get; set; }

        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Column("sessao")]
        public string Sessao { get; set; }

        [Column("acrescimo_total")]
        public decimal AcrescimoTotal { get; set; }

        [Column("data")]
        public DateTime Data { get; set; }

        // Chave Estrangeira e Propriedade de Navegação para Usuario
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        // Propriedade de navegação para os produtos desta compra
        public virtual ICollection<CompraProduto> CompraProdutos { get; set; }
    }
}