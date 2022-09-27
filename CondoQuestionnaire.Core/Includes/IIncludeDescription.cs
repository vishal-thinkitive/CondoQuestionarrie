using System.Linq.Expressions;
using System.Reflection;
using CondoQuestionnaire.Core.Models;
using FluentValidation.Validators;

namespace CondoQuestionnaire.Core.Includes;

public interface IIncludeDescription<T>
{
    IEnumerable<string> TheseNames();
    bool Contains(string name);
    public IIncludeDescription<T> Include(Expression<Func<T, object>> expression);

    public bool IncludesField(Expression<Func<T, object>> expression);
}