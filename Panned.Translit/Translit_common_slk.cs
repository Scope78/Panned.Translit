using System;
using System.Text.RegularExpressions;
using System.IO;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_common_slk : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.common_slk;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"A");
        output = Rule2().Replace(output, @"a");
        output = Rule3().Replace(output, @"A");
        output = Rule4().Replace(output, @"a");
        output = Rule5().Replace(output, @"C");
        output = Rule6().Replace(output, @"c");
        output = Rule7().Replace(output, @"D");
        output = Rule8().Replace(output, @"d");
        output = Rule9().Replace(output, @"d");
        output = Rule10().Replace(output, @"E");
        output = Rule11().Replace(output, @"e");
        output = Rule12().Replace(output, @"I");
        output = Rule13().Replace(output, @"i");
        output = Rule14().Replace(output, @"L");
        output = Rule15().Replace(output, @"l");
        output = Rule16().Replace(output, @"L");
        output = Rule17().Replace(output, @"l");
        output = Rule18().Replace(output, @"L");
        output = Rule19().Replace(output, @"l");
        output = Rule20().Replace(output, @"N");
        output = Rule21().Replace(output, @"n");
        output = Rule22().Replace(output, @"O");
        output = Rule23().Replace(output, @"o");
        output = Rule24().Replace(output, @"R");
        output = Rule25().Replace(output, @"r");
        output = Rule26().Replace(output, @"S");
        output = Rule27().Replace(output, @"s");
        output = Rule28().Replace(output, @"T");
        output = Rule29().Replace(output, @"t");
        output = Rule30().Replace(output, @"t");
        output = Rule31().Replace(output, @"U");
        output = Rule32().Replace(output, @"u");
        output = Rule33().Replace(output, @"Y");
        output = Rule34().Replace(output, @"y");
        output = Rule35().Replace(output, @"Z");
        output = Rule36().Replace(output, @"z");
        output = Rule37().Replace(output, @"O");
        output = Rule38().Replace(output, @"o");
        output = Rule39().Replace(output, @"DZ");
        output = Rule40().Replace(output, @"Dz");
        output = Rule41().Replace(output, @"dz");
        output = Rule42().Replace(output, @"DZ");
        output = Rule43().Replace(output, @"Dz");
        output = Rule44().Replace(output, @"dz");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new InvalidOperationException("Not reversable");
    }
              
    [GeneratedRegex(@"Á")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"á")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"Ä")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"ä")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"Č")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"č")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"Ď")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"ď")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"ď")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"É")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"é")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"Í")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"í")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"Ĺ")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"ĺ")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"Ľ")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"ľ")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"Ľ")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"ľ")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"Ň")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"ň")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"Ó")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"ó")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"Ŕ")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"ŕ")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"Š")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"š")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"Ť")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"ť")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"ť")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"Ú")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"ú")]
    private static partial Regex Rule32();
              
    [GeneratedRegex(@"Ý")]
    private static partial Regex Rule33();
              
    [GeneratedRegex(@"ý")]
    private static partial Regex Rule34();
              
    [GeneratedRegex(@"Ž")]
    private static partial Regex Rule35();
              
    [GeneratedRegex(@"ž")]
    private static partial Regex Rule36();
              
    [GeneratedRegex(@"Ô")]
    private static partial Regex Rule37();
              
    [GeneratedRegex(@"ô")]
    private static partial Regex Rule38();
              
    [GeneratedRegex(@"Ǳ")]
    private static partial Regex Rule39();
              
    [GeneratedRegex(@"ǲ")]
    private static partial Regex Rule40();
              
    [GeneratedRegex(@"ǳ")]
    private static partial Regex Rule41();
              
    [GeneratedRegex(@"Ǆ")]
    private static partial Regex Rule42();
              
    [GeneratedRegex(@"ǅ")]
    private static partial Regex Rule43();
              
    [GeneratedRegex(@"ǆ")]
    private static partial Regex Rule44();

}
