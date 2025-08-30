using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace _2_criando_web_api.Model;

public class CategoriaModel
{
    [Key]
    public int CategoriaId { get; set; }
    
    [Required]
    [StringLength(80)]
    public string?  Nome { get; set; }
    
    [Required]
    [StringLength(300)]
    public string?  ImagemUrl { get; set; }
    
    public ICollection<ProdutoModel>? Produtos { get; set; }
}