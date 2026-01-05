using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_din_1460_bul : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.din_1460_bul;

    public override bool IsReversable => true;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"ŠT");
        output = Rule2().Replace(output, @"Št");
        output = Rule3().Replace(output, @"št");
        output = Rule4().Replace(output, @"JU");
        output = Rule5().Replace(output, @"Ju");
        output = Rule6().Replace(output, @"ju");
        output = Rule7().Replace(output, @"JA");
        output = Rule8().Replace(output, @"Ja");
        output = Rule9().Replace(output, @"ja");
        output = Rule10().Replace(output, @"CH");
        output = Rule11().Replace(output, @"Ch");
        output = Rule12().Replace(output, @"ch");
        output = Rule13().Replace(output, @"J-");
        output = Rule14().Replace(output, @"j-");
        output = Rule15().Replace(output, @"Š-");
        output = Rule16().Replace(output, @"š-");
        output = Rule17().Replace(output, @"A");
        output = Rule18().Replace(output, @"a");
        output = Rule19().Replace(output, @"B");
        output = Rule20().Replace(output, @"b");
        output = Rule21().Replace(output, @"V");
        output = Rule22().Replace(output, @"v");
        output = Rule23().Replace(output, @"G");
        output = Rule24().Replace(output, @"g");
        output = Rule25().Replace(output, @"D");
        output = Rule26().Replace(output, @"d");
        output = Rule27().Replace(output, @"E");
        output = Rule28().Replace(output, @"e");
        output = Rule29().Replace(output, @"Ž");
        output = Rule30().Replace(output, @"ž");
        output = Rule31().Replace(output, @"Z");
        output = Rule32().Replace(output, @"z");
        output = Rule33().Replace(output, @"I");
        output = Rule34().Replace(output, @"i");
        output = Rule35().Replace(output, @"J");
        output = Rule36().Replace(output, @"j");
        output = Rule37().Replace(output, @"K");
        output = Rule38().Replace(output, @"k");
        output = Rule39().Replace(output, @"L");
        output = Rule40().Replace(output, @"l");
        output = Rule41().Replace(output, @"M");
        output = Rule42().Replace(output, @"m");
        output = Rule43().Replace(output, @"N");
        output = Rule44().Replace(output, @"n");
        output = Rule45().Replace(output, @"O");
        output = Rule46().Replace(output, @"o");
        output = Rule47().Replace(output, @"P");
        output = Rule48().Replace(output, @"p");
        output = Rule49().Replace(output, @"R");
        output = Rule50().Replace(output, @"r");
        output = Rule51().Replace(output, @"T");
        output = Rule52().Replace(output, @"t");
        output = Rule53().Replace(output, @"U");
        output = Rule54().Replace(output, @"u");
        output = Rule55().Replace(output, @"F");
        output = Rule56().Replace(output, @"f");
        output = Rule57().Replace(output, @"C");
        output = Rule58().Replace(output, @"c");
        output = Rule59().Replace(output, @"S");
        output = Rule60().Replace(output, @"s");
        output = Rule61().Replace(output, @"Č");
        output = Rule62().Replace(output, @"č");
        output = Rule63().Replace(output, @"Š");
        output = Rule64().Replace(output, @"š");
        output = Rule65().Replace(output, @"Ă");
        output = Rule66().Replace(output, @"ă");
        output = Rule67().Replace(output, @"'");
        output = Rule68().Replace(output, @"'");

        return output;
    }

    public override string Reverse(string input)
    {
        string output = input;

        output = RuleReverse1().Replace(output, @"Щ");
        output = RuleReverse2().Replace(output, @"Щ");
        output = RuleReverse3().Replace(output, @"щ");
        output = RuleReverse4().Replace(output, @"Ю");
        output = RuleReverse5().Replace(output, @"Ю");
        output = RuleReverse6().Replace(output, @"ю");
        output = RuleReverse7().Replace(output, @"Я");
        output = RuleReverse8().Replace(output, @"Я");
        output = RuleReverse9().Replace(output, @"я");
        output = RuleReverse10().Replace(output, @"Х");
        output = RuleReverse11().Replace(output, @"Х");
        output = RuleReverse12().Replace(output, @"х");
        output = RuleReverse13().Replace(output, @"Й");
        output = RuleReverse14().Replace(output, @"й");
        output = RuleReverse15().Replace(output, @"Ш");
        output = RuleReverse16().Replace(output, @"ш");
        output = RuleReverse17().Replace(output, @"А");
        output = RuleReverse18().Replace(output, @"а");
        output = RuleReverse19().Replace(output, @"Б");
        output = RuleReverse20().Replace(output, @"б");
        output = RuleReverse21().Replace(output, @"В");
        output = RuleReverse22().Replace(output, @"в");
        output = RuleReverse23().Replace(output, @"Г");
        output = RuleReverse24().Replace(output, @"г");
        output = RuleReverse25().Replace(output, @"Д");
        output = RuleReverse26().Replace(output, @"д");
        output = RuleReverse27().Replace(output, @"Е");
        output = RuleReverse28().Replace(output, @"е");
        output = RuleReverse29().Replace(output, @"Ж");
        output = RuleReverse30().Replace(output, @"ж");
        output = RuleReverse31().Replace(output, @"З");
        output = RuleReverse32().Replace(output, @"з");
        output = RuleReverse33().Replace(output, @"И");
        output = RuleReverse34().Replace(output, @"и");
        output = RuleReverse35().Replace(output, @"Й");
        output = RuleReverse36().Replace(output, @"й");
        output = RuleReverse37().Replace(output, @"К");
        output = RuleReverse38().Replace(output, @"к");
        output = RuleReverse39().Replace(output, @"Л");
        output = RuleReverse40().Replace(output, @"л");
        output = RuleReverse41().Replace(output, @"М");
        output = RuleReverse42().Replace(output, @"м");
        output = RuleReverse43().Replace(output, @"Н");
        output = RuleReverse44().Replace(output, @"н");
        output = RuleReverse45().Replace(output, @"О");
        output = RuleReverse46().Replace(output, @"о");
        output = RuleReverse47().Replace(output, @"П");
        output = RuleReverse48().Replace(output, @"п");
        output = RuleReverse49().Replace(output, @"Р");
        output = RuleReverse50().Replace(output, @"р");
        output = RuleReverse51().Replace(output, @"Т");
        output = RuleReverse52().Replace(output, @"т");
        output = RuleReverse53().Replace(output, @"У");
        output = RuleReverse54().Replace(output, @"у");
        output = RuleReverse55().Replace(output, @"Ф");
        output = RuleReverse56().Replace(output, @"ф");
        output = RuleReverse57().Replace(output, @"Ц");
        output = RuleReverse58().Replace(output, @"ц");
        output = RuleReverse59().Replace(output, @"С");
        output = RuleReverse60().Replace(output, @"с");
        output = RuleReverse61().Replace(output, @"Ч");
        output = RuleReverse62().Replace(output, @"ч");
        output = RuleReverse63().Replace(output, @"Ш");
        output = RuleReverse64().Replace(output, @"ш");
        output = RuleReverse65().Replace(output, @"Ъ");
        output = RuleReverse66().Replace(output, @"ъ");
        output = RuleReverse67().Replace(output, @"Ь");
        output = RuleReverse68().Replace(output, @"ь");

        return output;
    }
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Щ(?=[\p{Lu}\s])")]
    private static partial Regex Rule1();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])ŠT(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse1();
              
    [GeneratedRegex(@"Щ")]
    private static partial Regex Rule2();
                   
    [GeneratedRegex(@"Št")]
    private static partial Regex RuleReverse2();
              
    [GeneratedRegex(@"щ")]
    private static partial Regex Rule3();
                   
    [GeneratedRegex(@"št")]
    private static partial Regex RuleReverse3();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ю(?=[\p{Lu}\s])")]
    private static partial Regex Rule4();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])JU(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse4();
              
    [GeneratedRegex(@"Ю")]
    private static partial Regex Rule5();
                   
    [GeneratedRegex(@"Ju")]
    private static partial Regex RuleReverse5();
              
    [GeneratedRegex(@"ю")]
    private static partial Regex Rule6();
                   
    [GeneratedRegex(@"ju")]
    private static partial Regex RuleReverse6();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Я(?=[\p{Lu}\s])")]
    private static partial Regex Rule7();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])JA(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse7();
              
    [GeneratedRegex(@"Я")]
    private static partial Regex Rule8();
                   
    [GeneratedRegex(@"Ja")]
    private static partial Regex RuleReverse8();
              
    [GeneratedRegex(@"я")]
    private static partial Regex Rule9();
                   
    [GeneratedRegex(@"ja")]
    private static partial Regex RuleReverse9();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Х(?=[\p{Lu}\s])")]
    private static partial Regex Rule10();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])CH(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse10();
              
    [GeneratedRegex(@"Х")]
    private static partial Regex Rule11();
                   
    [GeneratedRegex(@"Ch")]
    private static partial Regex RuleReverse11();
              
    [GeneratedRegex(@"х")]
    private static partial Regex Rule12();
                   
    [GeneratedRegex(@"ch")]
    private static partial Regex RuleReverse12();
              
    [GeneratedRegex(@"Й(?=[auAUауАУ])")]
    private static partial Regex Rule13();
                   
    [GeneratedRegex(@"J-(?=[auAUауАУ])")]
    private static partial Regex RuleReverse13();
              
    [GeneratedRegex(@"й(?=[auау])")]
    private static partial Regex Rule14();
                   
    [GeneratedRegex(@"j-(?=[auау])")]
    private static partial Regex RuleReverse14();
              
    [GeneratedRegex(@"Ш(?=[tTтТ])")]
    private static partial Regex Rule15();
                   
    [GeneratedRegex(@"Š-(?=[tTтТ])")]
    private static partial Regex RuleReverse15();
              
    [GeneratedRegex(@"ш(?=[tт])")]
    private static partial Regex Rule16();
                   
    [GeneratedRegex(@"š-(?=[tт])")]
    private static partial Regex RuleReverse16();
              
    [GeneratedRegex(@"А")]
    private static partial Regex Rule17();
                   
    [GeneratedRegex(@"A")]
    private static partial Regex RuleReverse17();
              
    [GeneratedRegex(@"а")]
    private static partial Regex Rule18();
                   
    [GeneratedRegex(@"a")]
    private static partial Regex RuleReverse18();
              
    [GeneratedRegex(@"Б")]
    private static partial Regex Rule19();
                   
    [GeneratedRegex(@"B")]
    private static partial Regex RuleReverse19();
              
    [GeneratedRegex(@"б")]
    private static partial Regex Rule20();
                   
    [GeneratedRegex(@"b")]
    private static partial Regex RuleReverse20();
              
    [GeneratedRegex(@"В")]
    private static partial Regex Rule21();
                   
    [GeneratedRegex(@"V")]
    private static partial Regex RuleReverse21();
              
    [GeneratedRegex(@"в")]
    private static partial Regex Rule22();
                   
    [GeneratedRegex(@"v")]
    private static partial Regex RuleReverse22();
              
    [GeneratedRegex(@"Г")]
    private static partial Regex Rule23();
                   
    [GeneratedRegex(@"G")]
    private static partial Regex RuleReverse23();
              
    [GeneratedRegex(@"г")]
    private static partial Regex Rule24();
                   
    [GeneratedRegex(@"g")]
    private static partial Regex RuleReverse24();
              
    [GeneratedRegex(@"Д")]
    private static partial Regex Rule25();
                   
    [GeneratedRegex(@"D")]
    private static partial Regex RuleReverse25();
              
    [GeneratedRegex(@"д")]
    private static partial Regex Rule26();
                   
    [GeneratedRegex(@"d")]
    private static partial Regex RuleReverse26();
              
    [GeneratedRegex(@"Е")]
    private static partial Regex Rule27();
                   
    [GeneratedRegex(@"E")]
    private static partial Regex RuleReverse27();
              
    [GeneratedRegex(@"е")]
    private static partial Regex Rule28();
                   
    [GeneratedRegex(@"e")]
    private static partial Regex RuleReverse28();
              
    [GeneratedRegex(@"Ж")]
    private static partial Regex Rule29();
                   
    [GeneratedRegex(@"Ž")]
    private static partial Regex RuleReverse29();
              
    [GeneratedRegex(@"ж")]
    private static partial Regex Rule30();
                   
    [GeneratedRegex(@"ž")]
    private static partial Regex RuleReverse30();
              
    [GeneratedRegex(@"З")]
    private static partial Regex Rule31();
                   
    [GeneratedRegex(@"Z")]
    private static partial Regex RuleReverse31();
              
    [GeneratedRegex(@"з")]
    private static partial Regex Rule32();
                   
    [GeneratedRegex(@"z")]
    private static partial Regex RuleReverse32();
              
    [GeneratedRegex(@"И")]
    private static partial Regex Rule33();
                   
    [GeneratedRegex(@"I")]
    private static partial Regex RuleReverse33();
              
    [GeneratedRegex(@"и")]
    private static partial Regex Rule34();
                   
    [GeneratedRegex(@"i")]
    private static partial Regex RuleReverse34();
              
    [GeneratedRegex(@"Й")]
    private static partial Regex Rule35();
                   
    [GeneratedRegex(@"J")]
    private static partial Regex RuleReverse35();
              
    [GeneratedRegex(@"й")]
    private static partial Regex Rule36();
                   
    [GeneratedRegex(@"j")]
    private static partial Regex RuleReverse36();
              
    [GeneratedRegex(@"К")]
    private static partial Regex Rule37();
                   
    [GeneratedRegex(@"K")]
    private static partial Regex RuleReverse37();
              
    [GeneratedRegex(@"к")]
    private static partial Regex Rule38();
                   
    [GeneratedRegex(@"k")]
    private static partial Regex RuleReverse38();
              
    [GeneratedRegex(@"Л")]
    private static partial Regex Rule39();
                   
    [GeneratedRegex(@"L")]
    private static partial Regex RuleReverse39();
              
    [GeneratedRegex(@"л")]
    private static partial Regex Rule40();
                   
    [GeneratedRegex(@"l")]
    private static partial Regex RuleReverse40();
              
    [GeneratedRegex(@"М")]
    private static partial Regex Rule41();
                   
    [GeneratedRegex(@"M")]
    private static partial Regex RuleReverse41();
              
    [GeneratedRegex(@"м")]
    private static partial Regex Rule42();
                   
    [GeneratedRegex(@"m")]
    private static partial Regex RuleReverse42();
              
    [GeneratedRegex(@"Н")]
    private static partial Regex Rule43();
                   
    [GeneratedRegex(@"N")]
    private static partial Regex RuleReverse43();
              
    [GeneratedRegex(@"н")]
    private static partial Regex Rule44();
                   
    [GeneratedRegex(@"n")]
    private static partial Regex RuleReverse44();
              
    [GeneratedRegex(@"О")]
    private static partial Regex Rule45();
                   
    [GeneratedRegex(@"O")]
    private static partial Regex RuleReverse45();
              
    [GeneratedRegex(@"о")]
    private static partial Regex Rule46();
                   
    [GeneratedRegex(@"o")]
    private static partial Regex RuleReverse46();
              
    [GeneratedRegex(@"П")]
    private static partial Regex Rule47();
                   
    [GeneratedRegex(@"P")]
    private static partial Regex RuleReverse47();
              
    [GeneratedRegex(@"п")]
    private static partial Regex Rule48();
                   
    [GeneratedRegex(@"p")]
    private static partial Regex RuleReverse48();
              
    [GeneratedRegex(@"Р")]
    private static partial Regex Rule49();
                   
    [GeneratedRegex(@"R")]
    private static partial Regex RuleReverse49();
              
    [GeneratedRegex(@"р")]
    private static partial Regex Rule50();
                   
    [GeneratedRegex(@"r")]
    private static partial Regex RuleReverse50();
              
    [GeneratedRegex(@"Т")]
    private static partial Regex Rule51();
                   
    [GeneratedRegex(@"T")]
    private static partial Regex RuleReverse51();
              
    [GeneratedRegex(@"т")]
    private static partial Regex Rule52();
                   
    [GeneratedRegex(@"t")]
    private static partial Regex RuleReverse52();
              
    [GeneratedRegex(@"У")]
    private static partial Regex Rule53();
                   
    [GeneratedRegex(@"U")]
    private static partial Regex RuleReverse53();
              
    [GeneratedRegex(@"у")]
    private static partial Regex Rule54();
                   
    [GeneratedRegex(@"u")]
    private static partial Regex RuleReverse54();
              
    [GeneratedRegex(@"Ф")]
    private static partial Regex Rule55();
                   
    [GeneratedRegex(@"F")]
    private static partial Regex RuleReverse55();
              
    [GeneratedRegex(@"ф")]
    private static partial Regex Rule56();
                   
    [GeneratedRegex(@"f")]
    private static partial Regex RuleReverse56();
              
    [GeneratedRegex(@"Ц")]
    private static partial Regex Rule57();
                   
    [GeneratedRegex(@"C")]
    private static partial Regex RuleReverse57();
              
    [GeneratedRegex(@"ц")]
    private static partial Regex Rule58();
                   
    [GeneratedRegex(@"c")]
    private static partial Regex RuleReverse58();
              
    [GeneratedRegex(@"С")]
    private static partial Regex Rule59();
                   
    [GeneratedRegex(@"S")]
    private static partial Regex RuleReverse59();
              
    [GeneratedRegex(@"с")]
    private static partial Regex Rule60();
                   
    [GeneratedRegex(@"s")]
    private static partial Regex RuleReverse60();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule61();
                   
    [GeneratedRegex(@"Č")]
    private static partial Regex RuleReverse61();
              
    [GeneratedRegex(@"ч")]
    private static partial Regex Rule62();
                   
    [GeneratedRegex(@"č")]
    private static partial Regex RuleReverse62();
              
    [GeneratedRegex(@"Ш")]
    private static partial Regex Rule63();
                   
    [GeneratedRegex(@"Š")]
    private static partial Regex RuleReverse63();
              
    [GeneratedRegex(@"ш")]
    private static partial Regex Rule64();
                   
    [GeneratedRegex(@"š")]
    private static partial Regex RuleReverse64();
              
    [GeneratedRegex(@"Ъ")]
    private static partial Regex Rule65();
                   
    [GeneratedRegex(@"Ă")]
    private static partial Regex RuleReverse65();
              
    [GeneratedRegex(@"ъ")]
    private static partial Regex Rule66();
                   
    [GeneratedRegex(@"ă")]
    private static partial Regex RuleReverse66();
              
    [GeneratedRegex(@"(?<=\p{Lu})Ь")]
    private static partial Regex Rule67();
                   
    [GeneratedRegex(@"(?<=\p{Lu})'")]
    private static partial Regex RuleReverse67();
              
    [GeneratedRegex(@"ь")]
    private static partial Regex Rule68();
                   
    [GeneratedRegex(@"'")]
    private static partial Regex RuleReverse68();

}
