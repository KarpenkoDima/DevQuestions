using DevQuestions.Contracts;
using DevQuestions.Domain.Questions;

namespace DevQuestions.Application.Questions
{
    public interface IQuestionsService
    {
        Task<int> Create(CreateQuestionDto questionDto, CancellationToken cancellation);
        Task AddAnswer(AddAnswerDto questionDto, CancellationToken cancellation);
        Task Get(GetQuestionDto questionDto, CancellationToken cancellation);
        Task GetById(Guid questionId, CancellationToken cancellation);
        Task Update(Guid questionId, UpdateQuestionDto questionDto, CancellationToken cancellation);
        Task Delete(Guid questionId, CancellationToken cancellation);
        Task SelectSolution(Guid questionId, Guid answerId, CancellationToken cancellation);
    }
}