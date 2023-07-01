# Rezerwacja pokoi hotelowych

Prosta aplikacja konsolowa do rezerwacji pokoi hotelowych napisana w C#. Aplikacja korzysta z dwóch wzorców projektowych: Singleton i Adapter.

## Wzorce projektowe

**Singleton:** Wzorzec ten zapewnia, że tylko jedna instancja danej klasy istnieje w całym systemie. W tym przypadku Singleton jest używany do przechowywania jednej instancji obiektu rezerwacji pokoju (IRoomBooking).

**Adapter:** Adapter to wzorzec strukturalny, który pozwala na współdziałanie obiektów o niekompatybilnych interfejsach. W aplikacji Adapter jest używany do dostosowania interfejsu VipRoomBooking do interfejsu IRoomBooking.

## Instrukcje

1. Skompiluj i uruchom program.
2. Podaj wymagane informacje, kiedy o to poprosisz:
   - Imię i nazwisko
   - Data przyjazdu
   - Data odjazdu
   - Numer pokoju
   - Czy chcesz zarezerwować pokój VIP? Jeśli tak, wprowadź dodatkowe informacje dla VIP.
3. Aplikacja dokona rezerwacji pokoju z wprowadzonymi danymi.

Jeżeli podane daty nie są zgodne z zasadami (data przyjazdu nie może być z przeszłości, a data odjazdu nie może być dłuższa niż 30 dni od przyjazdu), aplikacja poprosi o wprowadzenie ich ponownie.

## Uwagi

Aplikacja nie sprawdza, czy numer pokoju jest dostępny. To jest uproszczony model i zakłada, że wszystkie pokoje są dostępne. Dla uproszczenia, aplikacja nie sprawdza, czy wprowadzone dane są poprawne (np. czy data jest poprawnym formatem daty). W rzeczywistym środowisku produkcyjnym należy dodać walidację danych wejściowych.

## Autor

Dominik Bednarz

## Licencja

Ten projekt jest licencjonowany na podstawie licencji MIT.
