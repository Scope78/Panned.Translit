using System;
using System.Text.RegularExpressions;
using System.IO;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_ala_lc_rus : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.ala_lc_rus;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"A");
        output = Rule2().Replace(output, @"B");
        output = Rule3().Replace(output, @"V");
        output = Rule4().Replace(output, @"G");
        output = Rule5().Replace(output, @"D");
        output = Rule6().Replace(output, @"E");
        output = Rule7().Replace(output, @"Ë");
        output = Rule8().Replace(output, @"Zh");
        output = Rule9().Replace(output, @"Z");
        output = Rule10().Replace(output, @"I");
        output = Rule11().Replace(output, @"Ī");
        output = Rule12().Replace(output, @"Ĭ");
        output = Rule13().Replace(output, @"K");
        output = Rule14().Replace(output, @"L");
        output = Rule15().Replace(output, @"M");
        output = Rule16().Replace(output, @"N");
        output = Rule17().Replace(output, @"O");
        output = Rule18().Replace(output, @"P");
        output = Rule19().Replace(output, @"R");
        output = Rule20().Replace(output, @"S");
        output = Rule21().Replace(output, @"T");
        output = Rule22().Replace(output, @"U");
        output = Rule23().Replace(output, @"F");
        output = Rule24().Replace(output, @"Kh");
        output = Rule25().Replace(output, @"TS");
        output = Rule26().Replace(output, @"Ch");
        output = Rule27().Replace(output, @"Ch");
        output = Rule28().Replace(output, @"Sh");
        output = Rule29().Replace(output, @"Shch");
        output = Rule30().Replace(output, @"");
        output = Rule31().Replace(output, @"″");
        output = Rule32().Replace(output, @"Y");
        output = Rule33().Replace(output, @"′");
        output = Rule34().Replace(output, @"IE");
        output = Rule35().Replace(output, @"Ė");
        output = Rule36().Replace(output, @"IU");
        output = Rule37().Replace(output, @"IA");
        output = Rule38().Replace(output, @"Ę");
        output = Rule39().Replace(output, @"Ḟ");
        output = Rule40().Replace(output, @"Ẏ");
        output = Rule41().Replace(output, @"a");
        output = Rule42().Replace(output, @"b");
        output = Rule43().Replace(output, @"v");
        output = Rule44().Replace(output, @"g");
        output = Rule45().Replace(output, @"d");
        output = Rule46().Replace(output, @"e");
        output = Rule47().Replace(output, @"ë");
        output = Rule48().Replace(output, @"zh");
        output = Rule49().Replace(output, @"z");
        output = Rule50().Replace(output, @"i");
        output = Rule51().Replace(output, @"ī");
        output = Rule52().Replace(output, @"ĭ");
        output = Rule53().Replace(output, @"k");
        output = Rule54().Replace(output, @"l");
        output = Rule55().Replace(output, @"m");
        output = Rule56().Replace(output, @"n");
        output = Rule57().Replace(output, @"o");
        output = Rule58().Replace(output, @"p");
        output = Rule59().Replace(output, @"r");
        output = Rule60().Replace(output, @"s");
        output = Rule61().Replace(output, @"t");
        output = Rule62().Replace(output, @"u");
        output = Rule63().Replace(output, @"f");
        output = Rule64().Replace(output, @"kh");
        output = Rule65().Replace(output, @"ts");
        output = Rule66().Replace(output, @"ch");
        output = Rule67().Replace(output, @"sh");
        output = Rule68().Replace(output, @"shch");
        output = Rule69().Replace(output, @"");
        output = Rule70().Replace(output, @"″");
        output = Rule71().Replace(output, @"y");
        output = Rule72().Replace(output, @"′");
        output = Rule73().Replace(output, @"ie");
        output = Rule74().Replace(output, @"ė");
        output = Rule75().Replace(output, @"iu");
        output = Rule76().Replace(output, @"ia");
        output = Rule77().Replace(output, @"ę");
        output = Rule78().Replace(output, @"ḟ");
        output = Rule79().Replace(output, @"ẏ");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new InvalidOperationException("Not reversable");
    }
              
    [GeneratedRegex(@"А")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"Б")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"В")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"Г")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"Д")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"Е")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"Ё")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"Ж")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"З")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"И")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"І")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"Й")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"К")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"Л")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"М")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"Н")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"О")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"П")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"Р")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"С")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"Т")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"У")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"Ф")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"Х")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"Ц")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"Ш")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"Щ")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"Ъ(?=\b)")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"Ъ")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"Ы")]
    private static partial Regex Rule32();
              
    [GeneratedRegex(@"Ь")]
    private static partial Regex Rule33();
              
    [GeneratedRegex(@"Ѣ")]
    private static partial Regex Rule34();
              
    [GeneratedRegex(@"Э")]
    private static partial Regex Rule35();
              
    [GeneratedRegex(@"Ю")]
    private static partial Regex Rule36();
              
    [GeneratedRegex(@"Я")]
    private static partial Regex Rule37();
              
    [GeneratedRegex(@"Ѧ")]
    private static partial Regex Rule38();
              
    [GeneratedRegex(@"Ө")]
    private static partial Regex Rule39();
              
    [GeneratedRegex(@"Ѵ")]
    private static partial Regex Rule40();
              
    [GeneratedRegex(@"а")]
    private static partial Regex Rule41();
              
    [GeneratedRegex(@"б")]
    private static partial Regex Rule42();
              
    [GeneratedRegex(@"в")]
    private static partial Regex Rule43();
              
    [GeneratedRegex(@"г")]
    private static partial Regex Rule44();
              
    [GeneratedRegex(@"д")]
    private static partial Regex Rule45();
              
    [GeneratedRegex(@"е")]
    private static partial Regex Rule46();
              
    [GeneratedRegex(@"ё")]
    private static partial Regex Rule47();
              
    [GeneratedRegex(@"ж")]
    private static partial Regex Rule48();
              
    [GeneratedRegex(@"з")]
    private static partial Regex Rule49();
              
    [GeneratedRegex(@"и")]
    private static partial Regex Rule50();
              
    [GeneratedRegex(@"і")]
    private static partial Regex Rule51();
              
    [GeneratedRegex(@"й")]
    private static partial Regex Rule52();
              
    [GeneratedRegex(@"к")]
    private static partial Regex Rule53();
              
    [GeneratedRegex(@"л")]
    private static partial Regex Rule54();
              
    [GeneratedRegex(@"м")]
    private static partial Regex Rule55();
              
    [GeneratedRegex(@"н")]
    private static partial Regex Rule56();
              
    [GeneratedRegex(@"о")]
    private static partial Regex Rule57();
              
    [GeneratedRegex(@"п")]
    private static partial Regex Rule58();
              
    [GeneratedRegex(@"р")]
    private static partial Regex Rule59();
              
    [GeneratedRegex(@"с")]
    private static partial Regex Rule60();
              
    [GeneratedRegex(@"т")]
    private static partial Regex Rule61();
              
    [GeneratedRegex(@"у")]
    private static partial Regex Rule62();
              
    [GeneratedRegex(@"ф")]
    private static partial Regex Rule63();
              
    [GeneratedRegex(@"х")]
    private static partial Regex Rule64();
              
    [GeneratedRegex(@"ц")]
    private static partial Regex Rule65();
              
    [GeneratedRegex(@"ч")]
    private static partial Regex Rule66();
              
    [GeneratedRegex(@"ш")]
    private static partial Regex Rule67();
              
    [GeneratedRegex(@"щ")]
    private static partial Regex Rule68();
              
    [GeneratedRegex(@"ъ(?=\b)")]
    private static partial Regex Rule69();
              
    [GeneratedRegex(@"ъ")]
    private static partial Regex Rule70();
              
    [GeneratedRegex(@"ы")]
    private static partial Regex Rule71();
              
    [GeneratedRegex(@"ь")]
    private static partial Regex Rule72();
              
    [GeneratedRegex(@"ѣ")]
    private static partial Regex Rule73();
              
    [GeneratedRegex(@"э")]
    private static partial Regex Rule74();
              
    [GeneratedRegex(@"ю")]
    private static partial Regex Rule75();
              
    [GeneratedRegex(@"я")]
    private static partial Regex Rule76();
              
    [GeneratedRegex(@"ѧ")]
    private static partial Regex Rule77();
              
    [GeneratedRegex(@"ө")]
    private static partial Regex Rule78();
              
    [GeneratedRegex(@"ѵ")]
    private static partial Regex Rule79();

}
