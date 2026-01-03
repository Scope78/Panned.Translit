using System;
using System.Text.RegularExpressions;
using System.IO;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_iso_r_9 : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.iso_r_9;

    public override bool IsReversable => true;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"A");
        output = Rule2().Replace(output, @"a");
        output = Rule3().Replace(output, @"B");
        output = Rule4().Replace(output, @"b");
        output = Rule5().Replace(output, @"V");
        output = Rule6().Replace(output, @"v");
        output = Rule7().Replace(output, @"G");
        output = Rule8().Replace(output, @"g");
        output = Rule9().Replace(output, @"G̀");
        output = Rule10().Replace(output, @"g̀");
        output = Rule11().Replace(output, @"D");
        output = Rule12().Replace(output, @"d");
        output = Rule13().Replace(output, @"Ǵ");
        output = Rule14().Replace(output, @"ǵ");
        output = Rule15().Replace(output, @"Đ");
        output = Rule16().Replace(output, @"đ");
        output = Rule17().Replace(output, @"E");
        output = Rule18().Replace(output, @"e");
        output = Rule19().Replace(output, @"Ë");
        output = Rule20().Replace(output, @"ë");
        output = Rule21().Replace(output, @"Je");
        output = Rule22().Replace(output, @"je");
        output = Rule23().Replace(output, @"Ž");
        output = Rule24().Replace(output, @"ž");
        output = Rule25().Replace(output, @"Z");
        output = Rule26().Replace(output, @"z");
        output = Rule27().Replace(output, @"Dz");
        output = Rule28().Replace(output, @"dz");
        output = Rule29().Replace(output, @"I");
        output = Rule30().Replace(output, @"i");
        output = Rule31().Replace(output, @"I");
        output = Rule32().Replace(output, @"i");
        output = Rule33().Replace(output, @"Ji");
        output = Rule34().Replace(output, @"ji");
        output = Rule35().Replace(output, @"J");
        output = Rule36().Replace(output, @"j");
        output = Rule37().Replace(output, @"J");
        output = Rule38().Replace(output, @"j");
        output = Rule39().Replace(output, @"K");
        output = Rule40().Replace(output, @"k");
        output = Rule41().Replace(output, @"L");
        output = Rule42().Replace(output, @"l");
        output = Rule43().Replace(output, @"LJ");
        output = Rule44().Replace(output, @"Lj");
        output = Rule45().Replace(output, @"lj");
        output = Rule46().Replace(output, @"M");
        output = Rule47().Replace(output, @"m");
        output = Rule48().Replace(output, @"N");
        output = Rule49().Replace(output, @"n");
        output = Rule50().Replace(output, @"NJ");
        output = Rule51().Replace(output, @"Nj");
        output = Rule52().Replace(output, @"nj");
        output = Rule53().Replace(output, @"O");
        output = Rule54().Replace(output, @"o");
        output = Rule55().Replace(output, @"P");
        output = Rule56().Replace(output, @"p");
        output = Rule57().Replace(output, @"R");
        output = Rule58().Replace(output, @"r");
        output = Rule59().Replace(output, @"S");
        output = Rule60().Replace(output, @"s");
        output = Rule61().Replace(output, @"T");
        output = Rule62().Replace(output, @"t");
        output = Rule63().Replace(output, @"Ḱ");
        output = Rule64().Replace(output, @"ḱ");
        output = Rule65().Replace(output, @"Ć");
        output = Rule66().Replace(output, @"ć");
        output = Rule67().Replace(output, @"U");
        output = Rule68().Replace(output, @"u");
        output = Rule69().Replace(output, @"Ŭ");
        output = Rule70().Replace(output, @"ŭ");
        output = Rule71().Replace(output, @"F");
        output = Rule72().Replace(output, @"f");
        output = Rule73().Replace(output, @"H");
        output = Rule74().Replace(output, @"h");
        output = Rule75().Replace(output, @"C");
        output = Rule76().Replace(output, @"c");
        output = Rule77().Replace(output, @"Č");
        output = Rule78().Replace(output, @"č");
        output = Rule79().Replace(output, @"DŽ");
        output = Rule80().Replace(output, @"Dž");
        output = Rule81().Replace(output, @"dž");
        output = Rule82().Replace(output, @"Š");
        output = Rule83().Replace(output, @"š");
        output = Rule84().Replace(output, @"ŠČ");
        output = Rule85().Replace(output, @"šč");
        output = Rule86().Replace(output, @"Y");
        output = Rule87().Replace(output, @"y");
        output = Rule88().Replace(output, @"Y");
        output = Rule89().Replace(output, @"y");
        output = Rule90().Replace(output, @"ʹ");
        output = Rule91().Replace(output, @"ʹ");
        output = Rule92().Replace(output, @"Ě");
        output = Rule93().Replace(output, @"ě");
        output = Rule94().Replace(output, @"È");
        output = Rule95().Replace(output, @"è");
        output = Rule96().Replace(output, @"JU");
        output = Rule97().Replace(output, @"Ju");
        output = Rule98().Replace(output, @"ju");
        output = Rule99().Replace(output, @"JA");
        output = Rule100().Replace(output, @"Ja");
        output = Rule101().Replace(output, @"ja");
        output = Rule102().Replace(output, @"Ȧ");
        output = Rule103().Replace(output, @"ȧ");
        output = Rule104().Replace(output, @"Ḟ");
        output = Rule105().Replace(output, @"ḟ");
        output = Rule106().Replace(output, @"Ẏ");
        output = Rule107().Replace(output, @"ẏ");

        return output;
    }

    public override string Reverse(string input)
    {
        string output = input;

        output = RuleReverse1().Replace(output, @"А");
        output = RuleReverse2().Replace(output, @"а");
        output = RuleReverse3().Replace(output, @"Б");
        output = RuleReverse4().Replace(output, @"б");
        output = RuleReverse5().Replace(output, @"В");
        output = RuleReverse6().Replace(output, @"в");
        output = RuleReverse7().Replace(output, @"Г");
        output = RuleReverse8().Replace(output, @"г");
        output = RuleReverse9().Replace(output, @"Ґ");
        output = RuleReverse10().Replace(output, @"ґ");
        output = RuleReverse11().Replace(output, @"Д");
        output = RuleReverse12().Replace(output, @"д");
        output = RuleReverse13().Replace(output, @"Ѓ");
        output = RuleReverse14().Replace(output, @"ѓ");
        output = RuleReverse15().Replace(output, @"Ђ");
        output = RuleReverse16().Replace(output, @"ђ");
        output = RuleReverse17().Replace(output, @"Е");
        output = RuleReverse18().Replace(output, @"е");
        output = RuleReverse19().Replace(output, @"Ё");
        output = RuleReverse20().Replace(output, @"ё");
        output = RuleReverse21().Replace(output, @"Є");
        output = RuleReverse22().Replace(output, @"є");
        output = RuleReverse23().Replace(output, @"Ж");
        output = RuleReverse24().Replace(output, @"ж");
        output = RuleReverse25().Replace(output, @"З");
        output = RuleReverse26().Replace(output, @"з");
        output = RuleReverse27().Replace(output, @"Ѕ");
        output = RuleReverse28().Replace(output, @"ѕ");
        output = RuleReverse29().Replace(output, @"И");
        output = RuleReverse30().Replace(output, @"и");
        output = RuleReverse31().Replace(output, @"І");
        output = RuleReverse32().Replace(output, @"і");
        output = RuleReverse33().Replace(output, @"Ї");
        output = RuleReverse34().Replace(output, @"ї");
        output = RuleReverse35().Replace(output, @"Й");
        output = RuleReverse36().Replace(output, @"й");
        output = RuleReverse37().Replace(output, @"Ј");
        output = RuleReverse38().Replace(output, @"ј");
        output = RuleReverse39().Replace(output, @"К");
        output = RuleReverse40().Replace(output, @"к");
        output = RuleReverse41().Replace(output, @"Л");
        output = RuleReverse42().Replace(output, @"л");
        output = RuleReverse43().Replace(output, @"Љ");
        output = RuleReverse44().Replace(output, @"Љ");
        output = RuleReverse45().Replace(output, @"љ");
        output = RuleReverse46().Replace(output, @"М");
        output = RuleReverse47().Replace(output, @"м");
        output = RuleReverse48().Replace(output, @"Н");
        output = RuleReverse49().Replace(output, @"н");
        output = RuleReverse50().Replace(output, @"Њ");
        output = RuleReverse51().Replace(output, @"Њ");
        output = RuleReverse52().Replace(output, @"њ");
        output = RuleReverse53().Replace(output, @"О");
        output = RuleReverse54().Replace(output, @"о");
        output = RuleReverse55().Replace(output, @"П");
        output = RuleReverse56().Replace(output, @"п");
        output = RuleReverse57().Replace(output, @"Р");
        output = RuleReverse58().Replace(output, @"р");
        output = RuleReverse59().Replace(output, @"С");
        output = RuleReverse60().Replace(output, @"с");
        output = RuleReverse61().Replace(output, @"Т");
        output = RuleReverse62().Replace(output, @"т");
        output = RuleReverse63().Replace(output, @"Ќ");
        output = RuleReverse64().Replace(output, @"ќ");
        output = RuleReverse65().Replace(output, @"Ћ");
        output = RuleReverse66().Replace(output, @"ћ");
        output = RuleReverse67().Replace(output, @"У");
        output = RuleReverse68().Replace(output, @"у");
        output = RuleReverse69().Replace(output, @"Ў");
        output = RuleReverse70().Replace(output, @"ў");
        output = RuleReverse71().Replace(output, @"Ф");
        output = RuleReverse72().Replace(output, @"ф");
        output = RuleReverse73().Replace(output, @"Х");
        output = RuleReverse74().Replace(output, @"х");
        output = RuleReverse75().Replace(output, @"Ц");
        output = RuleReverse76().Replace(output, @"ц");
        output = RuleReverse77().Replace(output, @"Ч");
        output = RuleReverse78().Replace(output, @"ч");
        output = RuleReverse79().Replace(output, @"Џ");
        output = RuleReverse80().Replace(output, @"Џ");
        output = RuleReverse81().Replace(output, @"џ");
        output = RuleReverse82().Replace(output, @"Ш");
        output = RuleReverse83().Replace(output, @"ш");
        output = RuleReverse84().Replace(output, @"Щ");
        output = RuleReverse85().Replace(output, @"щ");
        output = RuleReverse86().Replace(output, @"Ъ");
        output = RuleReverse87().Replace(output, @"ъ");
        output = RuleReverse88().Replace(output, @"Ы");
        output = RuleReverse89().Replace(output, @"ы");
        output = RuleReverse90().Replace(output, @"Ь");
        output = RuleReverse91().Replace(output, @"ь");
        output = RuleReverse92().Replace(output, @"Ѣ");
        output = RuleReverse93().Replace(output, @"ѣ");
        output = RuleReverse94().Replace(output, @"Э");
        output = RuleReverse95().Replace(output, @"э");
        output = RuleReverse96().Replace(output, @"Ю");
        output = RuleReverse97().Replace(output, @"Ю");
        output = RuleReverse98().Replace(output, @"ю");
        output = RuleReverse99().Replace(output, @"Я");
        output = RuleReverse100().Replace(output, @"Я");
        output = RuleReverse101().Replace(output, @"я");
        output = RuleReverse102().Replace(output, @"Ѫ");
        output = RuleReverse103().Replace(output, @"ѫ");
        output = RuleReverse104().Replace(output, @"Ѳ");
        output = RuleReverse105().Replace(output, @"ѳ");
        output = RuleReverse106().Replace(output, @"Ѵ");
        output = RuleReverse107().Replace(output, @"ѵ");

        return output;
    }
              
    [GeneratedRegex(@"А")]
    private static partial Regex Rule1();
                   
    [GeneratedRegex(@"A")]
    private static partial Regex RuleReverse1();
              
    [GeneratedRegex(@"а")]
    private static partial Regex Rule2();
                   
    [GeneratedRegex(@"a")]
    private static partial Regex RuleReverse2();
              
    [GeneratedRegex(@"Б")]
    private static partial Regex Rule3();
                   
    [GeneratedRegex(@"B")]
    private static partial Regex RuleReverse3();
              
    [GeneratedRegex(@"б")]
    private static partial Regex Rule4();
                   
    [GeneratedRegex(@"b")]
    private static partial Regex RuleReverse4();
              
    [GeneratedRegex(@"В")]
    private static partial Regex Rule5();
                   
    [GeneratedRegex(@"V")]
    private static partial Regex RuleReverse5();
              
    [GeneratedRegex(@"в")]
    private static partial Regex Rule6();
                   
    [GeneratedRegex(@"v")]
    private static partial Regex RuleReverse6();
              
    [GeneratedRegex(@"Г")]
    private static partial Regex Rule7();
                   
    [GeneratedRegex(@"G")]
    private static partial Regex RuleReverse7();
              
    [GeneratedRegex(@"г")]
    private static partial Regex Rule8();
                   
    [GeneratedRegex(@"g")]
    private static partial Regex RuleReverse8();
              
    [GeneratedRegex(@"Ґ")]
    private static partial Regex Rule9();
                   
    [GeneratedRegex(@"G̀")]
    private static partial Regex RuleReverse9();
              
    [GeneratedRegex(@"ґ")]
    private static partial Regex Rule10();
                   
    [GeneratedRegex(@"g̀")]
    private static partial Regex RuleReverse10();
              
    [GeneratedRegex(@"Д")]
    private static partial Regex Rule11();
                   
    [GeneratedRegex(@"D")]
    private static partial Regex RuleReverse11();
              
    [GeneratedRegex(@"д")]
    private static partial Regex Rule12();
                   
    [GeneratedRegex(@"d")]
    private static partial Regex RuleReverse12();
              
    [GeneratedRegex(@"Ѓ")]
    private static partial Regex Rule13();
                   
    [GeneratedRegex(@"Ǵ")]
    private static partial Regex RuleReverse13();
              
    [GeneratedRegex(@"ѓ")]
    private static partial Regex Rule14();
                   
    [GeneratedRegex(@"ǵ")]
    private static partial Regex RuleReverse14();
              
    [GeneratedRegex(@"Ђ")]
    private static partial Regex Rule15();
                   
    [GeneratedRegex(@"Đ")]
    private static partial Regex RuleReverse15();
              
    [GeneratedRegex(@"ђ")]
    private static partial Regex Rule16();
                   
    [GeneratedRegex(@"đ")]
    private static partial Regex RuleReverse16();
              
    [GeneratedRegex(@"Е")]
    private static partial Regex Rule17();
                   
    [GeneratedRegex(@"E")]
    private static partial Regex RuleReverse17();
              
    [GeneratedRegex(@"е")]
    private static partial Regex Rule18();
                   
    [GeneratedRegex(@"e")]
    private static partial Regex RuleReverse18();
              
    [GeneratedRegex(@"Ё")]
    private static partial Regex Rule19();
                   
    [GeneratedRegex(@"Ë")]
    private static partial Regex RuleReverse19();
              
    [GeneratedRegex(@"ё")]
    private static partial Regex Rule20();
                   
    [GeneratedRegex(@"ë")]
    private static partial Regex RuleReverse20();
              
    [GeneratedRegex(@"Є")]
    private static partial Regex Rule21();
                   
    [GeneratedRegex(@"Je")]
    private static partial Regex RuleReverse21();
              
    [GeneratedRegex(@"є")]
    private static partial Regex Rule22();
                   
    [GeneratedRegex(@"je")]
    private static partial Regex RuleReverse22();
              
    [GeneratedRegex(@"Ж")]
    private static partial Regex Rule23();
                   
    [GeneratedRegex(@"Ž")]
    private static partial Regex RuleReverse23();
              
    [GeneratedRegex(@"ж")]
    private static partial Regex Rule24();
                   
    [GeneratedRegex(@"ž")]
    private static partial Regex RuleReverse24();
              
    [GeneratedRegex(@"З")]
    private static partial Regex Rule25();
                   
    [GeneratedRegex(@"Z")]
    private static partial Regex RuleReverse25();
              
    [GeneratedRegex(@"з")]
    private static partial Regex Rule26();
                   
    [GeneratedRegex(@"z")]
    private static partial Regex RuleReverse26();
              
    [GeneratedRegex(@"Ѕ")]
    private static partial Regex Rule27();
                   
    [GeneratedRegex(@"Dz")]
    private static partial Regex RuleReverse27();
              
    [GeneratedRegex(@"ѕ")]
    private static partial Regex Rule28();
                   
    [GeneratedRegex(@"dz")]
    private static partial Regex RuleReverse28();
              
    [GeneratedRegex(@"И")]
    private static partial Regex Rule29();
                   
    [GeneratedRegex(@"I")]
    private static partial Regex RuleReverse29();
              
    [GeneratedRegex(@"и")]
    private static partial Regex Rule30();
                   
    [GeneratedRegex(@"i")]
    private static partial Regex RuleReverse30();
              
    [GeneratedRegex(@"І")]
    private static partial Regex Rule31();
                   
    [GeneratedRegex(@"I")]
    private static partial Regex RuleReverse31();
              
    [GeneratedRegex(@"і")]
    private static partial Regex Rule32();
                   
    [GeneratedRegex(@"i")]
    private static partial Regex RuleReverse32();
              
    [GeneratedRegex(@"Ї")]
    private static partial Regex Rule33();
                   
    [GeneratedRegex(@"Ji")]
    private static partial Regex RuleReverse33();
              
    [GeneratedRegex(@"ї")]
    private static partial Regex Rule34();
                   
    [GeneratedRegex(@"ji")]
    private static partial Regex RuleReverse34();
              
    [GeneratedRegex(@"Й")]
    private static partial Regex Rule35();
                   
    [GeneratedRegex(@"J")]
    private static partial Regex RuleReverse35();
              
    [GeneratedRegex(@"й")]
    private static partial Regex Rule36();
                   
    [GeneratedRegex(@"j")]
    private static partial Regex RuleReverse36();
              
    [GeneratedRegex(@"Ј")]
    private static partial Regex Rule37();
                   
    [GeneratedRegex(@"J")]
    private static partial Regex RuleReverse37();
              
    [GeneratedRegex(@"ј")]
    private static partial Regex Rule38();
                   
    [GeneratedRegex(@"j")]
    private static partial Regex RuleReverse38();
              
    [GeneratedRegex(@"К")]
    private static partial Regex Rule39();
                   
    [GeneratedRegex(@"K")]
    private static partial Regex RuleReverse39();
              
    [GeneratedRegex(@"к")]
    private static partial Regex Rule40();
                   
    [GeneratedRegex(@"k")]
    private static partial Regex RuleReverse40();
              
    [GeneratedRegex(@"Л")]
    private static partial Regex Rule41();
                   
    [GeneratedRegex(@"L")]
    private static partial Regex RuleReverse41();
              
    [GeneratedRegex(@"л")]
    private static partial Regex Rule42();
                   
    [GeneratedRegex(@"l")]
    private static partial Regex RuleReverse42();
              
    [GeneratedRegex(@"(?<=\p{Lu})Љ")]
    private static partial Regex Rule43();
                   
    [GeneratedRegex(@"(?<=\p{Lu})LJ")]
    private static partial Regex RuleReverse43();
              
    [GeneratedRegex(@"Љ")]
    private static partial Regex Rule44();
                   
    [GeneratedRegex(@"Lj")]
    private static partial Regex RuleReverse44();
              
    [GeneratedRegex(@"љ")]
    private static partial Regex Rule45();
                   
    [GeneratedRegex(@"lj")]
    private static partial Regex RuleReverse45();
              
    [GeneratedRegex(@"М")]
    private static partial Regex Rule46();
                   
    [GeneratedRegex(@"M")]
    private static partial Regex RuleReverse46();
              
    [GeneratedRegex(@"м")]
    private static partial Regex Rule47();
                   
    [GeneratedRegex(@"m")]
    private static partial Regex RuleReverse47();
              
    [GeneratedRegex(@"Н")]
    private static partial Regex Rule48();
                   
    [GeneratedRegex(@"N")]
    private static partial Regex RuleReverse48();
              
    [GeneratedRegex(@"н")]
    private static partial Regex Rule49();
                   
    [GeneratedRegex(@"n")]
    private static partial Regex RuleReverse49();
              
    [GeneratedRegex(@"(?<=\p{Lu})Њ")]
    private static partial Regex Rule50();
                   
    [GeneratedRegex(@"(?<=\p{Lu})NJ")]
    private static partial Regex RuleReverse50();
              
    [GeneratedRegex(@"Њ")]
    private static partial Regex Rule51();
                   
    [GeneratedRegex(@"Nj")]
    private static partial Regex RuleReverse51();
              
    [GeneratedRegex(@"њ")]
    private static partial Regex Rule52();
                   
    [GeneratedRegex(@"nj")]
    private static partial Regex RuleReverse52();
              
    [GeneratedRegex(@"О")]
    private static partial Regex Rule53();
                   
    [GeneratedRegex(@"O")]
    private static partial Regex RuleReverse53();
              
    [GeneratedRegex(@"о")]
    private static partial Regex Rule54();
                   
    [GeneratedRegex(@"o")]
    private static partial Regex RuleReverse54();
              
    [GeneratedRegex(@"П")]
    private static partial Regex Rule55();
                   
    [GeneratedRegex(@"P")]
    private static partial Regex RuleReverse55();
              
    [GeneratedRegex(@"п")]
    private static partial Regex Rule56();
                   
    [GeneratedRegex(@"p")]
    private static partial Regex RuleReverse56();
              
    [GeneratedRegex(@"Р")]
    private static partial Regex Rule57();
                   
    [GeneratedRegex(@"R")]
    private static partial Regex RuleReverse57();
              
    [GeneratedRegex(@"р")]
    private static partial Regex Rule58();
                   
    [GeneratedRegex(@"r")]
    private static partial Regex RuleReverse58();
              
    [GeneratedRegex(@"С")]
    private static partial Regex Rule59();
                   
    [GeneratedRegex(@"S")]
    private static partial Regex RuleReverse59();
              
    [GeneratedRegex(@"с")]
    private static partial Regex Rule60();
                   
    [GeneratedRegex(@"s")]
    private static partial Regex RuleReverse60();
              
    [GeneratedRegex(@"Т")]
    private static partial Regex Rule61();
                   
    [GeneratedRegex(@"T")]
    private static partial Regex RuleReverse61();
              
    [GeneratedRegex(@"т")]
    private static partial Regex Rule62();
                   
    [GeneratedRegex(@"t")]
    private static partial Regex RuleReverse62();
              
    [GeneratedRegex(@"Ќ")]
    private static partial Regex Rule63();
                   
    [GeneratedRegex(@"Ḱ")]
    private static partial Regex RuleReverse63();
              
    [GeneratedRegex(@"ќ")]
    private static partial Regex Rule64();
                   
    [GeneratedRegex(@"ḱ")]
    private static partial Regex RuleReverse64();
              
    [GeneratedRegex(@"Ћ")]
    private static partial Regex Rule65();
                   
    [GeneratedRegex(@"Ć")]
    private static partial Regex RuleReverse65();
              
    [GeneratedRegex(@"ћ")]
    private static partial Regex Rule66();
                   
    [GeneratedRegex(@"ć")]
    private static partial Regex RuleReverse66();
              
    [GeneratedRegex(@"У")]
    private static partial Regex Rule67();
                   
    [GeneratedRegex(@"U")]
    private static partial Regex RuleReverse67();
              
    [GeneratedRegex(@"у")]
    private static partial Regex Rule68();
                   
    [GeneratedRegex(@"u")]
    private static partial Regex RuleReverse68();
              
    [GeneratedRegex(@"Ў")]
    private static partial Regex Rule69();
                   
    [GeneratedRegex(@"Ŭ")]
    private static partial Regex RuleReverse69();
              
    [GeneratedRegex(@"ў")]
    private static partial Regex Rule70();
                   
    [GeneratedRegex(@"ŭ")]
    private static partial Regex RuleReverse70();
              
    [GeneratedRegex(@"Ф")]
    private static partial Regex Rule71();
                   
    [GeneratedRegex(@"F")]
    private static partial Regex RuleReverse71();
              
    [GeneratedRegex(@"ф")]
    private static partial Regex Rule72();
                   
    [GeneratedRegex(@"f")]
    private static partial Regex RuleReverse72();
              
    [GeneratedRegex(@"Х")]
    private static partial Regex Rule73();
                   
    [GeneratedRegex(@"H")]
    private static partial Regex RuleReverse73();
              
    [GeneratedRegex(@"х")]
    private static partial Regex Rule74();
                   
    [GeneratedRegex(@"h")]
    private static partial Regex RuleReverse74();
              
    [GeneratedRegex(@"Ц")]
    private static partial Regex Rule75();
                   
    [GeneratedRegex(@"C")]
    private static partial Regex RuleReverse75();
              
    [GeneratedRegex(@"ц")]
    private static partial Regex Rule76();
                   
    [GeneratedRegex(@"c")]
    private static partial Regex RuleReverse76();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule77();
                   
    [GeneratedRegex(@"Č")]
    private static partial Regex RuleReverse77();
              
    [GeneratedRegex(@"ч")]
    private static partial Regex Rule78();
                   
    [GeneratedRegex(@"č")]
    private static partial Regex RuleReverse78();
              
    [GeneratedRegex(@"(?<=\p{Lu})Џ")]
    private static partial Regex Rule79();
                   
    [GeneratedRegex(@"(?<=\p{Lu})DŽ")]
    private static partial Regex RuleReverse79();
              
    [GeneratedRegex(@"Џ")]
    private static partial Regex Rule80();
                   
    [GeneratedRegex(@"Dž")]
    private static partial Regex RuleReverse80();
              
    [GeneratedRegex(@"џ")]
    private static partial Regex Rule81();
                   
    [GeneratedRegex(@"dž")]
    private static partial Regex RuleReverse81();
              
    [GeneratedRegex(@"Ш")]
    private static partial Regex Rule82();
                   
    [GeneratedRegex(@"Š")]
    private static partial Regex RuleReverse82();
              
    [GeneratedRegex(@"ш")]
    private static partial Regex Rule83();
                   
    [GeneratedRegex(@"š")]
    private static partial Regex RuleReverse83();
              
    [GeneratedRegex(@"Щ")]
    private static partial Regex Rule84();
                   
    [GeneratedRegex(@"ŠČ")]
    private static partial Regex RuleReverse84();
              
    [GeneratedRegex(@"щ")]
    private static partial Regex Rule85();
                   
    [GeneratedRegex(@"šč")]
    private static partial Regex RuleReverse85();
              
    [GeneratedRegex(@"(?<=\p{Lu})Ъ")]
    private static partial Regex Rule86();
                   
    [GeneratedRegex(@"(?<=\p{Lu})Y")]
    private static partial Regex RuleReverse86();
              
    [GeneratedRegex(@"ъ")]
    private static partial Regex Rule87();
                   
    [GeneratedRegex(@"y")]
    private static partial Regex RuleReverse87();
              
    [GeneratedRegex(@"Ы")]
    private static partial Regex Rule88();
                   
    [GeneratedRegex(@"Y")]
    private static partial Regex RuleReverse88();
              
    [GeneratedRegex(@"ы")]
    private static partial Regex Rule89();
                   
    [GeneratedRegex(@"y")]
    private static partial Regex RuleReverse89();
              
    [GeneratedRegex(@"(?<=\p{Lu})Ь")]
    private static partial Regex Rule90();
                   
    [GeneratedRegex(@"(?<=\p{Lu})ʹ")]
    private static partial Regex RuleReverse90();
              
    [GeneratedRegex(@"ь")]
    private static partial Regex Rule91();
                   
    [GeneratedRegex(@"ʹ")]
    private static partial Regex RuleReverse91();
              
    [GeneratedRegex(@"Ѣ")]
    private static partial Regex Rule92();
                   
    [GeneratedRegex(@"Ě")]
    private static partial Regex RuleReverse92();
              
    [GeneratedRegex(@"ѣ")]
    private static partial Regex Rule93();
                   
    [GeneratedRegex(@"ě")]
    private static partial Regex RuleReverse93();
              
    [GeneratedRegex(@"Э")]
    private static partial Regex Rule94();
                   
    [GeneratedRegex(@"È")]
    private static partial Regex RuleReverse94();
              
    [GeneratedRegex(@"э")]
    private static partial Regex Rule95();
                   
    [GeneratedRegex(@"è")]
    private static partial Regex RuleReverse95();
              
    [GeneratedRegex(@"(?<=\p{Lu})Ю")]
    private static partial Regex Rule96();
                   
    [GeneratedRegex(@"(?<=\p{Lu})JU")]
    private static partial Regex RuleReverse96();
              
    [GeneratedRegex(@"Ю")]
    private static partial Regex Rule97();
                   
    [GeneratedRegex(@"Ju")]
    private static partial Regex RuleReverse97();
              
    [GeneratedRegex(@"ю")]
    private static partial Regex Rule98();
                   
    [GeneratedRegex(@"ju")]
    private static partial Regex RuleReverse98();
              
    [GeneratedRegex(@"(?<=\p{Lu})Я")]
    private static partial Regex Rule99();
                   
    [GeneratedRegex(@"(?<=\p{Lu})JA")]
    private static partial Regex RuleReverse99();
              
    [GeneratedRegex(@"Я")]
    private static partial Regex Rule100();
                   
    [GeneratedRegex(@"Ja")]
    private static partial Regex RuleReverse100();
              
    [GeneratedRegex(@"я")]
    private static partial Regex Rule101();
                   
    [GeneratedRegex(@"ja")]
    private static partial Regex RuleReverse101();
              
    [GeneratedRegex(@"Ѫ")]
    private static partial Regex Rule102();
                   
    [GeneratedRegex(@"Ȧ")]
    private static partial Regex RuleReverse102();
              
    [GeneratedRegex(@"ѫ")]
    private static partial Regex Rule103();
                   
    [GeneratedRegex(@"ȧ")]
    private static partial Regex RuleReverse103();
              
    [GeneratedRegex(@"Ѳ")]
    private static partial Regex Rule104();
                   
    [GeneratedRegex(@"Ḟ")]
    private static partial Regex RuleReverse104();
              
    [GeneratedRegex(@"ѳ")]
    private static partial Regex Rule105();
                   
    [GeneratedRegex(@"ḟ")]
    private static partial Regex RuleReverse105();
              
    [GeneratedRegex(@"Ѵ")]
    private static partial Regex Rule106();
                   
    [GeneratedRegex(@"Ẏ")]
    private static partial Regex RuleReverse106();
              
    [GeneratedRegex(@"ѵ")]
    private static partial Regex Rule107();
                   
    [GeneratedRegex(@"ẏ")]
    private static partial Regex RuleReverse107();

}
