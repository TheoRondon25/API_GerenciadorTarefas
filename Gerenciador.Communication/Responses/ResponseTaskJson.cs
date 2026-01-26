using Gerenciador.Communication.Enums;

namespace Gerenciador.Communication.Responses;
public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Prioridades Prioridade { get; set; }
    public DateTime DataLimite { get; set; }
    public Status Status { get; set; }
}
