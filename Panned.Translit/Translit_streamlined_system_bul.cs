using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_streamlined_system_bul : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.streamlined_system_bul;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"SHT");
        output = Rule2().Replace(output, @"Sht");
        output = Rule3().Replace(output, @"sht");
        output = Rule4().Replace(output, @"ZH");
        output = Rule5().Replace(output, @"Zh");
        output = Rule6().Replace(output, @"zh");
        output = Rule7().Replace(output, @"TS");
        output = Rule8().Replace(output, @"Ts");
        output = Rule9().Replace(output, @"ts");
        output = Rule10().Replace(output, @"CH");
        output = Rule11().Replace(output, @"Ch");
        output = Rule12().Replace(output, @"ch");
        output = Rule13().Replace(output, @"SH");
        output = Rule14().Replace(output, @"Sh");
        output = Rule15().Replace(output, @"sh");
        output = Rule16().Replace(output, @"YU");
        output = Rule17().Replace(output, @"Yu");
        output = Rule18().Replace(output, @"yu");
        output = Rule19().Replace(output, @"YA");
        output = Rule20().Replace(output, @"Ya");
        output = Rule21().Replace(output, @"ya");
        output = Rule22().Replace(output, @"A");
        output = Rule23().Replace(output, @"a");
        output = Rule24().Replace(output, @"B");
        output = Rule25().Replace(output, @"b");
        output = Rule26().Replace(output, @"V");
        output = Rule27().Replace(output, @"v");
        output = Rule28().Replace(output, @"G");
        output = Rule29().Replace(output, @"g");
        output = Rule30().Replace(output, @"D");
        output = Rule31().Replace(output, @"d");
        output = Rule32().Replace(output, @"E");
        output = Rule33().Replace(output, @"e");
        output = Rule34().Replace(output, @"Z");
        output = Rule35().Replace(output, @"z");
        output = Rule36().Replace(output, @"I");
        output = Rule37().Replace(output, @"i");
        output = Rule38().Replace(output, @"Y");
        output = Rule39().Replace(output, @"y");
        output = Rule40().Replace(output, @"K");
        output = Rule41().Replace(output, @"k");
        output = Rule42().Replace(output, @"L");
        output = Rule43().Replace(output, @"l");
        output = Rule44().Replace(output, @"M");
        output = Rule45().Replace(output, @"m");
        output = Rule46().Replace(output, @"N");
        output = Rule47().Replace(output, @"n");
        output = Rule48().Replace(output, @"O");
        output = Rule49().Replace(output, @"o");
        output = Rule50().Replace(output, @"P");
        output = Rule51().Replace(output, @"p");
        output = Rule52().Replace(output, @"R");
        output = Rule53().Replace(output, @"r");
        output = Rule54().Replace(output, @"S");
        output = Rule55().Replace(output, @"s");
        output = Rule56().Replace(output, @"T");
        output = Rule57().Replace(output, @"t");
        output = Rule58().Replace(output, @"U");
        output = Rule59().Replace(output, @"u");
        output = Rule60().Replace(output, @"F");
        output = Rule61().Replace(output, @"f");
        output = Rule62().Replace(output, @"H");
        output = Rule63().Replace(output, @"h");
        output = Rule64().Replace(output, @"A");
        output = Rule65().Replace(output, @"a");
        output = Rule66().Replace(output, @"Y");
        output = Rule67().Replace(output, @"y");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new NotReversableException();
    }
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Щ(?=[\p{Lu}\s])")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"Щ")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"щ")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ж(?=[\p{Lu}\s])")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"Ж")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"ж")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ц(?=[\p{Lu}\s])")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"Ц")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"ц")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ч(?=[\p{Lu}\s])")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"ч")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ш(?=[\p{Lu}\s])")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"Ш")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"ш")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ю(?=[\p{Lu}\s])")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"Ю")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"ю")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Я(?=[\p{Lu}\s])")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"Я")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"я")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"А")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"а")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"Б")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"б")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"В")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"в")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"Г")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"г")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"Д")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"д")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"Е")]
    private static partial Regex Rule32();
              
    [GeneratedRegex(@"е")]
    private static partial Regex Rule33();
              
    [GeneratedRegex(@"З")]
    private static partial Regex Rule34();
              
    [GeneratedRegex(@"з")]
    private static partial Regex Rule35();
              
    [GeneratedRegex(@"И")]
    private static partial Regex Rule36();
              
    [GeneratedRegex(@"и")]
    private static partial Regex Rule37();
              
    [GeneratedRegex(@"Й")]
    private static partial Regex Rule38();
              
    [GeneratedRegex(@"й")]
    private static partial Regex Rule39();
              
    [GeneratedRegex(@"К")]
    private static partial Regex Rule40();
              
    [GeneratedRegex(@"к")]
    private static partial Regex Rule41();
              
    [GeneratedRegex(@"Л")]
    private static partial Regex Rule42();
              
    [GeneratedRegex(@"л")]
    private static partial Regex Rule43();
              
    [GeneratedRegex(@"М")]
    private static partial Regex Rule44();
              
    [GeneratedRegex(@"м")]
    private static partial Regex Rule45();
              
    [GeneratedRegex(@"Н")]
    private static partial Regex Rule46();
              
    [GeneratedRegex(@"н")]
    private static partial Regex Rule47();
              
    [GeneratedRegex(@"О")]
    private static partial Regex Rule48();
              
    [GeneratedRegex(@"о")]
    private static partial Regex Rule49();
              
    [GeneratedRegex(@"П")]
    private static partial Regex Rule50();
              
    [GeneratedRegex(@"п")]
    private static partial Regex Rule51();
              
    [GeneratedRegex(@"Р")]
    private static partial Regex Rule52();
              
    [GeneratedRegex(@"р")]
    private static partial Regex Rule53();
              
    [GeneratedRegex(@"С")]
    private static partial Regex Rule54();
              
    [GeneratedRegex(@"с")]
    private static partial Regex Rule55();
              
    [GeneratedRegex(@"Т")]
    private static partial Regex Rule56();
              
    [GeneratedRegex(@"т")]
    private static partial Regex Rule57();
              
    [GeneratedRegex(@"У")]
    private static partial Regex Rule58();
              
    [GeneratedRegex(@"у")]
    private static partial Regex Rule59();
              
    [GeneratedRegex(@"Ф")]
    private static partial Regex Rule60();
              
    [GeneratedRegex(@"ф")]
    private static partial Regex Rule61();
              
    [GeneratedRegex(@"Х")]
    private static partial Regex Rule62();
              
    [GeneratedRegex(@"х")]
    private static partial Regex Rule63();
              
    [GeneratedRegex(@"Ъ")]
    private static partial Regex Rule64();
              
    [GeneratedRegex(@"ъ")]
    private static partial Regex Rule65();
              
    [GeneratedRegex(@"Ь")]
    private static partial Regex Rule66();
              
    [GeneratedRegex(@"ь")]
    private static partial Regex Rule67();

}
