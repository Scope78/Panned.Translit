namespace Panned.Translit.Contracts;

/// <summary>
///     Factory interface for Transliteration implementations
/// </summary>
public interface ITranslitFactory
{
    ITranslit Create(Transliteration transliteration);
}
