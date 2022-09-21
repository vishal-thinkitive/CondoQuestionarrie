using FluentValidation;

namespace TownhomeQuestionnaire.Core.Models.Validators;

public class QuestionProjectLegalNameValidator : AbstractValidator<QuestionProjectLegalName>
{
    public QuestionProjectLegalNameValidator()
    {
        RuleFor(q => q.Answer.Value)
            .NotEmpty()
            .MaximumLength(1200)
            .MinimumLength(2);
    }
}