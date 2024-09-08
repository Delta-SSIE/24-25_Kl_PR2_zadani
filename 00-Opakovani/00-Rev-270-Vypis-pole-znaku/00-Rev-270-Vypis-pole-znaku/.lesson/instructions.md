# Výpis pole znaků

 V již připravené části programu je na začátku inicializováno toto dvojrozměrné pole:

```
char[,] znaky = new char[,] {
    { 'a', 'b', 'c', 'd', 'e', 'f' },
    { 'g', 'h', 'i', 'j', 'k', 'l' },
    { 'm', 'n', 'o', 'p', 'q', 'r' },
    { 't', 'u', 'v', 'w', 'x', 'y' }
};
```

Nyní se uživatele zeptejte na dva dotazy - zda chce vypsat řádek nebo sloupec, a pak který. 

Na konci program vypíše řádek nebo sloupec dle přání uživatele. 

Program by měl správně fungovat i pro různě velká pole znaků v inicializaci.

*Ukázky komunikace s programem:*
```
PC: Chceš vypsat řádek (r) nebo sloupec (s)
Uživatel: s
PC: Který sloupec? (1 - 6)
Uživatel: 2
PC: bhnu
```

```
PC: Chceš vypsat řádek (r) nebo sloupec (s)
Uživatel: r
PC: Který řádek? (1 - 4)
Uživatel: 4
PC: tuvwxy
```
