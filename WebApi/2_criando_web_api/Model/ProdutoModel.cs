using System.ComponentModel.DataAnnotations;

namespace _2_criando_web_api.Model;

public class ProdutoModel
{
    [Key]
    public int ProdutoId { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; } 
}