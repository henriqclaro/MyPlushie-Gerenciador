using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPlushieGerenciador.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Column("admin")]
        public bool Admin { get; set; }

        [Column("excluido")]
        public bool Excluido { get; set; }

        [Column("data_exclusao")]
        public DateTime? DataExclusao { get; set; } // DateTime? para permitir valores nulos

        // Propriedade de navegação para as compras que este usuário realizou
        public virtual ICollection<Compra> Compras { get; set; }
    }
}