using Gerenciador.Communication.Enums;

namespace Gerenciador.Communication.Responses;
public class ResponseRegisteredTaskJson
{
    // resposta para o registro de tarefas
    public int Id { get; set; } 
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;    
    
}
