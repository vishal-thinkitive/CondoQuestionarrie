using FluentValidation;
using FluentValidation.Results;

namespace TownhomeQuestionnaire.Core.Models;

public abstract class Question
{
    public const string TypeBoolean = "boolean";
    public const string TypeText = "string";
    public const string TypeDate = "date";
    public const string TypeNumber = "number";
    
    public abstract string Label { get; init; }
    public abstract string Code { get; init; }
    public abstract short Order { get; init; }
    public abstract string DefaultAnswer { get; init; }
    public abstract string Hint { get; init; }
    public abstract string Instruction { get; init; }
    public abstract string QuestionType { get; set; }
    public abstract IReadOnlyCollection<Question> ChildQuestions { get; set; }
    public abstract QuestionnaireAnswer Answer { get; set; }
    public abstract IValidator<Question> Validator { get; init; }
    public virtual ValidationResult ValidateAnswer()
    {
        return Validator.Validate(this);
    }
}