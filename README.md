# Zgadnij Liczbę 2

## Opis projektu

Zgadnij Liczbę 2 to konsolowa gra napisana w języku C# w podejściu obiektowym.  
Jest to kontynuacja klasycznej gry „Zgadnij Liczbę”.

Gracz ma za zadanie odgadnąć losowo wygenerowaną liczbę w określonej liczbie prób.

---

## Funkcje gry

- wybór poziomu trudności
- tryb gry standardowej
- tryb Game Plus (liczba zmienia się co kilka prób)
- Hall of Fame (TOP 5 najlepszych wyników)
- zapisywanie wyniku gracza (imię, liczba prób, czas gry)
- ustawienia gry:
  - zmiana języka (PL / EN)
  - włączanie/wyłączanie trybu zakładu
  - czyszczenie Hall of Fame
- tryb zakładu (limit prób – przegrana po jego przekroczeniu)
- losowe podpowiedzi (za dużo / za mało)

---

## Poziomy trudności

- Easy: 1–50  
- Medium: 1–100  
- Hard: 1–250  

---

## Tryby gry

### Standardowa gra
Klasyczna wersja gry, w której liczba jest stała przez całą rozgrywkę.

### Game Plus
Utrudniona wersja gry, w której liczba zmienia się co 6–8 prób.

---

## Tryb zakładu

Jeśli tryb zakładu jest włączony:
- gracz podaje maksymalną liczbę prób
- jeśli przekroczy limit → przegrywa
- wynik nie trafia do Hall of Fame

---

## Hall of Fame

- TOP 5 wyników dla każdego poziomu trudności
- sortowanie: liczba prób → czas gry
- wyróżnienie Game Plus

---

## Uruchomienie

dotnet run

---

## Autor

Adrian Landyszkowski
