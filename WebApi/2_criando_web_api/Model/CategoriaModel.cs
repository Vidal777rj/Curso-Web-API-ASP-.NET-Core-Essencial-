using System.ComponentModel.DataAnnotations;

namespace _2_criando_web_api.Model;

public class CategoriaModel
{
    [Key]
    public int CategoriaId { get; set; }
    public string?  Nome { get; set; }
    public string?  ImagemUrl { get; set; }
}