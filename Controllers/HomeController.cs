using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BuscaEndereco.Models;
using BuscaEndereco.Util;
using Microsoft.AspNetCore.Mvc;

namespace BuscaEndereco.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var endereco = await ConverteJson();
            return View(endereco);
        }

        public async Task<Endereco> ConverteJson()
        {
            var json = await RetornaJson();
            var endereco = json.Parse<Endereco>();
            return endereco;
        }        

        private static async Task<string> RetornaJson()
        {
            HttpClient cliente = new HttpClient();
            HttpResponseMessage resposta = await cliente.GetAsync("https://viacep.com.br/ws/01001000/json/");
            resposta.EnsureSuccessStatusCode();

            return await resposta.Content.ReadAsStringAsync();       
        }
    }
}