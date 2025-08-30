using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2_criando_web_api.Model;

public class ProdutoModel
{
    [Key]
    public int ProdutoId { get; set; }
    
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }
    
    [Required]
    [StringLength(250)]
    public string? Descricao { get; set; }
    
    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }
    
    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }
    
    [Required]
    [StringLength(80)]
    public float Estoque { get; set; }
    
    public DateTime DataCadastro { get; set; } 
    
    public int CategoriaId { get; set; }
    public CategoriaModel? Categoria { get; set; }
}