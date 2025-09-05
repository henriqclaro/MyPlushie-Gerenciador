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
        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("senha_hash")]
        public string Senha { get; set; }

        [Column("admin")]
        public bool Admin { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("excluido")]
        public bool Excluido { get; set; }

        [Column("data_exclusao")]
        public DateTime? DataExclusao { get; set; }

        public List<Compra> Compras { get; set; }
    }
}
