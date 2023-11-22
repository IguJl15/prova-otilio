namespace Prova.Models;

public class Carrinho
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }

    public List<Produto> Produtos { get; set; }

}
