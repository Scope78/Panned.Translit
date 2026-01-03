using System;
using System.Text.RegularExpressions;
using System.IO;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_gost_7_79_ukr : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.gost_7_79_ukr;

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
        output = Rule9().Replace(output, @"g`");
        output = Rule10().Replace(output, @"G`");
        output = Rule11().Replace(output, @"ye");
        output = Rule12().Replace(output, @"YE");
        output = Rule13().Replace(output, @"Ye");
        output = Rule14().Replace(output, @"zh");
        output = Rule15().Replace(output, @"ZH");
        output = Rule16().Replace(output, @"Zh");
        output = Rule17().Replace(output, @"y`");
        output = Rule18().Replace(output, @"Y`");
        output = Rule19().Replace(output, @"yi");
        output = Rule20().Replace(output, @"YI");
        output = Rule21().Replace(output, @"Yi");
        output = Rule22().Replace(output, @"ch");
        output = Rule23().Replace(output, @"CH");
        output = Rule24().Replace(output, @"Ch");
        output = Rule25().Replace(output, @"sh");
        output = Rule26().Replace(output, @"SH");
        output = Rule27().Replace(output, @"Sh");
        output = Rule28().Replace(output, @"yu");
        output = Rule29().Replace(output, @"YU");
        output = Rule30().Replace(output, @"Yu");
        output = Rule31().Replace(output, @"ya");
        output = Rule32().Replace(output, @"YA");
        output = Rule33().Replace(output, @"Ya");
        output = Rule34().Replace(output, @"a");
        output = Rule35().Replace(output, @"A");
        output = Rule36().Replace(output, @"b");
        output = Rule37().Replace(output, @"B");
        output = Rule38().Replace(output, @"v");
        output = Rule39().Replace(output, @"V");
        output = Rule40().Replace(output, @"g");
        output = Rule41().Replace(output, @"G");
        output = Rule42().Replace(output, @"d");
        output = Rule43().Replace(output, @"D");
        output = Rule44().Replace(output, @"e");
        output = Rule45().Replace(output, @"E");
        output = Rule46().Replace(output, @"z");
        output = Rule47().Replace(output, @"Z");
        output = Rule48().Replace(output, @"j");
        output = Rule49().Replace(output, @"J");
        output = Rule50().Replace(output, @"i");
        output = Rule51().Replace(output, @"I");
        output = Rule52().Replace(output, @"k");
        output = Rule53().Replace(output, @"K");
        output = Rule54().Replace(output, @"l");
        output = Rule55().Replace(output, @"L");
        output = Rule56().Replace(output, @"m");
        output = Rule57().Replace(output, @"M");
        output = Rule58().Replace(output, @"n");
        output = Rule59().Replace(output, @"N");
        output = Rule60().Replace(output, @"o");
        output = Rule61().Replace(output, @"O");
        output = Rule62().Replace(output, @"p");
        output = Rule63().Replace(output, @"P");
        output = Rule64().Replace(output, @"r");
        output = Rule65().Replace(output, @"R");
        output = Rule66().Replace(output, @"s");
        output = Rule67().Replace(output, @"S");
        output = Rule68().Replace(output, @"t");
        output = Rule69().Replace(output, @"T");
        output = Rule70().Replace(output, @"u");
        output = Rule71().Replace(output, @"U");
        output = Rule72().Replace(output, @"f");
        output = Rule73().Replace(output, @"F");
        output = Rule74().Replace(output, @"x");
        output = Rule75().Replace(output, @"X");
        output = Rule76().Replace(output, @"`");
        output = Rule77().Replace(output, @"`");
        output = Rule78().Replace(output, @"#");

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
        output = RuleReverse9().Replace(output, @"ґ");
        output = RuleReverse10().Replace(output, @"Ґ");
        output = RuleReverse11().Replace(output, @"є");
        output = RuleReverse12().Replace(output, @"Є");
        output = RuleReverse13().Replace(output, @"Є");
        output = RuleReverse14().Replace(output, @"ж");
        output = RuleReverse15().Replace(output, @"Ж");
        output = RuleReverse16().Replace(output, @"Ж");
        output = RuleReverse17().Replace(output, @"и");
        output = RuleReverse18().Replace(output, @"И");
        output = RuleReverse19().Replace(output, @"ї");
        output = RuleReverse20().Replace(output, @"Ї");
        output = RuleReverse21().Replace(output, @"Ї");
        output = RuleReverse22().Replace(output, @"ч");
        output = RuleReverse23().Replace(output, @"Ч");
        output = RuleReverse24().Replace(output, @"Ч");
        output = RuleReverse25().Replace(output, @"ш");
        output = RuleReverse26().Replace(output, @"Ш");
        output = RuleReverse27().Replace(output, @"Ш");
        output = RuleReverse28().Replace(output, @"ю");
        output = RuleReverse29().Replace(output, @"Ю");
        output = RuleReverse30().Replace(output, @"Ю");
        output = RuleReverse31().Replace(output, @"я");
        output = RuleReverse32().Replace(output, @"Я");
        output = RuleReverse33().Replace(output, @"Я");
        output = RuleReverse34().Replace(output, @"а");
        output = RuleReverse35().Replace(output, @"А");
        output = RuleReverse36().Replace(output, @"б");
        output = RuleReverse37().Replace(output, @"Б");
        output = RuleReverse38().Replace(output, @"в");
        output = RuleReverse39().Replace(output, @"В");
        output = RuleReverse40().Replace(output, @"г");
        output = RuleReverse41().Replace(output, @"Г");
        output = RuleReverse42().Replace(output, @"д");
        output = RuleReverse43().Replace(output, @"Д");
        output = RuleReverse44().Replace(output, @"е");
        output = RuleReverse45().Replace(output, @"Е");
        output = RuleReverse46().Replace(output, @"з");
        output = RuleReverse47().Replace(output, @"З");
        output = RuleReverse48().Replace(output, @"й");
        output = RuleReverse49().Replace(output, @"Й");
        output = RuleReverse50().Replace(output, @"і");
        output = RuleReverse51().Replace(output, @"І");
        output = RuleReverse52().Replace(output, @"к");
        output = RuleReverse53().Replace(output, @"К");
        output = RuleReverse54().Replace(output, @"л");
        output = RuleReverse55().Replace(output, @"Л");
        output = RuleReverse56().Replace(output, @"м");
        output = RuleReverse57().Replace(output, @"М");
        output = RuleReverse58().Replace(output, @"н");
        output = RuleReverse59().Replace(output, @"Н");
        output = RuleReverse60().Replace(output, @"о");
        output = RuleReverse61().Replace(output, @"О");
        output = RuleReverse62().Replace(output, @"п");
        output = RuleReverse63().Replace(output, @"П");
        output = RuleReverse64().Replace(output, @"р");
        output = RuleReverse65().Replace(output, @"Р");
        output = RuleReverse66().Replace(output, @"с");
        output = RuleReverse67().Replace(output, @"С");
        output = RuleReverse68().Replace(output, @"т");
        output = RuleReverse69().Replace(output, @"Т");
        output = RuleReverse70().Replace(output, @"у");
        output = RuleReverse71().Replace(output, @"У");
        output = RuleReverse72().Replace(output, @"ф");
        output = RuleReverse73().Replace(output, @"Ф");
        output = RuleReverse74().Replace(output, @"х");
        output = RuleReverse75().Replace(output, @"Х");
        output = RuleReverse76().Replace(output, @"Ь");
        output = RuleReverse77().Replace(output, @"ь");
        output = RuleReverse78().Replace(output, @"№");

        return output;
    }
              
    [GeneratedRegex(@"ц(?=[iejyиейюяєії])")]
    private static partial Regex Rule1();
                   
    [GeneratedRegex(@"c(?=[iejyиейюяєії])")]
    private static partial Regex RuleReverse1();
              
    [GeneratedRegex(@"Ц(?=[IEJYИЕЙЮЯЄІЇ])")]
    private static partial Regex Rule2();
                   
    [GeneratedRegex(@"C(?=[IEJYИЕЙЮЯЄІЇ])")]
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
              
    [GeneratedRegex(@"ґ")]
    private static partial Regex Rule9();
                   
    [GeneratedRegex(@"g`")]
    private static partial Regex RuleReverse9();
              
    [GeneratedRegex(@"Ґ")]
    private static partial Regex Rule10();
                   
    [GeneratedRegex(@"G`")]
    private static partial Regex RuleReverse10();
              
    [GeneratedRegex(@"є")]
    private static partial Regex Rule11();
                   
    [GeneratedRegex(@"ye")]
    private static partial Regex RuleReverse11();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Є(?=[\p{Lu}\s])")]
    private static partial Regex Rule12();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])YE(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse12();
              
    [GeneratedRegex(@"Є")]
    private static partial Regex Rule13();
                   
    [GeneratedRegex(@"Ye")]
    private static partial Regex RuleReverse13();
              
    [GeneratedRegex(@"ж")]
    private static partial Regex Rule14();
                   
    [GeneratedRegex(@"zh")]
    private static partial Regex RuleReverse14();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ж(?=[\p{Lu}\s])")]
    private static partial Regex Rule15();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])ZH(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse15();
              
    [GeneratedRegex(@"Ж")]
    private static partial Regex Rule16();
                   
    [GeneratedRegex(@"Zh")]
    private static partial Regex RuleReverse16();
              
    [GeneratedRegex(@"и")]
    private static partial Regex Rule17();
                   
    [GeneratedRegex(@"y`")]
    private static partial Regex RuleReverse17();
              
    [GeneratedRegex(@"И")]
    private static partial Regex Rule18();
                   
    [GeneratedRegex(@"Y`")]
    private static partial Regex RuleReverse18();
              
    [GeneratedRegex(@"ї")]
    private static partial Regex Rule19();
                   
    [GeneratedRegex(@"yi")]
    private static partial Regex RuleReverse19();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ї(?=[\p{Lu}\s])")]
    private static partial Regex Rule20();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])YI(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse20();
              
    [GeneratedRegex(@"Ї")]
    private static partial Regex Rule21();
                   
    [GeneratedRegex(@"Yi")]
    private static partial Regex RuleReverse21();
              
    [GeneratedRegex(@"ч")]
    private static partial Regex Rule22();
                   
    [GeneratedRegex(@"ch")]
    private static partial Regex RuleReverse22();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ч(?=[\p{Lu}\s])")]
    private static partial Regex Rule23();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])CH(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse23();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule24();
                   
    [GeneratedRegex(@"Ch")]
    private static partial Regex RuleReverse24();
              
    [GeneratedRegex(@"ш")]
    private static partial Regex Rule25();
                   
    [GeneratedRegex(@"sh")]
    private static partial Regex RuleReverse25();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ш(?=[\p{Lu}\s])")]
    private static partial Regex Rule26();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])SH(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse26();
              
    [GeneratedRegex(@"Ш")]
    private static partial Regex Rule27();
                   
    [GeneratedRegex(@"Sh")]
    private static partial Regex RuleReverse27();
              
    [GeneratedRegex(@"ю")]
    private static partial Regex Rule28();
                   
    [GeneratedRegex(@"yu")]
    private static partial Regex RuleReverse28();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ю(?=[\p{Lu}\s])")]
    private static partial Regex Rule29();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])YU(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse29();
              
    [GeneratedRegex(@"Ю")]
    private static partial Regex Rule30();
                   
    [GeneratedRegex(@"Yu")]
    private static partial Regex RuleReverse30();
              
    [GeneratedRegex(@"я")]
    private static partial Regex Rule31();
                   
    [GeneratedRegex(@"ya")]
    private static partial Regex RuleReverse31();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Я(?=[\p{Lu}\s])")]
    private static partial Regex Rule32();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])YA(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse32();
              
    [GeneratedRegex(@"Я")]
    private static partial Regex Rule33();
                   
    [GeneratedRegex(@"Ya")]
    private static partial Regex RuleReverse33();
              
    [GeneratedRegex(@"а")]
    private static partial Regex Rule34();
                   
    [GeneratedRegex(@"a")]
    private static partial Regex RuleReverse34();
              
    [GeneratedRegex(@"А")]
    private static partial Regex Rule35();
                   
    [GeneratedRegex(@"A")]
    private static partial Regex RuleReverse35();
              
    [GeneratedRegex(@"б")]
    private static partial Regex Rule36();
                   
    [GeneratedRegex(@"b")]
    private static partial Regex RuleReverse36();
              
    [GeneratedRegex(@"Б")]
    private static partial Regex Rule37();
                   
    [GeneratedRegex(@"B")]
    private static partial Regex RuleReverse37();
              
    [GeneratedRegex(@"в")]
    private static partial Regex Rule38();
                   
    [GeneratedRegex(@"v")]
    private static partial Regex RuleReverse38();
              
    [GeneratedRegex(@"В")]
    private static partial Regex Rule39();
                   
    [GeneratedRegex(@"V")]
    private static partial Regex RuleReverse39();
              
    [GeneratedRegex(@"г")]
    private static partial Regex Rule40();
                   
    [GeneratedRegex(@"g")]
    private static partial Regex RuleReverse40();
              
    [GeneratedRegex(@"Г")]
    private static partial Regex Rule41();
                   
    [GeneratedRegex(@"G")]
    private static partial Regex RuleReverse41();
              
    [GeneratedRegex(@"д")]
    private static partial Regex Rule42();
                   
    [GeneratedRegex(@"d")]
    private static partial Regex RuleReverse42();
              
    [GeneratedRegex(@"Д")]
    private static partial Regex Rule43();
                   
    [GeneratedRegex(@"D")]
    private static partial Regex RuleReverse43();
              
    [GeneratedRegex(@"е")]
    private static partial Regex Rule44();
                   
    [GeneratedRegex(@"e")]
    private static partial Regex RuleReverse44();
              
    [GeneratedRegex(@"Е")]
    private static partial Regex Rule45();
                   
    [GeneratedRegex(@"E")]
    private static partial Regex RuleReverse45();
              
    [GeneratedRegex(@"з")]
    private static partial Regex Rule46();
                   
    [GeneratedRegex(@"z")]
    private static partial Regex RuleReverse46();
              
    [GeneratedRegex(@"З")]
    private static partial Regex Rule47();
                   
    [GeneratedRegex(@"Z")]
    private static partial Regex RuleReverse47();
              
    [GeneratedRegex(@"й")]
    private static partial Regex Rule48();
                   
    [GeneratedRegex(@"j")]
    private static partial Regex RuleReverse48();
              
    [GeneratedRegex(@"Й")]
    private static partial Regex Rule49();
                   
    [GeneratedRegex(@"J")]
    private static partial Regex RuleReverse49();
              
    [GeneratedRegex(@"і")]
    private static partial Regex Rule50();
                   
    [GeneratedRegex(@"i")]
    private static partial Regex RuleReverse50();
              
    [GeneratedRegex(@"І")]
    private static partial Regex Rule51();
                   
    [GeneratedRegex(@"I")]
    private static partial Regex RuleReverse51();
              
    [GeneratedRegex(@"к")]
    private static partial Regex Rule52();
                   
    [GeneratedRegex(@"k")]
    private static partial Regex RuleReverse52();
              
    [GeneratedRegex(@"К")]
    private static partial Regex Rule53();
                   
    [GeneratedRegex(@"K")]
    private static partial Regex RuleReverse53();
              
    [GeneratedRegex(@"л")]
    private static partial Regex Rule54();
                   
    [GeneratedRegex(@"l")]
    private static partial Regex RuleReverse54();
              
    [GeneratedRegex(@"Л")]
    private static partial Regex Rule55();
                   
    [GeneratedRegex(@"L")]
    private static partial Regex RuleReverse55();
              
    [GeneratedRegex(@"м")]
    private static partial Regex Rule56();
                   
    [GeneratedRegex(@"m")]
    private static partial Regex RuleReverse56();
              
    [GeneratedRegex(@"М")]
    private static partial Regex Rule57();
                   
    [GeneratedRegex(@"M")]
    private static partial Regex RuleReverse57();
              
    [GeneratedRegex(@"н")]
    private static partial Regex Rule58();
                   
    [GeneratedRegex(@"n")]
    private static partial Regex RuleReverse58();
              
    [GeneratedRegex(@"Н")]
    private static partial Regex Rule59();
                   
    [GeneratedRegex(@"N")]
    private static partial Regex RuleReverse59();
              
    [GeneratedRegex(@"о")]
    private static partial Regex Rule60();
                   
    [GeneratedRegex(@"o")]
    private static partial Regex RuleReverse60();
              
    [GeneratedRegex(@"О")]
    private static partial Regex Rule61();
                   
    [GeneratedRegex(@"O")]
    private static partial Regex RuleReverse61();
              
    [GeneratedRegex(@"п")]
    private static partial Regex Rule62();
                   
    [GeneratedRegex(@"p")]
    private static partial Regex RuleReverse62();
              
    [GeneratedRegex(@"П")]
    private static partial Regex Rule63();
                   
    [GeneratedRegex(@"P")]
    private static partial Regex RuleReverse63();
              
    [GeneratedRegex(@"р")]
    private static partial Regex Rule64();
                   
    [GeneratedRegex(@"r")]
    private static partial Regex RuleReverse64();
              
    [GeneratedRegex(@"Р")]
    private static partial Regex Rule65();
                   
    [GeneratedRegex(@"R")]
    private static partial Regex RuleReverse65();
              
    [GeneratedRegex(@"с")]
    private static partial Regex Rule66();
                   
    [GeneratedRegex(@"s")]
    private static partial Regex RuleReverse66();
              
    [GeneratedRegex(@"С")]
    private static partial Regex Rule67();
                   
    [GeneratedRegex(@"S")]
    private static partial Regex RuleReverse67();
              
    [GeneratedRegex(@"т")]
    private static partial Regex Rule68();
                   
    [GeneratedRegex(@"t")]
    private static partial Regex RuleReverse68();
              
    [GeneratedRegex(@"Т")]
    private static partial Regex Rule69();
                   
    [GeneratedRegex(@"T")]
    private static partial Regex RuleReverse69();
              
    [GeneratedRegex(@"у")]
    private static partial Regex Rule70();
                   
    [GeneratedRegex(@"u")]
    private static partial Regex RuleReverse70();
              
    [GeneratedRegex(@"У")]
    private static partial Regex Rule71();
                   
    [GeneratedRegex(@"U")]
    private static partial Regex RuleReverse71();
              
    [GeneratedRegex(@"ф")]
    private static partial Regex Rule72();
                   
    [GeneratedRegex(@"f")]
    private static partial Regex RuleReverse72();
              
    [GeneratedRegex(@"Ф")]
    private static partial Regex Rule73();
                   
    [GeneratedRegex(@"F")]
    private static partial Regex RuleReverse73();
              
    [GeneratedRegex(@"х")]
    private static partial Regex Rule74();
                   
    [GeneratedRegex(@"x")]
    private static partial Regex RuleReverse74();
              
    [GeneratedRegex(@"Х")]
    private static partial Regex Rule75();
                   
    [GeneratedRegex(@"X")]
    private static partial Regex RuleReverse75();
              
    [GeneratedRegex(@"(?<=\p{Lu})Ь")]
    private static partial Regex Rule76();
                   
    [GeneratedRegex(@"(?<=\p{Lu})`")]
    private static partial Regex RuleReverse76();
              
    [GeneratedRegex(@"ь")]
    private static partial Regex Rule77();
                   
    [GeneratedRegex(@"`")]
    private static partial Regex RuleReverse77();
              
    [GeneratedRegex(@"№")]
    private static partial Regex Rule78();
                   
    [GeneratedRegex(@"#")]
    private static partial Regex RuleReverse78();

}
