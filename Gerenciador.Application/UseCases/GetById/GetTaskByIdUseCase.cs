using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCases.GetById;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Nome = "Tarefa muito bacana",
            Descricao = "Descrição da tarefa muito bacana",
            Prioridade = Communication.Enums.Prioridades.Media,
            DataLimite = DateTime.Now.AddDays(5),
            Status = Communication.Enums.Status.Aguardando
        };
    }
}
