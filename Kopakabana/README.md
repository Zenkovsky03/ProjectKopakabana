# Opis zadania
Na pla�y Kopakabana opr�cz pla�owania tocz� si� te� rozgrywki w 3 grach zespo�owych: siatk�wka pla�owa, 2 ognie i przeci�ganie liny. 
Ka�da z dru�yn sk�ada si� ze sta�ej liczby zawodnik�w. 
Tocz� oni mecze/spotkania na zasadzie ka�dy z ka�dym. 
Pierwsze 4 dru�yny z najwi�ksz� liczb� zwyci�stw przechodz� do p�fina��w a ich zwyci�zcy do fina��w. 
Ka�de ze spotka� s�dziuje s�dzia, a dodatkowo w siatk�wce 2 s�dzi�w pomocniczych.

Minimalny zakres funkcjonalno�ci
zarz�dzanie s�dziami (dodawanie, usuwanie, przegl�d)
zarz�dzanie dru�ynami (zg�aszanie, wycofywanie, przegl�d)
organizacja rozgrywek w ka�dej dyscyplinie: tworzenie mecz�w (spotka�), wpisywanie wynik�w, automatyczne generowanie p�fina��w i fina��w
wy�wietlanie tabeli wynik�w
zapis i odczyt stanu systemu na dysk

# Kardynalne wskaz�wki dotycz�ce kodu:
- Stosuj znacz�ce nazwy 
- Oddzielaj interfejs od logiki ! :
	- u�ywaj parametr�w i wynik�w zamiast czyta� z klawiatury/pisa� na ekran) 
	- klasy logiki niezale�ne od klas interfejsowych, klasy interfejsowe zale�ne od klas logiki
- D�ugie metody powinny by� podzielone (zasada 1 ekranu)
- Ograniczaj u�ywanie konstrukcji 'if' - maks. 3 poziomy zag��bienia
- Komentarze - kod samo-dokumentuj�cy

# Wskaz�wki dotycz�ce prezentacji gotowych program�w
- Programy prezentowane s� publicznie z u�yciem projektora na komputerach pracowni lub student�w.
- Prezentowany program musi by� zgodny z kodem za�adowanym do Moodle.
- Prezentowany program jest obs�ugiwany przez prowadz�cego - ale mo�e on poprosi� o to jego autor�w.
- Wskazane jest dostarczenie przyk�adowego, zapisanego stanu programu, aby mo�na by�o go wczyta� i unikn�� �mudnego wprowadzania danych pocz�tkowych.

## Implementacja wi�kszego programu (na podstawie zaproponowanej struktury). Programy te realizowane s� w grupach 2-3 osobowych.
Mo�na za ni� zdoby� 40 punkt�w przy czym aby uzyska� zaliczenie z PS nale�y to zdoby� min. 10 punkt�w
UWAGA: W implementacji programu nale�y OBOWI�ZKOWO wykorzysta� i opisa� przynajmniej jedn� bibliotek� u�ytego j�zyka programowania opisan� w jego dokumentacji technicznej w j�zyku angielskim.
Szczeg�owa punktacja programu:
10 - struktura obiektowa programu: musi by� u�yte min. 5-6 klas, technika dziedziczenia i kompozycji; projekt finalny mo�e si� r�ni� od propozycji ocenianej na 10. zaj�ciach - ta cz�� jest oceniana podobnie jak ona, ale z wag� 50%;
8 - poprawno�� implementacji (realizacja funkcjonalno�ci, brak b��d�w w dzia�aniu);
6 - jako�� kodu (czytelne nazwy, komentarze, brak wielokrotnie zagnie�d�onych warunk�w 'if', kr�tkie metody)
4 - przyjazno�� u�ycia (jako�� interfejsu, intuicyjno�� obs�ugi);
4 - poprawne u�ycie metod wirtualnych do realizacji funkcjonalno�ci programu;
4 - u�ycie mechanizmu wyj�tk�w do obs�ugi b��d�w (wyrzucanie, obs�uga, w�asne klasy);
4 - napisanie test�w (JUnit, CSUnit).
nale�y jasno opisa� podzia� pracy (niedopuszczalne s� sformu�owania "wszyscy pracowali r�wno", "podzia� pracy po 50 %", ...)
"Kara" za nieterminowe oddanie diagramu UML i programu (pkt. 3 i 4) to -2 punkty za ka�dy zacz�ty dzie� zw�oki (liczony od rozpocz�cia zaj��, na kt�rych nale�a�o odda� zadanie). 