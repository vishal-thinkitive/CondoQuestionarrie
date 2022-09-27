namespace CondoQuestionnaire.Core.Utils.DateTime;

public class DateTimeProvider : IDateTimeProvider
{
    public virtual System.DateTime GetUtcNow()
    {
        return System.DateTime.UtcNow;
    }
}