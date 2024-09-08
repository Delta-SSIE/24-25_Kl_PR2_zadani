# Nejvíc nul

Napište hlavičku i tělo metody `NejvicNul`, které předáte dvojrozměrné pole celých čísel a metoda vypíše index sloupce (tak jak budou čísla zapsána v deklaraci), ve kterém je nejvíc hodnot rovných nule. Při shodě vypíše první nalezený sloupec.

Např:

```
        int[,] cisla =
        {
            { 0,  0, 12, 0,  7},
            {13,  0,  5, 0,  1},
            { 0, -1,  0, 4,  5},
            { 1, -1,  0, 0, -5},
        };

        Console.WriteLine(NejvicNul(cisla)); //vypíše 3
```

Metoda ale musí samozřejmě fungovat i pro jakákoli jiná pole.

## Level 2

Předávejte metodě ještě jeden parametr, třeba `typ`, který říká, jestli hledáme sloupec (`true`) nebo řádek (`false`)

```
        int[,] cisla =
        {
            { 0,  0, 12, 0,  7},
            {13,  0,  5, 0,  1},
            { 0, -1,  0, 4,  5},
            { 1, -1,  0, 0, -5},
        };

        Console.WriteLine(NejvicNul(cisla, true)); //vypíše 3 - pro sloupce
        Console.WriteLine(NejvicNul(cisla, false)); //vypíše 0 - pro řádky
```