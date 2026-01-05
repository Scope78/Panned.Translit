using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_din_1460_rus : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.din_1460_rus;

    public override bool IsReversable => true;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"ch");
        output = Rule2().Replace(output, @"CH");
        output = Rule3().Replace(output, @"Ch");
        output = Rule4().Replace(output, @"šč");
        output = Rule5().Replace(output, @"ŠČ");
        output = Rule6().Replace(output, @"Šč");
        output = Rule7().Replace(output, @"""");
        output = Rule8().Replace(output, @"""");
        output = Rule9().Replace(output, @"""");
        output = Rule10().Replace(output, @"""");
        output = Rule11().Replace(output, @"ju");
        output = Rule12().Replace(output, @"JU");
        output = Rule13().Replace(output, @"Ju");
        output = Rule14().Replace(output, @"ja");
        output = Rule15().Replace(output, @"JA");
        output = Rule16().Replace(output, @"Ja");
        output = Rule17().Replace(output, @"J-");
        output = Rule18().Replace(output, @"j-");
        output = Rule19().Replace(output, @"Š-");
        output = Rule20().Replace(output, @"š-");
        output = Rule21().Replace(output, @"a");
        output = Rule22().Replace(output, @"A");
        output = Rule23().Replace(output, @"b");
        output = Rule24().Replace(output, @"B");
        output = Rule25().Replace(output, @"v");
        output = Rule26().Replace(output, @"V");
        output = Rule27().Replace(output, @"g");
        output = Rule28().Replace(output, @"G");
        output = Rule29().Replace(output, @"d");
        output = Rule30().Replace(output, @"D");
        output = Rule31().Replace(output, @"e");
        output = Rule32().Replace(output, @"E");
        output = Rule33().Replace(output, @"ë");
        output = Rule34().Replace(output, @"Ë");
        output = Rule35().Replace(output, @"ž");
        output = Rule36().Replace(output, @"Ž");
        output = Rule37().Replace(output, @"z");
        output = Rule38().Replace(output, @"Z");
        output = Rule39().Replace(output, @"i");
        output = Rule40().Replace(output, @"I");
        output = Rule41().Replace(output, @"i");
        output = Rule42().Replace(output, @"I");
        output = Rule43().Replace(output, @"j");
        output = Rule44().Replace(output, @"J");
        output = Rule45().Replace(output, @"k");
        output = Rule46().Replace(output, @"K");
        output = Rule47().Replace(output, @"l");
        output = Rule48().Replace(output, @"L");
        output = Rule49().Replace(output, @"m");
        output = Rule50().Replace(output, @"M");
        output = Rule51().Replace(output, @"n");
        output = Rule52().Replace(output, @"N");
        output = Rule53().Replace(output, @"o");
        output = Rule54().Replace(output, @"O");
        output = Rule55().Replace(output, @"p");
        output = Rule56().Replace(output, @"P");
        output = Rule57().Replace(output, @"r");
        output = Rule58().Replace(output, @"R");
        output = Rule59().Replace(output, @"s");
        output = Rule60().Replace(output, @"S");
        output = Rule61().Replace(output, @"t");
        output = Rule62().Replace(output, @"T");
        output = Rule63().Replace(output, @"u");
        output = Rule64().Replace(output, @"U");
        output = Rule65().Replace(output, @"f");
        output = Rule66().Replace(output, @"F");
        output = Rule67().Replace(output, @"c");
        output = Rule68().Replace(output, @"C");
        output = Rule69().Replace(output, @"č");
        output = Rule70().Replace(output, @"Č");
        output = Rule71().Replace(output, @"š");
        output = Rule72().Replace(output, @"Š");
        output = Rule73().Replace(output, @"y");
        output = Rule74().Replace(output, @"Y");
        output = Rule75().Replace(output, @"'");
        output = Rule76().Replace(output, @"'");
        output = Rule77().Replace(output, @"ě");
        output = Rule78().Replace(output, @"Ě");
        output = Rule79().Replace(output, @"ė");
        output = Rule80().Replace(output, @"Ė");
        output = Rule81().Replace(output, @"ḟ");
        output = Rule82().Replace(output, @"Ḟ");
        output = Rule83().Replace(output, @"ẏ");
        output = Rule84().Replace(output, @"Ẏ");

        return output;
    }

    public override string Reverse(string input)
    {
        string output = input;

        output = RuleReverse1().Replace(output, @"х");
        output = RuleReverse2().Replace(output, @"Х");
        output = RuleReverse3().Replace(output, @"Х");
        output = RuleReverse4().Replace(output, @"щ");
        output = RuleReverse5().Replace(output, @"Щ");
        output = RuleReverse6().Replace(output, @"Щ");
        output = RuleReverse7().Replace(output, @"Ъ");
        output = RuleReverse8().Replace(output, @"ъ");
        output = RuleReverse9().Replace(output, @"ъ");
        output = RuleReverse10().Replace(output, @"Ъ");
        output = RuleReverse11().Replace(output, @"ю");
        output = RuleReverse12().Replace(output, @"Ю");
        output = RuleReverse13().Replace(output, @"Ю");
        output = RuleReverse14().Replace(output, @"я");
        output = RuleReverse15().Replace(output, @"Я");
        output = RuleReverse16().Replace(output, @"Я");
        output = RuleReverse17().Replace(output, @"Й");
        output = RuleReverse18().Replace(output, @"й");
        output = RuleReverse19().Replace(output, @"Ш");
        output = RuleReverse20().Replace(output, @"ш");
        output = RuleReverse21().Replace(output, @"а");
        output = RuleReverse22().Replace(output, @"А");
        output = RuleReverse23().Replace(output, @"б");
        output = RuleReverse24().Replace(output, @"Б");
        output = RuleReverse25().Replace(output, @"в");
        output = RuleReverse26().Replace(output, @"В");
        output = RuleReverse27().Replace(output, @"г");
        output = RuleReverse28().Replace(output, @"Г");
        output = RuleReverse29().Replace(output, @"д");
        output = RuleReverse30().Replace(output, @"Д");
        output = RuleReverse31().Replace(output, @"е");
        output = RuleReverse32().Replace(output, @"Е");
        output = RuleReverse33().Replace(output, @"ё");
        output = RuleReverse34().Replace(output, @"Ё");
        output = RuleReverse35().Replace(output, @"ж");
        output = RuleReverse36().Replace(output, @"Ж");
        output = RuleReverse37().Replace(output, @"з");
        output = RuleReverse38().Replace(output, @"З");
        output = RuleReverse39().Replace(output, @"и");
        output = RuleReverse40().Replace(output, @"И");
        output = RuleReverse41().Replace(output, @"і");
        output = RuleReverse42().Replace(output, @"І");
        output = RuleReverse43().Replace(output, @"й");
        output = RuleReverse44().Replace(output, @"Й");
        output = RuleReverse45().Replace(output, @"к");
        output = RuleReverse46().Replace(output, @"К");
        output = RuleReverse47().Replace(output, @"л");
        output = RuleReverse48().Replace(output, @"Л");
        output = RuleReverse49().Replace(output, @"м");
        output = RuleReverse50().Replace(output, @"М");
        output = RuleReverse51().Replace(output, @"н");
        output = RuleReverse52().Replace(output, @"Н");
        output = RuleReverse53().Replace(output, @"о");
        output = RuleReverse54().Replace(output, @"О");
        output = RuleReverse55().Replace(output, @"п");
        output = RuleReverse56().Replace(output, @"П");
        output = RuleReverse57().Replace(output, @"р");
        output = RuleReverse58().Replace(output, @"Р");
        output = RuleReverse59().Replace(output, @"с");
        output = RuleReverse60().Replace(output, @"С");
        output = RuleReverse61().Replace(output, @"т");
        output = RuleReverse62().Replace(output, @"Т");
        output = RuleReverse63().Replace(output, @"у");
        output = RuleReverse64().Replace(output, @"У");
        output = RuleReverse65().Replace(output, @"ф");
        output = RuleReverse66().Replace(output, @"Ф");
        output = RuleReverse67().Replace(output, @"ц");
        output = RuleReverse68().Replace(output, @"Ц");
        output = RuleReverse69().Replace(output, @"ч");
        output = RuleReverse70().Replace(output, @"Ч");
        output = RuleReverse71().Replace(output, @"ш");
        output = RuleReverse72().Replace(output, @"Ш");
        output = RuleReverse73().Replace(output, @"ы");
        output = RuleReverse74().Replace(output, @"Ы");
        output = RuleReverse75().Replace(output, @"Ь");
        output = RuleReverse76().Replace(output, @"ь");
        output = RuleReverse77().Replace(output, @"ѣ");
        output = RuleReverse78().Replace(output, @"Ѣ");
        output = RuleReverse79().Replace(output, @"э");
        output = RuleReverse80().Replace(output, @"Э");
        output = RuleReverse81().Replace(output, @"ѳ");
        output = RuleReverse82().Replace(output, @"Ѳ");
        output = RuleReverse83().Replace(output, @"ѵ");
        output = RuleReverse84().Replace(output, @"Ѵ");

        return output;
    }
              
    [GeneratedRegex(@"х")]
    private static partial Regex Rule1();
                   
    [GeneratedRegex(@"ch")]
    private static partial Regex RuleReverse1();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Х(?=[\p{Lu}\s])")]
    private static partial Regex Rule2();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])CH(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse2();
              
    [GeneratedRegex(@"Х")]
    private static partial Regex Rule3();
                   
    [GeneratedRegex(@"Ch")]
    private static partial Regex RuleReverse3();
              
    [GeneratedRegex(@"щ")]
    private static partial Regex Rule4();
                   
    [GeneratedRegex(@"šč")]
    private static partial Regex RuleReverse4();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Щ(?=[\p{Lu}\s])")]
    private static partial Regex Rule5();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])ŠČ(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse5();
              
    [GeneratedRegex(@"Щ")]
    private static partial Regex Rule6();
                   
    [GeneratedRegex(@"Šč")]
    private static partial Regex RuleReverse6();
              
    [GeneratedRegex(@"(?<=\p{Lu})Ъ(?=([^\w]|$))")]
    private static partial Regex Rule7();
                   
    [GeneratedRegex(@"(?<=\p{Lu})""(?=([^\w]|$))")]
    private static partial Regex RuleReverse7();
              
    [GeneratedRegex(@"(?<=\w)ъ(?=([^\w]|$))")]
    private static partial Regex Rule8();
                   
    [GeneratedRegex(@"(?<=\w)""(?=([^\w]|$))")]
    private static partial Regex RuleReverse8();
              
    [GeneratedRegex(@"(?<=\w)ъ(?=\w)")]
    private static partial Regex Rule9();
                   
    [GeneratedRegex(@"(?<=\w)""(?=\w)")]
    private static partial Regex RuleReverse9();
              
    [GeneratedRegex(@"(?<=\w)Ъ(?=\w)")]
    private static partial Regex Rule10();
                   
    [GeneratedRegex(@"(?<=\w)""(?=\w)")]
    private static partial Regex RuleReverse10();
              
    [GeneratedRegex(@"ю")]
    private static partial Regex Rule11();
                   
    [GeneratedRegex(@"ju")]
    private static partial Regex RuleReverse11();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ю(?=[\p{Lu}\s])")]
    private static partial Regex Rule12();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])JU(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse12();
              
    [GeneratedRegex(@"Ю")]
    private static partial Regex Rule13();
                   
    [GeneratedRegex(@"Ju")]
    private static partial Regex RuleReverse13();
              
    [GeneratedRegex(@"я")]
    private static partial Regex Rule14();
                   
    [GeneratedRegex(@"ja")]
    private static partial Regex RuleReverse14();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Я(?=[\p{Lu}\s])")]
    private static partial Regex Rule15();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])JA(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse15();
              
    [GeneratedRegex(@"Я")]
    private static partial Regex Rule16();
                   
    [GeneratedRegex(@"Ja")]
    private static partial Regex RuleReverse16();
              
    [GeneratedRegex(@"Й(?=[auAUауАУ])")]
    private static partial Regex Rule17();
                   
    [GeneratedRegex(@"J-(?=[auAUауАУ])")]
    private static partial Regex RuleReverse17();
              
    [GeneratedRegex(@"й(?=[auау])")]
    private static partial Regex Rule18();
                   
    [GeneratedRegex(@"j-(?=[auау])")]
    private static partial Regex RuleReverse18();
              
    [GeneratedRegex(@"Ш(?=[ČčЧч])")]
    private static partial Regex Rule19();
                   
    [GeneratedRegex(@"Š-(?=[ČčЧч])")]
    private static partial Regex RuleReverse19();
              
    [GeneratedRegex(@"ш(?=[čч])")]
    private static partial Regex Rule20();
                   
    [GeneratedRegex(@"š-(?=[čч])")]
    private static partial Regex RuleReverse20();
              
    [GeneratedRegex(@"а")]
    private static partial Regex Rule21();
                   
    [GeneratedRegex(@"a")]
    private static partial Regex RuleReverse21();
              
    [GeneratedRegex(@"А")]
    private static partial Regex Rule22();
                   
    [GeneratedRegex(@"A")]
    private static partial Regex RuleReverse22();
              
    [GeneratedRegex(@"б")]
    private static partial Regex Rule23();
                   
    [GeneratedRegex(@"b")]
    private static partial Regex RuleReverse23();
              
    [GeneratedRegex(@"Б")]
    private static partial Regex Rule24();
                   
    [GeneratedRegex(@"B")]
    private static partial Regex RuleReverse24();
              
    [GeneratedRegex(@"в")]
    private static partial Regex Rule25();
                   
    [GeneratedRegex(@"v")]
    private static partial Regex RuleReverse25();
              
    [GeneratedRegex(@"В")]
    private static partial Regex Rule26();
                   
    [GeneratedRegex(@"V")]
    private static partial Regex RuleReverse26();
              
    [GeneratedRegex(@"г")]
    private static partial Regex Rule27();
                   
    [GeneratedRegex(@"g")]
    private static partial Regex RuleReverse27();
              
    [GeneratedRegex(@"Г")]
    private static partial Regex Rule28();
                   
    [GeneratedRegex(@"G")]
    private static partial Regex RuleReverse28();
              
    [GeneratedRegex(@"д")]
    private static partial Regex Rule29();
                   
    [GeneratedRegex(@"d")]
    private static partial Regex RuleReverse29();
              
    [GeneratedRegex(@"Д")]
    private static partial Regex Rule30();
                   
    [GeneratedRegex(@"D")]
    private static partial Regex RuleReverse30();
              
    [GeneratedRegex(@"е")]
    private static partial Regex Rule31();
                   
    [GeneratedRegex(@"e")]
    private static partial Regex RuleReverse31();
              
    [GeneratedRegex(@"Е")]
    private static partial Regex Rule32();
                   
    [GeneratedRegex(@"E")]
    private static partial Regex RuleReverse32();
              
    [GeneratedRegex(@"ё")]
    private static partial Regex Rule33();
                   
    [GeneratedRegex(@"ë")]
    private static partial Regex RuleReverse33();
              
    [GeneratedRegex(@"Ё")]
    private static partial Regex Rule34();
                   
    [GeneratedRegex(@"Ë")]
    private static partial Regex RuleReverse34();
              
    [GeneratedRegex(@"ж")]
    private static partial Regex Rule35();
                   
    [GeneratedRegex(@"ž")]
    private static partial Regex RuleReverse35();
              
    [GeneratedRegex(@"Ж")]
    private static partial Regex Rule36();
                   
    [GeneratedRegex(@"Ž")]
    private static partial Regex RuleReverse36();
              
    [GeneratedRegex(@"з")]
    private static partial Regex Rule37();
                   
    [GeneratedRegex(@"z")]
    private static partial Regex RuleReverse37();
              
    [GeneratedRegex(@"З")]
    private static partial Regex Rule38();
                   
    [GeneratedRegex(@"Z")]
    private static partial Regex RuleReverse38();
              
    [GeneratedRegex(@"и")]
    private static partial Regex Rule39();
                   
    [GeneratedRegex(@"i")]
    private static partial Regex RuleReverse39();
              
    [GeneratedRegex(@"И")]
    private static partial Regex Rule40();
                   
    [GeneratedRegex(@"I")]
    private static partial Regex RuleReverse40();
              
    [GeneratedRegex(@"і")]
    private static partial Regex Rule41();
                   
    [GeneratedRegex(@"i")]
    private static partial Regex RuleReverse41();
              
    [GeneratedRegex(@"І")]
    private static partial Regex Rule42();
                   
    [GeneratedRegex(@"I")]
    private static partial Regex RuleReverse42();
              
    [GeneratedRegex(@"й")]
    private static partial Regex Rule43();
                   
    [GeneratedRegex(@"j")]
    private static partial Regex RuleReverse43();
              
    [GeneratedRegex(@"Й")]
    private static partial Regex Rule44();
                   
    [GeneratedRegex(@"J")]
    private static partial Regex RuleReverse44();
              
    [GeneratedRegex(@"к")]
    private static partial Regex Rule45();
                   
    [GeneratedRegex(@"k")]
    private static partial Regex RuleReverse45();
              
    [GeneratedRegex(@"К")]
    private static partial Regex Rule46();
                   
    [GeneratedRegex(@"K")]
    private static partial Regex RuleReverse46();
              
    [GeneratedRegex(@"л")]
    private static partial Regex Rule47();
                   
    [GeneratedRegex(@"l")]
    private static partial Regex RuleReverse47();
              
    [GeneratedRegex(@"Л")]
    private static partial Regex Rule48();
                   
    [GeneratedRegex(@"L")]
    private static partial Regex RuleReverse48();
              
    [GeneratedRegex(@"м")]
    private static partial Regex Rule49();
                   
    [GeneratedRegex(@"m")]
    private static partial Regex RuleReverse49();
              
    [GeneratedRegex(@"М")]
    private static partial Regex Rule50();
                   
    [GeneratedRegex(@"M")]
    private static partial Regex RuleReverse50();
              
    [GeneratedRegex(@"н")]
    private static partial Regex Rule51();
                   
    [GeneratedRegex(@"n")]
    private static partial Regex RuleReverse51();
              
    [GeneratedRegex(@"Н")]
    private static partial Regex Rule52();
                   
    [GeneratedRegex(@"N")]
    private static partial Regex RuleReverse52();
              
    [GeneratedRegex(@"о")]
    private static partial Regex Rule53();
                   
    [GeneratedRegex(@"o")]
    private static partial Regex RuleReverse53();
              
    [GeneratedRegex(@"О")]
    private static partial Regex Rule54();
                   
    [GeneratedRegex(@"O")]
    private static partial Regex RuleReverse54();
              
    [GeneratedRegex(@"п")]
    private static partial Regex Rule55();
                   
    [GeneratedRegex(@"p")]
    private static partial Regex RuleReverse55();
              
    [GeneratedRegex(@"П")]
    private static partial Regex Rule56();
                   
    [GeneratedRegex(@"P")]
    private static partial Regex RuleReverse56();
              
    [GeneratedRegex(@"р")]
    private static partial Regex Rule57();
                   
    [GeneratedRegex(@"r")]
    private static partial Regex RuleReverse57();
              
    [GeneratedRegex(@"Р")]
    private static partial Regex Rule58();
                   
    [GeneratedRegex(@"R")]
    private static partial Regex RuleReverse58();
              
    [GeneratedRegex(@"с")]
    private static partial Regex Rule59();
                   
    [GeneratedRegex(@"s")]
    private static partial Regex RuleReverse59();
              
    [GeneratedRegex(@"С")]
    private static partial Regex Rule60();
                   
    [GeneratedRegex(@"S")]
    private static partial Regex RuleReverse60();
              
    [GeneratedRegex(@"т")]
    private static partial Regex Rule61();
                   
    [GeneratedRegex(@"t")]
    private static partial Regex RuleReverse61();
              
    [GeneratedRegex(@"Т")]
    private static partial Regex Rule62();
                   
    [GeneratedRegex(@"T")]
    private static partial Regex RuleReverse62();
              
    [GeneratedRegex(@"у")]
    private static partial Regex Rule63();
                   
    [GeneratedRegex(@"u")]
    private static partial Regex RuleReverse63();
              
    [GeneratedRegex(@"У")]
    private static partial Regex Rule64();
                   
    [GeneratedRegex(@"U")]
    private static partial Regex RuleReverse64();
              
    [GeneratedRegex(@"ф")]
    private static partial Regex Rule65();
                   
    [GeneratedRegex(@"f")]
    private static partial Regex RuleReverse65();
              
    [GeneratedRegex(@"Ф")]
    private static partial Regex Rule66();
                   
    [GeneratedRegex(@"F")]
    private static partial Regex RuleReverse66();
              
    [GeneratedRegex(@"ц")]
    private static partial Regex Rule67();
                   
    [GeneratedRegex(@"c")]
    private static partial Regex RuleReverse67();
              
    [GeneratedRegex(@"Ц")]
    private static partial Regex Rule68();
                   
    [GeneratedRegex(@"C")]
    private static partial Regex RuleReverse68();
              
    [GeneratedRegex(@"ч")]
    private static partial Regex Rule69();
                   
    [GeneratedRegex(@"č")]
    private static partial Regex RuleReverse69();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule70();
                   
    [GeneratedRegex(@"Č")]
    private static partial Regex RuleReverse70();
              
    [GeneratedRegex(@"ш")]
    private static partial Regex Rule71();
                   
    [GeneratedRegex(@"š")]
    private static partial Regex RuleReverse71();
              
    [GeneratedRegex(@"Ш")]
    private static partial Regex Rule72();
                   
    [GeneratedRegex(@"Š")]
    private static partial Regex RuleReverse72();
              
    [GeneratedRegex(@"ы")]
    private static partial Regex Rule73();
                   
    [GeneratedRegex(@"y")]
    private static partial Regex RuleReverse73();
              
    [GeneratedRegex(@"Ы")]
    private static partial Regex Rule74();
                   
    [GeneratedRegex(@"Y")]
    private static partial Regex RuleReverse74();
              
    [GeneratedRegex(@"(?<=\p{Lu})Ь")]
    private static partial Regex Rule75();
                   
    [GeneratedRegex(@"(?<=\p{Lu})'")]
    private static partial Regex RuleReverse75();
              
    [GeneratedRegex(@"ь")]
    private static partial Regex Rule76();
                   
    [GeneratedRegex(@"'")]
    private static partial Regex RuleReverse76();
              
    [GeneratedRegex(@"ѣ")]
    private static partial Regex Rule77();
                   
    [GeneratedRegex(@"ě")]
    private static partial Regex RuleReverse77();
              
    [GeneratedRegex(@"Ѣ")]
    private static partial Regex Rule78();
                   
    [GeneratedRegex(@"Ě")]
    private static partial Regex RuleReverse78();
              
    [GeneratedRegex(@"э")]
    private static partial Regex Rule79();
                   
    [GeneratedRegex(@"ė")]
    private static partial Regex RuleReverse79();
              
    [GeneratedRegex(@"Э")]
    private static partial Regex Rule80();
                   
    [GeneratedRegex(@"Ė")]
    private static partial Regex RuleReverse80();
              
    [GeneratedRegex(@"ѳ")]
    private static partial Regex Rule81();
                   
    [GeneratedRegex(@"ḟ")]
    private static partial Regex RuleReverse81();
              
    [GeneratedRegex(@"Ѳ")]
    private static partial Regex Rule82();
                   
    [GeneratedRegex(@"Ḟ")]
    private static partial Regex RuleReverse82();
              
    [GeneratedRegex(@"ѵ")]
    private static partial Regex Rule83();
                   
    [GeneratedRegex(@"ẏ")]
    private static partial Regex RuleReverse83();
              
    [GeneratedRegex(@"Ѵ")]
    private static partial Regex Rule84();
                   
    [GeneratedRegex(@"Ẏ")]
    private static partial Regex RuleReverse84();

}
