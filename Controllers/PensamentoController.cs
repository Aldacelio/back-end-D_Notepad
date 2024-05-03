using D_Notepad_back.Models;
using D_Notepad_back.Views;
using Microsoft.AspNetCore.Mvc;

namespace D_Notepad_back.Controllers
{
    [ApiController]
    [Route("api/v1/pensamento")]
    public class PensamentoController : ControllerBase
    {
        private readonly IPensamentoRepository _pesamentoRepository;

        public PensamentoController(IPensamentoRepository pesamentoRepository)
        {
            _pesamentoRepository = pesamentoRepository ?? throw new ArgumentNullException();
        }

        [HttpPost]
        public IActionResult Add(PensamentoViewModel pensamentoView)
        {
            var pensamento = new Pensamento(pensamentoView.conteudo, pensamentoView.autoria, pensamentoView.modelo);
            _pesamentoRepository.Add(pensamento);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var pensamento = _pesamentoRepository.Get();

            Console.WriteLine(pensamento);
            return Ok(pensamento);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var pensamento = _pesamentoRepository.GetById(id);
            if (pensamento == null)
            {
                return NotFound(); // Retorna 404 se o pensamento não for encontrado
            }
            return Ok(pensamento);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, PensamentoViewModel pensamentoView)
        {
            var pensamento = _pesamentoRepository.GetById(id);
            if (pensamento == null)
            {
                return NotFound(); // Retorna 404 se não encontrar o pensamento com o ID especificado
            }

            pensamento.AtualizarPensamento(pensamentoView.conteudo, pensamentoView.autoria, pensamentoView.modelo);

            _pesamentoRepository.Update(pensamento);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pensamento = _pesamentoRepository.GetById(id);
            if (pensamento == null)
            {
                return NotFound(); // Retorna 404 se não encontrar o pensamento com o ID especificado
            }

            _pesamentoRepository.Delete(pensamento);

            return Ok();
        }



    }
}
