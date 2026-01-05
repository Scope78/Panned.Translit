using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_common_pol : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.common_pol;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"A");
        output = Rule2().Replace(output, @"a");
        output = Rule3().Replace(output, @"C");
        output = Rule4().Replace(output, @"c");
        output = Rule5().Replace(output, @"E");
        output = Rule6().Replace(output, @"e");
        output = Rule7().Replace(output, @"L");
        output = Rule8().Replace(output, @"l");
        output = Rule9().Replace(output, @"N");
        output = Rule10().Replace(output, @"n");
        output = Rule11().Replace(output, @"O");
        output = Rule12().Replace(output, @"o");
        output = Rule13().Replace(output, @"S");
        output = Rule14().Replace(output, @"s");
        output = Rule15().Replace(output, @"Z");
        output = Rule16().Replace(output, @"z");
        output = Rule17().Replace(output, @"Z");
        output = Rule18().Replace(output, @"z");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new NotReversableException();
    }
              
    [GeneratedRegex(@"Ą")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"ą")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"Ć")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"ć")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"Ę")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"ę")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"Ł")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"ł")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"Ń")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"ń")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"Ó")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"ó")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"Ś")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"ś")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"Ź")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"ź")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"Ż")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"ż")]
    private static partial Regex Rule18();

}
