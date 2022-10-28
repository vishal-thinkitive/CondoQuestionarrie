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

    public static QuestionType String => new(nameof(String));
    public static QuestionType Text => new(nameof(Text));
    public static QuestionType Boolean => new(nameof(Boolean));
    public static QuestionType Date => new(nameof(Date));
    public static QuestionType YearOnly => new(nameof(YearOnly));
    public static QuestionType Number => new(nameof(Number));
    public static QuestionType Percentage => new(nameof(Percentage));
    public static QuestionType PhoneNumber => new(nameof(PhoneNumber));
    public static QuestionType Address => new(nameof(Address));
    public static QuestionType Email => new(nameof(Email));
    public static QuestionType MultiSelect => new(nameof(MultiSelect));
    public static QuestionType BooleanWithDateOption => new(nameof(BooleanWithDateOption));
    public static QuestionType Selection => new(nameof(Selection));
    public static QuestionType Table => new(nameof(Table));
    public static QuestionType LabelOnly => new(nameof(LabelOnly));
    public static QuestionType Money = new(nameof(Money));
}