using System;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        public ProdutoController(DataContext context)
        {

        }

        //POST: api/produto/create
        [HttpPost]
        [Route("create")]
        public Produto Create(Produto produto)
        {
            Console.WriteLine(produto);
            produto.Nome += " Alterado";
            return produto;
        }
    }
}