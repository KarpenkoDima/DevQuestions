using Microsoft.AspNetCore.Mvc;

namespace DevQuestions.Presenters;

[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<string>> Create([FromBody] CreateQuestionDto questionDto, CancellationToken cancellation)
    {
        return Ok("Question");
    }

    [HttpPost("{question_id}/answer")]
    public async Task<IActionResult> AddAnswer([FromBody] AddAnswerDto questionDto, CancellationToken cancellation)
    {
        return Ok("Add answer");
    }

    // GET: /questions?tag_id=1&limit=1&title="test"
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetQuestionDto questionDto, CancellationToken cancellation)
    {
        return Ok("GetQuestion");
    }

    // GET: /quiestions/{question_id}
    [HttpGet("{questionId:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid questionId, CancellationToken cancellation)
    {
        return Ok("GetQuestion");
    }

    // PUT: /quiestions/{question_id}
    [HttpPut("{questionId:guid}")]
    public async Task<IActionResult> Update([FromRoute] Guid questionId, [FromBody]UpdateQuestionDto questionDto, CancellationToken cancellation)
    {
        return Ok("Update Question");
    }

    // DELETE: /quiestions/{question_id}
    [HttpDelete("{questionId:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid questionId, CancellationToken cancellation)
    {
        return Ok("Delete Question");
    }

    // PUT: /quiestions/{question_id}/solution
    [HttpPut("{questionId:guid}/solution")]
    public async Task<IActionResult> SelectSolution([FromRoute] Guid questionId, [FromQuery] Guid answerId, CancellationToken cancellation)
    {
        return Ok("Select solution");
    }
}

