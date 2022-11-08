using MudBlazor;

namespace CondoQuestionnaire.Client.Converters
{
    public class ConverterUtility
    {
        public static Converter<object> StringConverter => stringConverter;
        public static MudBlazor.Converter<DateTime?, string> DateConverter => dateConverter;
        public static MudBlazor.Converter<object, bool?> BooleanConverter => booleanConverter;

        private static Converter<object> stringConverter = new()
        {
            SetFunc = value => value.ToString(),
            GetFunc = text => (object)text,
        };

        private static MudBlazor.Converter<DateTime?, string> dateConverter = new ()
        {
            SetFunc = value => value.ToString(),
            GetFunc = text => Convert.ToDateTime(text),
        };

        private static MudBlazor.Converter<object, bool?> booleanConverter = new ()
        {
            SetFunc = value => (value ?? "").ToString() == "true",
            GetFunc = text => (object)text,
        };

    }
}
