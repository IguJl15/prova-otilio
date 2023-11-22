namespace Prova.Models;

public class Produto
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public string imageUrl { get; set; }
    public decimal Preco { get; set; }
    public int quantity { get; set; }
    public Categoria Categoria { get; set; }

}
