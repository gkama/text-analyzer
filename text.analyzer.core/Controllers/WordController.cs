using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using text.analyzer.data;
using text.analyzer.services;

namespace text.analyzer.core.Controllers
{
    [ApiController]
    [Route("v1/words")]
    public class WordController : ControllerBase
    {
        private readonly IWordRepository _repo;

        public WordController(IWordRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("analyse")]
        public IActionResult Get([FromBody, Required] WordAnalysisRequest req)
        {
            return Ok(_repo.Analyse(req.Text));
        }
    }
}