namespace DevQuestions.Presenters;

public record CreateQuestionDto(string Title,  string Body, Guid UserId, Guid[] TagsIds);
public record GetQuestionDto(string Search,  Guid[] TagsIds, int Page, int PageSize);
public record UpdateQuestionDto(string Title, string Body, Guid UserId, Guid[] TagsIds);
public record AddAnswerDto(Guid UserId, string text);