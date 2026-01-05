using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_common_deu : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.common_deu;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"Ae");
        output = Rule2().Replace(output, @"ae");
        output = Rule3().Replace(output, @"Oe");
        output = Rule4().Replace(output, @"oe");
        output = Rule5().Replace(output, @"Ue");
        output = Rule6().Replace(output, @"ue");
        output = Rule7().Replace(output, @"SS");
        output = Rule8().Replace(output, @"ss");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new NotReversableException();
    }
              
    [GeneratedRegex(@"Ä")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"ä")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"Ö")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"ö")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"Ü")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"ü")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"(?<=\p{Lu})ß")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"ß")]
    private static partial Regex Rule8();

}
