using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerenciador.Communication.Enums;

namespace Gerenciador.Communication.Responses;
public class ResponseRegisteredTaskJson
{
    // resposta para o registro de tarefas
    public int Id { get; set; } 
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Prioridades Prioridade { get; set; }
    public DateTime DataLimite { get; set; }    
    public Status Status { get; set; }
}
