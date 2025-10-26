using DevQuestions.Contracts;
using FluentValidation;

namespace DevQuestions.Application.Questions;

internal class CreateQuestionValidator : AbstractValidator<CreateQuestionDto>
{
    public CreateQuestionValidator()
    {
        RuleFor(q => q.Title).NotEmpty().MaximumLength(500).WithMessage("Too long title");
        RuleFor(q => q.UserId).NotEmpty().("User id dont empty");
    }
}
