# Třída `Paginator`

Napište třídu, která bude simulovat chování paginatoru (stránkovače).

* V konstruktoru třída obdrží pole řetězců (data k zobrazení) a celé číslo limit (kolik nejvýše smí být řetězců na stránce).

  Např: `Paginator p = new Paginator({"Přemysl", "Nezamysl", "Mnata", "Vojen", "Vnislav", "Křesomysl", "Neklan", "Hostivít"}, 3);`

`Paginator` bude mít vlastnosti
* `ItemCount` - počet prvků celkem (zde 8, máme uloženo 8 řetězců)
* `PageCount` - počet stránek (zde 3, dvě plné, na poslední jen 2 prvky)

`Paginator` bude mít metody
* `GetPageItemCount(int n)` - vrátí počet prvků na stránce číslo `n`, pro neexistující stránky vrátí 0
   - `p.GetPageItemCount(1)` vrátí `3`
   - `p.GetPageItemCount(2)` vrátí `2`
   - `p.GetPageItemCount(5)` vrátí `0`

* `GetPage(int n)` - vrátí pole prvků na stránce číslo `n`
   - `p.GetPage(1)` vrátí `{"Vojen", "Vnislav", "Křesomysl"}`
   - `p.GetPage(2)` vrátí `{"Neklan", "Hostivít"}`
   - `p.GetPage(5)` vrátí prázdné pole

* `FindPage(string s)` - vrátí číslo stránky, na které se prvek poprvé vyskytuje, nebo `-1` pro neexistující prvek
  - `p.FindPage("Vnislav")` vrátí `1`
  - `p.FindPage("Miloš")` vrátí `-1`
