using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cozinhu.Models;

[Table("Igrediente")]
public class Igrediente
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; }

    public ICollection<ReceitaIgrediente> Receitas { get; set; } 
}