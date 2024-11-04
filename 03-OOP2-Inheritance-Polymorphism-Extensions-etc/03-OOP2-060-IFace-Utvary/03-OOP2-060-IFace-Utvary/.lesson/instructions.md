# Geometrické úvtary

## Interface `IUtvar`
Založte interface `IUtvar`. `IUtvar` bude mít:
* vlastnost `Nazev` (string) veřejně pro čtení
* veřejné  metody `GetObvod()` a `GetObsah()` (vrací double)

## Třída `Ctverec`
Vytvořte uzavřenou třídu `Ctverec`, která implementuje `IUtvar`. Čtverec má
* veřejnou vlastnost `Strana` (double) se soukromým zápisem
* konstruktor, kterému se bude předávat strana a on ji uloží.
* implementovány metody `GetObvod()` a `GetObsah()`
deklarovánu metodu  `ToString()`, která přepíše původní  `ToString()` a vrací text `"Čtverec o straně ..."`
* vlastnost `IUtvar.Nazev` bude vracet řetězec "čtverec"

## Třída `Kruh`
Vytvořte uzavřenou třídu `Kruh`, která rozšiřuje  `IUtvar`. Kruh má
* veřejnou vlastnost Polomer (double) se soukromým zápisem
* konstruktor, kterému se bude předávat poloměr a on jej uloží.
* implementovány metody `GetObvod()` a `GetObsah()`
* deklarovánu metodu  `ToString()`, která přepíše původní  `ToString()` a vrací text `"Kruh o poloměru ..."`
* vlastnost `IUtvar.Nazev` bude vracet řetězec "kruh"

## Třída `Trojuhelnik`
Vytvořte uzavřenou třídu `Trojuhelnik`, která rozšiřuje  `IUtvar`. Trojuhelnik má
* veřejné vlastnosti `Strana1`, `Strana2` a `Strana3` (double) se soukromým zápisem
konstruktor, kterému se budou předávat strany a on je uloží.
* implementovány metody `GetObvod()` a `GetObsah()` _//pokud nevíte, jak na obsah, vyhledejte si Heronův vzorec_
* deklarovánu metodu  `ToString()`, která přepíše původní  `ToString()` a vrací text `"Trojúhelník o stranách ..., ... a ..."`
* vlastnost `IUtvar.Nazev` bude vracet řetězec "trojúhelník"

## `IUtvar` jako typ
1. Vytvořte pole objektů třídy `IUtvar` 
1. uložte do něj nejméně jeden útvar každého typu
1. projděte pole cyklem a vypište "podpisy" (`ToString`) všech obrazců v něm
1. zjistěte celkový obvod a obsah všech útvarů v poli
1. _(bonus)_ vypište počty všech typů útvarů uložených v poli (např: `"čtverec 2x, trojúhelník 1x"`)

## Třída `PlechovkaBarvy`
Vytvořte třídu `PlechovkaBarvy`
* bude v konstruktoru dostávat desetinná čísla `objem` a `vydatnost`, která si uloží. Čísla znamenají, kolik mililitrů v "pixle" je a kolik je třeba mililitrů na cm².
* bude mít veřejnou metodu  `ToString()`, která bude vracet něco jako `"Plechovka barvy, zbývá jí ještě na 60 cm²"`.
* bude mít veřejnou metodu `Obarvi()`, která obrdží `IUtvar` a pokud je v plechovce dost barvy na jeho obarvení, sníží svůj objem a vrátí `true` (úspěch), jinak si ponechá původní objem a vrátí `false` (neúspěch)
* Vytvořte instanci plechovky a vyzkoušejte obarvit všechny útvary z pole. Udělejte si pole větší, abyste vyzkoušeli i to, že plechovka dojde.