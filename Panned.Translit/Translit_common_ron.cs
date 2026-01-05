using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_common_ron : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.common_ron;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"A");
        output = Rule2().Replace(output, @"a");
        output = Rule3().Replace(output, @"A");
        output = Rule4().Replace(output, @"a");
        output = Rule5().Replace(output, @"I");
        output = Rule6().Replace(output, @"i");
        output = Rule7().Replace(output, @"S");
        output = Rule8().Replace(output, @"s");
        output = Rule9().Replace(output, @"S");
        output = Rule10().Replace(output, @"s");
        output = Rule11().Replace(output, @"T");
        output = Rule12().Replace(output, @"t");
        output = Rule13().Replace(output, @"T");
        output = Rule14().Replace(output, @"t");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new NotReversableException();
    }
              
    [GeneratedRegex(@"Ă")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"ă")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"Â")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"â")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"Î")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"î")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"Ș")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"ș")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"Ş")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"ş")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"Ț")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"ț")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"Ţ")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"ţ")]
    private static partial Regex Rule14();

}
