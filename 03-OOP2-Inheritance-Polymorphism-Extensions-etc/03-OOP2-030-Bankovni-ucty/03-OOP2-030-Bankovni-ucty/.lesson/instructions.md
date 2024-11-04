# Bankovní účty

## Třída `Ucet`

Vytvořte třídu pro bankovní účet. 
* Bude mít veřejnou vlastnost `Stav` (double) se soukromým zápisem
* Bude mít veřejné metody `Uloz (double castka)` a `Vyber (double castka)`
  * v případě nesmyslného vstupu budou vyvolávat výjimku
  * v případě pokusu o výběr pod nulový stav účtu vyvolá výjimku
* Bude mít nějaký hezký `ToString()`

## Třída SporiciUcet
Spořící účet bude dědit ze třídy `Ucet`, navíc ale bude 
* Mít veřejnou vlastnost `UrokovaMira` (double). Hodnota `1.35` bude znamenat, že úroková míra je 1,35%
* Mít veřejnou metodu `Urokuj()`, která připíše na účet úroky podle úrokové míry

## Třída UcetSPoplatkem
I účet s poplatkem bude dědit ze třídy `Ucet`
* Bude mít veřejné vlastnosti `PoplatekZaVyber` a `PoplatekZaVklad` (double)
* Změní metody `Vyber` a `Uloz` tak, aby se před provedením operace nejprve z účtu strhl poplatek. _(Poradíte si s vyvoláním výjimky při nemožném výběru, aby nedošlo ke stržení poplatku ale jen 
k výjimce?)_

## Test
Vyzkoušejte tři typy účtů použít včetně vyvolání a zachycení výjimek.