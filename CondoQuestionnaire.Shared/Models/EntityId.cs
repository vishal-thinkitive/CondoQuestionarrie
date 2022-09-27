namespace CondoQuestionnaire.Shared.Models;

public class EntityId: ICloneable
{
    private readonly Guid _idField;
    
    public EntityId()
    {
        _idField = new Guid();
    }

    public EntityId(Guid id)
    {
        _idField = Guid.Parse(id.ToString());
    }

    public Guid AsGuid() => Guid.Parse(_idField.ToString());
    
    public object Clone()
    {
        return new EntityId(_idField);
    }
    
    private sealed class IdFieldEqualityComparer : IEqualityComparer<EntityId>
    {
        public bool Equals(EntityId? x, EntityId? y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x._idField.Equals(y._idField);
        }

        public int GetHashCode(EntityId obj)
        {
            return obj._idField.GetHashCode();
        }
    }

    public static IEqualityComparer<EntityId> IdFieldComparer { get; } = new IdFieldEqualityComparer();

    protected bool Equals(EntityId other)
    {
        return _idField.Equals(other._idField);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((EntityId) obj);
    }

    public override int GetHashCode()
    {
        return _idField.GetHashCode();
    }

    public static implicit operator Guid(EntityId id) => id.AsGuid();

    public override string ToString()
    {
        return _idField.ToString();
    }
}