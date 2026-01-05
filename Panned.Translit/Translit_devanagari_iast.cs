using System.Text.RegularExpressions;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public partial class Translit_devanagari_iast : TranslitBase
{
    public override Transliteration Transliteration => Transliteration.devanagari_iast;

    public override bool IsReversable => false;

    public override string Transliterate(string input)
    {
        string output = input;

        output = Rule1().Replace(output, @"0");
        output = Rule2().Replace(output, @"9");
        output = Rule3().Replace(output, @"8");
        output = Rule4().Replace(output, @"7");
        output = Rule5().Replace(output, @"6");
        output = Rule6().Replace(output, @"5");
        output = Rule7().Replace(output, @"4");
        output = Rule8().Replace(output, @"3");
        output = Rule9().Replace(output, @"2");
        output = Rule10().Replace(output, @"1");
        output = Rule11().Replace(output, @"o");
        output = Rule12().Replace(output, @"e");
        output = Rule13().Replace(output, @"ḹ");
        output = Rule14().Replace(output, @"ḷ");
        output = Rule15().Replace(output, @"ṝ");
        output = Rule16().Replace(output, @"ṛ");
        output = Rule17().Replace(output, @"ū");
        output = Rule18().Replace(output, @"u");
        output = Rule19().Replace(output, @"ī");
        output = Rule20().Replace(output, @"i");
        output = Rule21().Replace(output, @"ā");
        output = Rule22().Replace(output, @"a");
        output = Rule23().Replace(output, @"au");
        output = Rule24().Replace(output, @"ai");
        output = Rule25().Replace(output, @"'");
        output = Rule26().Replace(output, @"्o");
        output = Rule27().Replace(output, @"्e");
        output = Rule28().Replace(output, @"्ḹ");
        output = Rule29().Replace(output, @"्ḷ");
        output = Rule30().Replace(output, @"्ṝ");
        output = Rule31().Replace(output, @"्ṛ");
        output = Rule32().Replace(output, @"्ū");
        output = Rule33().Replace(output, @"्u");
        output = Rule34().Replace(output, @"्ī");
        output = Rule35().Replace(output, @"्i");
        output = Rule36().Replace(output, @"्ā");
        output = Rule37().Replace(output, @"्au");
        output = Rule38().Replace(output, @"्ai");
        output = Rule39().Replace(output, @"h");
        output = Rule40().Replace(output, @"s");
        output = Rule41().Replace(output, @"ṣ");
        output = Rule42().Replace(output, @"ś");
        output = Rule43().Replace(output, @"v");
        output = Rule44().Replace(output, @"l");
        output = Rule45().Replace(output, @"r");
        output = Rule46().Replace(output, @"y");
        output = Rule47().Replace(output, @"m");
        output = Rule48().Replace(output, @"b");
        output = Rule49().Replace(output, @"bh");
        output = Rule50().Replace(output, @"ph");
        output = Rule51().Replace(output, @"p");
        output = Rule52().Replace(output, @"n");
        output = Rule53().Replace(output, @"d");
        output = Rule54().Replace(output, @"dh");
        output = Rule55().Replace(output, @"t");
        output = Rule56().Replace(output, @"th");
        output = Rule57().Replace(output, @"ṇ");
        output = Rule58().Replace(output, @"ḍ");
        output = Rule59().Replace(output, @"ḍh");
        output = Rule60().Replace(output, @"ṭ");
        output = Rule61().Replace(output, @"ṭh");
        output = Rule62().Replace(output, @"ñ");
        output = Rule63().Replace(output, @"j");
        output = Rule64().Replace(output, @"jh");
        output = Rule65().Replace(output, @"c");
        output = Rule66().Replace(output, @"ch");
        output = Rule67().Replace(output, @"ṅ");
        output = Rule68().Replace(output, @"g");
        output = Rule69().Replace(output, @"gh");
        output = Rule70().Replace(output, @"k");
        output = Rule71().Replace(output, @"kh");
        output = Rule72().Replace(output, @"ha");
        output = Rule73().Replace(output, @"sa");
        output = Rule74().Replace(output, @"ṣa");
        output = Rule75().Replace(output, @"śa");
        output = Rule76().Replace(output, @"va");
        output = Rule77().Replace(output, @"la");
        output = Rule78().Replace(output, @"ra");
        output = Rule79().Replace(output, @"ya");
        output = Rule80().Replace(output, @"ma");
        output = Rule81().Replace(output, @"ba");
        output = Rule82().Replace(output, @"bha");
        output = Rule83().Replace(output, @"pha");
        output = Rule84().Replace(output, @"pa");
        output = Rule85().Replace(output, @"na");
        output = Rule86().Replace(output, @"da");
        output = Rule87().Replace(output, @"dha");
        output = Rule88().Replace(output, @"ta");
        output = Rule89().Replace(output, @"tha");
        output = Rule90().Replace(output, @"ṇa");
        output = Rule91().Replace(output, @"ḍa");
        output = Rule92().Replace(output, @"ḍha");
        output = Rule93().Replace(output, @"ṭa");
        output = Rule94().Replace(output, @"ṭha");
        output = Rule95().Replace(output, @"ña");
        output = Rule96().Replace(output, @"ja");
        output = Rule97().Replace(output, @"jha");
        output = Rule98().Replace(output, @"ca");
        output = Rule99().Replace(output, @"cha");
        output = Rule100().Replace(output, @"ṅa");
        output = Rule101().Replace(output, @"ga");
        output = Rule102().Replace(output, @"gha");
        output = Rule103().Replace(output, @"ka");
        output = Rule104().Replace(output, @"kha");
        output = Rule105().Replace(output, @"ḥ");
        output = Rule106().Replace(output, @"ṃ");
        output = Rule107().Replace(output, @"oṁ");

        return output;
    }

    public override string Reverse(string input)
    {
        throw new NotReversableException();
    }
              
    [GeneratedRegex(@"०")]
    private static partial Regex Rule1();
              
    [GeneratedRegex(@"९")]
    private static partial Regex Rule2();
              
    [GeneratedRegex(@"८")]
    private static partial Regex Rule3();
              
    [GeneratedRegex(@"७")]
    private static partial Regex Rule4();
              
    [GeneratedRegex(@"६")]
    private static partial Regex Rule5();
              
    [GeneratedRegex(@"५")]
    private static partial Regex Rule6();
              
    [GeneratedRegex(@"४")]
    private static partial Regex Rule7();
              
    [GeneratedRegex(@"३")]
    private static partial Regex Rule8();
              
    [GeneratedRegex(@"२")]
    private static partial Regex Rule9();
              
    [GeneratedRegex(@"१")]
    private static partial Regex Rule10();
              
    [GeneratedRegex(@"ओ")]
    private static partial Regex Rule11();
              
    [GeneratedRegex(@"ए")]
    private static partial Regex Rule12();
              
    [GeneratedRegex(@"ॡ")]
    private static partial Regex Rule13();
              
    [GeneratedRegex(@"ऌ")]
    private static partial Regex Rule14();
              
    [GeneratedRegex(@"ॠ")]
    private static partial Regex Rule15();
              
    [GeneratedRegex(@"ऋ")]
    private static partial Regex Rule16();
              
    [GeneratedRegex(@"ऊ")]
    private static partial Regex Rule17();
              
    [GeneratedRegex(@"उ")]
    private static partial Regex Rule18();
              
    [GeneratedRegex(@"ई")]
    private static partial Regex Rule19();
              
    [GeneratedRegex(@"इ")]
    private static partial Regex Rule20();
              
    [GeneratedRegex(@"आ")]
    private static partial Regex Rule21();
              
    [GeneratedRegex(@"अ")]
    private static partial Regex Rule22();
              
    [GeneratedRegex(@"औ")]
    private static partial Regex Rule23();
              
    [GeneratedRegex(@"ऐ")]
    private static partial Regex Rule24();
              
    [GeneratedRegex(@"ऽ")]
    private static partial Regex Rule25();
              
    [GeneratedRegex(@"ो")]
    private static partial Regex Rule26();
              
    [GeneratedRegex(@"े")]
    private static partial Regex Rule27();
              
    [GeneratedRegex(@"ॣ")]
    private static partial Regex Rule28();
              
    [GeneratedRegex(@"ॢ")]
    private static partial Regex Rule29();
              
    [GeneratedRegex(@"ॄ")]
    private static partial Regex Rule30();
              
    [GeneratedRegex(@"ृ")]
    private static partial Regex Rule31();
              
    [GeneratedRegex(@"ू")]
    private static partial Regex Rule32();
              
    [GeneratedRegex(@"ु")]
    private static partial Regex Rule33();
              
    [GeneratedRegex(@"ी")]
    private static partial Regex Rule34();
              
    [GeneratedRegex(@"ि")]
    private static partial Regex Rule35();
              
    [GeneratedRegex(@"ा")]
    private static partial Regex Rule36();
              
    [GeneratedRegex(@"ौ")]
    private static partial Regex Rule37();
              
    [GeneratedRegex(@"ै")]
    private static partial Regex Rule38();
              
    [GeneratedRegex(@"ह्")]
    private static partial Regex Rule39();
              
    [GeneratedRegex(@"स्")]
    private static partial Regex Rule40();
              
    [GeneratedRegex(@"ष्")]
    private static partial Regex Rule41();
              
    [GeneratedRegex(@"श्")]
    private static partial Regex Rule42();
              
    [GeneratedRegex(@"व्")]
    private static partial Regex Rule43();
              
    [GeneratedRegex(@"ल्")]
    private static partial Regex Rule44();
              
    [GeneratedRegex(@"र्")]
    private static partial Regex Rule45();
              
    [GeneratedRegex(@"य्")]
    private static partial Regex Rule46();
              
    [GeneratedRegex(@"म्")]
    private static partial Regex Rule47();
              
    [GeneratedRegex(@"ब्")]
    private static partial Regex Rule48();
              
    [GeneratedRegex(@"भ्")]
    private static partial Regex Rule49();
              
    [GeneratedRegex(@"फ्")]
    private static partial Regex Rule50();
              
    [GeneratedRegex(@"प्")]
    private static partial Regex Rule51();
              
    [GeneratedRegex(@"न्")]
    private static partial Regex Rule52();
              
    [GeneratedRegex(@"द्")]
    private static partial Regex Rule53();
              
    [GeneratedRegex(@"ध्")]
    private static partial Regex Rule54();
              
    [GeneratedRegex(@"त्")]
    private static partial Regex Rule55();
              
    [GeneratedRegex(@"थ्")]
    private static partial Regex Rule56();
              
    [GeneratedRegex(@"ण्")]
    private static partial Regex Rule57();
              
    [GeneratedRegex(@"ड्")]
    private static partial Regex Rule58();
              
    [GeneratedRegex(@"ढ्")]
    private static partial Regex Rule59();
              
    [GeneratedRegex(@"ट्")]
    private static partial Regex Rule60();
              
    [GeneratedRegex(@"ठ्")]
    private static partial Regex Rule61();
              
    [GeneratedRegex(@"ञ्")]
    private static partial Regex Rule62();
              
    [GeneratedRegex(@"ज्")]
    private static partial Regex Rule63();
              
    [GeneratedRegex(@"झ्")]
    private static partial Regex Rule64();
              
    [GeneratedRegex(@"च्")]
    private static partial Regex Rule65();
              
    [GeneratedRegex(@"छ्")]
    private static partial Regex Rule66();
              
    [GeneratedRegex(@"ङ्")]
    private static partial Regex Rule67();
              
    [GeneratedRegex(@"ग्")]
    private static partial Regex Rule68();
              
    [GeneratedRegex(@"घ्")]
    private static partial Regex Rule69();
              
    [GeneratedRegex(@"क्")]
    private static partial Regex Rule70();
              
    [GeneratedRegex(@"ख्")]
    private static partial Regex Rule71();
              
    [GeneratedRegex(@"ह")]
    private static partial Regex Rule72();
              
    [GeneratedRegex(@"स")]
    private static partial Regex Rule73();
              
    [GeneratedRegex(@"ष")]
    private static partial Regex Rule74();
              
    [GeneratedRegex(@"श")]
    private static partial Regex Rule75();
              
    [GeneratedRegex(@"व")]
    private static partial Regex Rule76();
              
    [GeneratedRegex(@"ल")]
    private static partial Regex Rule77();
              
    [GeneratedRegex(@"र")]
    private static partial Regex Rule78();
              
    [GeneratedRegex(@"य")]
    private static partial Regex Rule79();
              
    [GeneratedRegex(@"म")]
    private static partial Regex Rule80();
              
    [GeneratedRegex(@"ब")]
    private static partial Regex Rule81();
              
    [GeneratedRegex(@"भ")]
    private static partial Regex Rule82();
              
    [GeneratedRegex(@"फ")]
    private static partial Regex Rule83();
              
    [GeneratedRegex(@"प")]
    private static partial Regex Rule84();
              
    [GeneratedRegex(@"न")]
    private static partial Regex Rule85();
              
    [GeneratedRegex(@"द")]
    private static partial Regex Rule86();
              
    [GeneratedRegex(@"ध")]
    private static partial Regex Rule87();
              
    [GeneratedRegex(@"त")]
    private static partial Regex Rule88();
              
    [GeneratedRegex(@"थ")]
    private static partial Regex Rule89();
              
    [GeneratedRegex(@"ण")]
    private static partial Regex Rule90();
              
    [GeneratedRegex(@"ड")]
    private static partial Regex Rule91();
              
    [GeneratedRegex(@"ढ")]
    private static partial Regex Rule92();
              
    [GeneratedRegex(@"ट")]
    private static partial Regex Rule93();
              
    [GeneratedRegex(@"ठ")]
    private static partial Regex Rule94();
              
    [GeneratedRegex(@"ञ")]
    private static partial Regex Rule95();
              
    [GeneratedRegex(@"ज")]
    private static partial Regex Rule96();
              
    [GeneratedRegex(@"झ")]
    private static partial Regex Rule97();
              
    [GeneratedRegex(@"च")]
    private static partial Regex Rule98();
              
    [GeneratedRegex(@"छ")]
    private static partial Regex Rule99();
              
    [GeneratedRegex(@"ङ")]
    private static partial Regex Rule100();
              
    [GeneratedRegex(@"ग")]
    private static partial Regex Rule101();
              
    [GeneratedRegex(@"घ")]
    private static partial Regex Rule102();
              
    [GeneratedRegex(@"क")]
    private static partial Regex Rule103();
              
    [GeneratedRegex(@"ख")]
    private static partial Regex Rule104();
              
    [GeneratedRegex(@"ः")]
    private static partial Regex Rule105();
              
    [GeneratedRegex(@"ं")]
    private static partial Regex Rule106();
              
    [GeneratedRegex(@"ॐ")]
    private static partial Regex Rule107();

}
