# Texas hold'em

Připravte si vhodné enumerace a třídu pro implementaci karty.
 * barvy karet (Suits) jsou Hearts, Clubs, Spades, Diamonds
 * výšky karet (Rank) jsou 2, 3, …, 10, Jack, Queen, King, Ace
 
  tedy `Card aceOfSpades = new Card(Rank.Ace, Suit.Spades)`

Vytvořte třídu `Hand`

* v konstruktoru bude nepovinně přijímat pole max 5 karet, které si v sobě uloží
* bude možné přidat kartu, pokud je karet v ruce méně než 5 (`Hand.Add(card)`)
* bude možné vyměnit kartu za jinou - předáme  pozici a novou kartu (`Hand.Swap(3, new card(Rank.5, Suit.Clubs))`). Pozice je číslována od 1 do 5.  
* U karet i u „ruky“ přidejte rozumný `ToString()`, aby je bylo možné vypsat (dumpovat).  

Dvě plné pokerové ruce bude možné porovnat - implementujte pravidla Texas hold'em (https://en.wikipedia.org/wiki/Texas_hold_%27em). (Záleží na figuře, následně na výšce - ale na barvě nezáleží, může nastat rovnost). Řešte jako metodu, případně si vzomeňte, že něco podobného jsme dělali vloni a přidejte přetížení operátoru. 