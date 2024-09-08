# Test výrobku

Sestavte dvě třídy

Třída `vyrobek` bude mít 
* veřejnou vlastnost `rozmer` (desetinné číslo). 
* v případě nastavení nulové nebo záporné hodnoty bude třída vyvolávat vhodnou výjimku
* `rozmer` bude také přijímat a ukládat konstruktor třídy

Třída `tester` bude mít
* veřejnou vlastnost `vzor` (konrétní instance výrobku)
* veřejnou vlastnost `tolerance` (desetinné číslo, udává toleranci v %)
* v konstruktoru bude přijímat jak vzor tak toleranci
* obě vlastnosti lze nastavit, při nesmyslné hodnotě (null, záporná čísla) bude vyvolána výjimka
* metodu `vyhovuje`, které předáte instanci výrobku a ona vrátí, zda výrobek vyhovuje nebo nevyhovuje toleranci (za základ povařujte `vzor`)

Pojmenujte všechny objekty, metody a vlastnosti podle běžných konvencí

