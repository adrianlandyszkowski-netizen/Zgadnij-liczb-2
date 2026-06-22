using System;
using System.Diagnostics;

public class Game
{
    protected Random random = new Random();

    public virtual Score Start(Difficulty difficulty, int maxAttempts, Language lang)
    {
        int max;

        if (difficulty == Difficulty.Easy)
        {
            max = 50;
        }
        else if (difficulty == Difficulty.Hard)
        {
            max = 250;
        }
        else
        {
            max = 100; 
        }

        int secret = random.Next(1, max + 1);
        int attempts = 0;

        Stopwatch sw = new Stopwatch();
        sw.Start();

        while (true)
        {
            Console.WriteLine(Texts.Get(lang, "try") + " " + (attempts + 1));

            if (!int.TryParse(Console.ReadLine(), out int guess))
            {
                Console.WriteLine(Texts.Get(lang, "typeNumber"));
                continue;
            }

            attempts++;

            if (guess == secret)
            {
                sw.Stop();

                Console.WriteLine(Texts.Get(lang, "win"));
                string name = Console.ReadLine();

                return new Score
                {
                    PlayerName = name,
                    Attempts = attempts,
                    TimeInSeconds = (int)sw.Elapsed.TotalSeconds,
                    Difficulty = difficulty,
                    IsGamePlus = false
                };
            }

            if (maxAttempts > 0 && attempts >= maxAttempts)
            {
                Console.WriteLine(Texts.Get(lang, "lose"));
                return null;
            }

            // ODPOWIEDZI
            string[] low = {
                Texts.Get(lang, "lose1"),
                Texts.Get(lang, "lose2"),
                Texts.Get(lang, "lose3"),
                Texts.Get(lang, "lose4"),
                Texts.Get(lang, "lose5"), 
            };

            string[] high = {
                Texts.Get(lang, "win1"),
                Texts.Get(lang, "win2"),
                Texts.Get(lang, "win3"),
                Texts.Get(lang, "win4"),
                Texts.Get(lang, "win5"),
            };
            
            if (guess < secret) {
                int indeks = random.Next(low.Length);
                Console.WriteLine(low[indeks]);
            } else {
                int indeks = random.Next(high.Length);
                Console.WriteLine(high[indeks]);
            }
        }
    }
}
