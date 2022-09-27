using System.Linq.Expressions;

namespace CondoQuestionnaire.Core.Includes;

public class IncludeDescription<T> : IIncludeDescription<T>
{
    private readonly HashSet<string> _properties;

    public IncludeDescription()
    {
        _properties = new HashSet<string>();
    }
    public IEnumerable<string> TheseNames()
    {
        return _properties.ToArray();
    }
    public bool Contains(string name)
    {
        return _properties.Contains(name);
    }

    public IIncludeDescription<T> Include(Expression<Func<T, object>> expression)
    {
        var name = GetNameForExpression(expression);

        _properties.Add(name);
        return this;
    }

    public bool IncludesField(Expression<Func<T, object>> expression)
    {
        return Contains(GetNameForExpression(expression));
    }

    private static string GetNameForExpression(Expression<Func<T, object>> expression)
    {
        var expressionBody = (MemberExpression) expression.Body;
        var name = expressionBody.Member.Name;
        return name;
    }
}