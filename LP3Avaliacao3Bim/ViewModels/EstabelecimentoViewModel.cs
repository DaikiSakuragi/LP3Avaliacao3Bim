using Microsoft.AspNetCore.Mvc;
namespace LP3Avaliacao3Bim.ViewModels;


public class EstabelecimentoViewModel
{
    public int Id { get; set; }
    public string Piso { get; set; }
    public string Nome { get; set; }
    public string Tipoestabelecimento { get; set; }
    public string Descricao { get; set; }
    public string Email { get; set; }

    public EstabelecimentoViewModel(int id, string piso, string nome, string descricao, string tipoestabelecimento, string email)
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Descricao = descricao;
        Tipoestabelecimento = tipoestabelecimento;
        Email = email;
    }
}