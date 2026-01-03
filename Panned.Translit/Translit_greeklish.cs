using System;
using System.Text.RegularExpressions;
using System.IO;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_greeklish : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.greeklish;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"i");
        output = Rule2().Replace(output, @"i");
        output = Rule3().Replace(output, @"i");
        output = Rule4().Replace(output, @"ef");
        output = Rule5().Replace(output, @"ef");
        output = Rule6().Replace(output, @"ef");
        output = Rule7().Replace(output, @"u");
        output = Rule8().Replace(output, @"u");
        output = Rule9().Replace(output, @"u");
        output = Rule10().Replace(output, @"A");
        output = Rule11().Replace(output, @"a");
        output = Rule12().Replace(output, @"A");
        output = Rule13().Replace(output, @"a");
        output = Rule14().Replace(output, @"V");
        output = Rule15().Replace(output, @"v");
        output = Rule16().Replace(output, @"Y");
        output = Rule17().Replace(output, @"y");
        output = Rule18().Replace(output, @"D");
        output = Rule19().Replace(output, @"d");
        output = Rule20().Replace(output, @"E");
        output = Rule21().Replace(output, @"e");
        output = Rule22().Replace(output, @"E");
        output = Rule23().Replace(output, @"e");
        output = Rule24().Replace(output, @"Z");
        output = Rule25().Replace(output, @"z");
        output = Rule26().Replace(output, @"I");
        output = Rule27().Replace(output, @"i");
        output = Rule28().Replace(output, @"I");
        output = Rule29().Replace(output, @"i");
        output = Rule30().Replace(output, @"Th");
        output = Rule31().Replace(output, @"th");
        output = Rule32().Replace(output, @"I");
        output = Rule33().Replace(output, @"i");
        output = Rule34().Replace(output, @"I");
        output = Rule35().Replace(output, @"i");
        output = Rule36().Replace(output, @"I");
        output = Rule37().Replace(output, @"i");
        output = Rule38().Replace(output, @"i");
        output = Rule39().Replace(output, @"K");
        output = Rule40().Replace(output, @"k");
        output = Rule41().Replace(output, @"L");
        output = Rule42().Replace(output, @"l");
        output = Rule43().Replace(output, @"M");
        output = Rule44().Replace(output, @"m");
        output = Rule45().Replace(output, @"N");
        output = Rule46().Replace(output, @"n");
        output = Rule47().Replace(output, @"X");
        output = Rule48().Replace(output, @"x");
        output = Rule49().Replace(output, @"O");
        output = Rule50().Replace(output, @"o");
        output = Rule51().Replace(output, @"O");
        output = Rule52().Replace(output, @"o");
        output = Rule53().Replace(output, @"P");
        output = Rule54().Replace(output, @"p");
        output = Rule55().Replace(output, @"R");
        output = Rule56().Replace(output, @"r");
        output = Rule57().Replace(output, @"S");
        output = Rule58().Replace(output, @"s");
        output = Rule59().Replace(output, @"T");
        output = Rule60().Replace(output, @"t");
        output = Rule61().Replace(output, @"I");
        output = Rule62().Replace(output, @"i");
        output = Rule63().Replace(output, @"I");
        output = Rule64().Replace(output, @"i");
        output = Rule65().Replace(output, @"I");
        output = Rule66().Replace(output, @"i");
        output = Rule67().Replace(output, @"i");
        output = Rule68().Replace(output, @"F");
        output = Rule69().Replace(output, @"f");
        output = Rule70().Replace(output, @"H");
        output = Rule71().Replace(output, @"h");
        output = Rule72().Replace(output, @"Ps");
        output = Rule73().Replace(output, @"ps");
        output = Rule74().Replace(output, @"O");
        output = Rule75().Replace(output, @"o");
        output = Rule76().Replace(output, @"O");
        output = Rule77().Replace(output, @"o");
        output = Rule78().Replace(output, @"s");
        output = Rule79().Replace(output, @"?");
        output = Rule80().Replace(output, @"?");
        output = Rule81().Replace(output, @";");
        output = Rule82().Replace(output, @"-");
        output = Rule83().Replace(output, @"");
        output = Rule84().Replace(output, @"");
        output = Rule85().Replace(output, @"");
        output = Rule86().Replace(output, @"");
        output = Rule87().Replace(output, @"");
        output = Rule88().Replace(output, @"");
        output = Rule89().Replace(output, @"");
        output = Rule90().Replace(output, @"");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new InvalidOperationException("Not reversable");
    }
              
    [GeneratedRegex(@"ει")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"έι")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"εί")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"ευ")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"έυ")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"εύ")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"ου")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"ού")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"όυ")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"Α")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"α")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"Ά")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"ά")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"Β")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"β")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"Γ")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"γ")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"Δ")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"δ")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"Ε")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"ε")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"Έ")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"έ")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"Ζ")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"ζ")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"Η")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"η")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"Ή")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"ή")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"Θ")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"θ")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"Ι")]
    private static partial Regex Rule32();
              
    [GeneratedRegex(@"ι")]
    private static partial Regex Rule33();
              
    [GeneratedRegex(@"Ί")]
    private static partial Regex Rule34();
              
    [GeneratedRegex(@"ί")]
    private static partial Regex Rule35();
              
    [GeneratedRegex(@"Ϊ")]
    private static partial Regex Rule36();
              
    [GeneratedRegex(@"ϊ")]
    private static partial Regex Rule37();
              
    [GeneratedRegex(@"ΐ")]
    private static partial Regex Rule38();
              
    [GeneratedRegex(@"Κ")]
    private static partial Regex Rule39();
              
    [GeneratedRegex(@"κ")]
    private static partial Regex Rule40();
              
    [GeneratedRegex(@"Λ")]
    private static partial Regex Rule41();
              
    [GeneratedRegex(@"λ")]
    private static partial Regex Rule42();
              
    [GeneratedRegex(@"Μ")]
    private static partial Regex Rule43();
              
    [GeneratedRegex(@"μ")]
    private static partial Regex Rule44();
              
    [GeneratedRegex(@"Ν")]
    private static partial Regex Rule45();
              
    [GeneratedRegex(@"ν")]
    private static partial Regex Rule46();
              
    [GeneratedRegex(@"Ξ")]
    private static partial Regex Rule47();
              
    [GeneratedRegex(@"ξ")]
    private static partial Regex Rule48();
              
    [GeneratedRegex(@"Ο")]
    private static partial Regex Rule49();
              
    [GeneratedRegex(@"ο")]
    private static partial Regex Rule50();
              
    [GeneratedRegex(@"Ό")]
    private static partial Regex Rule51();
              
    [GeneratedRegex(@"ό")]
    private static partial Regex Rule52();
              
    [GeneratedRegex(@"Π")]
    private static partial Regex Rule53();
              
    [GeneratedRegex(@"π")]
    private static partial Regex Rule54();
              
    [GeneratedRegex(@"Ρ")]
    private static partial Regex Rule55();
              
    [GeneratedRegex(@"ρ")]
    private static partial Regex Rule56();
              
    [GeneratedRegex(@"Σ")]
    private static partial Regex Rule57();
              
    [GeneratedRegex(@"σ")]
    private static partial Regex Rule58();
              
    [GeneratedRegex(@"Τ")]
    private static partial Regex Rule59();
              
    [GeneratedRegex(@"τ")]
    private static partial Regex Rule60();
              
    [GeneratedRegex(@"Υ")]
    private static partial Regex Rule61();
              
    [GeneratedRegex(@"υ")]
    private static partial Regex Rule62();
              
    [GeneratedRegex(@"Ύ")]
    private static partial Regex Rule63();
              
    [GeneratedRegex(@"ύ")]
    private static partial Regex Rule64();
              
    [GeneratedRegex(@"Ϋ")]
    private static partial Regex Rule65();
              
    [GeneratedRegex(@"ϋ")]
    private static partial Regex Rule66();
              
    [GeneratedRegex(@"ΰ")]
    private static partial Regex Rule67();
              
    [GeneratedRegex(@"Φ")]
    private static partial Regex Rule68();
              
    [GeneratedRegex(@"φ")]
    private static partial Regex Rule69();
              
    [GeneratedRegex(@"Χ")]
    private static partial Regex Rule70();
              
    [GeneratedRegex(@"χ")]
    private static partial Regex Rule71();
              
    [GeneratedRegex(@"Ψ")]
    private static partial Regex Rule72();
              
    [GeneratedRegex(@"ψ")]
    private static partial Regex Rule73();
              
    [GeneratedRegex(@"Ω")]
    private static partial Regex Rule74();
              
    [GeneratedRegex(@"ω")]
    private static partial Regex Rule75();
              
    [GeneratedRegex(@"Ώ")]
    private static partial Regex Rule76();
              
    [GeneratedRegex(@"ώ")]
    private static partial Regex Rule77();
              
    [GeneratedRegex(@"ς")]
    private static partial Regex Rule78();
              
    [GeneratedRegex(@"(?<=\b);")]
    private static partial Regex Rule79();
              
    [GeneratedRegex(@"(?<=\b);")]
    private static partial Regex Rule80();
              
    [GeneratedRegex(@"·")]
    private static partial Regex Rule81();
              
    [GeneratedRegex(@"‿")]
    private static partial Regex Rule82();
              
    [GeneratedRegex(@"΄")]
    private static partial Regex Rule83();
              
    [GeneratedRegex(@"΅")]
    private static partial Regex Rule84();
              
    [GeneratedRegex(@"͂")]
    private static partial Regex Rule85();
              
    [GeneratedRegex(@"̓")]
    private static partial Regex Rule86();
              
    [GeneratedRegex(@"̓")]
    private static partial Regex Rule87();
              
    [GeneratedRegex(@"̔")]
    private static partial Regex Rule88();
              
    [GeneratedRegex(@"ͅ")]
    private static partial Regex Rule89();
              
    [GeneratedRegex(@"ͅ")]
    private static partial Regex Rule90();

}
