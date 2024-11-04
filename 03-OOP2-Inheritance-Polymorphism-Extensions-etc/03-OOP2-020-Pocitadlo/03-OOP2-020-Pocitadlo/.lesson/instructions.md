# Počítadlo

## 1. `Counter` (počítadlo)
Vytvořte kód třídy `Counter` tak, aby každé počítadlo mělo:

* vlastnost `Count` (celé číslo, stav), který lze veřejně zjistit
* metodu `Next`, která nic nevrací, ale zvýší počítadlo o 1
* metodu `Reset`, která vrátí počítadlo zpět na nulu

## 2. `StepCounter`
Rozšiřte pomocí dědičnosti v nové třídě počítadlo tak, aby se mu v kontruktoru předávala hodnota `step` (krok). Při volání metody `Next` se pak bude zvyšovat o tuto hodnotu.

_Poznámka: K tomu by stačilo jen přidat do konstruktoru volitelný parametr. Novou třídu vytváříme jen proto, abychom si potrénovali dědičnost._

## 3. `DownCounter`
* Rozšiřte v další třídě počítadlo `StepCounter` tak, aby se mu v konstruktoru předával nejen `Step` ale také `initValue` (počíteční hodnota). `DownCounter` bude využívat konstruktor bázové třídy a bude ji rozšiřovat tak že při zavolání `Next` hodnota počítadla klesne o předanou hodnotu.
* `DownCounter` bude mít dále vlastnost `IsFinished`, která bude vrace true v případě, že odpočet došel na nulu (nebo níže)
* Metoda `Reset` stále funkční