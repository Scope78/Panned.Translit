namespace Panned.Translit.Contracts;

/// <summary>
///     Exception thrown if a transliteration is not reversable and a Reverse method is called
/// </summary>
public class NotReversableException : Exception
{
    public NotReversableException() : base("Not reversable")
    {
        // intentionally left blank
    }
}
