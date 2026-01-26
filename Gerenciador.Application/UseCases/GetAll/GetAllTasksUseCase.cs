using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCases.GetAll;
public class GetAllTasksUseCase
{
    public ResponseAllTasks Execute()
    {
        return new ResponseAllTasks
        {
            Tasks = new List<ResponseShortTasksJson>
            {
                new ResponseShortTasksJson
                {
                    Id = 1,
                    Nome = "Tarefa 1",
                    Descricao = "Descrição da tarefa 1",
                    Prioridade = Communication.Enums.Prioridades.Alta,
                    DataLimite = DateTime.Now.AddDays(5),
                    Status = Communication.Enums.Status.EmAndamento
                },
            }
        };
    }
}
