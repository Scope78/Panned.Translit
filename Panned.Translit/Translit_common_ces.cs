using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_common_ces : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.common_ces;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"A");
        output = Rule2().Replace(output, @"a");
        output = Rule3().Replace(output, @"C");
        output = Rule4().Replace(output, @"c");
        output = Rule5().Replace(output, @"D");
        output = Rule6().Replace(output, @"d");
        output = Rule7().Replace(output, @"d");
        output = Rule8().Replace(output, @"E");
        output = Rule9().Replace(output, @"e");
        output = Rule10().Replace(output, @"E");
        output = Rule11().Replace(output, @"e");
        output = Rule12().Replace(output, @"I");
        output = Rule13().Replace(output, @"i");
        output = Rule14().Replace(output, @"N");
        output = Rule15().Replace(output, @"n");
        output = Rule16().Replace(output, @"O");
        output = Rule17().Replace(output, @"o");
        output = Rule18().Replace(output, @"R");
        output = Rule19().Replace(output, @"r");
        output = Rule20().Replace(output, @"S");
        output = Rule21().Replace(output, @"s");
        output = Rule22().Replace(output, @"T");
        output = Rule23().Replace(output, @"t");
        output = Rule24().Replace(output, @"t");
        output = Rule25().Replace(output, @"U");
        output = Rule26().Replace(output, @"u");
        output = Rule27().Replace(output, @"U");
        output = Rule28().Replace(output, @"u");
        output = Rule29().Replace(output, @"Y");
        output = Rule30().Replace(output, @"y");
        output = Rule31().Replace(output, @"Z");
        output = Rule32().Replace(output, @"z");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new NotReversableException();
    }
              
    [GeneratedRegex(@"Á")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"á")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"Č")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"č")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"Ď")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"ď")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"ď")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"É")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"é")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"Ě")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"ě")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"Í")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"í")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"Ň")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"ň")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"Ó")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"ó")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"Ř")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"ř")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"Š")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"š")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"Ť")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"ť")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"ť;")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"Ú")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"ú")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"Ů")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"ů")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"Ý")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"ý")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"Ž")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"ž")]
    private static partial Regex Rule32();

}
