using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_common_ara : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.common_ara;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"th");
        output = Rule2().Replace(output, @"kh");
        output = Rule3().Replace(output, @"sh");
        output = Rule4().Replace(output, @"gh");
        output = Rule5().Replace(output, @"'e");
        output = Rule6().Replace(output, @"'e");
        output = Rule7().Replace(output, @"'e");
        output = Rule8().Replace(output, @"a");
        output = Rule9().Replace(output, @"a");
        output = Rule10().Replace(output, @"a");
        output = Rule11().Replace(output, @"a");
        output = Rule12().Replace(output, @"e");
        output = Rule13().Replace(output, @"b");
        output = Rule14().Replace(output, @"t");
        output = Rule15().Replace(output, @"j");
        output = Rule16().Replace(output, @"h");
        output = Rule17().Replace(output, @"d");
        output = Rule18().Replace(output, @"d");
        output = Rule19().Replace(output, @"d");
        output = Rule20().Replace(output, @"r");
        output = Rule21().Replace(output, @"z");
        output = Rule22().Replace(output, @"z");
        output = Rule23().Replace(output, @"s");
        output = Rule24().Replace(output, @"s");
        output = Rule25().Replace(output, @"t");
        output = Rule26().Replace(output, @"f");
        output = Rule27().Replace(output, @"q");
        output = Rule28().Replace(output, @"k");
        output = Rule29().Replace(output, @"l");
        output = Rule30().Replace(output, @"m");
        output = Rule31().Replace(output, @"n");
        output = Rule32().Replace(output, @"h");
        output = Rule33().Replace(output, @"h");
        output = Rule34().Replace(output, @"w");
        output = Rule35().Replace(output, @"y");
        output = Rule36().Replace(output, @"'");
        output = Rule37().Replace(output, @"?");
        output = Rule38().Replace(output, @",");
        output = Rule39().Replace(output, @"");
        output = Rule40().Replace(output, @"");
        output = Rule41().Replace(output, @"");
        output = Rule42().Replace(output, @"");
        output = Rule43().Replace(output, @"");
        output = Rule44().Replace(output, @"");
        output = Rule45().Replace(output, @"");
        output = Rule46().Replace(output, @"");
        output = Rule47().Replace(output, @"");
        output = Rule48().Replace(output, @"");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new NotReversableException();
    }
              
    [GeneratedRegex(@"ث")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"خ")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"ش")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"غ")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"ع")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"ئ")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"ؤ")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"ا")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"أ")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"آ")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"ى")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"إ")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"ب")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"ت")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"ج")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"ح")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"د")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"ذ")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"ض")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"ر")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"ز")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"ظ")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"س")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"ص")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"ط")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"ف")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"ق")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"ك")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"ل")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"م")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"ن")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"ه")]
    private static partial Regex Rule32();
              
    [GeneratedRegex(@"ة")]
    private static partial Regex Rule33();
              
    [GeneratedRegex(@"و")]
    private static partial Regex Rule34();
              
    [GeneratedRegex(@"ي")]
    private static partial Regex Rule35();
              
    [GeneratedRegex(@"ء")]
    private static partial Regex Rule36();
              
    [GeneratedRegex(@"؟")]
    private static partial Regex Rule37();
              
    [GeneratedRegex(@"،")]
    private static partial Regex Rule38();
              
    [GeneratedRegex(@"ـ")]
    private static partial Regex Rule39();
              
    [GeneratedRegex(@"ً")]
    private static partial Regex Rule40();
              
    [GeneratedRegex(@"ٌ")]
    private static partial Regex Rule41();
              
    [GeneratedRegex(@"ٍ")]
    private static partial Regex Rule42();
              
    [GeneratedRegex(@"َ")]
    private static partial Regex Rule43();
              
    [GeneratedRegex(@"ُ")]
    private static partial Regex Rule44();
              
    [GeneratedRegex(@"ِ")]
    private static partial Regex Rule45();
              
    [GeneratedRegex(@"ّ")]
    private static partial Regex Rule46();
              
    [GeneratedRegex(@"ْ")]
    private static partial Regex Rule47();
              
    [GeneratedRegex(@"‏")]
    private static partial Regex Rule48();

}
