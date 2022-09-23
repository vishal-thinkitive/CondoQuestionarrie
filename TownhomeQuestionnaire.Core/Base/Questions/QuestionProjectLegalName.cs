using System.Collections.ObjectModel;
using FluentValidation;
using FluentValidation.Results;

namespace TownhomeQuestionnaire.Core.Models;

public class QuestionProjectLegalName : Question
{
    public override string Label { get; init; } = "Project Legal Name";
    public override string Code { get; init; } = "Basic|1";
    public override short Order { get; init; } = 7;
    public override string DefaultAnswer { get; init; } = string.Empty;
    public override string Hint { get; init; } = string.Empty;
    public override string Instruction { get; init; } = string.Empty;
    public override string QuestionType { get; set; } = TypeText;
    public override IReadOnlyCollection<Question> ChildQuestions { get; set; } = new List<Question>().AsReadOnly();
    public override QuestionnaireAnswer Answer { get; set; }
    public override IValidator<Question> Validator { get; init; }
}