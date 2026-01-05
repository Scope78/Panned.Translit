using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_iso_843 : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.iso_843;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"A");
        output = Rule2().Replace(output, @"a");
        output = Rule3().Replace(output, @"V");
        output = Rule4().Replace(output, @"v");
        output = Rule5().Replace(output, @"G");
        output = Rule6().Replace(output, @"g");
        output = Rule7().Replace(output, @"D");
        output = Rule8().Replace(output, @"d");
        output = Rule9().Replace(output, @"E");
        output = Rule10().Replace(output, @"e");
        output = Rule11().Replace(output, @"Z");
        output = Rule12().Replace(output, @"z");
        output = Rule13().Replace(output, @"Ī");
        output = Rule14().Replace(output, @"ī");
        output = Rule15().Replace(output, @"Th");
        output = Rule16().Replace(output, @"th");
        output = Rule17().Replace(output, @"I");
        output = Rule18().Replace(output, @"i");
        output = Rule19().Replace(output, @"K");
        output = Rule20().Replace(output, @"k");
        output = Rule21().Replace(output, @"L");
        output = Rule22().Replace(output, @"l");
        output = Rule23().Replace(output, @"M");
        output = Rule24().Replace(output, @"m");
        output = Rule25().Replace(output, @"N");
        output = Rule26().Replace(output, @"n");
        output = Rule27().Replace(output, @"X");
        output = Rule28().Replace(output, @"x");
        output = Rule29().Replace(output, @"O");
        output = Rule30().Replace(output, @"o");
        output = Rule31().Replace(output, @"P");
        output = Rule32().Replace(output, @"p");
        output = Rule33().Replace(output, @"R");
        output = Rule34().Replace(output, @"r");
        output = Rule35().Replace(output, @"S");
        output = Rule36().Replace(output, @"s");
        output = Rule37().Replace(output, @"s");
        output = Rule38().Replace(output, @"T");
        output = Rule39().Replace(output, @"t");
        output = Rule40().Replace(output, @"Y");
        output = Rule41().Replace(output, @"y");
        output = Rule42().Replace(output, @"F");
        output = Rule43().Replace(output, @"f");
        output = Rule44().Replace(output, @"Ch");
        output = Rule45().Replace(output, @"ch");
        output = Rule46().Replace(output, @"Ps");
        output = Rule47().Replace(output, @"ps");
        output = Rule48().Replace(output, @"Ō");
        output = Rule49().Replace(output, @"ō");
        output = Rule50().Replace(output, @"S");
        output = Rule51().Replace(output, @"s");
        output = Rule52().Replace(output, @"W");
        output = Rule53().Replace(output, @"f");
        output = Rule54().Replace(output, @"j");
        output = Rule55().Replace(output, @"´");
        output = Rule56().Replace(output, @"΅");
        output = Rule57().Replace(output, @"̂");
        output = Rule58().Replace(output, @"ʼ");
        output = Rule59().Replace(output, @"ʼ");
        output = Rule60().Replace(output, @"h");
        output = Rule61().Replace(output, @"̧");
        output = Rule62().Replace(output, @"̧");
        output = Rule63().Replace(output, @"Á");
        output = Rule64().Replace(output, @"á");
        output = Rule65().Replace(output, @"É");
        output = Rule66().Replace(output, @"é");
        output = Rule67().Replace(output, @"Ī́");
        output = Rule68().Replace(output, @"ī́");
        output = Rule69().Replace(output, @"Í");
        output = Rule70().Replace(output, @"í");
        output = Rule71().Replace(output, @"Ó");
        output = Rule72().Replace(output, @"ó");
        output = Rule73().Replace(output, @"Ý");
        output = Rule74().Replace(output, @"ý");
        output = Rule75().Replace(output, @"Ṓ");
        output = Rule76().Replace(output, @"ṓ");
        output = Rule77().Replace(output, @"Ï");
        output = Rule78().Replace(output, @"ï");
        output = Rule79().Replace(output, @"Ÿ");
        output = Rule80().Replace(output, @"ÿ");
        output = Rule81().Replace(output, @"ḯ");
        output = Rule82().Replace(output, @"ÿ́");
        output = Rule83().Replace(output, @"?");
        output = Rule84().Replace(output, @"?");
        output = Rule85().Replace(output, @";");
        output = Rule86().Replace(output, @"-");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new NotReversableException();
    }
              
    [GeneratedRegex(@"Α")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"α")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"Β")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"β")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"Γ")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"γ")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"Δ")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"δ")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"Ε")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"ε")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"Ζ")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"ζ")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"Η")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"η")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"Θ")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"θ")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"Ι")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"ι")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"Κ")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"κ")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"Λ")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"λ")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"Μ")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"μ")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"Ν")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"ν")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"Ξ")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"ξ")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"Ο")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"ο")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"Π")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"π")]
    private static partial Regex Rule32();
              
    [GeneratedRegex(@"Ρ")]
    private static partial Regex Rule33();
              
    [GeneratedRegex(@"ρ")]
    private static partial Regex Rule34();
              
    [GeneratedRegex(@"Σ")]
    private static partial Regex Rule35();
              
    [GeneratedRegex(@"ς")]
    private static partial Regex Rule36();
              
    [GeneratedRegex(@"σ")]
    private static partial Regex Rule37();
              
    [GeneratedRegex(@"Τ")]
    private static partial Regex Rule38();
              
    [GeneratedRegex(@"τ")]
    private static partial Regex Rule39();
              
    [GeneratedRegex(@"Υ")]
    private static partial Regex Rule40();
              
    [GeneratedRegex(@"υ")]
    private static partial Regex Rule41();
              
    [GeneratedRegex(@"Φ")]
    private static partial Regex Rule42();
              
    [GeneratedRegex(@"φ")]
    private static partial Regex Rule43();
              
    [GeneratedRegex(@"Χ")]
    private static partial Regex Rule44();
              
    [GeneratedRegex(@"χ")]
    private static partial Regex Rule45();
              
    [GeneratedRegex(@"Ψ")]
    private static partial Regex Rule46();
              
    [GeneratedRegex(@"ψ")]
    private static partial Regex Rule47();
              
    [GeneratedRegex(@"Ω")]
    private static partial Regex Rule48();
              
    [GeneratedRegex(@"ω")]
    private static partial Regex Rule49();
              
    [GeneratedRegex(@"Ϛ")]
    private static partial Regex Rule50();
              
    [GeneratedRegex(@"ϛ")]
    private static partial Regex Rule51();
              
    [GeneratedRegex(@"Ϝ")]
    private static partial Regex Rule52();
              
    [GeneratedRegex(@"ϝ")]
    private static partial Regex Rule53();
              
    [GeneratedRegex(@"ϳ")]
    private static partial Regex Rule54();
              
    [GeneratedRegex(@"΄")]
    private static partial Regex Rule55();
              
    [GeneratedRegex(@"΅")]
    private static partial Regex Rule56();
              
    [GeneratedRegex(@"͂")]
    private static partial Regex Rule57();
              
    [GeneratedRegex(@"̓")]
    private static partial Regex Rule58();
              
    [GeneratedRegex(@"̓")]
    private static partial Regex Rule59();
              
    [GeneratedRegex(@"̔")]
    private static partial Regex Rule60();
              
    [GeneratedRegex(@"ͅ")]
    private static partial Regex Rule61();
              
    [GeneratedRegex(@"ͅ")]
    private static partial Regex Rule62();
              
    [GeneratedRegex(@"Ά")]
    private static partial Regex Rule63();
              
    [GeneratedRegex(@"ά")]
    private static partial Regex Rule64();
              
    [GeneratedRegex(@"Έ")]
    private static partial Regex Rule65();
              
    [GeneratedRegex(@"έ")]
    private static partial Regex Rule66();
              
    [GeneratedRegex(@"Ή")]
    private static partial Regex Rule67();
              
    [GeneratedRegex(@"ή")]
    private static partial Regex Rule68();
              
    [GeneratedRegex(@"Ί")]
    private static partial Regex Rule69();
              
    [GeneratedRegex(@"ί")]
    private static partial Regex Rule70();
              
    [GeneratedRegex(@"Ό")]
    private static partial Regex Rule71();
              
    [GeneratedRegex(@"ό")]
    private static partial Regex Rule72();
              
    [GeneratedRegex(@"Ύ")]
    private static partial Regex Rule73();
              
    [GeneratedRegex(@"ύ")]
    private static partial Regex Rule74();
              
    [GeneratedRegex(@"Ώ")]
    private static partial Regex Rule75();
              
    [GeneratedRegex(@"ώ")]
    private static partial Regex Rule76();
              
    [GeneratedRegex(@"Ϊ")]
    private static partial Regex Rule77();
              
    [GeneratedRegex(@"ϊ")]
    private static partial Regex Rule78();
              
    [GeneratedRegex(@"Ϋ")]
    private static partial Regex Rule79();
              
    [GeneratedRegex(@"ϋ")]
    private static partial Regex Rule80();
              
    [GeneratedRegex(@"ΐ")]
    private static partial Regex Rule81();
              
    [GeneratedRegex(@"ΰ")]
    private static partial Regex Rule82();
              
    [GeneratedRegex(@"(?<=\b);")]
    private static partial Regex Rule83();
              
    [GeneratedRegex(@"(?<=\b);")]
    private static partial Regex Rule84();
              
    [GeneratedRegex(@"·")]
    private static partial Regex Rule85();
              
    [GeneratedRegex(@"‿")]
    private static partial Regex Rule86();

}
