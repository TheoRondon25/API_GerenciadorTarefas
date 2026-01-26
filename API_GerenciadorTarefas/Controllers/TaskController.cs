using Gerenciador.Application.UseCases.GetAll;
using Gerenciador.Application.UseCases.GetById;
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
        
        var useCases = new CreateTasksUseCase();
        var response = useCases.Execute(request);

        return Created(string.Empty, response);               
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasks), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetAll()
    {        
        var useCase = new GetAllTasksUseCase();
        var response = useCase.Execute();

        if (response.Tasks.Any())
            return Ok(response);

        return NoContent();            
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]    
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Get(int id)
    {
        var useCase = new GetTaskByIdUseCase();
        var response = useCase.Execute(id);

        return Ok(response);        
    }
}
