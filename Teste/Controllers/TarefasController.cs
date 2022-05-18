using Teste.Data;
using Teste.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
namespace Teste.Controllers
{
    [Route("teste/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaRepository _tarefaRepo;
        public TarefasController(ITarefaRepository tarefaRepo)
        {
            _tarefaRepo = tarefaRepo;
        }
        [HttpGet]
        [Route("tarefas")]
        public async Task<IActionResult> GetTarefasAsync()
        {
            var result = await _tarefaRepo.GetTarefasAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("tarefaId")]
        public async Task<IActionResult> GetTodoItemByIdAsync(int id)
        {
            var tarefa = await _tarefaRepo.GetTarefaByIdAsync(id);
            return Ok(tarefa);
        }
        [HttpGet]
        [Route("tarefasNaoConcluidas")]
        public async Task<IActionResult> GetTarefasByDateAsync()
        {
            var result = await _tarefaRepo.GetTarefasByDateAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("tarefasConcluidas")]
        public async Task<IActionResult> GetTodoItemByEstadoAsync()
        {
            var tarefa = await _tarefaRepo.GetTarefasByEstadoAsync();
            return Ok(tarefa);
        }
        [HttpGet]
        [Route("tarefasApagadas")]
        public async Task<IActionResult> GetTodoItemByApagadoAsync()
        {
            var tarefa = await _tarefaRepo.GetTarefasByApagadoAsync();
            return Ok(tarefa);
        }
        [HttpPost]
        [Route("criarTarefa")]
        public async Task<IActionResult> SaveAsync(Tarefa novaTarefa)
        {
            var result = await _tarefaRepo.SaveAsync(novaTarefa);
            return Ok(result);
        }
        [HttpDelete]
        [Route("atualizarTarefa")]
        public async Task<IActionResult> UpdateTarefaStatusAsync(int id)
        {
            var resultado = await _tarefaRepo.UpdateTarefaStatusAsync(id);
            return Ok(resultado);
        }
        [HttpDelete]
        [Route("apagarTarefa")]
        public async Task<IActionResult> PostAsync(int id)
        {
            var resultado = await _tarefaRepo.PostAsync(id);
            return Ok(resultado);
        }
    }
}
