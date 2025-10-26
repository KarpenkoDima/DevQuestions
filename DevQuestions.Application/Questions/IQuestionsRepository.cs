using DevQuestions.Domain.Questions;

namespace DevQuestions.Application.Questions;

public interface IQuestionsRepository
{
    Task<Guid> AddAsync(Question question, CancellationToken cancellation);
    Task<Guid> UpdateAsync(Question question, CancellationToken cancellation);
    Task<Guid> DeleteAsync(Guid questionId, CancellationToken cancellation);
    Task<IEnumerable<Question>> GetAllAsync(CancellationToken cancellation);
    Task<Question> GetByIdAsync(Guid questionId, CancellationToken cancellation);

    Task<int> GetOpenUserQuestionsAsync(Guid userId, CancellationToken cancellation);
}
