# ELTE Beadandó feladat

Írjon egy `LinkedArray` nevű osztályt, amellyel egy tetszőleges (egyenlő) méretű belső tömbökben adatokat tudunk tárolni.

- A tömb mérete legyen n, tudjunk belőle tárolni m-et.
- Az osztály belsőleg egy tömböt használjon, amely több kisebb tömbben tárolja az adatokat.
- A külső metódusok mindig egy indexet kérjenek be!
- A belső tömb tároljon `Object` típusokat. (Esetleg generikus is lehet.)

Egy osztály szolgáltatásainak (összes metódusának) bemutatásához olyan főprogramot
kell készíteni, amelyik egy menü segítségével teszi lehetővé a metódusok tetszőleges
sorrendben történő kipróbálását. A főprogram példányosítson egy objektumot, amelyre a
menüpontok közvetítésével lehessen meghívni az egyes metódusokat. Természetesen szükség
lehet minden tevékenység után az objektum állapotának kiírására vagy egy az objektum
állapotát kiíró külön menüpontra. 

Az osztály minden megírt metódusához írjon unit tesztet is.

Szükség szerint írjon saját segédfüggvényeket.

A problémákat (pl. hibás beadott értékek) kezelje le konzisztensen valamely tanult módszer segítségével.

2-es: 

- Készítse el az `LinkedArray` osztályt.
- Legyen egy `Object GetElement(int index)`, és egy `void SetElement(int index, Object value)` metódusa.
- Legyen rá mód, hogy kikérjük belőle a teljes méretét.
- Létrehozáskor legyen megadható, hogy mekkorák legyenek a belső tömbök.
- Készítsen az osztályhoz egy függvényt, amellyel minden tárolt adatot ki lehet üríteni.
- Készítsen az osztályhoz egy függvényt, amellyel a belső tömbök méretét egyszerűen 0-ra lehet állítani.
- Készítsen az osztályhoz egy függvényt, amellyel egy új sort hozzá tudunk adni a tömb végére.
- Legyen meg hozzá a teszt program.
- Legyenek hozzá Unit tesztek.

3-as:

- 2-es követelmények teljesülnek.
- Írjon felhasználói és fejlesztői dokumentációt az elkészített programhoz.

4-es:

- 2-es, 3-as követelmények teljesülnek.
- Készítsen az osztályhoz egy átméretező függvényt. Ügyeljen rá, hogy a bent maradó elemek indexei átméretezés után ne változzanak!
- Készítsen az osztályhoz egy függvényt, amellyel egy új sort hozzá tudunk adni a tömb végére.
- Készítsen az osztályhoz egy függvényt, amellyel a belső tömböt direktbe ki tudjuk kérni.
- Készítsen az osztályhoz egy függvényt, amellyel a belső tömb összes elemét egy művelettel fel tudjuk tölteni.
- Készítsen az osztályhoz egy függvényt, amellyel egy új sort hozzá tudunk adni a tömb elejére.
- Készítsen az osztályhoz egy függvényt amellyel meg tudjuk számolni, hogy a tömbünkben hány nem `null` elem van benn.
- A teszt program legyen kiegészítve az új függvényekkel.
- Legyenek az új függvényekhez is Unit tesztek.

5-ös:

- 2-es, 3-as, 4-es követelmények teljesülnek.
- Írjon felhasználói és fejlesztői dokumentációt az elkészített programhoz.
- Készítsen az egyik előző (nem triviális) feladathoz szekvencia diagramot, vagy 2 tetszőleges (nem triviális) függvényhez formális definíciót.
