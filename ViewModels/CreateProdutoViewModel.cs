using Prova.Models;

namespace Prova.ViewModels;

public class CreateProdutoViewModel
{
    public Produto produto { get; set; }
    public List<Categoria> categorias { get; set; }
}