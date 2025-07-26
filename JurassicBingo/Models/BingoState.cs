namespace JurassicBingo.Models;

public class BingoState
{
    /// <summary>
    /// All 25 square IDs (including -1 for FREE SPACE at center).
    /// </summary>
    public int[] PhraseIds { get; set; } = [];

    /// <summary>
    /// All 25 corresponding marked states (true = checked).
    /// </summary>
    public bool[] MarkedStates { get; set; } = [];
}