using System;
using Panned.Translit.Contracts;

namespace Panned.Translit;

public class TranslitFactory
{
    public static ITranslit Create(Transliteration transliteration)
    {
        switch(transliteration)
        {
            case Transliteration.ala_lc_rus:
                return new Translit_ala_lc_rus();
            case Transliteration.bgn_pcgn_rus_standard:
                return new Translit_bgn_pcgn_rus_standard();
            case Transliteration.bgn_pcgn_rus_strict:
                return new Translit_bgn_pcgn_rus_strict();
            case Transliteration.common_ara:
                return new Translit_common_ara();
            case Transliteration.common_ces:
                return new Translit_common_ces();
            case Transliteration.common_deu:
                return new Translit_common_deu();
            case Transliteration.common_pol:
                return new Translit_common_pol();
            case Transliteration.common_ron:
                return new Translit_common_ron();
            case Transliteration.common_slk:
                return new Translit_common_slk();
            case Transliteration.common_slv:
                return new Translit_common_slv();
            case Transliteration.devanagari_iast:
                return new Translit_devanagari_iast();
            case Transliteration.din_1460_bul:
                return new Translit_din_1460_bul();
            case Transliteration.din_1460_rus:
                return new Translit_din_1460_rus();
            case Transliteration.din_1460_ukr:
                return new Translit_din_1460_ukr();
            case Transliteration.din_31634:
                return new Translit_din_31634();
            case Transliteration.gost_7_79_rus:
                return new Translit_gost_7_79_rus();
            case Transliteration.gost_7_79_rus_old:
                return new Translit_gost_7_79_rus_old();
            case Transliteration.gost_7_79_ukr:
                return new Translit_gost_7_79_ukr();
            case Transliteration.greeklish:
                return new Translit_greeklish();
            case Transliteration.iast_devanagari:
                return new Translit_iast_devanagari();
            case Transliteration.iso_r_9:
                return new Translit_iso_r_9();
            case Transliteration.iso_843:
                return new Translit_iso_843();
            case Transliteration.iso_8859_16_ron:
                return new Translit_iso_8859_16_ron();
            case Transliteration.iso_9:
                return new Translit_iso_9();
            case Transliteration.streamlined_system_bul:
                return new Translit_streamlined_system_bul();
            default:
                throw new InvalidOperationException($"Unknown Transliteration {transliteration}");
        }
    }
}
