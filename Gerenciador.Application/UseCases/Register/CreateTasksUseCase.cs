using System.Net.Http.Headers;
using Gerenciador.Communication.Enums;
using Gerenciador.Communication.Requests;
using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCases.Register;
public class CreateTasksUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
    {
        Validate(request);

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

    private void Validate(RequestTaskJson request)
    {
        // Itens obrigatorios 
        foreach (var prop in request.GetType().GetProperties())
        {
            var value = prop.GetValue(request);
            if (value is null || string.IsNullOrWhiteSpace(value.ToString()))
                throw new ArgumentException($"O campo {prop.Name} é obrigatório.");
        }

        // maximo 100 caracteres
        if (request.Nome.Length > 100)
            throw new ArgumentException("O nome da tarefa deve ter no máximo 100 caracteres.");

        // Prioridade deve ser um valor valido do enum
        if (!Enum.IsDefined(typeof(Prioridades), request.Prioridade))
            throw new ArgumentException("Prioridade inválida - Enum inexistente.");

        // Data Limite nao pode ser menor que hoje
        if (request.DataLimite.Date < DateTime.Now.Date)
            throw new ArgumentException("A data limite não pode ser menor que a data atual.");

        // Status deve ser um valor valido do enum
        if (!Enum.IsDefined(typeof(Status), request.Status))
            throw new ArgumentException("Status inválido -- Enum inexistente.");
    }
}