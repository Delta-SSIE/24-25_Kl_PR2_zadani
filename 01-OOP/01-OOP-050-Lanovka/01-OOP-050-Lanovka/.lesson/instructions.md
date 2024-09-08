# Lanovka

V této úloze potřebujete dvě třídy: `Clovek` a `Lanovka`

## Třída `Clovek`

`Clovek` je prosté úložiště pro dvě vlastnosti
 * `Jmeno` (string)
 * `Hmotnost` (double)


## Třída `Lanovka`

`Lanovka` bude představovat lanovku (pro jednoduchost ji budeme chápat jako "jednosměrnou")

Bude mít vlastnosti
 * `Delka` : počet sedaček (k zapsání pouze v konstruktoru)
 * `Nosnost` : nosnost v kg (k zapsání pouze v konstruktoru)
 * `Zatizeni` : pouze ke čtení, ukazuje aktuální zatížení lanovky všemi cestujícícmi dohromady
 * `JeVolnoDole` : logická, říká, zda je první sedačka volná nebo není
 * `JeVolnoNahore` : logická, říká, zda je volná poslední sedačka

Bude mít metody 

 * `Nastup(clovek)`: umístí na první sedačku člověka, pokud je volná a nedojde k přetížení lanovky. Vrací `true` nebo `false`
 * `Vystup()` : vrací člověka na poslední sedačce a vyprázdní ji (pokud tam byl) nebo `null`, pokud byla prázdná.
 * `Jed()` : posune všechny sedačky nahoru a poslední vrátí dolu. Pokud na poslední sedačce někdo ještě seděl, vyvolá místo toho výjimku.
 