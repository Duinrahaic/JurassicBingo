namespace JurassicBingo.Models;

public class BingoSquare
{
    /// <summary>
    /// The unique ID of the phrase, or -1 for FREE SPACE.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The visible phrase.
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// Whether the square is marked.
    /// </summary>
    public bool Marked { get; set; }

    /// <summary>
    /// True if this square represents the center FREE SPACE.
    /// </summary>
    public bool IsFreeSpace => Id == -1;
}