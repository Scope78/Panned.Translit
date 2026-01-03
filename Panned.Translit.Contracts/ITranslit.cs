namespace Panned.Translit.Contracts;

/// <summary>
///     Transliteration interface
/// </summary>
public interface ITranslit
{
    Transliteration Transliteration { get; }

    bool IsReversable { get; }

    string Transliterate(string input);
    void Transliterate(StreamReader input, StreamWriter output);

    string Reverse(string input);
    void Reverse(StreamReader input, StreamWriter output);
}
