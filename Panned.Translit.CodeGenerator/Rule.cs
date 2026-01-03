namespace Panned.Translit.CodeGenerator;

internal class Rule
{
    public Rule(int id, string from, string to, string? before, string? after)
    {
        Id = id;
        From = EscapeQuotes(from);
        To = EscapeQuotes(to);
        Before = EscapeQuotes(ChangePropertyClasses(before));
        After = EscapeQuotes(ChangePropertyClasses(after));
    }

    public int Id { get; }
    public string MethodName => $"Rule{Id}";
    public string MethodNameReverse => $"RuleReverse{Id}";
    public string From { get; }
    public string To { get; }
    public string Before { get; }
    public string After { get; }

    public string RegEx => GetRegEx(From);
    public string RegExReverse => GetRegEx(To);

    private string GetRegEx(string from)
    {
        if (!string.IsNullOrEmpty(Before) && string.IsNullOrEmpty(After))
        {
            return @$"{from}(?={Before})";
        }
        else if (!string.IsNullOrEmpty(After) && string.IsNullOrEmpty(Before))
        {
            return $@"(?<={After}){from}";
        }
        else if (!string.IsNullOrEmpty(Before) && !string.IsNullOrEmpty(After))
        {
            return @$"(?<={After}){from}(?={Before})";
        }
        else
        {
            return from;
        }
    }

    private static string EscapeQuotes(string? text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return string.Empty;
        }

        return text.Replace("\"", "\"\"");
    }

    private static string ChangePropertyClasses(string? pattern)
    {
        if (string.IsNullOrEmpty(pattern))
        {
            return string.Empty;
        }

        pattern = pattern.Replace(@"\p{IsUpper}", @"\p{Lu}");
        pattern = pattern.Replace(@"\p{IsLower}", @"\p{LI}");
        pattern = pattern.Replace(@"\p{IsSpace}", @"\s");
        pattern = pattern.Replace(@"\p{IsWord}", @"\w");

        return pattern;
    }
}