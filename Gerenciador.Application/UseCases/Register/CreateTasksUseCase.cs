using Gerenciador.Communication.Requests;
using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCases.Register;
public class CreateTasksUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseRegisteredTaskJson()
        {
            Id = new Random().Next(1, 1000), // Simula a geração de um ID único
            Nome = request.Nome,
            Descricao = request.Descricao,
            Prioridade = request.Prioridade,
            DataLimite = request.DataLimite,
            Status = request.Status
        };

    }
}
