using System;
using System.Text.RegularExpressions;
using System.IO;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_iso_9 : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.iso_9;

    public override bool IsReversable => true;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"A");
        output = Rule2().Replace(output, @"a");
        output = Rule3().Replace(output, @"Ă");
        output = Rule4().Replace(output, @"ă");
        output = Rule5().Replace(output, @"Ä");
        output = Rule6().Replace(output, @"ä");
        output = Rule7().Replace(output, @"A̋");
        output = Rule8().Replace(output, @"a̋");
        output = Rule9().Replace(output, @"B");
        output = Rule10().Replace(output, @"b");
        output = Rule11().Replace(output, @"V");
        output = Rule12().Replace(output, @"v");
        output = Rule13().Replace(output, @"G");
        output = Rule14().Replace(output, @"g");
        output = Rule15().Replace(output, @"G̀");
        output = Rule16().Replace(output, @"g̀");
        output = Rule17().Replace(output, @"Ğ");
        output = Rule18().Replace(output, @"ğ");
        output = Rule19().Replace(output, @"Ġ");
        output = Rule20().Replace(output, @"ġ");
        output = Rule21().Replace(output, @"D");
        output = Rule22().Replace(output, @"d");
        output = Rule23().Replace(output, @"Đ");
        output = Rule24().Replace(output, @"đ");
        output = Rule25().Replace(output, @"Ǵ");
        output = Rule26().Replace(output, @"ǵ");
        output = Rule27().Replace(output, @"E");
        output = Rule28().Replace(output, @"e");
        output = Rule29().Replace(output, @"Ë");
        output = Rule30().Replace(output, @"ë");
        output = Rule31().Replace(output, @"Ĕ");
        output = Rule32().Replace(output, @"ĕ");
        output = Rule33().Replace(output, @"Ê");
        output = Rule34().Replace(output, @"ê");
        output = Rule35().Replace(output, @"C̆");
        output = Rule36().Replace(output, @"c̆");
        output = Rule37().Replace(output, @"Ç̆");
        output = Rule38().Replace(output, @"ç̆");
        output = Rule39().Replace(output, @"Ž");
        output = Rule40().Replace(output, @"ž");
        output = Rule41().Replace(output, @"Z̆");
        output = Rule42().Replace(output, @"z̆");
        output = Rule43().Replace(output, @"Z̄");
        output = Rule44().Replace(output, @"z̄");
        output = Rule45().Replace(output, @"Ž̦");
        output = Rule46().Replace(output, @"ž̧");
        output = Rule47().Replace(output, @"Z");
        output = Rule48().Replace(output, @"z");
        output = Rule49().Replace(output, @"Z̈");
        output = Rule50().Replace(output, @"z̈");
        output = Rule51().Replace(output, @"Ẑ");
        output = Rule52().Replace(output, @"ẑ");
        output = Rule53().Replace(output, @"Ź");
        output = Rule54().Replace(output, @"ź");
        output = Rule55().Replace(output, @"I");
        output = Rule56().Replace(output, @"i");
        output = Rule57().Replace(output, @"Î");
        output = Rule58().Replace(output, @"î");
        output = Rule59().Replace(output, @"Ì");
        output = Rule60().Replace(output, @"ì");
        output = Rule61().Replace(output, @"Ï");
        output = Rule62().Replace(output, @"ï");
        output = Rule63().Replace(output, @"J");
        output = Rule64().Replace(output, @"j");
        output = Rule65().Replace(output, @"J̌");
        output = Rule66().Replace(output, @"ǰ");
        output = Rule67().Replace(output, @"K");
        output = Rule68().Replace(output, @"k");
        output = Rule69().Replace(output, @"Ķ");
        output = Rule70().Replace(output, @"ķ");
        output = Rule71().Replace(output, @"K̄");
        output = Rule72().Replace(output, @"k̄");
        output = Rule73().Replace(output, @"L");
        output = Rule74().Replace(output, @"l");
        output = Rule75().Replace(output, @"L̂");
        output = Rule76().Replace(output, @"l̂");
        output = Rule77().Replace(output, @"M");
        output = Rule78().Replace(output, @"m");
        output = Rule79().Replace(output, @"N");
        output = Rule80().Replace(output, @"n");
        output = Rule81().Replace(output, @"N̂");
        output = Rule82().Replace(output, @"n̂");
        output = Rule83().Replace(output, @"Ṅ");
        output = Rule84().Replace(output, @"ṅ");
        output = Rule85().Replace(output, @"Ṇ");
        output = Rule86().Replace(output, @"ṇ");
        output = Rule87().Replace(output, @"O");
        output = Rule88().Replace(output, @"o");
        output = Rule89().Replace(output, @"Ö");
        output = Rule90().Replace(output, @"ö");
        output = Rule91().Replace(output, @"Ô");
        output = Rule92().Replace(output, @"ô");
        output = Rule93().Replace(output, @"P");
        output = Rule94().Replace(output, @"p");
        output = Rule95().Replace(output, @"Ṕ");
        output = Rule96().Replace(output, @"ṕ");
        output = Rule97().Replace(output, @"R");
        output = Rule98().Replace(output, @"r");
        output = Rule99().Replace(output, @"S");
        output = Rule100().Replace(output, @"s");
        output = Rule101().Replace(output, @"Ç");
        output = Rule102().Replace(output, @"ç");
        output = Rule103().Replace(output, @"T");
        output = Rule104().Replace(output, @"t");
        output = Rule105().Replace(output, @"Ţ");
        output = Rule106().Replace(output, @"ţ");
        output = Rule107().Replace(output, @"Ć");
        output = Rule108().Replace(output, @"Ű");
        output = Rule109().Replace(output, @"Ḱ");
        output = Rule110().Replace(output, @"ḱ");
        output = Rule111().Replace(output, @"U");
        output = Rule112().Replace(output, @"u");
        output = Rule113().Replace(output, @"Ú");
        output = Rule114().Replace(output, @"ú");
        output = Rule115().Replace(output, @"Ŭ");
        output = Rule116().Replace(output, @"ŭ");
        output = Rule117().Replace(output, @"Ü");
        output = Rule118().Replace(output, @"ü");
        output = Rule119().Replace(output, @"Ű");
        output = Rule120().Replace(output, @"ű");
        output = Rule121().Replace(output, @"Ù");
        output = Rule122().Replace(output, @"ù");
        output = Rule123().Replace(output, @"F");
        output = Rule124().Replace(output, @"f");
        output = Rule125().Replace(output, @"H");
        output = Rule126().Replace(output, @"h");
        output = Rule127().Replace(output, @"Ḩ");
        output = Rule128().Replace(output, @"ḩ");
        output = Rule129().Replace(output, @"Ḥ");
        output = Rule130().Replace(output, @"ḥ");
        output = Rule131().Replace(output, @"C");
        output = Rule132().Replace(output, @"c");
        output = Rule133().Replace(output, @"C̄");
        output = Rule134().Replace(output, @"c̄");
        output = Rule135().Replace(output, @"Č");
        output = Rule136().Replace(output, @"č");
        output = Rule137().Replace(output, @"C̈");
        output = Rule138().Replace(output, @"c̈");
        output = Rule139().Replace(output, @"Ç");
        output = Rule140().Replace(output, @"ç");
        output = Rule141().Replace(output, @"D̂");
        output = Rule142().Replace(output, @"d̂");
        output = Rule143().Replace(output, @"Š");
        output = Rule144().Replace(output, @"š");
        output = Rule145().Replace(output, @"Ŝ");
        output = Rule146().Replace(output, @"ŝ");
        output = Rule147().Replace(output, @"ʺ");
        output = Rule148().Replace(output, @"ʺ");
        output = Rule149().Replace(output, @"’");
        output = Rule150().Replace(output, @"Y");
        output = Rule151().Replace(output, @"y");
        output = Rule152().Replace(output, @"Ÿ");
        output = Rule153().Replace(output, @"ÿ");
        output = Rule154().Replace(output, @"ʹ");
        output = Rule155().Replace(output, @"ʹ");
        output = Rule156().Replace(output, @"È");
        output = Rule157().Replace(output, @"è");
        output = Rule158().Replace(output, @"Û");
        output = Rule159().Replace(output, @"û");
        output = Rule160().Replace(output, @"Â");
        output = Rule161().Replace(output, @"â");
        output = Rule162().Replace(output, @"Ě");
        output = Rule163().Replace(output, @"ě");
        output = Rule164().Replace(output, @"Ǎ");
        output = Rule165().Replace(output, @"ǎ");
        output = Rule166().Replace(output, @"F̀");
        output = Rule167().Replace(output, @"f̀");
        output = Rule168().Replace(output, @"Ỳ");
        output = Rule169().Replace(output, @"ỳ");
        output = Rule170().Replace(output, @"Ò");
        output = Rule171().Replace(output, @"ò");
        output = Rule172().Replace(output, @"‡");

        return output;
    }

    public override string Reverse(string input)
    {
        string output = input;

        output = RuleReverse1().Replace(output, @"А");
        output = RuleReverse2().Replace(output, @"а");
        output = RuleReverse3().Replace(output, @"Ӑ");
        output = RuleReverse4().Replace(output, @"ӑ");
        output = RuleReverse5().Replace(output, @"Ӓ");
        output = RuleReverse6().Replace(output, @"ӓ");
        output = RuleReverse7().Replace(output, @"Ә");
        output = RuleReverse8().Replace(output, @"ә");
        output = RuleReverse9().Replace(output, @"Б");
        output = RuleReverse10().Replace(output, @"б");
        output = RuleReverse11().Replace(output, @"В");
        output = RuleReverse12().Replace(output, @"в");
        output = RuleReverse13().Replace(output, @"Г");
        output = RuleReverse14().Replace(output, @"г");
        output = RuleReverse15().Replace(output, @"Ґ");
        output = RuleReverse16().Replace(output, @"ґ");
        output = RuleReverse17().Replace(output, @"Ҕ");
        output = RuleReverse18().Replace(output, @"ҕ");
        output = RuleReverse19().Replace(output, @"Ғ");
        output = RuleReverse20().Replace(output, @"ғ");
        output = RuleReverse21().Replace(output, @"Д");
        output = RuleReverse22().Replace(output, @"д");
        output = RuleReverse23().Replace(output, @"Ђ");
        output = RuleReverse24().Replace(output, @"ђ");
        output = RuleReverse25().Replace(output, @"Ѓ");
        output = RuleReverse26().Replace(output, @"ѓ");
        output = RuleReverse27().Replace(output, @"Е");
        output = RuleReverse28().Replace(output, @"е");
        output = RuleReverse29().Replace(output, @"Ё");
        output = RuleReverse30().Replace(output, @"ё");
        output = RuleReverse31().Replace(output, @"Ӗ");
        output = RuleReverse32().Replace(output, @"ӗ");
        output = RuleReverse33().Replace(output, @"Є");
        output = RuleReverse34().Replace(output, @"є");
        output = RuleReverse35().Replace(output, @"Ҽ");
        output = RuleReverse36().Replace(output, @"ҽ");
        output = RuleReverse37().Replace(output, @"Ҿ");
        output = RuleReverse38().Replace(output, @"ҿ");
        output = RuleReverse39().Replace(output, @"Ж");
        output = RuleReverse40().Replace(output, @"ж");
        output = RuleReverse41().Replace(output, @"Ӂ");
        output = RuleReverse42().Replace(output, @"ӂ");
        output = RuleReverse43().Replace(output, @"Ӝ");
        output = RuleReverse44().Replace(output, @"ӝ");
        output = RuleReverse45().Replace(output, @"Җ");
        output = RuleReverse46().Replace(output, @"җ");
        output = RuleReverse47().Replace(output, @"З");
        output = RuleReverse48().Replace(output, @"з");
        output = RuleReverse49().Replace(output, @"Ӟ");
        output = RuleReverse50().Replace(output, @"ӟ");
        output = RuleReverse51().Replace(output, @"Ѕ");
        output = RuleReverse52().Replace(output, @"ѕ");
        output = RuleReverse53().Replace(output, @"Ӡ");
        output = RuleReverse54().Replace(output, @"ӡ");
        output = RuleReverse55().Replace(output, @"И");
        output = RuleReverse56().Replace(output, @"и");
        output = RuleReverse57().Replace(output, @"Ӥ");
        output = RuleReverse58().Replace(output, @"ӥ");
        output = RuleReverse59().Replace(output, @"І");
        output = RuleReverse60().Replace(output, @"і");
        output = RuleReverse61().Replace(output, @"Ї");
        output = RuleReverse62().Replace(output, @"ї");
        output = RuleReverse63().Replace(output, @"Й");
        output = RuleReverse64().Replace(output, @"й");
        output = RuleReverse65().Replace(output, @"Ј");
        output = RuleReverse66().Replace(output, @"ј");
        output = RuleReverse67().Replace(output, @"К");
        output = RuleReverse68().Replace(output, @"к");
        output = RuleReverse69().Replace(output, @"Қ");
        output = RuleReverse70().Replace(output, @"қ");
        output = RuleReverse71().Replace(output, @"Ҟ");
        output = RuleReverse72().Replace(output, @"ҟ");
        output = RuleReverse73().Replace(output, @"Л");
        output = RuleReverse74().Replace(output, @"л");
        output = RuleReverse75().Replace(output, @"Љ");
        output = RuleReverse76().Replace(output, @"љ");
        output = RuleReverse77().Replace(output, @"М");
        output = RuleReverse78().Replace(output, @"м");
        output = RuleReverse79().Replace(output, @"Н");
        output = RuleReverse80().Replace(output, @"н");
        output = RuleReverse81().Replace(output, @"Њ");
        output = RuleReverse82().Replace(output, @"њ");
        output = RuleReverse83().Replace(output, @"Ҥ");
        output = RuleReverse84().Replace(output, @"ҥ");
        output = RuleReverse85().Replace(output, @"Ң");
        output = RuleReverse86().Replace(output, @"ң");
        output = RuleReverse87().Replace(output, @"О");
        output = RuleReverse88().Replace(output, @"о");
        output = RuleReverse89().Replace(output, @"Ӧ");
        output = RuleReverse90().Replace(output, @"ӧ");
        output = RuleReverse91().Replace(output, @"Ө");
        output = RuleReverse92().Replace(output, @"ө");
        output = RuleReverse93().Replace(output, @"П");
        output = RuleReverse94().Replace(output, @"п");
        output = RuleReverse95().Replace(output, @"Ҧ");
        output = RuleReverse96().Replace(output, @"ҧ");
        output = RuleReverse97().Replace(output, @"Р");
        output = RuleReverse98().Replace(output, @"р");
        output = RuleReverse99().Replace(output, @"С");
        output = RuleReverse100().Replace(output, @"с");
        output = RuleReverse101().Replace(output, @"Ҫ");
        output = RuleReverse102().Replace(output, @"ҫ");
        output = RuleReverse103().Replace(output, @"Т");
        output = RuleReverse104().Replace(output, @"т");
        output = RuleReverse105().Replace(output, @"Ҭ");
        output = RuleReverse106().Replace(output, @"ҭ");
        output = RuleReverse107().Replace(output, @"Ћ");
        output = RuleReverse108().Replace(output, @"ћ");
        output = RuleReverse109().Replace(output, @"Ќ");
        output = RuleReverse110().Replace(output, @"ќ");
        output = RuleReverse111().Replace(output, @"У");
        output = RuleReverse112().Replace(output, @"у");
        output = RuleReverse113().Replace(output, @"У́");
        output = RuleReverse114().Replace(output, @"у́");
        output = RuleReverse115().Replace(output, @"Ў");
        output = RuleReverse116().Replace(output, @"ў");
        output = RuleReverse117().Replace(output, @"Ӱ");
        output = RuleReverse118().Replace(output, @"ӱ");
        output = RuleReverse119().Replace(output, @"Ӳ");
        output = RuleReverse120().Replace(output, @"ӳ");
        output = RuleReverse121().Replace(output, @"Ү");
        output = RuleReverse122().Replace(output, @"ү");
        output = RuleReverse123().Replace(output, @"Ф");
        output = RuleReverse124().Replace(output, @"ф");
        output = RuleReverse125().Replace(output, @"Х");
        output = RuleReverse126().Replace(output, @"х");
        output = RuleReverse127().Replace(output, @"Ҳ");
        output = RuleReverse128().Replace(output, @"ҳ");
        output = RuleReverse129().Replace(output, @"Һ");
        output = RuleReverse130().Replace(output, @"һ");
        output = RuleReverse131().Replace(output, @"Ц");
        output = RuleReverse132().Replace(output, @"ц");
        output = RuleReverse133().Replace(output, @"Ҵ");
        output = RuleReverse134().Replace(output, @"ҵ");
        output = RuleReverse135().Replace(output, @"Ч");
        output = RuleReverse136().Replace(output, @"ч");
        output = RuleReverse137().Replace(output, @"Ӵ");
        output = RuleReverse138().Replace(output, @"ӵ");
        output = RuleReverse139().Replace(output, @"Ӌ");
        output = RuleReverse140().Replace(output, @"ӌ");
        output = RuleReverse141().Replace(output, @"Џ");
        output = RuleReverse142().Replace(output, @"џ");
        output = RuleReverse143().Replace(output, @"Ш");
        output = RuleReverse144().Replace(output, @"ш");
        output = RuleReverse145().Replace(output, @"Щ");
        output = RuleReverse146().Replace(output, @"щ");
        output = RuleReverse147().Replace(output, @"Ъ");
        output = RuleReverse148().Replace(output, @"ъ");
        output = RuleReverse149().Replace(output, @"ʼ");
        output = RuleReverse150().Replace(output, @"Ы");
        output = RuleReverse151().Replace(output, @"ы");
        output = RuleReverse152().Replace(output, @"Ӹ");
        output = RuleReverse153().Replace(output, @"ӹ");
        output = RuleReverse154().Replace(output, @"Ь");
        output = RuleReverse155().Replace(output, @"ь");
        output = RuleReverse156().Replace(output, @"Э");
        output = RuleReverse157().Replace(output, @"э");
        output = RuleReverse158().Replace(output, @"Ю");
        output = RuleReverse159().Replace(output, @"ю");
        output = RuleReverse160().Replace(output, @"Я");
        output = RuleReverse161().Replace(output, @"я");
        output = RuleReverse162().Replace(output, @"Ҍ");
        output = RuleReverse163().Replace(output, @"ҍ");
        output = RuleReverse164().Replace(output, @"Ѫ");
        output = RuleReverse165().Replace(output, @"ѫ");
        output = RuleReverse166().Replace(output, @"Ѳ");
        output = RuleReverse167().Replace(output, @"ѳ");
        output = RuleReverse168().Replace(output, @"Ѵ");
        output = RuleReverse169().Replace(output, @"ѵ");
        output = RuleReverse170().Replace(output, @"Ҩ");
        output = RuleReverse171().Replace(output, @"ҩ");
        output = RuleReverse172().Replace(output, @"Ӏ");

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
              
    [GeneratedRegex(@"Ӑ")]
    private static partial Regex Rule3();
                   
    [GeneratedRegex(@"Ă")]
    private static partial Regex RuleReverse3();
              
    [GeneratedRegex(@"ӑ")]
    private static partial Regex Rule4();
                   
    [GeneratedRegex(@"ă")]
    private static partial Regex RuleReverse4();
              
    [GeneratedRegex(@"Ӓ")]
    private static partial Regex Rule5();
                   
    [GeneratedRegex(@"Ä")]
    private static partial Regex RuleReverse5();
              
    [GeneratedRegex(@"ӓ")]
    private static partial Regex Rule6();
                   
    [GeneratedRegex(@"ä")]
    private static partial Regex RuleReverse6();
              
    [GeneratedRegex(@"Ә")]
    private static partial Regex Rule7();
                   
    [GeneratedRegex(@"A̋")]
    private static partial Regex RuleReverse7();
              
    [GeneratedRegex(@"ә")]
    private static partial Regex Rule8();
                   
    [GeneratedRegex(@"a̋")]
    private static partial Regex RuleReverse8();
              
    [GeneratedRegex(@"Б")]
    private static partial Regex Rule9();
                   
    [GeneratedRegex(@"B")]
    private static partial Regex RuleReverse9();
              
    [GeneratedRegex(@"б")]
    private static partial Regex Rule10();
                   
    [GeneratedRegex(@"b")]
    private static partial Regex RuleReverse10();
              
    [GeneratedRegex(@"В")]
    private static partial Regex Rule11();
                   
    [GeneratedRegex(@"V")]
    private static partial Regex RuleReverse11();
              
    [GeneratedRegex(@"в")]
    private static partial Regex Rule12();
                   
    [GeneratedRegex(@"v")]
    private static partial Regex RuleReverse12();
              
    [GeneratedRegex(@"Г")]
    private static partial Regex Rule13();
                   
    [GeneratedRegex(@"G")]
    private static partial Regex RuleReverse13();
              
    [GeneratedRegex(@"г")]
    private static partial Regex Rule14();
                   
    [GeneratedRegex(@"g")]
    private static partial Regex RuleReverse14();
              
    [GeneratedRegex(@"Ґ")]
    private static partial Regex Rule15();
                   
    [GeneratedRegex(@"G̀")]
    private static partial Regex RuleReverse15();
              
    [GeneratedRegex(@"ґ")]
    private static partial Regex Rule16();
                   
    [GeneratedRegex(@"g̀")]
    private static partial Regex RuleReverse16();
              
    [GeneratedRegex(@"Ҕ")]
    private static partial Regex Rule17();
                   
    [GeneratedRegex(@"Ğ")]
    private static partial Regex RuleReverse17();
              
    [GeneratedRegex(@"ҕ")]
    private static partial Regex Rule18();
                   
    [GeneratedRegex(@"ğ")]
    private static partial Regex RuleReverse18();
              
    [GeneratedRegex(@"Ғ")]
    private static partial Regex Rule19();
                   
    [GeneratedRegex(@"Ġ")]
    private static partial Regex RuleReverse19();
              
    [GeneratedRegex(@"ғ")]
    private static partial Regex Rule20();
                   
    [GeneratedRegex(@"ġ")]
    private static partial Regex RuleReverse20();
              
    [GeneratedRegex(@"Д")]
    private static partial Regex Rule21();
                   
    [GeneratedRegex(@"D")]
    private static partial Regex RuleReverse21();
              
    [GeneratedRegex(@"д")]
    private static partial Regex Rule22();
                   
    [GeneratedRegex(@"d")]
    private static partial Regex RuleReverse22();
              
    [GeneratedRegex(@"Ђ")]
    private static partial Regex Rule23();
                   
    [GeneratedRegex(@"Đ")]
    private static partial Regex RuleReverse23();
              
    [GeneratedRegex(@"ђ")]
    private static partial Regex Rule24();
                   
    [GeneratedRegex(@"đ")]
    private static partial Regex RuleReverse24();
              
    [GeneratedRegex(@"Ѓ")]
    private static partial Regex Rule25();
                   
    [GeneratedRegex(@"Ǵ")]
    private static partial Regex RuleReverse25();
              
    [GeneratedRegex(@"ѓ")]
    private static partial Regex Rule26();
                   
    [GeneratedRegex(@"ǵ")]
    private static partial Regex RuleReverse26();
              
    [GeneratedRegex(@"Е")]
    private static partial Regex Rule27();
                   
    [GeneratedRegex(@"E")]
    private static partial Regex RuleReverse27();
              
    [GeneratedRegex(@"е")]
    private static partial Regex Rule28();
                   
    [GeneratedRegex(@"e")]
    private static partial Regex RuleReverse28();
              
    [GeneratedRegex(@"Ё")]
    private static partial Regex Rule29();
                   
    [GeneratedRegex(@"Ë")]
    private static partial Regex RuleReverse29();
              
    [GeneratedRegex(@"ё")]
    private static partial Regex Rule30();
                   
    [GeneratedRegex(@"ë")]
    private static partial Regex RuleReverse30();
              
    [GeneratedRegex(@"Ӗ")]
    private static partial Regex Rule31();
                   
    [GeneratedRegex(@"Ĕ")]
    private static partial Regex RuleReverse31();
              
    [GeneratedRegex(@"ӗ")]
    private static partial Regex Rule32();
                   
    [GeneratedRegex(@"ĕ")]
    private static partial Regex RuleReverse32();
              
    [GeneratedRegex(@"Є")]
    private static partial Regex Rule33();
                   
    [GeneratedRegex(@"Ê")]
    private static partial Regex RuleReverse33();
              
    [GeneratedRegex(@"є")]
    private static partial Regex Rule34();
                   
    [GeneratedRegex(@"ê")]
    private static partial Regex RuleReverse34();
              
    [GeneratedRegex(@"Ҽ")]
    private static partial Regex Rule35();
                   
    [GeneratedRegex(@"C̆")]
    private static partial Regex RuleReverse35();
              
    [GeneratedRegex(@"ҽ")]
    private static partial Regex Rule36();
                   
    [GeneratedRegex(@"c̆")]
    private static partial Regex RuleReverse36();
              
    [GeneratedRegex(@"Ҿ")]
    private static partial Regex Rule37();
                   
    [GeneratedRegex(@"Ç̆")]
    private static partial Regex RuleReverse37();
              
    [GeneratedRegex(@"ҿ")]
    private static partial Regex Rule38();
                   
    [GeneratedRegex(@"ç̆")]
    private static partial Regex RuleReverse38();
              
    [GeneratedRegex(@"Ж")]
    private static partial Regex Rule39();
                   
    [GeneratedRegex(@"Ž")]
    private static partial Regex RuleReverse39();
              
    [GeneratedRegex(@"ж")]
    private static partial Regex Rule40();
                   
    [GeneratedRegex(@"ž")]
    private static partial Regex RuleReverse40();
              
    [GeneratedRegex(@"Ӂ")]
    private static partial Regex Rule41();
                   
    [GeneratedRegex(@"Z̆")]
    private static partial Regex RuleReverse41();
              
    [GeneratedRegex(@"ӂ")]
    private static partial Regex Rule42();
                   
    [GeneratedRegex(@"z̆")]
    private static partial Regex RuleReverse42();
              
    [GeneratedRegex(@"Ӝ")]
    private static partial Regex Rule43();
                   
    [GeneratedRegex(@"Z̄")]
    private static partial Regex RuleReverse43();
              
    [GeneratedRegex(@"ӝ")]
    private static partial Regex Rule44();
                   
    [GeneratedRegex(@"z̄")]
    private static partial Regex RuleReverse44();
              
    [GeneratedRegex(@"Җ")]
    private static partial Regex Rule45();
                   
    [GeneratedRegex(@"Ž̦")]
    private static partial Regex RuleReverse45();
              
    [GeneratedRegex(@"җ")]
    private static partial Regex Rule46();
                   
    [GeneratedRegex(@"ž̧")]
    private static partial Regex RuleReverse46();
              
    [GeneratedRegex(@"З")]
    private static partial Regex Rule47();
                   
    [GeneratedRegex(@"Z")]
    private static partial Regex RuleReverse47();
              
    [GeneratedRegex(@"з")]
    private static partial Regex Rule48();
                   
    [GeneratedRegex(@"z")]
    private static partial Regex RuleReverse48();
              
    [GeneratedRegex(@"Ӟ")]
    private static partial Regex Rule49();
                   
    [GeneratedRegex(@"Z̈")]
    private static partial Regex RuleReverse49();
              
    [GeneratedRegex(@"ӟ")]
    private static partial Regex Rule50();
                   
    [GeneratedRegex(@"z̈")]
    private static partial Regex RuleReverse50();
              
    [GeneratedRegex(@"Ѕ")]
    private static partial Regex Rule51();
                   
    [GeneratedRegex(@"Ẑ")]
    private static partial Regex RuleReverse51();
              
    [GeneratedRegex(@"ѕ")]
    private static partial Regex Rule52();
                   
    [GeneratedRegex(@"ẑ")]
    private static partial Regex RuleReverse52();
              
    [GeneratedRegex(@"Ӡ")]
    private static partial Regex Rule53();
                   
    [GeneratedRegex(@"Ź")]
    private static partial Regex RuleReverse53();
              
    [GeneratedRegex(@"ӡ")]
    private static partial Regex Rule54();
                   
    [GeneratedRegex(@"ź")]
    private static partial Regex RuleReverse54();
              
    [GeneratedRegex(@"И")]
    private static partial Regex Rule55();
                   
    [GeneratedRegex(@"I")]
    private static partial Regex RuleReverse55();
              
    [GeneratedRegex(@"и")]
    private static partial Regex Rule56();
                   
    [GeneratedRegex(@"i")]
    private static partial Regex RuleReverse56();
              
    [GeneratedRegex(@"Ӥ")]
    private static partial Regex Rule57();
                   
    [GeneratedRegex(@"Î")]
    private static partial Regex RuleReverse57();
              
    [GeneratedRegex(@"ӥ")]
    private static partial Regex Rule58();
                   
    [GeneratedRegex(@"î")]
    private static partial Regex RuleReverse58();
              
    [GeneratedRegex(@"І")]
    private static partial Regex Rule59();
                   
    [GeneratedRegex(@"Ì")]
    private static partial Regex RuleReverse59();
              
    [GeneratedRegex(@"і")]
    private static partial Regex Rule60();
                   
    [GeneratedRegex(@"ì")]
    private static partial Regex RuleReverse60();
              
    [GeneratedRegex(@"Ї")]
    private static partial Regex Rule61();
                   
    [GeneratedRegex(@"Ï")]
    private static partial Regex RuleReverse61();
              
    [GeneratedRegex(@"ї")]
    private static partial Regex Rule62();
                   
    [GeneratedRegex(@"ï")]
    private static partial Regex RuleReverse62();
              
    [GeneratedRegex(@"Й")]
    private static partial Regex Rule63();
                   
    [GeneratedRegex(@"J")]
    private static partial Regex RuleReverse63();
              
    [GeneratedRegex(@"й")]
    private static partial Regex Rule64();
                   
    [GeneratedRegex(@"j")]
    private static partial Regex RuleReverse64();
              
    [GeneratedRegex(@"Ј")]
    private static partial Regex Rule65();
                   
    [GeneratedRegex(@"J̌")]
    private static partial Regex RuleReverse65();
              
    [GeneratedRegex(@"ј")]
    private static partial Regex Rule66();
                   
    [GeneratedRegex(@"ǰ")]
    private static partial Regex RuleReverse66();
              
    [GeneratedRegex(@"К")]
    private static partial Regex Rule67();
                   
    [GeneratedRegex(@"K")]
    private static partial Regex RuleReverse67();
              
    [GeneratedRegex(@"к")]
    private static partial Regex Rule68();
                   
    [GeneratedRegex(@"k")]
    private static partial Regex RuleReverse68();
              
    [GeneratedRegex(@"Қ")]
    private static partial Regex Rule69();
                   
    [GeneratedRegex(@"Ķ")]
    private static partial Regex RuleReverse69();
              
    [GeneratedRegex(@"қ")]
    private static partial Regex Rule70();
                   
    [GeneratedRegex(@"ķ")]
    private static partial Regex RuleReverse70();
              
    [GeneratedRegex(@"Ҟ")]
    private static partial Regex Rule71();
                   
    [GeneratedRegex(@"K̄")]
    private static partial Regex RuleReverse71();
              
    [GeneratedRegex(@"ҟ")]
    private static partial Regex Rule72();
                   
    [GeneratedRegex(@"k̄")]
    private static partial Regex RuleReverse72();
              
    [GeneratedRegex(@"Л")]
    private static partial Regex Rule73();
                   
    [GeneratedRegex(@"L")]
    private static partial Regex RuleReverse73();
              
    [GeneratedRegex(@"л")]
    private static partial Regex Rule74();
                   
    [GeneratedRegex(@"l")]
    private static partial Regex RuleReverse74();
              
    [GeneratedRegex(@"Љ")]
    private static partial Regex Rule75();
                   
    [GeneratedRegex(@"L̂")]
    private static partial Regex RuleReverse75();
              
    [GeneratedRegex(@"љ")]
    private static partial Regex Rule76();
                   
    [GeneratedRegex(@"l̂")]
    private static partial Regex RuleReverse76();
              
    [GeneratedRegex(@"М")]
    private static partial Regex Rule77();
                   
    [GeneratedRegex(@"M")]
    private static partial Regex RuleReverse77();
              
    [GeneratedRegex(@"м")]
    private static partial Regex Rule78();
                   
    [GeneratedRegex(@"m")]
    private static partial Regex RuleReverse78();
              
    [GeneratedRegex(@"Н")]
    private static partial Regex Rule79();
                   
    [GeneratedRegex(@"N")]
    private static partial Regex RuleReverse79();
              
    [GeneratedRegex(@"н")]
    private static partial Regex Rule80();
                   
    [GeneratedRegex(@"n")]
    private static partial Regex RuleReverse80();
              
    [GeneratedRegex(@"Њ")]
    private static partial Regex Rule81();
                   
    [GeneratedRegex(@"N̂")]
    private static partial Regex RuleReverse81();
              
    [GeneratedRegex(@"њ")]
    private static partial Regex Rule82();
                   
    [GeneratedRegex(@"n̂")]
    private static partial Regex RuleReverse82();
              
    [GeneratedRegex(@"Ҥ")]
    private static partial Regex Rule83();
                   
    [GeneratedRegex(@"Ṅ")]
    private static partial Regex RuleReverse83();
              
    [GeneratedRegex(@"ҥ")]
    private static partial Regex Rule84();
                   
    [GeneratedRegex(@"ṅ")]
    private static partial Regex RuleReverse84();
              
    [GeneratedRegex(@"Ң")]
    private static partial Regex Rule85();
                   
    [GeneratedRegex(@"Ṇ")]
    private static partial Regex RuleReverse85();
              
    [GeneratedRegex(@"ң")]
    private static partial Regex Rule86();
                   
    [GeneratedRegex(@"ṇ")]
    private static partial Regex RuleReverse86();
              
    [GeneratedRegex(@"О")]
    private static partial Regex Rule87();
                   
    [GeneratedRegex(@"O")]
    private static partial Regex RuleReverse87();
              
    [GeneratedRegex(@"о")]
    private static partial Regex Rule88();
                   
    [GeneratedRegex(@"o")]
    private static partial Regex RuleReverse88();
              
    [GeneratedRegex(@"Ӧ")]
    private static partial Regex Rule89();
                   
    [GeneratedRegex(@"Ö")]
    private static partial Regex RuleReverse89();
              
    [GeneratedRegex(@"ӧ")]
    private static partial Regex Rule90();
                   
    [GeneratedRegex(@"ö")]
    private static partial Regex RuleReverse90();
              
    [GeneratedRegex(@"Ө")]
    private static partial Regex Rule91();
                   
    [GeneratedRegex(@"Ô")]
    private static partial Regex RuleReverse91();
              
    [GeneratedRegex(@"ө")]
    private static partial Regex Rule92();
                   
    [GeneratedRegex(@"ô")]
    private static partial Regex RuleReverse92();
              
    [GeneratedRegex(@"П")]
    private static partial Regex Rule93();
                   
    [GeneratedRegex(@"P")]
    private static partial Regex RuleReverse93();
              
    [GeneratedRegex(@"п")]
    private static partial Regex Rule94();
                   
    [GeneratedRegex(@"p")]
    private static partial Regex RuleReverse94();
              
    [GeneratedRegex(@"Ҧ")]
    private static partial Regex Rule95();
                   
    [GeneratedRegex(@"Ṕ")]
    private static partial Regex RuleReverse95();
              
    [GeneratedRegex(@"ҧ")]
    private static partial Regex Rule96();
                   
    [GeneratedRegex(@"ṕ")]
    private static partial Regex RuleReverse96();
              
    [GeneratedRegex(@"Р")]
    private static partial Regex Rule97();
                   
    [GeneratedRegex(@"R")]
    private static partial Regex RuleReverse97();
              
    [GeneratedRegex(@"р")]
    private static partial Regex Rule98();
                   
    [GeneratedRegex(@"r")]
    private static partial Regex RuleReverse98();
              
    [GeneratedRegex(@"С")]
    private static partial Regex Rule99();
                   
    [GeneratedRegex(@"S")]
    private static partial Regex RuleReverse99();
              
    [GeneratedRegex(@"с")]
    private static partial Regex Rule100();
                   
    [GeneratedRegex(@"s")]
    private static partial Regex RuleReverse100();
              
    [GeneratedRegex(@"Ҫ")]
    private static partial Regex Rule101();
                   
    [GeneratedRegex(@"Ç")]
    private static partial Regex RuleReverse101();
              
    [GeneratedRegex(@"ҫ")]
    private static partial Regex Rule102();
                   
    [GeneratedRegex(@"ç")]
    private static partial Regex RuleReverse102();
              
    [GeneratedRegex(@"Т")]
    private static partial Regex Rule103();
                   
    [GeneratedRegex(@"T")]
    private static partial Regex RuleReverse103();
              
    [GeneratedRegex(@"т")]
    private static partial Regex Rule104();
                   
    [GeneratedRegex(@"t")]
    private static partial Regex RuleReverse104();
              
    [GeneratedRegex(@"Ҭ")]
    private static partial Regex Rule105();
                   
    [GeneratedRegex(@"Ţ")]
    private static partial Regex RuleReverse105();
              
    [GeneratedRegex(@"ҭ")]
    private static partial Regex Rule106();
                   
    [GeneratedRegex(@"ţ")]
    private static partial Regex RuleReverse106();
              
    [GeneratedRegex(@"Ћ")]
    private static partial Regex Rule107();
                   
    [GeneratedRegex(@"Ć")]
    private static partial Regex RuleReverse107();
              
    [GeneratedRegex(@"ћ")]
    private static partial Regex Rule108();
                   
    [GeneratedRegex(@"Ű")]
    private static partial Regex RuleReverse108();
              
    [GeneratedRegex(@"Ќ")]
    private static partial Regex Rule109();
                   
    [GeneratedRegex(@"Ḱ")]
    private static partial Regex RuleReverse109();
              
    [GeneratedRegex(@"ќ")]
    private static partial Regex Rule110();
                   
    [GeneratedRegex(@"ḱ")]
    private static partial Regex RuleReverse110();
              
    [GeneratedRegex(@"У")]
    private static partial Regex Rule111();
                   
    [GeneratedRegex(@"U")]
    private static partial Regex RuleReverse111();
              
    [GeneratedRegex(@"у")]
    private static partial Regex Rule112();
                   
    [GeneratedRegex(@"u")]
    private static partial Regex RuleReverse112();
              
    [GeneratedRegex(@"У́")]
    private static partial Regex Rule113();
                   
    [GeneratedRegex(@"Ú")]
    private static partial Regex RuleReverse113();
              
    [GeneratedRegex(@"у́")]
    private static partial Regex Rule114();
                   
    [GeneratedRegex(@"ú")]
    private static partial Regex RuleReverse114();
              
    [GeneratedRegex(@"Ў")]
    private static partial Regex Rule115();
                   
    [GeneratedRegex(@"Ŭ")]
    private static partial Regex RuleReverse115();
              
    [GeneratedRegex(@"ў")]
    private static partial Regex Rule116();
                   
    [GeneratedRegex(@"ŭ")]
    private static partial Regex RuleReverse116();
              
    [GeneratedRegex(@"Ӱ")]
    private static partial Regex Rule117();
                   
    [GeneratedRegex(@"Ü")]
    private static partial Regex RuleReverse117();
              
    [GeneratedRegex(@"ӱ")]
    private static partial Regex Rule118();
                   
    [GeneratedRegex(@"ü")]
    private static partial Regex RuleReverse118();
              
    [GeneratedRegex(@"Ӳ")]
    private static partial Regex Rule119();
                   
    [GeneratedRegex(@"Ű")]
    private static partial Regex RuleReverse119();
              
    [GeneratedRegex(@"ӳ")]
    private static partial Regex Rule120();
                   
    [GeneratedRegex(@"ű")]
    private static partial Regex RuleReverse120();
              
    [GeneratedRegex(@"Ү")]
    private static partial Regex Rule121();
                   
    [GeneratedRegex(@"Ù")]
    private static partial Regex RuleReverse121();
              
    [GeneratedRegex(@"ү")]
    private static partial Regex Rule122();
                   
    [GeneratedRegex(@"ù")]
    private static partial Regex RuleReverse122();
              
    [GeneratedRegex(@"Ф")]
    private static partial Regex Rule123();
                   
    [GeneratedRegex(@"F")]
    private static partial Regex RuleReverse123();
              
    [GeneratedRegex(@"ф")]
    private static partial Regex Rule124();
                   
    [GeneratedRegex(@"f")]
    private static partial Regex RuleReverse124();
              
    [GeneratedRegex(@"Х")]
    private static partial Regex Rule125();
                   
    [GeneratedRegex(@"H")]
    private static partial Regex RuleReverse125();
              
    [GeneratedRegex(@"х")]
    private static partial Regex Rule126();
                   
    [GeneratedRegex(@"h")]
    private static partial Regex RuleReverse126();
              
    [GeneratedRegex(@"Ҳ")]
    private static partial Regex Rule127();
                   
    [GeneratedRegex(@"Ḩ")]
    private static partial Regex RuleReverse127();
              
    [GeneratedRegex(@"ҳ")]
    private static partial Regex Rule128();
                   
    [GeneratedRegex(@"ḩ")]
    private static partial Regex RuleReverse128();
              
    [GeneratedRegex(@"Һ")]
    private static partial Regex Rule129();
                   
    [GeneratedRegex(@"Ḥ")]
    private static partial Regex RuleReverse129();
              
    [GeneratedRegex(@"һ")]
    private static partial Regex Rule130();
                   
    [GeneratedRegex(@"ḥ")]
    private static partial Regex RuleReverse130();
              
    [GeneratedRegex(@"Ц")]
    private static partial Regex Rule131();
                   
    [GeneratedRegex(@"C")]
    private static partial Regex RuleReverse131();
              
    [GeneratedRegex(@"ц")]
    private static partial Regex Rule132();
                   
    [GeneratedRegex(@"c")]
    private static partial Regex RuleReverse132();
              
    [GeneratedRegex(@"Ҵ")]
    private static partial Regex Rule133();
                   
    [GeneratedRegex(@"C̄")]
    private static partial Regex RuleReverse133();
              
    [GeneratedRegex(@"ҵ")]
    private static partial Regex Rule134();
                   
    [GeneratedRegex(@"c̄")]
    private static partial Regex RuleReverse134();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule135();
                   
    [GeneratedRegex(@"Č")]
    private static partial Regex RuleReverse135();
              
    [GeneratedRegex(@"ч")]
    private static partial Regex Rule136();
                   
    [GeneratedRegex(@"č")]
    private static partial Regex RuleReverse136();
              
    [GeneratedRegex(@"Ӵ")]
    private static partial Regex Rule137();
                   
    [GeneratedRegex(@"C̈")]
    private static partial Regex RuleReverse137();
              
    [GeneratedRegex(@"ӵ")]
    private static partial Regex Rule138();
                   
    [GeneratedRegex(@"c̈")]
    private static partial Regex RuleReverse138();
              
    [GeneratedRegex(@"Ӌ")]
    private static partial Regex Rule139();
                   
    [GeneratedRegex(@"Ç")]
    private static partial Regex RuleReverse139();
              
    [GeneratedRegex(@"ӌ")]
    private static partial Regex Rule140();
                   
    [GeneratedRegex(@"ç")]
    private static partial Regex RuleReverse140();
              
    [GeneratedRegex(@"Џ")]
    private static partial Regex Rule141();
                   
    [GeneratedRegex(@"D̂")]
    private static partial Regex RuleReverse141();
              
    [GeneratedRegex(@"џ")]
    private static partial Regex Rule142();
                   
    [GeneratedRegex(@"d̂")]
    private static partial Regex RuleReverse142();
              
    [GeneratedRegex(@"Ш")]
    private static partial Regex Rule143();
                   
    [GeneratedRegex(@"Š")]
    private static partial Regex RuleReverse143();
              
    [GeneratedRegex(@"ш")]
    private static partial Regex Rule144();
                   
    [GeneratedRegex(@"š")]
    private static partial Regex RuleReverse144();
              
    [GeneratedRegex(@"Щ")]
    private static partial Regex Rule145();
                   
    [GeneratedRegex(@"Ŝ")]
    private static partial Regex RuleReverse145();
              
    [GeneratedRegex(@"щ")]
    private static partial Regex Rule146();
                   
    [GeneratedRegex(@"ŝ")]
    private static partial Regex RuleReverse146();
              
    [GeneratedRegex(@"(?<=\p{Lu})Ъ")]
    private static partial Regex Rule147();
                   
    [GeneratedRegex(@"(?<=\p{Lu})ʺ")]
    private static partial Regex RuleReverse147();
              
    [GeneratedRegex(@"ъ")]
    private static partial Regex Rule148();
                   
    [GeneratedRegex(@"ʺ")]
    private static partial Regex RuleReverse148();
              
    [GeneratedRegex(@"ʼ")]
    private static partial Regex Rule149();
                   
    [GeneratedRegex(@"’")]
    private static partial Regex RuleReverse149();
              
    [GeneratedRegex(@"Ы")]
    private static partial Regex Rule150();
                   
    [GeneratedRegex(@"Y")]
    private static partial Regex RuleReverse150();
              
    [GeneratedRegex(@"ы")]
    private static partial Regex Rule151();
                   
    [GeneratedRegex(@"y")]
    private static partial Regex RuleReverse151();
              
    [GeneratedRegex(@"Ӹ")]
    private static partial Regex Rule152();
                   
    [GeneratedRegex(@"Ÿ")]
    private static partial Regex RuleReverse152();
              
    [GeneratedRegex(@"ӹ")]
    private static partial Regex Rule153();
                   
    [GeneratedRegex(@"ÿ")]
    private static partial Regex RuleReverse153();
              
    [GeneratedRegex(@"(?<=\p{Lu})Ь")]
    private static partial Regex Rule154();
                   
    [GeneratedRegex(@"(?<=\p{Lu})ʹ")]
    private static partial Regex RuleReverse154();
              
    [GeneratedRegex(@"ь")]
    private static partial Regex Rule155();
                   
    [GeneratedRegex(@"ʹ")]
    private static partial Regex RuleReverse155();
              
    [GeneratedRegex(@"Э")]
    private static partial Regex Rule156();
                   
    [GeneratedRegex(@"È")]
    private static partial Regex RuleReverse156();
              
    [GeneratedRegex(@"э")]
    private static partial Regex Rule157();
                   
    [GeneratedRegex(@"è")]
    private static partial Regex RuleReverse157();
              
    [GeneratedRegex(@"Ю")]
    private static partial Regex Rule158();
                   
    [GeneratedRegex(@"Û")]
    private static partial Regex RuleReverse158();
              
    [GeneratedRegex(@"ю")]
    private static partial Regex Rule159();
                   
    [GeneratedRegex(@"û")]
    private static partial Regex RuleReverse159();
              
    [GeneratedRegex(@"Я")]
    private static partial Regex Rule160();
                   
    [GeneratedRegex(@"Â")]
    private static partial Regex RuleReverse160();
              
    [GeneratedRegex(@"я")]
    private static partial Regex Rule161();
                   
    [GeneratedRegex(@"â")]
    private static partial Regex RuleReverse161();
              
    [GeneratedRegex(@"Ҍ")]
    private static partial Regex Rule162();
                   
    [GeneratedRegex(@"Ě")]
    private static partial Regex RuleReverse162();
              
    [GeneratedRegex(@"ҍ")]
    private static partial Regex Rule163();
                   
    [GeneratedRegex(@"ě")]
    private static partial Regex RuleReverse163();
              
    [GeneratedRegex(@"Ѫ")]
    private static partial Regex Rule164();
                   
    [GeneratedRegex(@"Ǎ")]
    private static partial Regex RuleReverse164();
              
    [GeneratedRegex(@"ѫ")]
    private static partial Regex Rule165();
                   
    [GeneratedRegex(@"ǎ")]
    private static partial Regex RuleReverse165();
              
    [GeneratedRegex(@"Ѳ")]
    private static partial Regex Rule166();
                   
    [GeneratedRegex(@"F̀")]
    private static partial Regex RuleReverse166();
              
    [GeneratedRegex(@"ѳ")]
    private static partial Regex Rule167();
                   
    [GeneratedRegex(@"f̀")]
    private static partial Regex RuleReverse167();
              
    [GeneratedRegex(@"Ѵ")]
    private static partial Regex Rule168();
                   
    [GeneratedRegex(@"Ỳ")]
    private static partial Regex RuleReverse168();
              
    [GeneratedRegex(@"ѵ")]
    private static partial Regex Rule169();
                   
    [GeneratedRegex(@"ỳ")]
    private static partial Regex RuleReverse169();
              
    [GeneratedRegex(@"Ҩ")]
    private static partial Regex Rule170();
                   
    [GeneratedRegex(@"Ò")]
    private static partial Regex RuleReverse170();
              
    [GeneratedRegex(@"ҩ")]
    private static partial Regex Rule171();
                   
    [GeneratedRegex(@"ò")]
    private static partial Regex RuleReverse171();
              
    [GeneratedRegex(@"Ӏ")]
    private static partial Regex Rule172();
                   
    [GeneratedRegex(@"‡")]
    private static partial Regex RuleReverse172();

}
