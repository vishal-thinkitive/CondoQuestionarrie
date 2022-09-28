namespace CondoQuestionnaire.Core.CondoQuestionnaire;

public class QuestionType : IEquatable<QuestionType>
{
    public string Value { get; }

    private QuestionType(string value)
    {
        Value = value;
    }

    public bool Equals(QuestionType? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Value == other.Value;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((QuestionType) obj);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public static bool operator ==(QuestionType? left, QuestionType? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(QuestionType? left, QuestionType? right)
    {
        return !Equals(left, right);
    }

    public static QuestionType String => new QuestionType(nameof(String));
    public static QuestionType Text => new QuestionType(nameof(Text));
    public static QuestionType Boolean => new QuestionType(nameof(Boolean));
    public static QuestionType Date => new QuestionType(nameof(Date));
    public static QuestionType Number => new QuestionType(nameof(Number));
    public static QuestionType PhoneNumber => new QuestionType(nameof(PhoneNumber));
    public static QuestionType Address => new QuestionType(nameof(Address));
    public static QuestionType Email => new QuestionType(nameof(Email));
    public static QuestionType MultiSelect => new QuestionType(nameof(MultiSelect));
}