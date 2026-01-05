using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_gost_7_79_rus_old : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.gost_7_79_rus_old;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"i'");
        output = Rule2().Replace(output, @"I'");
        output = Rule3().Replace(output, @"i");
        output = Rule4().Replace(output, @"I");
        output = Rule5().Replace(output, @"c");
        output = Rule6().Replace(output, @"C");
        output = Rule7().Replace(output, @"cz");
        output = Rule8().Replace(output, @"CZ");
        output = Rule9().Replace(output, @"Cz");
        output = Rule10().Replace(output, @"a");
        output = Rule11().Replace(output, @"A");
        output = Rule12().Replace(output, @"b");
        output = Rule13().Replace(output, @"B");
        output = Rule14().Replace(output, @"v");
        output = Rule15().Replace(output, @"V");
        output = Rule16().Replace(output, @"g");
        output = Rule17().Replace(output, @"G");
        output = Rule18().Replace(output, @"d");
        output = Rule19().Replace(output, @"D");
        output = Rule20().Replace(output, @"e");
        output = Rule21().Replace(output, @"E");
        output = Rule22().Replace(output, @"yo");
        output = Rule23().Replace(output, @"YO");
        output = Rule24().Replace(output, @"Yo");
        output = Rule25().Replace(output, @"zh");
        output = Rule26().Replace(output, @"ZH");
        output = Rule27().Replace(output, @"Zh");
        output = Rule28().Replace(output, @"z");
        output = Rule29().Replace(output, @"Z");
        output = Rule30().Replace(output, @"i");
        output = Rule31().Replace(output, @"I");
        output = Rule32().Replace(output, @"j");
        output = Rule33().Replace(output, @"J");
        output = Rule34().Replace(output, @"k");
        output = Rule35().Replace(output, @"K");
        output = Rule36().Replace(output, @"l");
        output = Rule37().Replace(output, @"L");
        output = Rule38().Replace(output, @"m");
        output = Rule39().Replace(output, @"M");
        output = Rule40().Replace(output, @"n");
        output = Rule41().Replace(output, @"N");
        output = Rule42().Replace(output, @"o");
        output = Rule43().Replace(output, @"O");
        output = Rule44().Replace(output, @"p");
        output = Rule45().Replace(output, @"P");
        output = Rule46().Replace(output, @"r");
        output = Rule47().Replace(output, @"R");
        output = Rule48().Replace(output, @"s");
        output = Rule49().Replace(output, @"S");
        output = Rule50().Replace(output, @"t");
        output = Rule51().Replace(output, @"T");
        output = Rule52().Replace(output, @"u");
        output = Rule53().Replace(output, @"U");
        output = Rule54().Replace(output, @"f");
        output = Rule55().Replace(output, @"F");
        output = Rule56().Replace(output, @"x");
        output = Rule57().Replace(output, @"X");
        output = Rule58().Replace(output, @"ch");
        output = Rule59().Replace(output, @"CH");
        output = Rule60().Replace(output, @"Ch");
        output = Rule61().Replace(output, @"sh");
        output = Rule62().Replace(output, @"SH");
        output = Rule63().Replace(output, @"Sh");
        output = Rule64().Replace(output, @"shh");
        output = Rule65().Replace(output, @"SHH");
        output = Rule66().Replace(output, @"Shh");
        output = Rule67().Replace(output, @"``");
        output = Rule68().Replace(output, @"``");
        output = Rule69().Replace(output, @"y'");
        output = Rule70().Replace(output, @"Y'");
        output = Rule71().Replace(output, @"`");
        output = Rule72().Replace(output, @"`");
        output = Rule73().Replace(output, @"e`");
        output = Rule74().Replace(output, @"E`");
        output = Rule75().Replace(output, @"yu");
        output = Rule76().Replace(output, @"YU");
        output = Rule77().Replace(output, @"Yu");
        output = Rule78().Replace(output, @"ya");
        output = Rule79().Replace(output, @"YA");
        output = Rule80().Replace(output, @"Ya");
        output = Rule81().Replace(output, @"ye");
        output = Rule82().Replace(output, @"YE");
        output = Rule83().Replace(output, @"Ye");
        output = Rule84().Replace(output, @"fh");
        output = Rule85().Replace(output, @"FH");
        output = Rule86().Replace(output, @"Fh");
        output = Rule87().Replace(output, @"yh");
        output = Rule88().Replace(output, @"YH");
        output = Rule89().Replace(output, @"Yh");
        output = Rule90().Replace(output, @"#");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new NotReversableException();
    }
              
    [GeneratedRegex(@"і(?=[^аеёиоуыэюяэёѣѵі])")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"І(?=[^АЕЁИОУЫЭЮЯЁЭѢѴІ])")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"і")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"І")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"ц(?=[iejyиейыюя])")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"Ц(?=[IEJYИЕЙЫЮЯ])")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"ц")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ц(?=[\p{Lu}\s])")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"Ц")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"а")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"А")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"б")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"Б")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"в")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"В")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"г")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"Г")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"д")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"Д")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"е")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"Е")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"ё")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ё(?=[\p{Lu}\s])")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"Ё")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"ж")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ж(?=[\p{Lu}\s])")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"Ж")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"з")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"З")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"и")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"И")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"й")]
    private static partial Regex Rule32();
              
    [GeneratedRegex(@"Й")]
    private static partial Regex Rule33();
              
    [GeneratedRegex(@"к")]
    private static partial Regex Rule34();
              
    [GeneratedRegex(@"К")]
    private static partial Regex Rule35();
              
    [GeneratedRegex(@"л")]
    private static partial Regex Rule36();
              
    [GeneratedRegex(@"Л")]
    private static partial Regex Rule37();
              
    [GeneratedRegex(@"м")]
    private static partial Regex Rule38();
              
    [GeneratedRegex(@"М")]
    private static partial Regex Rule39();
              
    [GeneratedRegex(@"н")]
    private static partial Regex Rule40();
              
    [GeneratedRegex(@"Н")]
    private static partial Regex Rule41();
              
    [GeneratedRegex(@"о")]
    private static partial Regex Rule42();
              
    [GeneratedRegex(@"О")]
    private static partial Regex Rule43();
              
    [GeneratedRegex(@"п")]
    private static partial Regex Rule44();
              
    [GeneratedRegex(@"П")]
    private static partial Regex Rule45();
              
    [GeneratedRegex(@"р")]
    private static partial Regex Rule46();
              
    [GeneratedRegex(@"Р")]
    private static partial Regex Rule47();
              
    [GeneratedRegex(@"с")]
    private static partial Regex Rule48();
              
    [GeneratedRegex(@"С")]
    private static partial Regex Rule49();
              
    [GeneratedRegex(@"т")]
    private static partial Regex Rule50();
              
    [GeneratedRegex(@"Т")]
    private static partial Regex Rule51();
              
    [GeneratedRegex(@"у")]
    private static partial Regex Rule52();
              
    [GeneratedRegex(@"У")]
    private static partial Regex Rule53();
              
    [GeneratedRegex(@"ф")]
    private static partial Regex Rule54();
              
    [GeneratedRegex(@"Ф")]
    private static partial Regex Rule55();
              
    [GeneratedRegex(@"х")]
    private static partial Regex Rule56();
              
    [GeneratedRegex(@"Х")]
    private static partial Regex Rule57();
              
    [GeneratedRegex(@"ч")]
    private static partial Regex Rule58();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ч(?=[\p{Lu}\s])")]
    private static partial Regex Rule59();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule60();
              
    [GeneratedRegex(@"ш")]
    private static partial Regex Rule61();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ш(?=[\p{Lu}\s])")]
    private static partial Regex Rule62();
              
    [GeneratedRegex(@"Ш")]
    private static partial Regex Rule63();
              
    [GeneratedRegex(@"щ")]
    private static partial Regex Rule64();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Щ(?=[\p{Lu}\s])")]
    private static partial Regex Rule65();
              
    [GeneratedRegex(@"Щ")]
    private static partial Regex Rule66();
              
    [GeneratedRegex(@"ъ")]
    private static partial Regex Rule67();
              
    [GeneratedRegex(@"Ъ")]
    private static partial Regex Rule68();
              
    [GeneratedRegex(@"ы")]
    private static partial Regex Rule69();
              
    [GeneratedRegex(@"Ы")]
    private static partial Regex Rule70();
              
    [GeneratedRegex(@"Ь")]
    private static partial Regex Rule71();
              
    [GeneratedRegex(@"ь")]
    private static partial Regex Rule72();
              
    [GeneratedRegex(@"э")]
    private static partial Regex Rule73();
              
    [GeneratedRegex(@"Э")]
    private static partial Regex Rule74();
              
    [GeneratedRegex(@"ю")]
    private static partial Regex Rule75();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ю(?=[\p{Lu}\s])")]
    private static partial Regex Rule76();
              
    [GeneratedRegex(@"Ю")]
    private static partial Regex Rule77();
              
    [GeneratedRegex(@"я")]
    private static partial Regex Rule78();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Я(?=[\p{Lu}\s])")]
    private static partial Regex Rule79();
              
    [GeneratedRegex(@"Я")]
    private static partial Regex Rule80();
              
    [GeneratedRegex(@"ѣ")]
    private static partial Regex Rule81();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ѣ(?=[\p{Lu}\s])")]
    private static partial Regex Rule82();
              
    [GeneratedRegex(@"Ѣ")]
    private static partial Regex Rule83();
              
    [GeneratedRegex(@"ѳ")]
    private static partial Regex Rule84();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ѳ(?=[\p{Lu}\s])")]
    private static partial Regex Rule85();
              
    [GeneratedRegex(@"Ѳ")]
    private static partial Regex Rule86();
              
    [GeneratedRegex(@"ѵ")]
    private static partial Regex Rule87();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ѵ(?=[\p{Lu}\s])")]
    private static partial Regex Rule88();
              
    [GeneratedRegex(@"Ѵ")]
    private static partial Regex Rule89();
              
    [GeneratedRegex(@"№")]
    private static partial Regex Rule90();

}
