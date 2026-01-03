using System;
using System.Text.RegularExpressions;
using System.IO;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_iast_devanagari : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.iast_devanagari;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"ॐ");
        output = Rule2().Replace(output, @"ॐ");
        output = Rule3().Replace(output, @"ं");
        output = Rule4().Replace(output, @"ः");
        output = Rule5().Replace(output, @"ख्");
        output = Rule6().Replace(output, @"ख्");
        output = Rule7().Replace(output, @"क्");
        output = Rule8().Replace(output, @"क्");
        output = Rule9().Replace(output, @"घ्");
        output = Rule10().Replace(output, @"घ्");
        output = Rule11().Replace(output, @"ग्");
        output = Rule12().Replace(output, @"ग्");
        output = Rule13().Replace(output, @"ङ्");
        output = Rule14().Replace(output, @"ङ्");
        output = Rule15().Replace(output, @"छ्");
        output = Rule16().Replace(output, @"छ्");
        output = Rule17().Replace(output, @"च्");
        output = Rule18().Replace(output, @"च्");
        output = Rule19().Replace(output, @"झ्");
        output = Rule20().Replace(output, @"झ्");
        output = Rule21().Replace(output, @"ज्");
        output = Rule22().Replace(output, @"ज्");
        output = Rule23().Replace(output, @"ञ्");
        output = Rule24().Replace(output, @"ञ्");
        output = Rule25().Replace(output, @"ठ्");
        output = Rule26().Replace(output, @"ठ्");
        output = Rule27().Replace(output, @"ट्");
        output = Rule28().Replace(output, @"ट्");
        output = Rule29().Replace(output, @"ढ्");
        output = Rule30().Replace(output, @"ढ्");
        output = Rule31().Replace(output, @"ड्");
        output = Rule32().Replace(output, @"ड्");
        output = Rule33().Replace(output, @"ण्");
        output = Rule34().Replace(output, @"ण्");
        output = Rule35().Replace(output, @"थ्");
        output = Rule36().Replace(output, @"थ्");
        output = Rule37().Replace(output, @"त्");
        output = Rule38().Replace(output, @"त्");
        output = Rule39().Replace(output, @"ध्");
        output = Rule40().Replace(output, @"ध्");
        output = Rule41().Replace(output, @"द्");
        output = Rule42().Replace(output, @"द्");
        output = Rule43().Replace(output, @"न्");
        output = Rule44().Replace(output, @"न्");
        output = Rule45().Replace(output, @"फ्");
        output = Rule46().Replace(output, @"फ्");
        output = Rule47().Replace(output, @"प्");
        output = Rule48().Replace(output, @"प्");
        output = Rule49().Replace(output, @"भ्");
        output = Rule50().Replace(output, @"भ्");
        output = Rule51().Replace(output, @"ब्");
        output = Rule52().Replace(output, @"ब्");
        output = Rule53().Replace(output, @"म्");
        output = Rule54().Replace(output, @"म्");
        output = Rule55().Replace(output, @"य्");
        output = Rule56().Replace(output, @"य्");
        output = Rule57().Replace(output, @"र्");
        output = Rule58().Replace(output, @"र्");
        output = Rule59().Replace(output, @"ल्");
        output = Rule60().Replace(output, @"ल्");
        output = Rule61().Replace(output, @"व्");
        output = Rule62().Replace(output, @"व्");
        output = Rule63().Replace(output, @"श्");
        output = Rule64().Replace(output, @"श्");
        output = Rule65().Replace(output, @"ष्");
        output = Rule66().Replace(output, @"ष्");
        output = Rule67().Replace(output, @"स्");
        output = Rule68().Replace(output, @"स्");
        output = Rule69().Replace(output, @"ह्");
        output = Rule70().Replace(output, @"ह्");
        output = Rule71().Replace(output, @"ै");
        output = Rule72().Replace(output, @"ौ");
        output = Rule73().Replace(output, @"");
        output = Rule74().Replace(output, @"ा");
        output = Rule75().Replace(output, @"ि");
        output = Rule76().Replace(output, @"ी");
        output = Rule77().Replace(output, @"ु");
        output = Rule78().Replace(output, @"ू");
        output = Rule79().Replace(output, @"ृ");
        output = Rule80().Replace(output, @"ॄ");
        output = Rule81().Replace(output, @"ॢ");
        output = Rule82().Replace(output, @"ॣ");
        output = Rule83().Replace(output, @"े");
        output = Rule84().Replace(output, @"ो");
        output = Rule85().Replace(output, @"ऽ");
        output = Rule86().Replace(output, @"ऐ");
        output = Rule87().Replace(output, @"ऐ");
        output = Rule88().Replace(output, @"औ");
        output = Rule89().Replace(output, @"औ");
        output = Rule90().Replace(output, @"अ");
        output = Rule91().Replace(output, @"अ");
        output = Rule92().Replace(output, @"आ");
        output = Rule93().Replace(output, @"आ");
        output = Rule94().Replace(output, @"इ");
        output = Rule95().Replace(output, @"इ");
        output = Rule96().Replace(output, @"ई");
        output = Rule97().Replace(output, @"ई");
        output = Rule98().Replace(output, @"उ");
        output = Rule99().Replace(output, @"उ");
        output = Rule100().Replace(output, @"ऊ");
        output = Rule101().Replace(output, @"ऊ");
        output = Rule102().Replace(output, @"ऋ");
        output = Rule103().Replace(output, @"ऋ");
        output = Rule104().Replace(output, @"ॠ");
        output = Rule105().Replace(output, @"ॠ");
        output = Rule106().Replace(output, @"ऌ");
        output = Rule107().Replace(output, @"ऌ");
        output = Rule108().Replace(output, @"ॡ");
        output = Rule109().Replace(output, @"ॡ");
        output = Rule110().Replace(output, @"ए");
        output = Rule111().Replace(output, @"ए");
        output = Rule112().Replace(output, @"ओ");
        output = Rule113().Replace(output, @"ओ");
        output = Rule114().Replace(output, @"१");
        output = Rule115().Replace(output, @"२");
        output = Rule116().Replace(output, @"३");
        output = Rule117().Replace(output, @"४");
        output = Rule118().Replace(output, @"५");
        output = Rule119().Replace(output, @"६");
        output = Rule120().Replace(output, @"७");
        output = Rule121().Replace(output, @"८");
        output = Rule122().Replace(output, @"९");
        output = Rule123().Replace(output, @"०");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new InvalidOperationException("Not reversable");
    }
              
    [GeneratedRegex(@"oṁ")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"Oṁ")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"ṃ")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"ḥ")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"kh")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"Kh")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"K")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"k")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"gh")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"Gh")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"G")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"g")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"Ṅ")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"ṅ")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"ch")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"Ch")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"C")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"c")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"jh")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"Jh")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"J")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"j")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"Ñ")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"ñ")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"ṭh")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"Ṭh")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"Ṭ")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"ṭ")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"ḍh")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"Ḍh")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"Ḍ")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"ḍ")]
    private static partial Regex Rule32();
              
    [GeneratedRegex(@"Ṇ")]
    private static partial Regex Rule33();
              
    [GeneratedRegex(@"ṇ")]
    private static partial Regex Rule34();
              
    [GeneratedRegex(@"th")]
    private static partial Regex Rule35();
              
    [GeneratedRegex(@"Th")]
    private static partial Regex Rule36();
              
    [GeneratedRegex(@"T")]
    private static partial Regex Rule37();
              
    [GeneratedRegex(@"t")]
    private static partial Regex Rule38();
              
    [GeneratedRegex(@"dh")]
    private static partial Regex Rule39();
              
    [GeneratedRegex(@"Dh")]
    private static partial Regex Rule40();
              
    [GeneratedRegex(@"D")]
    private static partial Regex Rule41();
              
    [GeneratedRegex(@"d")]
    private static partial Regex Rule42();
              
    [GeneratedRegex(@"N")]
    private static partial Regex Rule43();
              
    [GeneratedRegex(@"n")]
    private static partial Regex Rule44();
              
    [GeneratedRegex(@"ph")]
    private static partial Regex Rule45();
              
    [GeneratedRegex(@"Ph")]
    private static partial Regex Rule46();
              
    [GeneratedRegex(@"P")]
    private static partial Regex Rule47();
              
    [GeneratedRegex(@"p")]
    private static partial Regex Rule48();
              
    [GeneratedRegex(@"bh")]
    private static partial Regex Rule49();
              
    [GeneratedRegex(@"Bh")]
    private static partial Regex Rule50();
              
    [GeneratedRegex(@"B")]
    private static partial Regex Rule51();
              
    [GeneratedRegex(@"b")]
    private static partial Regex Rule52();
              
    [GeneratedRegex(@"M")]
    private static partial Regex Rule53();
              
    [GeneratedRegex(@"m")]
    private static partial Regex Rule54();
              
    [GeneratedRegex(@"Y")]
    private static partial Regex Rule55();
              
    [GeneratedRegex(@"y")]
    private static partial Regex Rule56();
              
    [GeneratedRegex(@"R")]
    private static partial Regex Rule57();
              
    [GeneratedRegex(@"r")]
    private static partial Regex Rule58();
              
    [GeneratedRegex(@"L")]
    private static partial Regex Rule59();
              
    [GeneratedRegex(@"l")]
    private static partial Regex Rule60();
              
    [GeneratedRegex(@"V")]
    private static partial Regex Rule61();
              
    [GeneratedRegex(@"v")]
    private static partial Regex Rule62();
              
    [GeneratedRegex(@"Ś")]
    private static partial Regex Rule63();
              
    [GeneratedRegex(@"ś")]
    private static partial Regex Rule64();
              
    [GeneratedRegex(@"Ṣ")]
    private static partial Regex Rule65();
              
    [GeneratedRegex(@"ṣ")]
    private static partial Regex Rule66();
              
    [GeneratedRegex(@"S")]
    private static partial Regex Rule67();
              
    [GeneratedRegex(@"s")]
    private static partial Regex Rule68();
              
    [GeneratedRegex(@"H")]
    private static partial Regex Rule69();
              
    [GeneratedRegex(@"h")]
    private static partial Regex Rule70();
              
    [GeneratedRegex(@"्ai")]
    private static partial Regex Rule71();
              
    [GeneratedRegex(@"्au")]
    private static partial Regex Rule72();
              
    [GeneratedRegex(@"्a")]
    private static partial Regex Rule73();
              
    [GeneratedRegex(@"्ā")]
    private static partial Regex Rule74();
              
    [GeneratedRegex(@"्i")]
    private static partial Regex Rule75();
              
    [GeneratedRegex(@"्ī")]
    private static partial Regex Rule76();
              
    [GeneratedRegex(@"्u")]
    private static partial Regex Rule77();
              
    [GeneratedRegex(@"्ū")]
    private static partial Regex Rule78();
              
    [GeneratedRegex(@"्ṛ")]
    private static partial Regex Rule79();
              
    [GeneratedRegex(@"्ṝ")]
    private static partial Regex Rule80();
              
    [GeneratedRegex(@"्ḷ")]
    private static partial Regex Rule81();
              
    [GeneratedRegex(@"्ḹ")]
    private static partial Regex Rule82();
              
    [GeneratedRegex(@"्e")]
    private static partial Regex Rule83();
              
    [GeneratedRegex(@"्o")]
    private static partial Regex Rule84();
              
    [GeneratedRegex(@"'")]
    private static partial Regex Rule85();
              
    [GeneratedRegex(@"ai")]
    private static partial Regex Rule86();
              
    [GeneratedRegex(@"Ai")]
    private static partial Regex Rule87();
              
    [GeneratedRegex(@"au")]
    private static partial Regex Rule88();
              
    [GeneratedRegex(@"Au")]
    private static partial Regex Rule89();
              
    [GeneratedRegex(@"a")]
    private static partial Regex Rule90();
              
    [GeneratedRegex(@"A")]
    private static partial Regex Rule91();
              
    [GeneratedRegex(@"ā")]
    private static partial Regex Rule92();
              
    [GeneratedRegex(@"Ā")]
    private static partial Regex Rule93();
              
    [GeneratedRegex(@"i")]
    private static partial Regex Rule94();
              
    [GeneratedRegex(@"I")]
    private static partial Regex Rule95();
              
    [GeneratedRegex(@"ī")]
    private static partial Regex Rule96();
              
    [GeneratedRegex(@"Ī")]
    private static partial Regex Rule97();
              
    [GeneratedRegex(@"u")]
    private static partial Regex Rule98();
              
    [GeneratedRegex(@"U")]
    private static partial Regex Rule99();
              
    [GeneratedRegex(@"ū")]
    private static partial Regex Rule100();
              
    [GeneratedRegex(@"Ū")]
    private static partial Regex Rule101();
              
    [GeneratedRegex(@"ṛ")]
    private static partial Regex Rule102();
              
    [GeneratedRegex(@"Ṛ")]
    private static partial Regex Rule103();
              
    [GeneratedRegex(@"ṝ")]
    private static partial Regex Rule104();
              
    [GeneratedRegex(@"Ṝ")]
    private static partial Regex Rule105();
              
    [GeneratedRegex(@"ḷ")]
    private static partial Regex Rule106();
              
    [GeneratedRegex(@"Ḷ")]
    private static partial Regex Rule107();
              
    [GeneratedRegex(@"ḹ")]
    private static partial Regex Rule108();
              
    [GeneratedRegex(@"Ḹ")]
    private static partial Regex Rule109();
              
    [GeneratedRegex(@"e")]
    private static partial Regex Rule110();
              
    [GeneratedRegex(@"E")]
    private static partial Regex Rule111();
              
    [GeneratedRegex(@"o")]
    private static partial Regex Rule112();
              
    [GeneratedRegex(@"O")]
    private static partial Regex Rule113();
              
    [GeneratedRegex(@"1")]
    private static partial Regex Rule114();
              
    [GeneratedRegex(@"2")]
    private static partial Regex Rule115();
              
    [GeneratedRegex(@"3")]
    private static partial Regex Rule116();
              
    [GeneratedRegex(@"4")]
    private static partial Regex Rule117();
              
    [GeneratedRegex(@"5")]
    private static partial Regex Rule118();
              
    [GeneratedRegex(@"6")]
    private static partial Regex Rule119();
              
    [GeneratedRegex(@"7")]
    private static partial Regex Rule120();
              
    [GeneratedRegex(@"8")]
    private static partial Regex Rule121();
              
    [GeneratedRegex(@"9")]
    private static partial Regex Rule122();
              
    [GeneratedRegex(@"0")]
    private static partial Regex Rule123();

}
