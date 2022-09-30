using VeiculosAPI.Data;
using VeiculosAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeiculosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : Controller
    {
        private VeiculoContext _context;

        public VeiculoController(VeiculoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Veiculo> GetVeiculo()
        {
            return _context.Veiculo;
        }
        [HttpPost]
        public IActionResult AddVeiculo([FromBody] Veiculo veiculo)
        {
            if(veiculo.Ano > 1930) 
            {
                _context.Veiculo.Add(veiculo);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetVeiculoById), new { veiculo.IdVeiculo }, veiculo);
            }
            return NotFound();
        }


        [HttpGet("{id}")]
        public IActionResult GetVeiculoById(int id)
        {
            Veiculo veiculo = _context.Veiculo.FirstOrDefault(veiculo => veiculo.IdVeiculo == id);
            if (veiculo != null)
            {
                return Ok(veiculo);
            }
            return NotFound();
        }

    }
}
