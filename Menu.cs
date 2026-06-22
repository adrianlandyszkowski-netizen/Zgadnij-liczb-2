using System;
using System.Collections.Generic;

public class Menu
{
    private Settings settings = new Settings();
    private HallOfFame hall = new HallOfFame();

    //Menu

    public void Show()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine(Texts.Get(settings.Language, "title"));
            Console.WriteLine();

            Console.WriteLine(Texts.Get(settings.Language, "newGame"));
            Console.WriteLine(Texts.Get(settings.Language, "settings"));

            if (hall.HasScores())
                Console.WriteLine(Texts.Get(settings.Language, "hall"));
            Console.WriteLine(Texts.Get(settings.Language, "exit"));

            string c = Console.ReadLine();

            if (c == "1") NewGame();
            else if (c == "2") SettingsMenu();
            else if (c == "3" && hall.HasScores()) ShowHall();
            else if (c == "0") break;
        }
    }

    //Nowa gra

    private void NewGame()
    {
        Console.Clear();

        Console.WriteLine("");
        Console.WriteLine("1. Standard");
        Console.WriteLine("2. Plus");

        string type = Console.ReadLine();

        Console.WriteLine(Texts.Get(settings.Language, "easy"));
        Console.WriteLine(Texts.Get(settings.Language, "medium"));
        Console.WriteLine(Texts.Get(settings.Language, "hard"));

        string d = Console.ReadLine();

        Difficulty diff;

        if (d == "1")
        {
            diff = Difficulty.Easy;
        }
        else if (d == "3")
        {
            diff = Difficulty.Hard;
        }
        else
        {
            diff = Difficulty.Medium;
        }

        int maxAttempts = 0;

        if (settings.AskForBetMode && type != "2")
        {
            Console.WriteLine(Texts.Get(settings.Language, "bet"));
            if (Console.ReadLine().ToUpper() == "T")
            {
                Console.WriteLine(Texts.Get(settings.Language, "max"));
                int.TryParse(Console.ReadLine(), out maxAttempts);
            }
        }

        Score score;
        Game gra;

        if (type == "2")
        {
            gra = new GamePlus();
        }
        else
        {
            gra = new Game();
        }

        // Wywołujemy metodę Start na przygotowanym obiekcie 'gra'
        score = gra.Start(diff, maxAttempts, settings.Language);

        // Kompilator jest teraz w 100% bezpieczny, bo 'score' 
        // dostał wartość wyżej i nie jest pusty
        if (score != null)
        {
            hall.AddScore(score);
            Console.WriteLine(Texts.Get(settings.Language, "time") + " " + score.TimeInSeconds);
        }

        Console.ReadLine();
    }

    //Pokaz halloffame

    private void ShowHall()
    {
        Console.Clear();

        Console.WriteLine("");
        Console.WriteLine(Texts.Get(settings.Language, "halleasy"));
        Console.WriteLine(Texts.Get(settings.Language, "hallmedium"));
        Console.WriteLine(Texts.Get(settings.Language, "hallhard"));

        string c = Console.ReadLine();

        Difficulty d;

        if (c == "1")
        {
            d = Difficulty.Easy;
        }
        else if (c == "3")
        {
            d = Difficulty.Hard;
        }
        else
        {
            d = Difficulty.Medium;
        }

        var list = hall.GetTop5(d);

        Console.Clear();
        Console.WriteLine("HALL OF FAME\n");

        int i = 1;

        foreach (var s in list)
        {
            Console.WriteLine(i + ". " + s.PlayerName +
                " | x" + s.Attempts +
                " | " + s.TimeInSeconds + "s");

            i++;
        }

        Console.ReadLine();
    }

    //Ustawienia

    private void SettingsMenu()
    {
        Console.Clear();

        Console.WriteLine("");
        Console.WriteLine(Texts.Get(settings.Language, "bet") + settings.AskForBetMode);
        Console.WriteLine(Texts.Get(settings.Language, "lang"));
        Console.WriteLine(Texts.Get(settings.Language, "setbet"));
        Console.WriteLine(Texts.Get(settings.Language, "clear"));
        Console.WriteLine(Texts.Get(settings.Language, "back"));

        string c = Console.ReadLine();

        if (c == "1")
        {
            if (settings.Language == Language.PL)
            {
                settings.Language = Language.EN;
            }
            else
            {
                settings.Language = Language.PL;
            }
        }

        if (c == "2")
            settings.AskForBetMode = !settings.AskForBetMode;

        if (c == "3")
        {
            Console.WriteLine(Texts.Get(settings.Language, "sure"));
            string input = Console.ReadLine().ToUpper();
            if (input == "Y" || input == "T")
                hall.Clear();

        }
    }
}