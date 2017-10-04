using consumerApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace consumerApi.Controllers
{
    public class FuncionarioController : Controller
    {
        public IList<Funcionario> funcs = new List<Funcionario>();
        // GET: Funcionario
        public ActionResult Index()
        {
            var client = new WebClient();

            client.Encoding = System.Text.Encoding.UTF8;

            var docJson = client.DownloadString(@"http://localhost:1395/api/Funcionarios");
            

            List<dynamic> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<dynamic>>(docJson.ToString());

            foreach (var f in list)
            {
                var func = new Funcionario();
                func.Id = f.Id;
                func.Nome = f.Nome;
                func.Funcao = f.Funcao;
                func.Turno = f.Turno;
                func.HorasTrabalhadas = f.HorasTrabalhadas;
                func.ValorDaHora = f.ValorDaHora;

                func.ValorVenda = func.getValorVenda();
                func.SalarioFinal = func.getSalarioFinal();
                funcs.Add(func);
            }
            return View(funcs);
        }
    }
}