using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Models
{
    [Table("pct_usuario")]
    public class UserDBO
    {
        [Column("id_usuario")]
        public int Id { get; set; }

        [Column("nom_usuario")]
        public string? Nome { get; set; }

        [Column("cd_usuario")]
        public string? Bi { get; set; }

        [Column("nom_email")]
        public string? Email { get; set; }

        [Column("cd_situacao")]
        public string? Situacao { get; set; }

        [Column("dt_criacao")]
        public DateTime? DataCriacao { get; set; }

        [Column("dt_modificacao")]
        public DateTime? DataModificacao { get; set; }

    }
}
