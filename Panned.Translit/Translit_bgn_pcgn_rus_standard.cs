using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_bgn_pcgn_rus_standard : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.bgn_pcgn_rus_standard;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"");
        output = Rule2().Replace(output, @"Ye");
        output = Rule3().Replace(output, @"Ye");
        output = Rule4().Replace(output, @"E");
        output = Rule5().Replace(output, @"Yë");
        output = Rule6().Replace(output, @"Yë");
        output = Rule7().Replace(output, @"Ë");
        output = Rule8().Replace(output, @"Y");
        output = Rule9().Replace(output, @"Y");
        output = Rule10().Replace(output, @"E");
        output = Rule11().Replace(output, @"A");
        output = Rule12().Replace(output, @"B");
        output = Rule13().Replace(output, @"V");
        output = Rule14().Replace(output, @"G");
        output = Rule15().Replace(output, @"D");
        output = Rule16().Replace(output, @"Zh");
        output = Rule17().Replace(output, @"Z");
        output = Rule18().Replace(output, @"I");
        output = Rule19().Replace(output, @"K");
        output = Rule20().Replace(output, @"L");
        output = Rule21().Replace(output, @"M");
        output = Rule22().Replace(output, @"N");
        output = Rule23().Replace(output, @"O");
        output = Rule24().Replace(output, @"P");
        output = Rule25().Replace(output, @"R");
        output = Rule26().Replace(output, @"S");
        output = Rule27().Replace(output, @"T");
        output = Rule28().Replace(output, @"U");
        output = Rule29().Replace(output, @"F");
        output = Rule30().Replace(output, @"Kh");
        output = Rule31().Replace(output, @"Ts");
        output = Rule32().Replace(output, @"Ch");
        output = Rule33().Replace(output, @"Sh");
        output = Rule34().Replace(output, @"Shch");
        output = Rule35().Replace(output, @"''");
        output = Rule36().Replace(output, @"'");
        output = Rule37().Replace(output, @"Yu");
        output = Rule38().Replace(output, @"Ya");
        output = Rule39().Replace(output, @"ye");
        output = Rule40().Replace(output, @"ye");
        output = Rule41().Replace(output, @"e");
        output = Rule42().Replace(output, @"yë");
        output = Rule43().Replace(output, @"yë");
        output = Rule44().Replace(output, @"ë");
        output = Rule45().Replace(output, @"y");
        output = Rule46().Replace(output, @"y");
        output = Rule47().Replace(output, @"e");
        output = Rule48().Replace(output, @"a");
        output = Rule49().Replace(output, @"b");
        output = Rule50().Replace(output, @"v");
        output = Rule51().Replace(output, @"g");
        output = Rule52().Replace(output, @"d");
        output = Rule53().Replace(output, @"zh");
        output = Rule54().Replace(output, @"z");
        output = Rule55().Replace(output, @"i");
        output = Rule56().Replace(output, @"k");
        output = Rule57().Replace(output, @"l");
        output = Rule58().Replace(output, @"m");
        output = Rule59().Replace(output, @"n");
        output = Rule60().Replace(output, @"o");
        output = Rule61().Replace(output, @"p");
        output = Rule62().Replace(output, @"r");
        output = Rule63().Replace(output, @"s");
        output = Rule64().Replace(output, @"t");
        output = Rule65().Replace(output, @"u");
        output = Rule66().Replace(output, @"f");
        output = Rule67().Replace(output, @"kh");
        output = Rule68().Replace(output, @"ts");
        output = Rule69().Replace(output, @"ch");
        output = Rule70().Replace(output, @"sh");
        output = Rule71().Replace(output, @"shch");
        output = Rule72().Replace(output, @"''");
        output = Rule73().Replace(output, @"'");
        output = Rule74().Replace(output, @"yu");
        output = Rule75().Replace(output, @"ya");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new NotReversableException();
    }
              
    [GeneratedRegex(@"́")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"(?<=[АЕЁИОУЫЭЮЯЙЬЪаеёиоуыэюяйьъ])Е")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"(?<=\b)Е")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"Е")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"(?<=[АЕЁИОУЫЭЮЯЙЬЪаеёиоуыэюяйьъe])Ё")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"(?<=\b)Ё")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"Ё")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"Й")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"Ы")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"Э")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"А")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"Б")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"В")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"Г")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"Д")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"Ж")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"З")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"И")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"К")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"Л")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"М")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"Н")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"О")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"П")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"Р")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"С")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"Т")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"У")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"Ф")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"Х")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"Ц")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule32();
              
    [GeneratedRegex(@"Ш")]
    private static partial Regex Rule33();
              
    [GeneratedRegex(@"Щ")]
    private static partial Regex Rule34();
              
    [GeneratedRegex(@"Ъ")]
    private static partial Regex Rule35();
              
    [GeneratedRegex(@"Ь")]
    private static partial Regex Rule36();
              
    [GeneratedRegex(@"Ю")]
    private static partial Regex Rule37();
              
    [GeneratedRegex(@"Я")]
    private static partial Regex Rule38();
              
    [GeneratedRegex(@"(?<=[AEËIOUYeëau'аеёиоуыэюяйьъ])е")]
    private static partial Regex Rule39();
              
    [GeneratedRegex(@"(?<=\b)е")]
    private static partial Regex Rule40();
              
    [GeneratedRegex(@"е")]
    private static partial Regex Rule41();
              
    [GeneratedRegex(@"(?<=[AEËIOUYeëau'аеёиоуыэюяйьъ])ё")]
    private static partial Regex Rule42();
              
    [GeneratedRegex(@"(?<=\b)ё")]
    private static partial Regex Rule43();
              
    [GeneratedRegex(@"ё")]
    private static partial Regex Rule44();
              
    [GeneratedRegex(@"й")]
    private static partial Regex Rule45();
              
    [GeneratedRegex(@"ы")]
    private static partial Regex Rule46();
              
    [GeneratedRegex(@"э")]
    private static partial Regex Rule47();
              
    [GeneratedRegex(@"а")]
    private static partial Regex Rule48();
              
    [GeneratedRegex(@"б")]
    private static partial Regex Rule49();
              
    [GeneratedRegex(@"в")]
    private static partial Regex Rule50();
              
    [GeneratedRegex(@"г")]
    private static partial Regex Rule51();
              
    [GeneratedRegex(@"д")]
    private static partial Regex Rule52();
              
    [GeneratedRegex(@"ж")]
    private static partial Regex Rule53();
              
    [GeneratedRegex(@"з")]
    private static partial Regex Rule54();
              
    [GeneratedRegex(@"и")]
    private static partial Regex Rule55();
              
    [GeneratedRegex(@"к")]
    private static partial Regex Rule56();
              
    [GeneratedRegex(@"л")]
    private static partial Regex Rule57();
              
    [GeneratedRegex(@"м")]
    private static partial Regex Rule58();
              
    [GeneratedRegex(@"н")]
    private static partial Regex Rule59();
              
    [GeneratedRegex(@"о")]
    private static partial Regex Rule60();
              
    [GeneratedRegex(@"п")]
    private static partial Regex Rule61();
              
    [GeneratedRegex(@"р")]
    private static partial Regex Rule62();
              
    [GeneratedRegex(@"с")]
    private static partial Regex Rule63();
              
    [GeneratedRegex(@"т")]
    private static partial Regex Rule64();
              
    [GeneratedRegex(@"у")]
    private static partial Regex Rule65();
              
    [GeneratedRegex(@"ф")]
    private static partial Regex Rule66();
              
    [GeneratedRegex(@"х")]
    private static partial Regex Rule67();
              
    [GeneratedRegex(@"ц")]
    private static partial Regex Rule68();
              
    [GeneratedRegex(@"ч")]
    private static partial Regex Rule69();
              
    [GeneratedRegex(@"ш")]
    private static partial Regex Rule70();
              
    [GeneratedRegex(@"щ")]
    private static partial Regex Rule71();
              
    [GeneratedRegex(@"ъ")]
    private static partial Regex Rule72();
              
    [GeneratedRegex(@"ь")]
    private static partial Regex Rule73();
              
    [GeneratedRegex(@"ю")]
    private static partial Regex Rule74();
              
    [GeneratedRegex(@"я")]
    private static partial Regex Rule75();

}
