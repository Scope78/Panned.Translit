using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_iso_8859_16_ron : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.iso_8859_16_ron;

    public override bool IsReversable => true;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"Ș");
        output = Rule2().Replace(output, @"ș");
        output = Rule3().Replace(output, @"Ț");
        output = Rule4().Replace(output, @"ț");

        return output;
    }

    public override string Reverse(string input)
    {
        string output = input;

        output = RuleReverse1().Replace(output, @"Ş");
        output = RuleReverse2().Replace(output, @"ş");
        output = RuleReverse3().Replace(output, @"Ţ");
        output = RuleReverse4().Replace(output, @"ţ");

        return output;
    }
              
    [GeneratedRegex(@"Ş")]
    private static partial Regex Rule1();
                   
    [GeneratedRegex(@"Ș")]
    private static partial Regex RuleReverse1();
              
    [GeneratedRegex(@"ş")]
    private static partial Regex Rule2();
                   
    [GeneratedRegex(@"ș")]
    private static partial Regex RuleReverse2();
              
    [GeneratedRegex(@"Ţ")]
    private static partial Regex Rule3();
                   
    [GeneratedRegex(@"Ț")]
    private static partial Regex RuleReverse3();
              
    [GeneratedRegex(@"ţ")]
    private static partial Regex Rule4();
                   
    [GeneratedRegex(@"ț")]
    private static partial Regex RuleReverse4();

}
