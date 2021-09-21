using CsjSistemas.LocaisReciclagem.API.DTO;
using CsjSistemas.LocaisReciclagem.API.Queries.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsjSistemas.LocaisReciclagem.API.Controllers
{
    
    public class LocaisReciclagemController : MainController
    {
        private readonly ILocaisReciclagemQueries _locaisReciclagemQueries;

        public LocaisReciclagemController(ILocaisReciclagemQueries locaisReciclagemQueries)
        {
            _locaisReciclagemQueries = locaisReciclagemQueries;
        }

        [Route("api/listagem")]
        public async Task<IActionResult> Index()
        {
            var locais = await _locaisReciclagemQueries.ObterTodos();
            return CustomResponse(_locaisReciclagemQueries.ObterTodos());
        }

        [HttpGet]
        [Route("api/todos-locais")]
        public async Task<JsonResult> ObterTodos()
        {
            var resultado = await _locaisReciclagemQueries.ObterTodos();
            return Json(CustomResponse(resultado));
        }

        [HttpGet]
        [Route("api/local")]
        public async Task<JsonResult> ObterPorId(Int64 id)
        {
            var resultado = await _locaisReciclagemQueries.ObterPorId(id);

            return Json(CustomResponse(resultado));
        }

        
        [HttpPost]
        [Route("api/adicionar")]
        public JsonResult Adicionar([FromForm]LocaisReciclagemDTO param)
        {
            _locaisReciclagemQueries.Adicionar(param);

            return Json(CustomResponse());
        }

        [HttpPost]
        [Route("api/atualizar")]
        public async Task<JsonResult> Atualizar([FromForm] LocaisReciclagemDTO local)
        {
            var localCompleto = SplitLocal(local);
            await _locaisReciclagemQueries.Atualizar(localCompleto);

            return Json(CustomResponse());
        }

        [HttpGet]
        [Route("api/excluir/{id}")]
        public async Task<JsonResult> Excluir(string id)
        {
            await _locaisReciclagemQueries.Excluir(Convert.ToInt64(id));
            return Json(CustomResponse());
        }


        private LocaisReciclagemDTO SplitLocal(LocaisReciclagemDTO endereco)
        {
            var obj = new LocaisReciclagemDTO();
            var split = endereco.Logradouro.Split(",");
            obj.Logradouro = split.FirstOrDefault();
            obj.CEP = split[3];

            var splitCidade = split[2].Split("-");
            obj.Cidade = splitCidade.FirstOrDefault();
            var splitNumero = split[1].Split("-");
            obj.NumeroEndereco = splitNumero.FirstOrDefault();
            obj.Bairro = splitNumero[1].ToString();

            obj.Identificacao = $"LR - {splitNumero[1].ToString()}";
            obj.Latitude = endereco.Latitude;
            obj.Longitude = endereco.Longitude;
            obj.Capacidade = endereco.Capacidade;
            obj.Complemento = endereco.Complemento;
            obj.LocalReciclagem_Id = endereco.LocalReciclagem_Id;

            return obj;
        }
    }
}
