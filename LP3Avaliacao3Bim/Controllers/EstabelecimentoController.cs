using Microsoft.AspNetCore.Mvc;
using LP3Avaliacao3Bim.ViewModels;
using System.Diagnostics;
using LP3Avaliacao3Bim.Models;

namespace LP3Avaliacao3Bim.Controllers;

public class EstabelecimentoController : Controller
{

    private static List<EstabelecimentoViewModel> estabelecimentos = new List<EstabelecimentoViewModel>{
        new EstabelecimentoViewModel(1, "Piso 3", "Tênis Brasil", "Aqui vc encontra os tênis","Loja","tenis@email.com"),
        new EstabelecimentoViewModel(2, "Piso 3", "Lembranças Já", "Vem comprar sua lembrança", "Kiosque", "lemb@email.com"),
        new EstabelecimentoViewModel(3, "Piso 1", "Sorvetinho Gelado", "Sorvetinho Gelado", "Kiosque", "sorvet@email.com")
    };

    public IActionResult Index()
    {
        return View(estabelecimentos);
    }
    public IActionResult Detalhes(int id)
    {
        return View(estabelecimentos[id - 1]);
    }
    public IActionResult Admin()
    {
        return View(estabelecimentos);
    }

    public IActionResult Cadastro(int id, string piso, string nome, string descricao, string tipoestabelecimento, string email)
    {  
        foreach (var estabelecimento in estabelecimentos)
        {
            if(nome == estabelecimento.Nome){
                ViewData["Nome"] = nome;
                return View();
            }
        } 
            
        id = estabelecimentos.Count + 1;
        estabelecimentos.Add(new EstabelecimentoViewModel(id, piso, nome, descricao, tipoestabelecimento, email));
        return View("Cadastro");
    }

    public IActionResult Excluir(int id)
    {
        estabelecimentos.RemoveAt(id - 1);

        for(var i = id - 1; i < estabelecimentos.Count; i++)
        {
            estabelecimentos[i].Id -= 1;
        }
       
        return View("Excluir");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
 
}