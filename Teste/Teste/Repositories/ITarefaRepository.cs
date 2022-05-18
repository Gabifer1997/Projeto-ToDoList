using Teste.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Teste.Repositories
{
    public interface ITarefaRepository
    {
        Task<List<Tarefa>> GetTarefasAsync();
        Task<List<Tarefa>> GetTarefasByDateAsync();
        Task<List<Tarefa>> GetTarefasByEstadoAsync();
        Task<List<Tarefa>> GetTarefasByApagadoAsync();
        Task<Tarefa> GetTarefaByIdAsync(int id);
        Task<int> SaveAsync(Tarefa novaTarefa);
        Task<int> UpdateTarefaStatusAsync(int id);
        Task<int> PostAsync(int id);
    }
}
