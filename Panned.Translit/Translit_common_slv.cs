using System;
using System.Text.RegularExpressions;
using System.IO;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_common_slv : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.common_slv;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"C");
        output = Rule2().Replace(output, @"c");
        output = Rule3().Replace(output, @"S");
        output = Rule4().Replace(output, @"s");
        output = Rule5().Replace(output, @"Z");
        output = Rule6().Replace(output, @"z");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new InvalidOperationException("Not reversable");
    }
              
    [GeneratedRegex(@"Č")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"č")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"Š")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"š")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"Ž")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"ž")]
    private static partial Regex Rule6();

}
