using System.Xml.Linq;

namespace Panned.Translit.CodeGenerator;

internal class TranslitParser
{
    public TranslitParser(string fileName)
    {
        var rulesDoc = XDocument.Load(fileName);
        IsReversable = rulesDoc.Root?.Element("reverse")?.Value == "true";
        IsReversableValue = IsReversable ? "true" : "false";
        var allRules = rulesDoc.Root?.Element("rules")?.Elements("rule");
        Rules = [.. GetRules(allRules)];
    }

    private static IEnumerable<Rule> GetRules(IEnumerable<XElement>? allRules)
    {
        if (allRules == null)
        {
            yield break;
        }

        var id = 0;

        foreach (var rule in allRules)
        {
            var ruleFrom = rule.Element("from")!.Value;
            var ruleTo = rule.Element("to")!.Value;
            var context = rule.Element("context");
            var contextBefore = context?.Element("before")?.Value;
            var contextAfter = context?.Element("after")?.Value;

            yield return new Rule(++id, ruleFrom, ruleTo, contextBefore, contextAfter);
        }
    }

    public bool IsReversable { get; }
    public string IsReversableValue { get; }

    public IList<Rule> Rules { get; }
}
