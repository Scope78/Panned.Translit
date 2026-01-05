using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_din_31634 : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.din_31634;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"AU");
        output = Rule2().Replace(output, @"au");
        output = Rule3().Replace(output, @"Au");
        output = Rule4().Replace(output, @"AŸ");
        output = Rule5().Replace(output, @"aÿ");
        output = Rule6().Replace(output, @"NG");
        output = Rule7().Replace(output, @"ng");
        output = Rule8().Replace(output, @"Ng");
        output = Rule9().Replace(output, @"GK");
        output = Rule10().Replace(output, @"gk");
        output = Rule11().Replace(output, @"Gk");
        output = Rule12().Replace(output, @"NK");
        output = Rule13().Replace(output, @"nk");
        output = Rule14().Replace(output, @"Nk");
        output = Rule15().Replace(output, @"NX");
        output = Rule16().Replace(output, @"nx");
        output = Rule17().Replace(output, @"Nx");
        output = Rule18().Replace(output, @"nch");
        output = Rule19().Replace(output, @"nch");
        output = Rule20().Replace(output, @"Nch");
        output = Rule21().Replace(output, @"EU");
        output = Rule22().Replace(output, @"eu");
        output = Rule23().Replace(output, @"Eu");
        output = Rule24().Replace(output, @"ĒU");
        output = Rule25().Replace(output, @"ēu");
        output = Rule26().Replace(output, @"Ēu");
        output = Rule27().Replace(output, @"U");
        output = Rule28().Replace(output, @"u");
        output = Rule29().Replace(output, @"U");
        output = Rule30().Replace(output, @"OŸ");
        output = Rule31().Replace(output, @"oÿ");
        output = Rule32().Replace(output, @"A");
        output = Rule33().Replace(output, @"a");
        output = Rule34().Replace(output, @"B");
        output = Rule35().Replace(output, @"b");
        output = Rule36().Replace(output, @"G");
        output = Rule37().Replace(output, @"g");
        output = Rule38().Replace(output, @"D");
        output = Rule39().Replace(output, @"d");
        output = Rule40().Replace(output, @"E");
        output = Rule41().Replace(output, @"e");
        output = Rule42().Replace(output, @"Z");
        output = Rule43().Replace(output, @"z");
        output = Rule44().Replace(output, @"Ē");
        output = Rule45().Replace(output, @"ē");
        output = Rule46().Replace(output, @"Th");
        output = Rule47().Replace(output, @"th");
        output = Rule48().Replace(output, @"th");
        output = Rule49().Replace(output, @"I");
        output = Rule50().Replace(output, @"i");
        output = Rule51().Replace(output, @"K");
        output = Rule52().Replace(output, @"k");
        output = Rule53().Replace(output, @"L");
        output = Rule54().Replace(output, @"l");
        output = Rule55().Replace(output, @"M");
        output = Rule56().Replace(output, @"m");
        output = Rule57().Replace(output, @"N");
        output = Rule58().Replace(output, @"n");
        output = Rule59().Replace(output, @"X");
        output = Rule60().Replace(output, @"x");
        output = Rule61().Replace(output, @"O");
        output = Rule62().Replace(output, @"o");
        output = Rule63().Replace(output, @"P");
        output = Rule64().Replace(output, @"p");
        output = Rule65().Replace(output, @"R");
        output = Rule66().Replace(output, @"r");
        output = Rule67().Replace(output, @"S");
        output = Rule68().Replace(output, @"s");
        output = Rule69().Replace(output, @"s");
        output = Rule70().Replace(output, @"T");
        output = Rule71().Replace(output, @"t");
        output = Rule72().Replace(output, @"Y");
        output = Rule73().Replace(output, @"y");
        output = Rule74().Replace(output, @"Ph");
        output = Rule75().Replace(output, @"ph");
        output = Rule76().Replace(output, @"ph");
        output = Rule77().Replace(output, @"Ch");
        output = Rule78().Replace(output, @"ch");
        output = Rule79().Replace(output, @"Ps");
        output = Rule80().Replace(output, @"ps");
        output = Rule81().Replace(output, @"Ō");
        output = Rule82().Replace(output, @"ō");
        output = Rule83().Replace(output, @"A");
        output = Rule84().Replace(output, @"a");
        output = Rule85().Replace(output, @"E");
        output = Rule86().Replace(output, @"e");
        output = Rule87().Replace(output, @"Ē");
        output = Rule88().Replace(output, @"ē");
        output = Rule89().Replace(output, @"I");
        output = Rule90().Replace(output, @"i");
        output = Rule91().Replace(output, @"I");
        output = Rule92().Replace(output, @"i");
        output = Rule93().Replace(output, @"i");
        output = Rule94().Replace(output, @"O");
        output = Rule95().Replace(output, @"o");
        output = Rule96().Replace(output, @"Y");
        output = Rule97().Replace(output, @"y");
        output = Rule98().Replace(output, @"Y");
        output = Rule99().Replace(output, @"y");
        output = Rule100().Replace(output, @"y");
        output = Rule101().Replace(output, @"Ō");
        output = Rule102().Replace(output, @"ō");
        output = Rule103().Replace(output, @"?");
        output = Rule104().Replace(output, @"?");
        output = Rule105().Replace(output, @";");
        output = Rule106().Replace(output, @"");
        output = Rule107().Replace(output, @"");
        output = Rule108().Replace(output, @"");
        output = Rule109().Replace(output, @"");
        output = Rule110().Replace(output, @"");
        output = Rule111().Replace(output, @"");
        output = Rule112().Replace(output, @"");
        output = Rule113().Replace(output, @"");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new NotReversableException();
    }
              
    [GeneratedRegex(@"ΑΥ")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"αυ")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"Αυ")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"ΑΫ")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"αϋ")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"ΓΓ")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"γγ")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"Γγ")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"(?<=\b)ΓΚ")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"(?<=\b)γκ")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"(?<=\b)Γκ")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"ΓΚ")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"γκ")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"Γκ")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"ΓΞ")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"γξ")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"Γξ")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"ΓΧ")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"γχ")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"Γχ")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"ΕΥ")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"ευ")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"Ευ")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"ΗΥ")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"ηυ")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"Ηυ")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"ΟΥ")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"ου")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"Ου")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"ΟΫ")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"οϋ")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"Α")]
    private static partial Regex Rule32();
              
    [GeneratedRegex(@"α")]
    private static partial Regex Rule33();
              
    [GeneratedRegex(@"Β")]
    private static partial Regex Rule34();
              
    [GeneratedRegex(@"β")]
    private static partial Regex Rule35();
              
    [GeneratedRegex(@"Γ")]
    private static partial Regex Rule36();
              
    [GeneratedRegex(@"γ")]
    private static partial Regex Rule37();
              
    [GeneratedRegex(@"Δ")]
    private static partial Regex Rule38();
              
    [GeneratedRegex(@"δ")]
    private static partial Regex Rule39();
              
    [GeneratedRegex(@"Ε")]
    private static partial Regex Rule40();
              
    [GeneratedRegex(@"ε")]
    private static partial Regex Rule41();
              
    [GeneratedRegex(@"Ζ")]
    private static partial Regex Rule42();
              
    [GeneratedRegex(@"ζ")]
    private static partial Regex Rule43();
              
    [GeneratedRegex(@"Η")]
    private static partial Regex Rule44();
              
    [GeneratedRegex(@"η")]
    private static partial Regex Rule45();
              
    [GeneratedRegex(@"Θ")]
    private static partial Regex Rule46();
              
    [GeneratedRegex(@"θ")]
    private static partial Regex Rule47();
              
    [GeneratedRegex(@"ϑ")]
    private static partial Regex Rule48();
              
    [GeneratedRegex(@"Ι")]
    private static partial Regex Rule49();
              
    [GeneratedRegex(@"ι")]
    private static partial Regex Rule50();
              
    [GeneratedRegex(@"Κ")]
    private static partial Regex Rule51();
              
    [GeneratedRegex(@"κ")]
    private static partial Regex Rule52();
              
    [GeneratedRegex(@"Λ")]
    private static partial Regex Rule53();
              
    [GeneratedRegex(@"λ")]
    private static partial Regex Rule54();
              
    [GeneratedRegex(@"Μ")]
    private static partial Regex Rule55();
              
    [GeneratedRegex(@"μ")]
    private static partial Regex Rule56();
              
    [GeneratedRegex(@"Ν")]
    private static partial Regex Rule57();
              
    [GeneratedRegex(@"ν")]
    private static partial Regex Rule58();
              
    [GeneratedRegex(@"Ξ")]
    private static partial Regex Rule59();
              
    [GeneratedRegex(@"ξ")]
    private static partial Regex Rule60();
              
    [GeneratedRegex(@"Ο")]
    private static partial Regex Rule61();
              
    [GeneratedRegex(@"ο")]
    private static partial Regex Rule62();
              
    [GeneratedRegex(@"Π")]
    private static partial Regex Rule63();
              
    [GeneratedRegex(@"π")]
    private static partial Regex Rule64();
              
    [GeneratedRegex(@"Ρ")]
    private static partial Regex Rule65();
              
    [GeneratedRegex(@"ρ")]
    private static partial Regex Rule66();
              
    [GeneratedRegex(@"Σ")]
    private static partial Regex Rule67();
              
    [GeneratedRegex(@"σ")]
    private static partial Regex Rule68();
              
    [GeneratedRegex(@"ς(?=\b)")]
    private static partial Regex Rule69();
              
    [GeneratedRegex(@"Τ")]
    private static partial Regex Rule70();
              
    [GeneratedRegex(@"τ")]
    private static partial Regex Rule71();
              
    [GeneratedRegex(@"Υ")]
    private static partial Regex Rule72();
              
    [GeneratedRegex(@"υ")]
    private static partial Regex Rule73();
              
    [GeneratedRegex(@"Φ")]
    private static partial Regex Rule74();
              
    [GeneratedRegex(@"φ")]
    private static partial Regex Rule75();
              
    [GeneratedRegex(@"ϕ")]
    private static partial Regex Rule76();
              
    [GeneratedRegex(@"Χ")]
    private static partial Regex Rule77();
              
    [GeneratedRegex(@"χ")]
    private static partial Regex Rule78();
              
    [GeneratedRegex(@"Ψ")]
    private static partial Regex Rule79();
              
    [GeneratedRegex(@"ψ")]
    private static partial Regex Rule80();
              
    [GeneratedRegex(@"Ω")]
    private static partial Regex Rule81();
              
    [GeneratedRegex(@"ω")]
    private static partial Regex Rule82();
              
    [GeneratedRegex(@"Ά")]
    private static partial Regex Rule83();
              
    [GeneratedRegex(@"ά")]
    private static partial Regex Rule84();
              
    [GeneratedRegex(@"Έ")]
    private static partial Regex Rule85();
              
    [GeneratedRegex(@"έ")]
    private static partial Regex Rule86();
              
    [GeneratedRegex(@"Ή")]
    private static partial Regex Rule87();
              
    [GeneratedRegex(@"ή")]
    private static partial Regex Rule88();
              
    [GeneratedRegex(@"Ί")]
    private static partial Regex Rule89();
              
    [GeneratedRegex(@"ί")]
    private static partial Regex Rule90();
              
    [GeneratedRegex(@"Ϊ")]
    private static partial Regex Rule91();
              
    [GeneratedRegex(@"ϊ")]
    private static partial Regex Rule92();
              
    [GeneratedRegex(@"ΐ")]
    private static partial Regex Rule93();
              
    [GeneratedRegex(@"Ό")]
    private static partial Regex Rule94();
              
    [GeneratedRegex(@"ό")]
    private static partial Regex Rule95();
              
    [GeneratedRegex(@"Ύ")]
    private static partial Regex Rule96();
              
    [GeneratedRegex(@"ύ")]
    private static partial Regex Rule97();
              
    [GeneratedRegex(@"Ϋ")]
    private static partial Regex Rule98();
              
    [GeneratedRegex(@"ϋ")]
    private static partial Regex Rule99();
              
    [GeneratedRegex(@"ΰ")]
    private static partial Regex Rule100();
              
    [GeneratedRegex(@"Ώ")]
    private static partial Regex Rule101();
              
    [GeneratedRegex(@"ώ")]
    private static partial Regex Rule102();
              
    [GeneratedRegex(@";")]
    private static partial Regex Rule103();
              
    [GeneratedRegex(@";")]
    private static partial Regex Rule104();
              
    [GeneratedRegex(@"·")]
    private static partial Regex Rule105();
              
    [GeneratedRegex(@"΄")]
    private static partial Regex Rule106();
              
    [GeneratedRegex(@"΅")]
    private static partial Regex Rule107();
              
    [GeneratedRegex(@"͂")]
    private static partial Regex Rule108();
              
    [GeneratedRegex(@"̓")]
    private static partial Regex Rule109();
              
    [GeneratedRegex(@"̓")]
    private static partial Regex Rule110();
              
    [GeneratedRegex(@"̔")]
    private static partial Regex Rule111();
              
    [GeneratedRegex(@"ͅ")]
    private static partial Regex Rule112();
              
    [GeneratedRegex(@"ͅ")]
    private static partial Regex Rule113();

}
