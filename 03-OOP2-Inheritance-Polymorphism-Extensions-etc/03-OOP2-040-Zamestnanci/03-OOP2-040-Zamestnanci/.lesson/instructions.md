# Firma a zaměstnanci

V této úloze využijeme dědičnost/polymorfizmus. Budeme modelovat výplatní logiku firmy, která má zaměstnance několika typů, ale díky polymorfizmu k nim můžeme přistupovat jednotným způsobem. 

Vytvořte kód těchto tříd:

## `Zamestnanec`
Abstraktní třída 
* s vlastnostmi `Jmeno`, `Prijmeni` (řetězce), které lze veřejně číst, ale nastavit je může jen konstruktor
* s konstruktorem, kterému se `Jmeno` a `Prijmeni` předávají
* s abstraktní metodou `Mzda()` (celé číslo)

## `StalyZamestnanec`
* Dědí ze třídy `Zamestnanec`
* V konstruktoru přímo přijímá měsíční mzdu (celé číslo) a ukládá si ji tak, aby ji metoda `Mzda()` vracela

## `Brigadnik`
* Dědí ze třídy `Zamestnanec`
* Má veřejné vlastnosti `Odpracovano` (celé číslo, počet odpracovaných hodin) a `HodinovaMzda` (celé číslo)
* `Mzda()` vrací mzdu vypočtenou z předchozích položek

## `Dobrovolnik`
* Dědí ze třídy `Zamestnanec`
* Jeho mzda je nulová

## `Firma`
* Má veřejné metody `Zamestnej(zamestnanec)` a `Propust(zamestnanec)`, kterým předáme instanci nějakého zaměstnance a firma si jej připíše na svůj seznam. (_Nápověda: použijte List - nebo by se hodil HashSet, ale ten si musíte dohledat_)
* Má veřejnou metodu `Vyplata`, která vypíše pod sebe na řádky všechny zaměstnance spolu  s částkou, která jim bude vyplacena a pod to napíše celkovou sumu výplat.