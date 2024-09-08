# Třída `Archiv`

Napište kód třídy `Archiv`. Archiv bude simulovat úložiště objektů - třeba časopisů. 

Časopisy se skladují do polic, přičemž do jedné police se vejde `kapacita` časopisů, a jedna skříň má `police` polic. Časopisy se pouze ukládají, nikdy neodebírají.

Třída `Archiv`
* nesmí mít žádnou datovou položku kromě parametrů předaných konstruktoru (v zadání označeny `kapacita` a `police`)
* smí mít jen jednu další vlastnost - `Pocet`, která bude obsahovat, kolik časopisů bylo uloženo 
* bude mít dvě veřejné metody
  * `Uloz(kolik)`, která do archivu uloží zadaný počet časopisů
  * `Reset()`, která archiv zcela vyprázdní
* Pak přidejte ještě dvě veřejné vlastnosti (bez zápisu)
  * `Skrin`, `Police` a `Pozice`, které budou udávat pozici příštího uloženého časopisu v polici, pořadí této police ve skříni a číslo skříně. Všechny pozice jsou číslovány přirozeně - tedy začínají číslem 1.
* Při vytvoření nového archivu předá uživatel konstruktoru hodnoty `police` a `kapacita`. 


Například tedy pro 
```
Archiv archiv = new Archiv(4, 25);//4 police na skříň
                                  //25 časopisů na polici
```
budou zobrazené hodnoty vlastností `archiv.Skrin = 1`, `archiv.Police = 1`, `archiv.Pozice = 1`

Poté, co vykonáme
```
archiv.Uloz(160);
```
budou hodnoty `archiv.Skrin = 2`, `archiv.Police = 3`, `archiv.Pozice = 11`