Projeto | ToDoList
Resumo do Projeto:
Consiste na criação de uma aplicação para gerenciar uma lista de tarefas • Cadastrar • Buscar • Atualizar • Excluir.

Com ela, criei uma API REST (Swagger) utilizando C# e .NET 6 com Dapper, também utilizei Microsoft SQL Server como Banco de Dados.

     
A WEB API vai expor endpoints que permitem consultar e realizar as operações para visualizar, incluir, alterar e excluir informações da Tarefas.

OS ENDPOINTS SÃO:

/api/Tarefas/GetTarefas: Puxa todas as Tarefas cadastradas em ordem ASC;
/api/Tarefas/Tarefa/{id}: Puxa um ID relacionada a tal Tarefa;
/api/Tarefas/GetTodosAndCount: Puxa Todas as Tarefas até mesmo as deletadas.
/api/Tarefas/Save: Salva/Cadastra uma Tarefa;
/api/Tarefas/UpadteTodosStatus: Atualiza o Status de uma Tarefa.
/api/Tarefas/Delete: Deleta uma Tarefa, mas deixa ela como "ausente", podendo assim filtrar ela para determinada consulta.
🔨 Sua funcionalidade:
Cadastro de Tarefa: É possível cadastrar quantas tarefas você desejar, junto de uma data no qual ela deve ser concluída

Buscar e fazer atualizações de Tarefa: Podemos filtrar e atualizar as Tarefas, podendo atualizá-las se a mesma ja foi conclúida.

Exclusão: Ela deixa a tarefa como "Ausente" mas não exclui, isso para pertmir que a tal Tarefa possa ser filtrada futuramente caso tenha sido concluída ou não.

Lista Ordenada: Ordena as Tarefas por Ordem ASC

📁 Acesso ao Projeto:
Baixe o arquivo .zip ou abra diretamente na IDE Visual Studio.

🛠️ Abrir e rodar o projeto:
Configurar Banco de Dados: Configure o Banco de Dados SQL ou Qualquer outro banco de sua preferência em appsettings.json.
Basta compilar o código uma vez, para que todas as dependências sejam instaladas corretamente.

Após isso, abra seu SGBD e crie seu Banco de Dados com base na API.
