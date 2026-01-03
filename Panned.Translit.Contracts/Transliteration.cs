using System.Runtime.Serialization;

namespace Panned.Translit.Contracts;

/// <summary>
///     Available Transliterations
/// </summary>
public enum Transliteration
{
    [EnumMember(Value = "ala-lc_rus")]
    ala_lc_rus,

    [EnumMember(Value = "bgn-pcgn_rus_standard")]
    bgn_pcgn_rus_standard,

    [EnumMember(Value = "bgn-pcgn_rus_strict")]
    bgn_pcgn_rus_strict,

    [EnumMember(Value = "common_ara")]
    common_ara,

    [EnumMember(Value = "common_ces")]
    common_ces,

    [EnumMember(Value = "common_deu")]
    common_deu,

    [EnumMember(Value = "common_pol")]
    common_pol,

    [EnumMember(Value = "common_ron")]
    common_ron,

    [EnumMember(Value = "common_slk")]
    common_slk,

    [EnumMember(Value = "common_slv")]
    common_slv,

    [EnumMember(Value = "devanagari_iast")]
    devanagari_iast,

    [EnumMember(Value = "din_1460_bul")]
    din_1460_bul,

    [EnumMember(Value = "din_1460_rus")]
    din_1460_rus,

    [EnumMember(Value = "din_1460_ukr")]
    din_1460_ukr,

    [EnumMember(Value = "din_31634")]
    din_31634,

    [EnumMember(Value = "gost_7-79_rus")]
    gost_7_79_rus,

    [EnumMember(Value = "gost_7-79_rus_old")]
    gost_7_79_rus_old,

    [EnumMember(Value = "gost_7-79_ukr")]
    gost_7_79_ukr,

    [EnumMember(Value = "greeklish")]
    greeklish,

    [EnumMember(Value = "iast_devanagari")]
    iast_devanagari,

    [EnumMember(Value = "iso-r_9")]
    iso_r_9,

    [EnumMember(Value = "iso_843")]
    iso_843,

    [EnumMember(Value = "iso_8859-16_ron")]
    iso_8859_16_ron,

    [EnumMember(Value = "iso_9")]
    iso_9,

    [EnumMember(Value = "streamlined_system_bul")]
    streamlined_system_bul
}
