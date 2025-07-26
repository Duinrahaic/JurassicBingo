using JurassicBingo.Models;

namespace JurassicBingo.Utilities;

public static class BingoStateConverter
{
    /// <summary>Convert squares to a BingoState (serializable).</summary>
    public static BingoState ToBingoState(this List<BingoSquare> squares)
    {
        if (squares.Count != 25)
            throw new InvalidOperationException("Expected exactly 25 squares (including FREE SPACE).");

        return new BingoState
        {
            PhraseIds = squares.Select(s => s.Id).ToArray(),
            MarkedStates = squares.Select(s => s.Marked).ToArray()
        };
    }

    /// <summary>Convert BingoState back to squares (text is placeholder).</summary>
    public static List<BingoSquare> ToBingoSquares(this BingoState state)
    {
        if (state.PhraseIds.Length != 25 || state.MarkedStates.Length != 25)
            throw new InvalidOperationException("BingoState must contain 25 IDs and MarkedStates.");

        return Enumerable.Range(0, 25).Select(i => new BingoSquare
        {
            Id = state.PhraseIds[i],
            Text = state.PhraseIds[i] == -1 ? "FREE SPACE" : $"Phrase {state.PhraseIds[i]}",
            Marked = state.MarkedStates[i]
        }).ToList();
    }
}