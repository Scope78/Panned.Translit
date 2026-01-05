using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_din_1460_ukr : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.din_1460_ukr;

    public override bool IsReversable => true;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"je");
        output = Rule2().Replace(output, @"JE");
        output = Rule3().Replace(output, @"Je");
        output = Rule4().Replace(output, @"ch");
        output = Rule5().Replace(output, @"CH");
        output = Rule6().Replace(output, @"Ch");
        output = Rule7().Replace(output, @"šč");
        output = Rule8().Replace(output, @"ŠČ");
        output = Rule9().Replace(output, @"Šč");
        output = Rule10().Replace(output, @"ju");
        output = Rule11().Replace(output, @"JU");
        output = Rule12().Replace(output, @"Ju");
        output = Rule13().Replace(output, @"ja");
        output = Rule14().Replace(output, @"JA");
        output = Rule15().Replace(output, @"Ja");
        output = Rule16().Replace(output, @"J-");
        output = Rule17().Replace(output, @"j-");
        output = Rule18().Replace(output, @"Š-");
        output = Rule19().Replace(output, @"š-");
        output = Rule20().Replace(output, @"c-");
        output = Rule21().Replace(output, @"C-");
        output = Rule22().Replace(output, @"a");
        output = Rule23().Replace(output, @"A");
        output = Rule24().Replace(output, @"b");
        output = Rule25().Replace(output, @"B");
        output = Rule26().Replace(output, @"v");
        output = Rule27().Replace(output, @"V");
        output = Rule28().Replace(output, @"h");
        output = Rule29().Replace(output, @"H");
        output = Rule30().Replace(output, @"g");
        output = Rule31().Replace(output, @"G");
        output = Rule32().Replace(output, @"d");
        output = Rule33().Replace(output, @"D");
        output = Rule34().Replace(output, @"e");
        output = Rule35().Replace(output, @"E");
        output = Rule36().Replace(output, @"ž");
        output = Rule37().Replace(output, @"Ž");
        output = Rule38().Replace(output, @"z");
        output = Rule39().Replace(output, @"Z");
        output = Rule40().Replace(output, @"y");
        output = Rule41().Replace(output, @"Y");
        output = Rule42().Replace(output, @"i");
        output = Rule43().Replace(output, @"I");
        output = Rule44().Replace(output, @"ï");
        output = Rule45().Replace(output, @"Ï");
        output = Rule46().Replace(output, @"j");
        output = Rule47().Replace(output, @"J");
        output = Rule48().Replace(output, @"k");
        output = Rule49().Replace(output, @"K");
        output = Rule50().Replace(output, @"l");
        output = Rule51().Replace(output, @"L");
        output = Rule52().Replace(output, @"m");
        output = Rule53().Replace(output, @"M");
        output = Rule54().Replace(output, @"n");
        output = Rule55().Replace(output, @"N");
        output = Rule56().Replace(output, @"o");
        output = Rule57().Replace(output, @"O");
        output = Rule58().Replace(output, @"p");
        output = Rule59().Replace(output, @"P");
        output = Rule60().Replace(output, @"r");
        output = Rule61().Replace(output, @"R");
        output = Rule62().Replace(output, @"s");
        output = Rule63().Replace(output, @"S");
        output = Rule64().Replace(output, @"t");
        output = Rule65().Replace(output, @"T");
        output = Rule66().Replace(output, @"u");
        output = Rule67().Replace(output, @"U");
        output = Rule68().Replace(output, @"f");
        output = Rule69().Replace(output, @"F");
        output = Rule70().Replace(output, @"c");
        output = Rule71().Replace(output, @"C");
        output = Rule72().Replace(output, @"č");
        output = Rule73().Replace(output, @"Č");
        output = Rule74().Replace(output, @"š");
        output = Rule75().Replace(output, @"Š");
        output = Rule76().Replace(output, @"'");
        output = Rule77().Replace(output, @"'");
        output = Rule78().Replace(output, @"ˮ");

        return output;
    }

    public override string Reverse(string input)
    {
        string output = input;

        output = RuleReverse1().Replace(output, @"є");
        output = RuleReverse2().Replace(output, @"Є");
        output = RuleReverse3().Replace(output, @"Є");
        output = RuleReverse4().Replace(output, @"х");
        output = RuleReverse5().Replace(output, @"Х");
        output = RuleReverse6().Replace(output, @"Х");
        output = RuleReverse7().Replace(output, @"щ");
        output = RuleReverse8().Replace(output, @"Щ");
        output = RuleReverse9().Replace(output, @"Щ");
        output = RuleReverse10().Replace(output, @"ю");
        output = RuleReverse11().Replace(output, @"Ю");
        output = RuleReverse12().Replace(output, @"Ю");
        output = RuleReverse13().Replace(output, @"я");
        output = RuleReverse14().Replace(output, @"Я");
        output = RuleReverse15().Replace(output, @"Я");
        output = RuleReverse16().Replace(output, @"Й");
        output = RuleReverse17().Replace(output, @"й");
        output = RuleReverse18().Replace(output, @"Ш");
        output = RuleReverse19().Replace(output, @"ш");
        output = RuleReverse20().Replace(output, @"ц");
        output = RuleReverse21().Replace(output, @"Ц");
        output = RuleReverse22().Replace(output, @"а");
        output = RuleReverse23().Replace(output, @"А");
        output = RuleReverse24().Replace(output, @"б");
        output = RuleReverse25().Replace(output, @"Б");
        output = RuleReverse26().Replace(output, @"в");
        output = RuleReverse27().Replace(output, @"В");
        output = RuleReverse28().Replace(output, @"г");
        output = RuleReverse29().Replace(output, @"Г");
        output = RuleReverse30().Replace(output, @"ґ");
        output = RuleReverse31().Replace(output, @"Ґ");
        output = RuleReverse32().Replace(output, @"д");
        output = RuleReverse33().Replace(output, @"Д");
        output = RuleReverse34().Replace(output, @"е");
        output = RuleReverse35().Replace(output, @"Е");
        output = RuleReverse36().Replace(output, @"ж");
        output = RuleReverse37().Replace(output, @"Ж");
        output = RuleReverse38().Replace(output, @"з");
        output = RuleReverse39().Replace(output, @"З");
        output = RuleReverse40().Replace(output, @"и");
        output = RuleReverse41().Replace(output, @"И");
        output = RuleReverse42().Replace(output, @"і");
        output = RuleReverse43().Replace(output, @"І");
        output = RuleReverse44().Replace(output, @"ї");
        output = RuleReverse45().Replace(output, @"Ї");
        output = RuleReverse46().Replace(output, @"й");
        output = RuleReverse47().Replace(output, @"Й");
        output = RuleReverse48().Replace(output, @"к");
        output = RuleReverse49().Replace(output, @"К");
        output = RuleReverse50().Replace(output, @"л");
        output = RuleReverse51().Replace(output, @"Л");
        output = RuleReverse52().Replace(output, @"м");
        output = RuleReverse53().Replace(output, @"М");
        output = RuleReverse54().Replace(output, @"н");
        output = RuleReverse55().Replace(output, @"Н");
        output = RuleReverse56().Replace(output, @"о");
        output = RuleReverse57().Replace(output, @"О");
        output = RuleReverse58().Replace(output, @"п");
        output = RuleReverse59().Replace(output, @"П");
        output = RuleReverse60().Replace(output, @"р");
        output = RuleReverse61().Replace(output, @"Р");
        output = RuleReverse62().Replace(output, @"с");
        output = RuleReverse63().Replace(output, @"С");
        output = RuleReverse64().Replace(output, @"т");
        output = RuleReverse65().Replace(output, @"Т");
        output = RuleReverse66().Replace(output, @"у");
        output = RuleReverse67().Replace(output, @"У");
        output = RuleReverse68().Replace(output, @"ф");
        output = RuleReverse69().Replace(output, @"Ф");
        output = RuleReverse70().Replace(output, @"ц");
        output = RuleReverse71().Replace(output, @"Ц");
        output = RuleReverse72().Replace(output, @"ч");
        output = RuleReverse73().Replace(output, @"Ч");
        output = RuleReverse74().Replace(output, @"ш");
        output = RuleReverse75().Replace(output, @"Ш");
        output = RuleReverse76().Replace(output, @"Ь");
        output = RuleReverse77().Replace(output, @"ь");
        output = RuleReverse78().Replace(output, @"ʼ");

        return output;
    }
              
    [GeneratedRegex(@"є")]
    private static partial Regex Rule1();
                   
    [GeneratedRegex(@"je")]
    private static partial Regex RuleReverse1();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Є(?=[\p{Lu}\s])")]
    private static partial Regex Rule2();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])JE(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse2();
              
    [GeneratedRegex(@"Є")]
    private static partial Regex Rule3();
                   
    [GeneratedRegex(@"Je")]
    private static partial Regex RuleReverse3();
              
    [GeneratedRegex(@"х")]
    private static partial Regex Rule4();
                   
    [GeneratedRegex(@"ch")]
    private static partial Regex RuleReverse4();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Х(?=[\p{Lu}\s])")]
    private static partial Regex Rule5();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])CH(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse5();
              
    [GeneratedRegex(@"Х")]
    private static partial Regex Rule6();
                   
    [GeneratedRegex(@"Ch")]
    private static partial Regex RuleReverse6();
              
    [GeneratedRegex(@"щ")]
    private static partial Regex Rule7();
                   
    [GeneratedRegex(@"šč")]
    private static partial Regex RuleReverse7();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Щ(?=[\p{Lu}\s])")]
    private static partial Regex Rule8();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])ŠČ(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse8();
              
    [GeneratedRegex(@"Щ")]
    private static partial Regex Rule9();
                   
    [GeneratedRegex(@"Šč")]
    private static partial Regex RuleReverse9();
              
    [GeneratedRegex(@"ю")]
    private static partial Regex Rule10();
                   
    [GeneratedRegex(@"ju")]
    private static partial Regex RuleReverse10();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Ю(?=[\p{Lu}\s])")]
    private static partial Regex Rule11();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])JU(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse11();
              
    [GeneratedRegex(@"Ю")]
    private static partial Regex Rule12();
                   
    [GeneratedRegex(@"Ju")]
    private static partial Regex RuleReverse12();
              
    [GeneratedRegex(@"я")]
    private static partial Regex Rule13();
                   
    [GeneratedRegex(@"ja")]
    private static partial Regex RuleReverse13();
              
    [GeneratedRegex(@"(?<=[\p{Lu}\s])Я(?=[\p{Lu}\s])")]
    private static partial Regex Rule14();
                   
    [GeneratedRegex(@"(?<=[\p{Lu}\s])JA(?=[\p{Lu}\s])")]
    private static partial Regex RuleReverse14();
              
    [GeneratedRegex(@"Я")]
    private static partial Regex Rule15();
                   
    [GeneratedRegex(@"Ja")]
    private static partial Regex RuleReverse15();
              
    [GeneratedRegex(@"Й(?=[aueAUEауеАУЕ])")]
    private static partial Regex Rule16();
                   
    [GeneratedRegex(@"J-(?=[aueAUEауеАУЕ])")]
    private static partial Regex RuleReverse16();
              
    [GeneratedRegex(@"й(?=[aueауе])")]
    private static partial Regex Rule17();
                   
    [GeneratedRegex(@"j-(?=[aueауе])")]
    private static partial Regex RuleReverse17();
              
    [GeneratedRegex(@"Ш(?=[ČčЧч])")]
    private static partial Regex Rule18();
                   
    [GeneratedRegex(@"Š-(?=[ČčЧч])")]
    private static partial Regex RuleReverse18();
              
    [GeneratedRegex(@"ш(?=[čч])")]
    private static partial Regex Rule19();
                   
    [GeneratedRegex(@"š-(?=[čч])")]
    private static partial Regex RuleReverse19();
              
    [GeneratedRegex(@"ц(?=[hг])")]
    private static partial Regex Rule20();
                   
    [GeneratedRegex(@"c-(?=[hг])")]
    private static partial Regex RuleReverse20();
              
    [GeneratedRegex(@"Ц(?=[hHгГ])")]
    private static partial Regex Rule21();
                   
    [GeneratedRegex(@"C-(?=[hHгГ])")]
    private static partial Regex RuleReverse21();
              
    [GeneratedRegex(@"а")]
    private static partial Regex Rule22();
                   
    [GeneratedRegex(@"a")]
    private static partial Regex RuleReverse22();
              
    [GeneratedRegex(@"А")]
    private static partial Regex Rule23();
                   
    [GeneratedRegex(@"A")]
    private static partial Regex RuleReverse23();
              
    [GeneratedRegex(@"б")]
    private static partial Regex Rule24();
                   
    [GeneratedRegex(@"b")]
    private static partial Regex RuleReverse24();
              
    [GeneratedRegex(@"Б")]
    private static partial Regex Rule25();
                   
    [GeneratedRegex(@"B")]
    private static partial Regex RuleReverse25();
              
    [GeneratedRegex(@"в")]
    private static partial Regex Rule26();
                   
    [GeneratedRegex(@"v")]
    private static partial Regex RuleReverse26();
              
    [GeneratedRegex(@"В")]
    private static partial Regex Rule27();
                   
    [GeneratedRegex(@"V")]
    private static partial Regex RuleReverse27();
              
    [GeneratedRegex(@"г")]
    private static partial Regex Rule28();
                   
    [GeneratedRegex(@"h")]
    private static partial Regex RuleReverse28();
              
    [GeneratedRegex(@"Г")]
    private static partial Regex Rule29();
                   
    [GeneratedRegex(@"H")]
    private static partial Regex RuleReverse29();
              
    [GeneratedRegex(@"ґ")]
    private static partial Regex Rule30();
                   
    [GeneratedRegex(@"g")]
    private static partial Regex RuleReverse30();
              
    [GeneratedRegex(@"Ґ")]
    private static partial Regex Rule31();
                   
    [GeneratedRegex(@"G")]
    private static partial Regex RuleReverse31();
              
    [GeneratedRegex(@"д")]
    private static partial Regex Rule32();
                   
    [GeneratedRegex(@"d")]
    private static partial Regex RuleReverse32();
              
    [GeneratedRegex(@"Д")]
    private static partial Regex Rule33();
                   
    [GeneratedRegex(@"D")]
    private static partial Regex RuleReverse33();
              
    [GeneratedRegex(@"е")]
    private static partial Regex Rule34();
                   
    [GeneratedRegex(@"e")]
    private static partial Regex RuleReverse34();
              
    [GeneratedRegex(@"Е")]
    private static partial Regex Rule35();
                   
    [GeneratedRegex(@"E")]
    private static partial Regex RuleReverse35();
              
    [GeneratedRegex(@"ж")]
    private static partial Regex Rule36();
                   
    [GeneratedRegex(@"ž")]
    private static partial Regex RuleReverse36();
              
    [GeneratedRegex(@"Ж")]
    private static partial Regex Rule37();
                   
    [GeneratedRegex(@"Ž")]
    private static partial Regex RuleReverse37();
              
    [GeneratedRegex(@"з")]
    private static partial Regex Rule38();
                   
    [GeneratedRegex(@"z")]
    private static partial Regex RuleReverse38();
              
    [GeneratedRegex(@"З")]
    private static partial Regex Rule39();
                   
    [GeneratedRegex(@"Z")]
    private static partial Regex RuleReverse39();
              
    [GeneratedRegex(@"и")]
    private static partial Regex Rule40();
                   
    [GeneratedRegex(@"y")]
    private static partial Regex RuleReverse40();
              
    [GeneratedRegex(@"И")]
    private static partial Regex Rule41();
                   
    [GeneratedRegex(@"Y")]
    private static partial Regex RuleReverse41();
              
    [GeneratedRegex(@"і")]
    private static partial Regex Rule42();
                   
    [GeneratedRegex(@"i")]
    private static partial Regex RuleReverse42();
              
    [GeneratedRegex(@"І")]
    private static partial Regex Rule43();
                   
    [GeneratedRegex(@"I")]
    private static partial Regex RuleReverse43();
              
    [GeneratedRegex(@"ї")]
    private static partial Regex Rule44();
                   
    [GeneratedRegex(@"ï")]
    private static partial Regex RuleReverse44();
              
    [GeneratedRegex(@"Ї")]
    private static partial Regex Rule45();
                   
    [GeneratedRegex(@"Ï")]
    private static partial Regex RuleReverse45();
              
    [GeneratedRegex(@"й")]
    private static partial Regex Rule46();
                   
    [GeneratedRegex(@"j")]
    private static partial Regex RuleReverse46();
              
    [GeneratedRegex(@"Й")]
    private static partial Regex Rule47();
                   
    [GeneratedRegex(@"J")]
    private static partial Regex RuleReverse47();
              
    [GeneratedRegex(@"к")]
    private static partial Regex Rule48();
                   
    [GeneratedRegex(@"k")]
    private static partial Regex RuleReverse48();
              
    [GeneratedRegex(@"К")]
    private static partial Regex Rule49();
                   
    [GeneratedRegex(@"K")]
    private static partial Regex RuleReverse49();
              
    [GeneratedRegex(@"л")]
    private static partial Regex Rule50();
                   
    [GeneratedRegex(@"l")]
    private static partial Regex RuleReverse50();
              
    [GeneratedRegex(@"Л")]
    private static partial Regex Rule51();
                   
    [GeneratedRegex(@"L")]
    private static partial Regex RuleReverse51();
              
    [GeneratedRegex(@"м")]
    private static partial Regex Rule52();
                   
    [GeneratedRegex(@"m")]
    private static partial Regex RuleReverse52();
              
    [GeneratedRegex(@"М")]
    private static partial Regex Rule53();
                   
    [GeneratedRegex(@"M")]
    private static partial Regex RuleReverse53();
              
    [GeneratedRegex(@"н")]
    private static partial Regex Rule54();
                   
    [GeneratedRegex(@"n")]
    private static partial Regex RuleReverse54();
              
    [GeneratedRegex(@"Н")]
    private static partial Regex Rule55();
                   
    [GeneratedRegex(@"N")]
    private static partial Regex RuleReverse55();
              
    [GeneratedRegex(@"о")]
    private static partial Regex Rule56();
                   
    [GeneratedRegex(@"o")]
    private static partial Regex RuleReverse56();
              
    [GeneratedRegex(@"О")]
    private static partial Regex Rule57();
                   
    [GeneratedRegex(@"O")]
    private static partial Regex RuleReverse57();
              
    [GeneratedRegex(@"п")]
    private static partial Regex Rule58();
                   
    [GeneratedRegex(@"p")]
    private static partial Regex RuleReverse58();
              
    [GeneratedRegex(@"П")]
    private static partial Regex Rule59();
                   
    [GeneratedRegex(@"P")]
    private static partial Regex RuleReverse59();
              
    [GeneratedRegex(@"р")]
    private static partial Regex Rule60();
                   
    [GeneratedRegex(@"r")]
    private static partial Regex RuleReverse60();
              
    [GeneratedRegex(@"Р")]
    private static partial Regex Rule61();
                   
    [GeneratedRegex(@"R")]
    private static partial Regex RuleReverse61();
              
    [GeneratedRegex(@"с")]
    private static partial Regex Rule62();
                   
    [GeneratedRegex(@"s")]
    private static partial Regex RuleReverse62();
              
    [GeneratedRegex(@"С")]
    private static partial Regex Rule63();
                   
    [GeneratedRegex(@"S")]
    private static partial Regex RuleReverse63();
              
    [GeneratedRegex(@"т")]
    private static partial Regex Rule64();
                   
    [GeneratedRegex(@"t")]
    private static partial Regex RuleReverse64();
              
    [GeneratedRegex(@"Т")]
    private static partial Regex Rule65();
                   
    [GeneratedRegex(@"T")]
    private static partial Regex RuleReverse65();
              
    [GeneratedRegex(@"у")]
    private static partial Regex Rule66();
                   
    [GeneratedRegex(@"u")]
    private static partial Regex RuleReverse66();
              
    [GeneratedRegex(@"У")]
    private static partial Regex Rule67();
                   
    [GeneratedRegex(@"U")]
    private static partial Regex RuleReverse67();
              
    [GeneratedRegex(@"ф")]
    private static partial Regex Rule68();
                   
    [GeneratedRegex(@"f")]
    private static partial Regex RuleReverse68();
              
    [GeneratedRegex(@"Ф")]
    private static partial Regex Rule69();
                   
    [GeneratedRegex(@"F")]
    private static partial Regex RuleReverse69();
              
    [GeneratedRegex(@"ц")]
    private static partial Regex Rule70();
                   
    [GeneratedRegex(@"c")]
    private static partial Regex RuleReverse70();
              
    [GeneratedRegex(@"Ц")]
    private static partial Regex Rule71();
                   
    [GeneratedRegex(@"C")]
    private static partial Regex RuleReverse71();
              
    [GeneratedRegex(@"ч")]
    private static partial Regex Rule72();
                   
    [GeneratedRegex(@"č")]
    private static partial Regex RuleReverse72();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule73();
                   
    [GeneratedRegex(@"Č")]
    private static partial Regex RuleReverse73();
              
    [GeneratedRegex(@"ш")]
    private static partial Regex Rule74();
                   
    [GeneratedRegex(@"š")]
    private static partial Regex RuleReverse74();
              
    [GeneratedRegex(@"Ш")]
    private static partial Regex Rule75();
                   
    [GeneratedRegex(@"Š")]
    private static partial Regex RuleReverse75();
              
    [GeneratedRegex(@"(?<=\p{Lu})Ь")]
    private static partial Regex Rule76();
                   
    [GeneratedRegex(@"(?<=\p{Lu})'")]
    private static partial Regex RuleReverse76();
              
    [GeneratedRegex(@"ь")]
    private static partial Regex Rule77();
                   
    [GeneratedRegex(@"'")]
    private static partial Regex RuleReverse77();
              
    [GeneratedRegex(@"ʼ")]
    private static partial Regex Rule78();
                   
    [GeneratedRegex(@"ˮ")]
    private static partial Regex RuleReverse78();

}
