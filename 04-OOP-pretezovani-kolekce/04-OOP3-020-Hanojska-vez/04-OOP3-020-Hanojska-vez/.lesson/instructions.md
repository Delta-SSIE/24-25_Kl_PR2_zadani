# Hanojská věž

Napište simulátor hlavolamu: https://www.mathsisfun.com/games/towerofhanoi.html         

* Hlavolam implementujte jako objekt
* V konstruktoru dostane počet desek (a tím pádem poloměr největší z nich)
* Všechny desky jsou na začátku uspořádány na levém kolíku (věži)
* Hlavolam bude mít metodu `Render()` která vykreslí do konzole aktuální stav, např:

```
    #         |         |
   ###        |         |
  #####       |         |
 #######      |         |
#########     |         |
============================
```
nebo
```
    |         |         |
    |         |         | 
    |         |         |
    #        ###        |
#########  ######     #####
============================
```
* Pro jednoduchost můžete nejprve jen vypisovat uložené hodnoty, později upravíte výstup:
```
L: 5 1
S: 4 2  
P: 3 
```
* Hlavolam bude mít metodu `Move(int from, int to)`, která přesune horní desku z jednoho kolíku na druhý, pokud lze
* Pak vyzkoušejte sérii příkazů v kódu (v poli) a nechte je vykonávat (s nějakou pauzou)
* Změňte způsob posouvání na interaktivní - z klávesnice
* **(Bonus)** napište automat, který bude přesouvat desky sám