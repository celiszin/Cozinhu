using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cozinhu.Models;

[Table("ReceitaIgrediente")]
public class ReceitaIgrediente
{
    [Key, Column(Order =1)]
    public int ReceitaId {get; set; }
    [ForeignKey("ReceitaId")]

    public Receita Receita { get; set; }

    [Key, Column(Order = 2)]
    public int IgredienteId {get; set; }
    [ForeignKey("IgredientesId")]
    public Igrediente Igrediente { get; set; }

    [Required]
    [StringLength(30)]
    public string Quantidade { get; set; }

    [StringLength(200)]
    public string Preparo { get; set; }
}