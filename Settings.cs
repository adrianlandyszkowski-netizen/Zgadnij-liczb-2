public class Settings
{
    public Language Language { get; set; }
    public bool AskForBetMode { get; set; }

    public Settings()
    {
        Language = Language.PL;
        AskForBetMode = true;
    }
}