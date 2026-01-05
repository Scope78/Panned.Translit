using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_bgn_pcgn_rus_strict : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.bgn_pcgn_rus_strict;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"");
        output = Rule2().Replace(output, @"Ye");
        output = Rule3().Replace(output, @"Ye");
        output = Rule4().Replace(output, @"E");
        output = Rule5().Replace(output, @"Yë");
        output = Rule6().Replace(output, @"Yë");
        output = Rule7().Replace(output, @"Ë");
        output = Rule8().Replace(output, @"Y·");
        output = Rule9().Replace(output, @"Y");
        output = Rule10().Replace(output, @"Y·");
        output = Rule11().Replace(output, @"·Y");
        output = Rule12().Replace(output, @"Y");
        output = Rule13().Replace(output, @"·E");
        output = Rule14().Replace(output, @"E");
        output = Rule15().Replace(output, @"A");
        output = Rule16().Replace(output, @"B");
        output = Rule17().Replace(output, @"V");
        output = Rule18().Replace(output, @"G");
        output = Rule19().Replace(output, @"D");
        output = Rule20().Replace(output, @"Zh");
        output = Rule21().Replace(output, @"Z");
        output = Rule22().Replace(output, @"I");
        output = Rule23().Replace(output, @"K");
        output = Rule24().Replace(output, @"L");
        output = Rule25().Replace(output, @"M");
        output = Rule26().Replace(output, @"N");
        output = Rule27().Replace(output, @"O");
        output = Rule28().Replace(output, @"P");
        output = Rule29().Replace(output, @"R");
        output = Rule30().Replace(output, @"T·S");
        output = Rule31().Replace(output, @"T·s");
        output = Rule32().Replace(output, @"S");
        output = Rule33().Replace(output, @"T");
        output = Rule34().Replace(output, @"U");
        output = Rule35().Replace(output, @"F");
        output = Rule36().Replace(output, @"Kh");
        output = Rule37().Replace(output, @"Ts");
        output = Rule38().Replace(output, @"Sh·Ch");
        output = Rule39().Replace(output, @"Sh·ch");
        output = Rule40().Replace(output, @"Ch");
        output = Rule41().Replace(output, @"Sh");
        output = Rule42().Replace(output, @"Shch");
        output = Rule43().Replace(output, @"''");
        output = Rule44().Replace(output, @"'");
        output = Rule45().Replace(output, @"Yu");
        output = Rule46().Replace(output, @"Ya");
        output = Rule47().Replace(output, @"ye");
        output = Rule48().Replace(output, @"ye");
        output = Rule49().Replace(output, @"e");
        output = Rule50().Replace(output, @"yë");
        output = Rule51().Replace(output, @"yë");
        output = Rule52().Replace(output, @"ë");
        output = Rule53().Replace(output, @"y·");
        output = Rule54().Replace(output, @"y");
        output = Rule55().Replace(output, @"y·");
        output = Rule56().Replace(output, @"·y");
        output = Rule57().Replace(output, @"y");
        output = Rule58().Replace(output, @"·e");
        output = Rule59().Replace(output, @"e");
        output = Rule60().Replace(output, @"a");
        output = Rule61().Replace(output, @"b");
        output = Rule62().Replace(output, @"v");
        output = Rule63().Replace(output, @"g");
        output = Rule64().Replace(output, @"d");
        output = Rule65().Replace(output, @"zh");
        output = Rule66().Replace(output, @"z");
        output = Rule67().Replace(output, @"i");
        output = Rule68().Replace(output, @"k");
        output = Rule69().Replace(output, @"l");
        output = Rule70().Replace(output, @"m");
        output = Rule71().Replace(output, @"n");
        output = Rule72().Replace(output, @"o");
        output = Rule73().Replace(output, @"p");
        output = Rule74().Replace(output, @"r");
        output = Rule75().Replace(output, @"t·s");
        output = Rule76().Replace(output, @"s");
        output = Rule77().Replace(output, @"t");
        output = Rule78().Replace(output, @"u");
        output = Rule79().Replace(output, @"f");
        output = Rule80().Replace(output, @"kh");
        output = Rule81().Replace(output, @"ts");
        output = Rule82().Replace(output, @"sh·ch");
        output = Rule83().Replace(output, @"ch");
        output = Rule84().Replace(output, @"sh");
        output = Rule85().Replace(output, @"shch");
        output = Rule86().Replace(output, @"''");
        output = Rule87().Replace(output, @"'");
        output = Rule88().Replace(output, @"yu");
        output = Rule89().Replace(output, @"ya");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new NotReversableException();
    }
              
    [GeneratedRegex(@"́")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"(?<=[АЕЁИОУЫЭЮЯЙЬЪаеёиоуыэюяйьъ])Е")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"(?<=\b)Е")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"Е")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"(?<=[АЕЁИОУЫЭЮЯЙЬЪаеёиоуыэюяйьъe])Ё")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"(?<=\b)Ё")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"Ё")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"Й(?=[АУЫЭауыэ])")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"Й")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"Ы(?=[АУЫЭауыэ])")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"(?<=[АЕЁИОУЫЭЮЯЙаеёиоуыэюяйeëY])Ы")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"Ы")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"(?<=[БВГДЖЗКЛМНПРСТФХЦЧШЩбвгджзклмнпрстфхцчшщ])Э")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"Э")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"А")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"Б")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"В")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"Г")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"Д")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"Ж")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"З")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"И")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"К")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"Л")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"М")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"Н")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"О")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"П")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"Р")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"ТС")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"Тс")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"С")]
    private static partial Regex Rule32();
              
    [GeneratedRegex(@"Т")]
    private static partial Regex Rule33();
              
    [GeneratedRegex(@"У")]
    private static partial Regex Rule34();
              
    [GeneratedRegex(@"Ф")]
    private static partial Regex Rule35();
              
    [GeneratedRegex(@"Х")]
    private static partial Regex Rule36();
              
    [GeneratedRegex(@"Ц")]
    private static partial Regex Rule37();
              
    [GeneratedRegex(@"ШЧ")]
    private static partial Regex Rule38();
              
    [GeneratedRegex(@"Шч")]
    private static partial Regex Rule39();
              
    [GeneratedRegex(@"Ч")]
    private static partial Regex Rule40();
              
    [GeneratedRegex(@"Ш")]
    private static partial Regex Rule41();
              
    [GeneratedRegex(@"Щ")]
    private static partial Regex Rule42();
              
    [GeneratedRegex(@"Ъ")]
    private static partial Regex Rule43();
              
    [GeneratedRegex(@"Ь")]
    private static partial Regex Rule44();
              
    [GeneratedRegex(@"Ю")]
    private static partial Regex Rule45();
              
    [GeneratedRegex(@"Я")]
    private static partial Regex Rule46();
              
    [GeneratedRegex(@"(?<=[AEËIOUYeëau'аеёиоуыэюяйьъ·])е")]
    private static partial Regex Rule47();
              
    [GeneratedRegex(@"(?<=\b)е")]
    private static partial Regex Rule48();
              
    [GeneratedRegex(@"е")]
    private static partial Regex Rule49();
              
    [GeneratedRegex(@"(?<=[AEËIOUYeëau'аеёиоуыэюяйьъ·])ё")]
    private static partial Regex Rule50();
              
    [GeneratedRegex(@"(?<=\b)ё")]
    private static partial Regex Rule51();
              
    [GeneratedRegex(@"ё")]
    private static partial Regex Rule52();
              
    [GeneratedRegex(@"й(?=[AUYEауыэ])")]
    private static partial Regex Rule53();
              
    [GeneratedRegex(@"й")]
    private static partial Regex Rule54();
              
    [GeneratedRegex(@"ы(?=[AUYE·ауыэ])")]
    private static partial Regex Rule55();
              
    [GeneratedRegex(@"(?<=[AEËIOUYaueëyаеёиоуыэюя])ы")]
    private static partial Regex Rule56();
              
    [GeneratedRegex(@"ы")]
    private static partial Regex Rule57();
              
    [GeneratedRegex(@"(?<=[BVGDZhKLMNPRSTsFCScбвгджзклмнпрстфхцчшщ])э")]
    private static partial Regex Rule58();
              
    [GeneratedRegex(@"э")]
    private static partial Regex Rule59();
              
    [GeneratedRegex(@"а")]
    private static partial Regex Rule60();
              
    [GeneratedRegex(@"б")]
    private static partial Regex Rule61();
              
    [GeneratedRegex(@"в")]
    private static partial Regex Rule62();
              
    [GeneratedRegex(@"г")]
    private static partial Regex Rule63();
              
    [GeneratedRegex(@"д")]
    private static partial Regex Rule64();
              
    [GeneratedRegex(@"ж")]
    private static partial Regex Rule65();
              
    [GeneratedRegex(@"з")]
    private static partial Regex Rule66();
              
    [GeneratedRegex(@"и")]
    private static partial Regex Rule67();
              
    [GeneratedRegex(@"к")]
    private static partial Regex Rule68();
              
    [GeneratedRegex(@"л")]
    private static partial Regex Rule69();
              
    [GeneratedRegex(@"м")]
    private static partial Regex Rule70();
              
    [GeneratedRegex(@"н")]
    private static partial Regex Rule71();
              
    [GeneratedRegex(@"о")]
    private static partial Regex Rule72();
              
    [GeneratedRegex(@"п")]
    private static partial Regex Rule73();
              
    [GeneratedRegex(@"р")]
    private static partial Regex Rule74();
              
    [GeneratedRegex(@"тс")]
    private static partial Regex Rule75();
              
    [GeneratedRegex(@"с")]
    private static partial Regex Rule76();
              
    [GeneratedRegex(@"т")]
    private static partial Regex Rule77();
              
    [GeneratedRegex(@"у")]
    private static partial Regex Rule78();
              
    [GeneratedRegex(@"ф")]
    private static partial Regex Rule79();
              
    [GeneratedRegex(@"х")]
    private static partial Regex Rule80();
              
    [GeneratedRegex(@"ц")]
    private static partial Regex Rule81();
              
    [GeneratedRegex(@"шч")]
    private static partial Regex Rule82();
              
    [GeneratedRegex(@"ч")]
    private static partial Regex Rule83();
              
    [GeneratedRegex(@"ш")]
    private static partial Regex Rule84();
              
    [GeneratedRegex(@"щ")]
    private static partial Regex Rule85();
              
    [GeneratedRegex(@"ъ")]
    private static partial Regex Rule86();
              
    [GeneratedRegex(@"ь")]
    private static partial Regex Rule87();
              
    [GeneratedRegex(@"ю")]
    private static partial Regex Rule88();
              
    [GeneratedRegex(@"я")]
    private static partial Regex Rule89();

}
