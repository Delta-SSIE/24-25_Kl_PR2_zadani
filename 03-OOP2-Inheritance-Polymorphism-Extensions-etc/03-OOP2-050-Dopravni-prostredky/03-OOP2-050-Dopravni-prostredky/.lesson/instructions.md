# Dopravní prostředky

1. Připravte enumeraci `TypPohonu` s hodnotami `Manualni`, `SpalovaciMotor`, `Elektromotor`

1. Vytvořte abstraktní třídu `DopravniProstredek`. 
  Ta bude mít
   * Veřejné vlastnosti `Nazev` (string), `Pohon` (TypPohonu), `MaxRychlost` (double) a `PocetMist` (int)
   * Konstruktor, který obdrží a uloží předchozí parametry
   * Abstraktní metodu `Natankuj()`, která nic nevrací
   * nějaký pěkný `ToString()` sestavený z vlastností prostředku

1. Vytvořte uzavřenou třídu `Motocykl`, která dědí z `DP`.
   * Konstruktor bude přijímat pouze maximální rychlost. Bude volat konstruktor bázové třídy a předávat mu reálné parametry (pohon je `spalovací`, počet míst `2`)
   * `Natankuj()` vypíše do konzole `"Plním nádrž benzínem"`

1. Vytvořte abstraktní třídu `Automobil`, která dědí z `DP`.
   * Konstruktor bude přijímat všechny parametry z bodu 1 kromě názvu, pak zavolá konstruktor bázové třídy a vše jí předá (název je `"automobil"`)

1. Vytvořte uzavřenou třídu `DieselAuto`, která dědí z `Automobil`
   * Konstruktor bude přijímat jen `MaxRychlost` a `PocetMist`, pak zavolá konstruktor bázové třídy a vše jí předá (pohon je `spalovací`)
   * `Natankuj()` vypíše do konzole `"Plním nádrž naftou"`

1. Vytvořte uzavřenou třídu `ElektroAuto`, která dědí z `Automobil`
   * Konstruktor bude přijímat jen `MaxRychlost` a `PocetMist`, pak zavolá konstruktor bázové třídy a vše jí předá (pohon je `elektromotor`)
   * `Natankuj()` vypíše do konzole `"Připojuji na nabíječku"`

1. Vytvořte uzavřenou třídu `Bicykl`, která dědí z `DP`.
   * Konstruktor bude přijímat pouze maximální rychlost. Bude volat konstruktor bázové třídy a předávat mu reálné parametry (název je `"bicykl"`, pohon je `manuální`)
   * `Natankuj()` vypíše do konzole `"jdu na svačinu"` :)

1. Vytvořte uzavřenou třídu `Flotila`
   * Flotila bude mít nějakou formu úložiště, ve kterém si bude ukládat jednotlivá vozidla flotily
   * bude mít metodu `PridejVozidlo (DopravniProstredek v)`, která přidá předané vozidlo do flotily
      * pokud by přesně toto vozidlo ve flotile už bylo, pak vyvolá výjimku
   * (volitelně) bude mít také metodu `OdeberVozidlo (DopravniProstredek v)`
   * bude mít veřejné vlastnosti (jen pro čtení) `Velikost` a `Kapacita`, které budou vracet, kolik vozidel ve flotile je a kolik lidí flotila uveze.
   * bude mít veřejnou metodu `Natankuj()`, která natankuje všechna vozidla ve flotile
   * _Pokud umíte seřadit pole_: bude mít veřejnou metodu `OdvezRychle(int pocetLidi)`, která vybere vozidla tak, aby daný počet lidí přepravila nejrychleji. Vypíše do konzole všechna použitá vozidla a také rychlost přesunu (předpokládáme, že celá flotila pojede rychlostí nejpomalejšího prvku). Pokud není možné lidi odvézt, metoda to také vypíše
   * bude mít veřejnou vlastnost `Pohony` (jen pro čtení), která bude vracet pole všech pohonů vozidel. Pozor, každý typ bude v poli nejvýše jednou, i kdyby jej mělo 10 vozidel

1. Vytvořte flotilu a naplňte ji několika různými vozidly. Vyzkoušejte její metody včetně neřešitelných, krajních a chybových stavů (moc lidí k přepravě, Pohony prázdné flotily, přidání stejného auta podruhé, odebrání neexistujícího)

### Další možné úkoly
* Můžete přidat i další podobné třídy, třeba Kůň nebo Autobus …
* Přidejte každému prostředku vlastnost dojezd, která se bude vypočítávat podle vlastních parametrů třídy - třeba u motocyklu a auta z velikosti nádrže, stavu benzínu a spotřeby (budete předávat v konstruktoru), natankuj pak bude doplňovat nádrž na 100%. 
   * U elektroauta nebude nádrž, ale baterie a spotřeba v Ah/km, 
   * U kola bude dojezd 60 km fixně. 
   * Pak flotile vytvoříte metodu `KapacitaDo`, které dáte vzdálenost a ona vám řekne, kolik lidí tam dokáže dovézt.