using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cozinhu.Models;

[Table("Comentario")]
public class Comentario
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int ReceitaId { get; set; }
    [ForeignKey("ReceitaId")]
    public string Receita { get; set; }

    [Required]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    public DateTime DataComentario { get; set; } = DateTime.Now;

    [StringLength(300)]
    public string TextoComentaro { get; set; }
}