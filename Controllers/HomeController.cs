using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LhPet.Models;

namespace LhPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Instancias do tipo cliente
        ClientePet cliente1 = new ClientePet(01,"Agatha Aguiar","493.802.040-86", "aguiarAgatha@pe.br","Fadinha"); 
        ClientePet cliente2 = new ClientePet(02,"Emanuele Albuquerque","356.079.230-45","ManuAlbuquerque2011@pe.br", "Machel");
        ClientePet cliente3 = new ClientePet(03,"Vinicius Oliveira","818.778.690-66","vinicius@oliveira.pe.br","Vitorio");
        ClientePet cliente4 = new ClientePet(04,"Neto Gonçalves","548.402.700-40","netogoncalves@pe.br","Carrapicho");

        //lista de Clientes e atribui os Clientes
        List<ClientePet> listaClientes = new List<ClientePet>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);

        ViewBag.listaClientes = listaClientes;


        // Instancias do tipo Fornecedor e atribui Fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01,"Sedan Pet","12.182.104/0001-70","sedanpet@pe.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "RacoesC&a", "20.154.201/0001-10", "racoescia@pe.br");

        //lista de fornecedor
        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(fornecedor1);
        listaFornecedor.Add(fornecedor2);

        ViewBag.listaFornecedor = listaFornecedor;

        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
