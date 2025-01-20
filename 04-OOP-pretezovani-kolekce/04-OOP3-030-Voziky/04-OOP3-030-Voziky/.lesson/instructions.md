# Vozíky u supermarketu

Před obchodem stojí vozíky zasunuté v sobě. Zjistěte, jak bude který za den opotřeben (kolik minut stráví v provozu).

**Úlohu definují tyto parametry:**
* Počet vozíků
* Čas začátku provozu
* Čas konce provozu (kdy si lze vzít nejpozději vozík a začít nakupovat)
* Max počet zákazníků za minutu
* Min. doba nákupu
* Max. doba nákupu

Problém je asi pochopitelný - každou minutu přijde určitý počet zákazníků k vozíkům a postupně si je odeberou, pak stráví daný čas v obchodě (každý zákazník má svůj čas) a vozík vrátí. 

Vozíky budeme nejprve odebírat a až pak vracet - pokud si zákazník vezme vozík v minutě 3 a má strávit v obchodě 15 minut, předpokládejte, že v minutě 18 jeho vozík ještě není k dispozici ostatním, ale v minutě 19 už ano.

Zákazníky generujte s použitím generátoru náhodných čísel. 

**Kvůli porovnatelnosti výsledků**
* vložte do generátoru náhodných čísel seed 123456
* náhodné parametry generujte v uvedeném pořadí (nejprve počet v této minutě, pak pro každého nejprve minimální, pak maximální dobu nákupu)
* pokud v jedné minutě vrací vozíky více zákazníků, nejdříve je vrátí ti, kteří si ho jako první vyzvedli

Takto byste i při používání random měli dostávat všichni stejné a porovnatelné výsledky

**Pokud dojdou vozíky, pak:**
* v první verzi přerušte vykonávání a vypište varování
* když bude vše ostatní fungovat, řaďte zákazníky do fronty na vozíky

## Výsledek
Na konci vypište, jak dlouho byl který vozík v provozu (pokud dokážete, seřaďte od nejpoužívanějšího)
