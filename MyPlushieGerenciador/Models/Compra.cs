namespace MyPlushieGerenciador.Models
{
    [Table("compra")]
    public class Compra
    {
        [Key]
        [Column("id_compra")]
        public int IdCompra { get; set; }

        [Column("fk_usuario")]
        public int FkUsuario { get; set; }

        [ForeignKey("FkUsuario")]
        public virtual Usuario Usuario { get; set; }

        [Column("status_compra")]
        public StatusCompra Status { get; set; }

        [Column("data")]
        public DateTime Data { get; set; }

        [Column("acrescimo_total")]
        public decimal AcrescimoTotal { get; set; }

        [Column("sessao")]
        public string Sessao { get; set; }

        public List<CompraProduto> CompraProdutos { get; set; }
    }
    public enum StatusCompra
    {
        Pendente,
        Realizada,
        Cancelada
    }
}
