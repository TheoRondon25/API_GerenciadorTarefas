using Gerenciador.Application.UseCases.Register;
using Gerenciador.Communication.Requests;
using Gerenciador.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_GerenciadorTarefas.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult RegisterTask([FromBody] RequestTaskJson request)
    {
        try
        {
            var useCases = new CreateTasksUseCase();
            var response = useCases.Execute(request);

            return Created(string.Empty, response);
        }
        catch (Exception ex)
        {
            return BadRequest(new { erro = ex.Message });
        }               
    }
}
