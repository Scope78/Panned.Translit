using Panned.Translit.Contracts;

namespace Panned.Translit;

/// <summary>
///     Abstract base class for Translit
/// </summary>
public abstract class TranslitBase : ITranslit
{
    public abstract Transliteration Transliteration { get; }
    public abstract bool IsReversable { get; }

    public abstract string Transliterate(string input);
    public abstract string Reverse(string input);

    public void Transliterate(StreamReader input, StreamWriter output)
    {
        while (!input.EndOfStream)
        {
            var inputLine = input.ReadLine();
            var outputLine = string.IsNullOrEmpty(inputLine) ? inputLine : Transliterate(inputLine);
            output.WriteLine(outputLine);
        }
    }

    public void Reverse(StreamReader input, StreamWriter output)
    {
        if (!IsReversable)
        {
            throw new NotReversableException();
        }

        while (!input.EndOfStream)
        {
            var inputLine = input.ReadLine();
            var outputLine = string.IsNullOrEmpty(inputLine) ? inputLine : Reverse(inputLine);
            output.WriteLine(outputLine);
        }
    }
}
