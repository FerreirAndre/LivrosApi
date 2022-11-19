using Microsoft.EntityFrameworkCore;
using LivrosApi.Context;
using Microsoft.AspNetCore.Mvc;
using LivrosApi.Models;

namespace LivrosApi.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class LivroController : ControllerBase
    {
        private readonly LivrariaContext _context;
        
        public LivroController(LivrariaContext context)
        {
            _context = context;
        }
        
        [HttpPost("/criar")]
        public IActionResult Create(Livro livro)
        {
            _context.Add(livro);
            _context.SaveChanges();
            return Ok(livro);
        }
    }
}