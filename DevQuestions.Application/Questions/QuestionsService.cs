using DevQuestions.Domain.Questions;
using DevQuestions.Contracts;
using Microsoft.Extensions.Logging;
using FluentValidation;

namespace DevQuestions.Application.Questions;

public class QuestionsService:IQuestionsService
{
    private readonly IQuestionsRepository _questionsRepository;
    private readonly ILogger<QuestionsService> _logger;
    private readonly IValidator<CreateQuestionDto> _validator;

    public QuestionsService(IQuestionsRepository questionsRepository, ILogger<QuestionsService> logger, IValidator<CreateQuestionDto> validator)
    {
        _questionsRepository = questionsRepository;
        _validator = validator;
        _logger = logger;
    }
    public async Task<Guid> Create(CreateQuestionDto questionDto, CancellationToken cancellation)
    {
       var validationResult = await _validator.ValidateAsync(questionDto, cancellation);
        if (false == validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }
        int count = await _questionsRepository.GetOpenUserQuestionsAsync(questionDto.UserId, cancellation);
        if(count >= 3)
        {
            throw new Exception("Пользователь не может открыть больше 3 вопросов");
        }

        Guid id = Guid.NewGuid();
        var question = new Question(
            id,
            questionDto.Title,
            questionDto.Body, 
            questionDto.UserId,
            screenshortId:null,
            questionDto.TagsIds.ToList()
        );

        await _questionsRepository.AddAsync(question, cancellation);
        _logger.LogInformation($"Craete question wit id {question.Id}");
        return id;
    }

    public async Task AddAnswer( AddAnswerDto questionDto, CancellationToken cancellation)
    {
    }

  
    public async Task Get(GetQuestionDto questionDto, CancellationToken cancellation)
    {
    }

   
    public async Task GetById( Guid questionId, CancellationToken cancellation)
    {
       
    }

    public async Task Update(Guid questionId, UpdateQuestionDto questionDto, CancellationToken cancellation)
    {
    }

  
    public async Task Delete( Guid questionId, CancellationToken cancellation)
    {
    }

   
    public async Task SelectSolution(Guid questionId,  Guid answerId, CancellationToken cancellation)
    {
    }
}
