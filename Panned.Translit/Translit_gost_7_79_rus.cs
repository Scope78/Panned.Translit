using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_gost_7_79_rus : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.gost_7_79_rus;

    public override bool IsReversable => true;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"c");
        output = Rule2().Replace(output, @"C");
        output = Rule3().Replace(output, @"cz");
        output = Rule4().Replace(output, @"CZ");
        output = Rule5().Replace(output, @"Cz");
        output = Rule6().Replace(output, @"shh");
        output = Rule7().Replace(output, @"SHH");
        output = Rule8().Replace(output, @"Shh");
        output = Rule9().Replace(output, @"yo");
        output = Rule10().Replace(output, @"YO");
        output = Rule11().Replace(output, @"Yo");
        output = Rule12().Replace(output, @"zh");
        output = Rule13().Replace(output, @"ZH");
        output = Rule14().Replace(output, @"Zh");
        output = Rule15().Replace(output, @"ch");
        output = Rule16().Replace(output, @"CH");
        output = Rule17().Replace(output, @"Ch");
        output = Rule18().Replace(output, @"sh");
        output = Rule19().Replace(output, @"SH");
        output = Rule20().Replace(output, @"Sh");
        output = Rule21().Replace(output, @"yu");
        output = Rule22().Replace(output, @"YU");
        output = Rule23().Replace(output, @"Yu");
        output = Rule24().Replace(output, @"ya");
        output = Rule25().Replace(output, @"YA");
        output = Rule26().Replace(output, @"Ya");
        output = Rule27().Replace(output, @"``");
        output = Rule28().Replace(output, @"``");
        output = Rule29().Replace(output, @"y'");
        output = Rule30().Replace(output, @"Y'");
        output = Rule31().Replace(output, @"e`");
        output = Rule32().Replace(output, @"E`");
        output = Rule33().Replace(output, @"a");
        output = Rule34().Replace(output, @"A");
        output = Rule35().Replace(output, @"b");
        output = Rule36().Replace(output, @"B");
        output = Rule37().Replace(output, @"v");
        output = Rule38().Replace(output, @"V");
        output = Rule39().Replace(output, @"g");
        output = Rule40().Replace(output, @"G");
        output = Rule41().Replace(output, @"d");
        output = Rule42().Replace(output, @"D");
        output = Rule43().Replace(output, @"e");
        output = Rule44().Replace(output, @"E");
        output = Rule45().Replace(output, @"z");
        output = Rule46().Replace(output, @"Z");
        output = Rule47().Replace(output, @"i");
        output = Rule48().Replace(output, @"I");
        output = Rule49().Replace(output, @"j");
        output = Rule50().Replace(output, @"J");
        output = Rule51().Replace(output, @"k");
        output = Rule52().Replace(output, @"K");
        output = Rule53().Replace(output, @"l");
        output = Rule54().Replace(output, @"L");
        output = Rule55().Replace(output, @"m");
        output = Rule56().Replace(output, @"M");
        output = Rule57().Replace(output, @"n");
        output = Rule58().Replace(output, @"N");
        output = Rule59().Replace(output, @"o");
        output = Rule60().Replace(output, @"O");
        output = Rule61().Replace(output, @"p");
        output = Rule62().Replace(output, @"P");
        output = Rule63().Replace(output, @"r");
        output = Rule64().Replace(output, @"R");
        output = Rule65().Replace(output, @"s");
        output = Rule66().Replace(output, @"S");
        output = Rule67().Replace(output, @"t");
        output = Rule68().Replace(output, @"T");
        output = Rule69().Replace(output, @"u");
        output = Rule70().Replace(output, @"U");
        output = Rule71().Replace(output, @"f");
        output = Rule72().Replace(output, @"F");
        output = Rule73().Replace(output, @"x");
        output = Rule74().Replace(output, @"X");
        output = Rule75().Replace(output, @"`");
        output = Rule76().Replace(output, @"`");
        output = Rule77().Replace(output, @"#");

        return output;
    }

    public override string Reverse(string input)
    {
        string output = input;

        output = RuleReverse1().Replace(output, @"ц");
        output = RuleReverse2().Replace(output, @"Ц");
        output = RuleReverse3().Replace(output, @"ц");
        output = RuleReverse4().Replace(output, @"Ц");
        output = RuleReverse5().Replace(output, @"Ц");
        output = RuleReverse6().Replace(output, @"щ");
        output = RuleReverse7().Replace(output, @"Щ");
        output = RuleReverse8().Replace(output, @"Щ");
        output = RuleReverse9().Replace(output, @"ё");
        output = RuleReverse10().Replace(output, @"Ё");
        output = RuleReverse11().Replace(output, @"Ё");
        output = RuleReverse12().Replace(output, @"ж");
        output = RuleReverse13().Replace(output, @"Ж");
        output = RuleReverse14().Replace(output, @"Ж");
        output = RuleReverse15().Replace(output, @"ч");
        output = RuleReverse16().Replace(output, @"Ч");
        output = RuleReverse17().Replace(output, @"Ч");
        output = RuleReverse18().Replace(output, @"ш");
        output = RuleReverse19().Replace(output, @"Ш");
        output = RuleReverse20().Replace(output, @"Ш");
        output = RuleReverse21().Replace(output, @"ю");
        output = RuleReverse22().Replace(output, @"Ю");
        output = RuleReverse23().Replace(output, @"Ю");
        output = RuleReverse24().Replace(output, @"я");
        output = RuleReverse25().Replace(output, @"Я");
        output = RuleReverse26().Replace(output, @"Я");
        output = RuleReverse27().Replace(output, @"ъ");
        output = RuleReverse28().Replace(output, @"Ъ");
        output = RuleReverse29().Replace(output, @"ы");
        output = RuleReverse30().Replace(output, @"Ы");
        output = RuleReverse31().Replace(output, @"э");
        output = RuleReverse32().Replace(output, @"Э");
        output = RuleReverse33().Replace(output, @"а");
        output = RuleReverse34().Replace(output, @"А");
        output = RuleReverse35().Replace(output, @"б");
        output = RuleReverse36().Replace(output, @"Б");
        output = RuleReverse37().Replace(output, @"в");
        output = RuleReverse38().Replace(output, @"В");
        output = RuleReverse39().Replace(output, @"г");
        output = RuleReverse40().Replace(output, @"Г");
        output = RuleReverse41().Replace(output, @"д");
        output = RuleReverse42().Replace(output, @"Д");
        output = RuleReverse43().Replace(output, @"е");
        output = RuleReverse44().Replace(output, @"Е");
        output = RuleReverse45().Replace(output, @"з");
        output = RuleReverse46().Replace(output, @"З");
        output = RuleReverse47().Replace(output, @"и");
        output = RuleReverse48().Replace(output, @"И");
        output = RuleReverse49().Replace(output, @"й");
        output = RuleReverse50().Replace(output, @"Й");
        output = RuleReverse51().Replace(output, @"к");
        output = RuleReverse52().Replace(output, @"К");
        output = RuleReverse53().Replace(output, @"л");
        output = RuleReverse54().Replace(output, @"Л");
        output = RuleReverse55().Replace(output, @"м");
        output = RuleReverse56().Replace(output, @"М");
        output = RuleReverse57().Replace(output, @"н");
        output = RuleReverse58().Replace(output, @"Н");
        output = RuleReverse59().Replace(output, @"о");
        output = RuleReverse60().Replace(output, @"О");
        output = RuleReverse61().Replace(output, @"п");
        output = RuleReverse62().Replace(output, @"П");
        output = RuleReverse63().Replace(output, @"р");
        output = RuleReverse64().Replace(output, @"Р");
        output = RuleReverse65().Replace(output, @"с");
        output = RuleReverse66().Replace(output, @"С");
        output = RuleReverse67().Replace(output, @"т");
        output = RuleReverse68().Replace(output, @"Т");
        output = RuleReverse69().Replace(output, @"у");
        output = RuleReverse70().Replace(output, @"У");
        output = RuleReverse71().Replace(output, @"ф");
        output = RuleReverse72().Replace(output, @"Ф");
        output = RuleReverse73().Replace(output, @"х");
        output = RuleReverse74().Replace(output, @"Х");
        output = RuleReverse75().Replace(output, @"Ь");
        output = RuleReverse76().Replace(output, @"ь");
        output = RuleReverse77().Replace(output, @"№");

        return output;
    }
              
    [GeneratedRegex(@"ц(?=[iejyиейыюяэё])")]
    private static partial Regex Rule1();
                   
    [GeneratedRegex(@"c(?=[iejyиейыюяэё])")]
    private static partial Regex RuleReverse1();
              
    [GeneratedRegex(@"Ц(?=[IEJYИЕЙЫЮЯЁЭ])")]
    private static partial Regex Rule2();
                   
    [GeneratedRegex(@"C(?=[IEJYИЕЙЫЮЯЁЭ])")]
    private static partial Regex RuleReverse2();
              
    [GeneratedRegex(@"ц")]
    private static partial Regex Rule3();
                   
    [GeneratedRegex(@"cz")]
    private static partial Regex RuleReverse3();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ц(?=[\p{Lu}\s])")]
    private static partial Regex Rule4();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])CZ(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse4();
              
    [GeneratedRegex(@"Ц")]
    private static partial Regex Rule5();
                   
    [GeneratedRegex(@"Cz")]
    private static partial Regex RuleReverse5();
              
    [GeneratedRegex(@"щ")]
    private static partial Regex Rule6();
                   
    [GeneratedRegex(@"shh")]
    private static partial Regex RuleReverse6();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Щ(?=[\p{Lu}\s])")]
    private static partial Regex Rule7();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])SHH(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse7();
              
    [GeneratedRegex(@"Щ")]
    private static partial Regex Rule8();
                   
    [GeneratedRegex(@"Shh")]
    private static partial Regex RuleReverse8();
              
    [GeneratedRegex(@"ё")]
    private static partial Regex Rule9();
                   
    [GeneratedRegex(@"yo")]
    private static partial Regex RuleReverse9();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ё(?=[\p{Lu}\s])")]
    private static partial Regex Rule10();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])YO(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse10();
              
    [GeneratedRegex(@"Ё")]
    private static partial Regex Rule11();
                   
    [GeneratedRegex(@"Yo")]
    private static partial Regex RuleReverse11();
              
    [GeneratedRegex(@"ж")]
    private static partial Regex Rule12();
                   
    [GeneratedRegex(@"zh")]
    private static partial Regex RuleReverse12();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ж(?=[\p{Lu}\s])")]
    private static partial Regex Rule13();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])ZH(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse13();
              
    [GeneratedRegex(@"Ж")]
    private static partial Regex Rule14();
                   
    [GeneratedRegex(@"Zh")]
    private static partial Regex RuleReverse14();
              
    [GeneratedRegex(@"ч")]
    private static partial Regex Rule15();
                   
    [GeneratedRegex(@"ch")]
    private static partial Regex RuleReverse15();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ч(?=[\p{Lu}\s])")]
    private static partial Regex Rule16();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])CH(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse16();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule17();
                   
    [GeneratedRegex(@"Ch")]
    private static partial Regex RuleReverse17();
              
    [GeneratedRegex(@"ш")]
    private static partial Regex Rule18();
                   
    [GeneratedRegex(@"sh")]
    private static partial Regex RuleReverse18();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ш(?=[\p{Lu}\s])")]
    private static partial Regex Rule19();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])SH(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse19();
              
    [GeneratedRegex(@"Ш")]
    private static partial Regex Rule20();
                   
    [GeneratedRegex(@"Sh")]
    private static partial Regex RuleReverse20();
              
    [GeneratedRegex(@"ю")]
    private static partial Regex Rule21();
                   
    [GeneratedRegex(@"yu")]
    private static partial Regex RuleReverse21();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ю(?=[\p{Lu}\s])")]
    private static partial Regex Rule22();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])YU(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse22();
              
    [GeneratedRegex(@"Ю")]
    private static partial Regex Rule23();
                   
    [GeneratedRegex(@"Yu")]
    private static partial Regex RuleReverse23();
              
    [GeneratedRegex(@"я")]
    private static partial Regex Rule24();
                   
    [GeneratedRegex(@"ya")]
    private static partial Regex RuleReverse24();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Я(?=[\p{Lu}\s])")]
    private static partial Regex Rule25();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])YA(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse25();
              
    [GeneratedRegex(@"Я")]
    private static partial Regex Rule26();
                   
    [GeneratedRegex(@"Ya")]
    private static partial Regex RuleReverse26();
              
    [GeneratedRegex(@"ъ")]
    private static partial Regex Rule27();
                   
    [GeneratedRegex(@"``")]
    private static partial Regex RuleReverse27();
              
    [GeneratedRegex(@"(?<=\p{Lu})Ъ(?=([^\w]|$))")]
    private static partial Regex Rule28();
                   
    [GeneratedRegex(@"(?<=\p{Lu})``(?=([^\w]|$))")]
    private static partial Regex RuleReverse28();
              
    [GeneratedRegex(@"ы")]
    private static partial Regex Rule29();
                   
    [GeneratedRegex(@"y'")]
    private static partial Regex RuleReverse29();
              
    [GeneratedRegex(@"Ы")]
    private static partial Regex Rule30();
                   
    [GeneratedRegex(@"Y'")]
    private static partial Regex RuleReverse30();
              
    [GeneratedRegex(@"э")]
    private static partial Regex Rule31();
                   
    [GeneratedRegex(@"e`")]
    private static partial Regex RuleReverse31();
              
    [GeneratedRegex(@"Э")]
    private static partial Regex Rule32();
                   
    [GeneratedRegex(@"E`")]
    private static partial Regex RuleReverse32();
              
    [GeneratedRegex(@"а")]
    private static partial Regex Rule33();
                   
    [GeneratedRegex(@"a")]
    private static partial Regex RuleReverse33();
              
    [GeneratedRegex(@"А")]
    private static partial Regex Rule34();
                   
    [GeneratedRegex(@"A")]
    private static partial Regex RuleReverse34();
              
    [GeneratedRegex(@"б")]
    private static partial Regex Rule35();
                   
    [GeneratedRegex(@"b")]
    private static partial Regex RuleReverse35();
              
    [GeneratedRegex(@"Б")]
    private static partial Regex Rule36();
                   
    [GeneratedRegex(@"B")]
    private static partial Regex RuleReverse36();
              
    [GeneratedRegex(@"в")]
    private static partial Regex Rule37();
                   
    [GeneratedRegex(@"v")]
    private static partial Regex RuleReverse37();
              
    [GeneratedRegex(@"В")]
    private static partial Regex Rule38();
                   
    [GeneratedRegex(@"V")]
    private static partial Regex RuleReverse38();
              
    [GeneratedRegex(@"г")]
    private static partial Regex Rule39();
                   
    [GeneratedRegex(@"g")]
    private static partial Regex RuleReverse39();
              
    [GeneratedRegex(@"Г")]
    private static partial Regex Rule40();
                   
    [GeneratedRegex(@"G")]
    private static partial Regex RuleReverse40();
              
    [GeneratedRegex(@"д")]
    private static partial Regex Rule41();
                   
    [GeneratedRegex(@"d")]
    private static partial Regex RuleReverse41();
              
    [GeneratedRegex(@"Д")]
    private static partial Regex Rule42();
                   
    [GeneratedRegex(@"D")]
    private static partial Regex RuleReverse42();
              
    [GeneratedRegex(@"е")]
    private static partial Regex Rule43();
                   
    [GeneratedRegex(@"e")]
    private static partial Regex RuleReverse43();
              
    [GeneratedRegex(@"Е")]
    private static partial Regex Rule44();
                   
    [GeneratedRegex(@"E")]
    private static partial Regex RuleReverse44();
              
    [GeneratedRegex(@"з")]
    private static partial Regex Rule45();
                   
    [GeneratedRegex(@"z")]
    private static partial Regex RuleReverse45();
              
    [GeneratedRegex(@"З")]
    private static partial Regex Rule46();
                   
    [GeneratedRegex(@"Z")]
    private static partial Regex RuleReverse46();
              
    [GeneratedRegex(@"и")]
    private static partial Regex Rule47();
                   
    [GeneratedRegex(@"i")]
    private static partial Regex RuleReverse47();
              
    [GeneratedRegex(@"И")]
    private static partial Regex Rule48();
                   
    [GeneratedRegex(@"I")]
    private static partial Regex RuleReverse48();
              
    [GeneratedRegex(@"й")]
    private static partial Regex Rule49();
                   
    [GeneratedRegex(@"j")]
    private static partial Regex RuleReverse49();
              
    [GeneratedRegex(@"Й")]
    private static partial Regex Rule50();
                   
    [GeneratedRegex(@"J")]
    private static partial Regex RuleReverse50();
              
    [GeneratedRegex(@"к")]
    private static partial Regex Rule51();
                   
    [GeneratedRegex(@"k")]
    private static partial Regex RuleReverse51();
              
    [GeneratedRegex(@"К")]
    private static partial Regex Rule52();
                   
    [GeneratedRegex(@"K")]
    private static partial Regex RuleReverse52();
              
    [GeneratedRegex(@"л")]
    private static partial Regex Rule53();
                   
    [GeneratedRegex(@"l")]
    private static partial Regex RuleReverse53();
              
    [GeneratedRegex(@"Л")]
    private static partial Regex Rule54();
                   
    [GeneratedRegex(@"L")]
    private static partial Regex RuleReverse54();
              
    [GeneratedRegex(@"м")]
    private static partial Regex Rule55();
                   
    [GeneratedRegex(@"m")]
    private static partial Regex RuleReverse55();
              
    [GeneratedRegex(@"М")]
    private static partial Regex Rule56();
                   
    [GeneratedRegex(@"M")]
    private static partial Regex RuleReverse56();
              
    [GeneratedRegex(@"н")]
    private static partial Regex Rule57();
                   
    [GeneratedRegex(@"n")]
    private static partial Regex RuleReverse57();
              
    [GeneratedRegex(@"Н")]
    private static partial Regex Rule58();
                   
    [GeneratedRegex(@"N")]
    private static partial Regex RuleReverse58();
              
    [GeneratedRegex(@"о")]
    private static partial Regex Rule59();
                   
    [GeneratedRegex(@"o")]
    private static partial Regex RuleReverse59();
              
    [GeneratedRegex(@"О")]
    private static partial Regex Rule60();
                   
    [GeneratedRegex(@"O")]
    private static partial Regex RuleReverse60();
              
    [GeneratedRegex(@"п")]
    private static partial Regex Rule61();
                   
    [GeneratedRegex(@"p")]
    private static partial Regex RuleReverse61();
              
    [GeneratedRegex(@"П")]
    private static partial Regex Rule62();
                   
    [GeneratedRegex(@"P")]
    private static partial Regex RuleReverse62();
              
    [GeneratedRegex(@"р")]
    private static partial Regex Rule63();
                   
    [GeneratedRegex(@"r")]
    private static partial Regex RuleReverse63();
              
    [GeneratedRegex(@"Р")]
    private static partial Regex Rule64();
                   
    [GeneratedRegex(@"R")]
    private static partial Regex RuleReverse64();
              
    [GeneratedRegex(@"с")]
    private static partial Regex Rule65();
                   
    [GeneratedRegex(@"s")]
    private static partial Regex RuleReverse65();
              
    [GeneratedRegex(@"С")]
    private static partial Regex Rule66();
                   
    [GeneratedRegex(@"S")]
    private static partial Regex RuleReverse66();
              
    [GeneratedRegex(@"т")]
    private static partial Regex Rule67();
                   
    [GeneratedRegex(@"t")]
    private static partial Regex RuleReverse67();
              
    [GeneratedRegex(@"Т")]
    private static partial Regex Rule68();
                   
    [GeneratedRegex(@"T")]
    private static partial Regex RuleReverse68();
              
    [GeneratedRegex(@"у")]
    private static partial Regex Rule69();
                   
    [GeneratedRegex(@"u")]
    private static partial Regex RuleReverse69();
              
    [GeneratedRegex(@"У")]
    private static partial Regex Rule70();
                   
    [GeneratedRegex(@"U")]
    private static partial Regex RuleReverse70();
              
    [GeneratedRegex(@"ф")]
    private static partial Regex Rule71();
                   
    [GeneratedRegex(@"f")]
    private static partial Regex RuleReverse71();
              
    [GeneratedRegex(@"Ф")]
    private static partial Regex Rule72();
                   
    [GeneratedRegex(@"F")]
    private static partial Regex RuleReverse72();
              
    [GeneratedRegex(@"х")]
    private static partial Regex Rule73();
                   
    [GeneratedRegex(@"x")]
    private static partial Regex RuleReverse73();
              
    [GeneratedRegex(@"Х")]
    private static partial Regex Rule74();
                   
    [GeneratedRegex(@"X")]
    private static partial Regex RuleReverse74();
              
    [GeneratedRegex(@"(?<=\p{Lu})Ь")]
    private static partial Regex Rule75();
                   
    [GeneratedRegex(@"(?<=\p{Lu})`")]
    private static partial Regex RuleReverse75();
              
    [GeneratedRegex(@"ь")]
    private static partial Regex Rule76();
                   
    [GeneratedRegex(@"`")]
    private static partial Regex RuleReverse76();
              
    [GeneratedRegex(@"№")]
    private static partial Regex Rule77();
                   
    [GeneratedRegex(@"#")]
    private static partial Regex RuleReverse77();

}
