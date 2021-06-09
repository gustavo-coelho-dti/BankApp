using BankApp.Api.Data;
using BankApp.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Api.Controllers
{
    [Route("contas")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private ApplicationDbContext _context;

        public ContasController(ApplicationDbContext context) 
        {
            _context = context;  // objeto do tipo ApplicationDbContext - container de serviços
        }

        [HttpGet("listar")]
        public IActionResult Listar()
        {
            List<Conta> listaContas = _context.Contas.ToList();
            return new OkObjectResult(listaContas);
        }
    }
}
