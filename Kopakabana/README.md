# Opis zadania
Na pla¿y Kopakabana oprócz pla¿owania tocz¹ siê te¿ rozgrywki w 3 grach zespo³owych: siatkówka pla¿owa, 2 ognie i przeci¹ganie liny. 
Ka¿da z dru¿yn sk³ada siê ze sta³ej liczby zawodników. 
Tocz¹ oni mecze/spotkania na zasadzie ka¿dy z ka¿dym. 
Pierwsze 4 dru¿yny z najwiêksz¹ liczb¹ zwyciêstw przechodz¹ do pó³fina³ów a ich zwyciêzcy do fina³ów. 
Ka¿de ze spotkañ sêdziuje sêdzia, a dodatkowo w siatkówce 2 sêdziów pomocniczych.

Minimalny zakres funkcjonalnoœci
zarz¹dzanie sêdziami (dodawanie, usuwanie, przegl¹d)
zarz¹dzanie dru¿ynami (zg³aszanie, wycofywanie, przegl¹d)
organizacja rozgrywek w ka¿dej dyscyplinie: tworzenie meczów (spotkañ), wpisywanie wyników, automatyczne generowanie pó³fina³ów i fina³ów
wyœwietlanie tabeli wyników
zapis i odczyt stanu systemu na dysk

# Kardynalne wskazówki dotycz¹ce kodu:
- Stosuj znacz¹ce nazwy 
- Oddzielaj interfejs od logiki ! :
	- u¿ywaj parametrów i wyników zamiast czytaæ z klawiatury/pisaæ na ekran) 
	- klasy logiki niezale¿ne od klas interfejsowych, klasy interfejsowe zale¿ne od klas logiki
- D³ugie metody powinny byæ podzielone (zasada 1 ekranu)
- Ograniczaj u¿ywanie konstrukcji 'if' - maks. 3 poziomy zag³êbienia
- Komentarze - kod samo-dokumentuj¹cy

# Wskazówki dotycz¹ce prezentacji gotowych programów
- Programy prezentowane s¹ publicznie z u¿yciem projektora na komputerach pracowni lub studentów.
- Prezentowany program musi byæ zgodny z kodem za³adowanym do Moodle.
- Prezentowany program jest obs³ugiwany przez prowadz¹cego - ale mo¿e on poprosiæ o to jego autorów.
- Wskazane jest dostarczenie przyk³adowego, zapisanego stanu programu, aby mo¿na by³o go wczytaæ i unikn¹æ ¿mudnego wprowadzania danych pocz¹tkowych.

## Implementacja wiêkszego programu (na podstawie zaproponowanej struktury). Programy te realizowane s¹ w grupach 2-3 osobowych.
Mo¿na za ni¹ zdobyæ 40 punktów przy czym aby uzyskaæ zaliczenie z PS nale¿y to zdobyæ min. 10 punktów
UWAGA: W implementacji programu nale¿y OBOWI¥ZKOWO wykorzystaæ i opisaæ przynajmniej jedn¹ bibliotekê u¿ytego jêzyka programowania opisan¹ w jego dokumentacji technicznej w jêzyku angielskim.
Szczegó³owa punktacja programu:
10 - struktura obiektowa programu: musi byæ u¿yte min. 5-6 klas, technika dziedziczenia i kompozycji; projekt finalny mo¿e siê ró¿niæ od propozycji ocenianej na 10. zajêciach - ta czêœæ jest oceniana podobnie jak ona, ale z wag¹ 50%;
8 - poprawnoœæ implementacji (realizacja funkcjonalnoœci, brak b³êdów w dzia³aniu);
6 - jakoœæ kodu (czytelne nazwy, komentarze, brak wielokrotnie zagnie¿d¿onych warunków 'if', krótkie metody)
4 - przyjaznoœæ u¿ycia (jakoœæ interfejsu, intuicyjnoœæ obs³ugi);
4 - poprawne u¿ycie metod wirtualnych do realizacji funkcjonalnoœci programu;
4 - u¿ycie mechanizmu wyj¹tków do obs³ugi b³êdów (wyrzucanie, obs³uga, w³asne klasy);
4 - napisanie testów (JUnit, CSUnit).
nale¿y jasno opisaæ podzia³ pracy (niedopuszczalne s¹ sformu³owania "wszyscy pracowali równo", "podzia³ pracy po 50 %", ...)
"Kara" za nieterminowe oddanie diagramu UML i programu (pkt. 3 i 4) to -2 punkty za ka¿dy zaczêty dzieñ zw³oki (liczony od rozpoczêcia zajêæ, na których nale¿a³o oddaæ zadanie). 