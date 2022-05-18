using Teste.Data;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private DbSession _db;
        public TarefaRepository(DbSession dbSession)
        {
            _db = dbSession;
        }
        public async Task<List<Tarefa>> GetTarefasAsync()
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM tarefas";
                List<Tarefa> tarefas = (await conn.QueryAsync<Tarefa>(sql: query)).ToList();
                return tarefas;
            }
        }
        public async Task<List<Tarefa>> GetTarefasByDateAsync()
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM tarefas WHERE estado = 0 ORDER BY dataConclusao";
                List<Tarefa> tarefas = (await conn.QueryAsync<Tarefa>(sql: query)).ToList();
                return tarefas;
            }
        }
        public async Task<List<Tarefa>> GetTarefasByEstadoAsync()
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM tarefas WHERE estado = 1 ORDER BY dataConclusao";
                List<Tarefa> tarefas = (await conn.QueryAsync<Tarefa>(sql: query)).ToList();
                return tarefas;
            }
        }
        public async Task<List<Tarefa>> GetTarefasByApagadoAsync()
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM tarefas WHERE apagado = 1 ORDER BY dataConclusao";
                List<Tarefa> tarefas = (await conn.QueryAsync<Tarefa>(sql: query)).ToList();
                return tarefas;
            }
        }
        public async Task<Tarefa> GetTarefaByIdAsync(int id)
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM tarefas WHERE Id = @id";
                Tarefa tarefa = await conn.QueryFirstOrDefaultAsync<Tarefa>
                    (sql: query, param: new { id });
                return tarefa;
            }
        }
        public async Task<int> SaveAsync(Tarefa novaTarefa)
        {
            using (var conn = _db.Connection)
            {
                string command = @"INSERT into tarefas (nome, dataConclusao, estado, apagado) values (@nome, @dataConclusao, 0, 0);";
                var result = await conn.ExecuteAsync(sql: command, param: novaTarefa);
                return result;
            }
        }
        public async Task<int> UpdateTarefaStatusAsync(int id)
        {
            using (var conn = _db.Connection)
            {
                string command = @"UPDATE Tarefas SET estado = 1 WHERE Id = @Id";
                var resultado = await conn.ExecuteAsync(sql: command, param: new { id });
                return resultado;
            }
        }
        public async Task<int> PostAsync(int id)
        {
            using (var conn = _db.Connection)
            {
                string command = @"UPDATE Tarefas SET apagado = 1 WHERE Id = @Id";
                var resultado = await conn.ExecuteAsync(sql: command, param: new { id });
                return resultado;
            }
        }
    }
}
