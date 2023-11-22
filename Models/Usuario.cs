namespace Prova.Models;

public class Usuario
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    public Carrinho Carrinho { get; set; }

}
