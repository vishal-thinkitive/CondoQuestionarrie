namespace CondoQuestionnaire.Shared.ValueEnums;

public class ContactMethodType : IEquatable<ContactMethodType>
{
    public string Value { get; }

    private sealed class ValueEqualityComparer : IEqualityComparer<ContactMethodType>
    {
        public bool Equals(ContactMethodType x, ContactMethodType y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.Value == y.Value;
        }

        public int GetHashCode(ContactMethodType obj)
        {
            return obj.Value.GetHashCode();
        }
    }

    public static IEqualityComparer<ContactMethodType> ValueComparer { get; } = new ValueEqualityComparer();

    public bool Equals(ContactMethodType? other)
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
        return Equals((ContactMethodType) obj);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public static bool operator ==(ContactMethodType? left, ContactMethodType? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(ContactMethodType? left, ContactMethodType? right)
    {
        return !Equals(left, right);
    }

    private ContactMethodType(string value)
    {
        Value = value;
    }
    
    public static ContactMethodType Phone => new(nameof(Phone));
    public static ContactMethodType Email => new(nameof(Email));
    public static ContactMethodType Fax => new(nameof(Fax));
}