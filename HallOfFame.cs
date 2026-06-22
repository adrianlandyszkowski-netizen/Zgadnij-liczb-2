using System.Collections.Generic;
using System.Linq;

public class HallOfFame
{
    private List<Score> scores = new List<Score>();

    public void AddScore(Score s) => scores.Add(s);

    public void Clear() => scores.Clear();

    public bool HasScores() => scores.Count > 0;

    public List<Score> GetTop5(Difficulty d)
    {
        return scores
            .Where(x => x.Difficulty == d)
            .OrderBy(x => x.Attempts)
            .ThenBy(x => x.TimeInSeconds)
            .Take(5)
            .ToList();
    }
}