public static class Texts
{
    public static string Get(Language lang, string key)
    {
        // Angielski
        if (lang == Language.EN)
        {
            if (key == "title") return "GUESS THE NUMBER";
            if (key == "newGame") return "1. New Game";
            if (key == "settings") return "2. Settings";
            if (key == "hall") return "3. Hall of Fame";
            if (key == "exit") return "0. Exit";
            if (key == "typeNumber") return "Type number!";
            if (key == "try") return "Try:";
            if (key == "win") return "Correct! Enter your name:";
            if (key == "lose") return "You lost!";
            if (key == "bet") return "Bet mode:";
            if (key == "lang") return "1. Change Language";
            if (key == "setbet") return "2. Change bet Mode";
            if (key == "clear") return "3. Clear HallOfFame";
            if (key == "back") return "4. Back";
            if (key == "sure") return "Are you sure? Y/N";
            if (key == "max") return "Max attempts:";
            if (key == "time") return "Time:";
            if (key == "easy") return "1. Easy";
            if (key == "medium") return "2. Medium";
            if (key == "hard") return "3. Hard";
            if (key == "lose1") return "Too low! Try higher.";
            if (key == "lose2") return "Almost there! A little bit more.";
            if (key == "lose3") return "Missed! Your number is too low.";
            if (key == "lose4") return "You need to aim for bigger numbers!";
            if (key == "lose5") return "Warm... but add a little more.";
            if (key == "win1") return "Too much! You overshot.";
            if (key == "win2") return "Definitely too much.";
            if (key == "win3") return "Your number is too high.";
            if (key == "win4") return "Go lower, the value is too big!";
            if (key == "win5") return "Don't rush, try a smaller number.";
            if (key == "halleasy") return "1. Easy [1-50]";
            if (key == "hallmedium") return "2. Medium [1-100]";
            if (key == "hallhard") return "3. Hard [1-250]";
            if (key == "change") return "Number has change!";
            

            return "";
        }

        // Polski

        if (key == "title") return "ZGADNIJ LICZBE";
        if (key == "newGame") return "1. Nowa gra";
        if (key == "settings") return "2. Ustawienia";
        if (key == "hall") return "3. Hall of Fame";
        if (key == "exit") return "0. Wyjscie";
        if (key == "typeNumber") return "Podaj liczbe!";
        if (key == "try") return "Proba:";
        if (key == "win") return "Brawo! Podaj imie:";
        if (key == "lose") return "Przegrales!";
        if (key == "langset") return "Język: ";
        if (key == "bet") return "Tryb zakladu: ";
        if (key == "lang") return "1. Zmień język";
        if (key == "setbet") return "2. Zmień tryb zakładu";
        if (key == "clear") return "3. Wyczyść HallOfFame";
        if (key == "back") return "4. Wróc";
        if (key == "sure") return "Jesteś pewny? T/N";
        if (key == "max") return "Max liczba prob:";
        if (key == "time") return "Czas:";
        if (key == "easy") return "1. Łatwy";
        if (key == "medium") return "2. Średni";
        if (key == "hard") return "3. Trudny";
        if (key == "lose1") return "Za mało! Spróbuj wyżej.";
        if (key == "lose2") return "Prawie się udało! Troszkę więcej.";
        if (key == "lose3") return "Pudło! Twoja liczba jest zbyt niska.";
        if (key == "lose4") return "Musisz celować w większe liczby!";
        if (key == "lose5") return "Ciepło... ale dodaj jeszcze trochę.";
        if (key == "win1") return "Za dużo! Przestrzeliłeś.";
        if (key == "win2") return "Zdecydowanie za dużo.";
        if (key == "win3") return "Twoja liczba jest zbyt wysoka.";
        if (key == "win4") return "Schodź w dół, za duża wartość!";
        if (key == "win5") return "Nie szarżuj, spróbuj mniejszej liczby.";
        if (key == "halleasy") return "1. Łatwy [1-50]";
        if (key == "hallmedium") return "2. Medium [1-100]";
        if (key == "hallhard") return "3. Trudny [1-250]";
        if (key == "change") return "Liczba została zmieniona!";

        return "";
    }
}