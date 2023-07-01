using DPaSA_w61905;

//pierwsza próba
// Console.Write("Podaj imię i nazwisko: ");
// string name = Console.ReadLine();
//
// Console.Write("Podaj datę przyjazdu (format: yyyy-mm-dd): ");
// DateTime arrival = DateTime.Parse(Console.ReadLine());
//
// Console.Write("Podaj datę odjazdu (format: yyyy-mm-dd): ");
// DateTime departure = DateTime.Parse(Console.ReadLine());
//
// Console.Write("Podaj numer pokoju: ");
// int roomNumber = int.Parse(Console.ReadLine());
//
// Room room = new Room { Arrival = arrival, Departure = departure, RoomNumber = roomNumber };
//
// IRoomBooking roomBooking;
//
// Console.Write("Czy chcesz zarezerwować pokój VIP? (Tak/Nie): ");
// string isVip = Console.ReadLine()?.ToLower();
//
// if (isVip == "tak")
// {
//     Console.Write("Podaj dodatkowe informacje dla VIP: ");
//     room.BookingInfo = Console.ReadLine();
//     room.IsVip = true;
//     roomBooking = new VipRoomBookingAdapter();
// }
// else
// {
//     roomBooking = new StandardRoomBooking();
// }
//
// roomBooking.BookRoom(name, room);



//druga próba


Console.Write("Podaj imię i nazwisko: ");
string name = Console.ReadLine();

DateTime arrival;
while (true)
{
    Console.Write("Podaj datę przyjazdu (format: yyyy-mm-dd): ");
    arrival = DateTime.Parse(Console.ReadLine());

    if (arrival < DateTime.Today)
    {
        Console.WriteLine("Data przyjazdu nie może być z przeszłości. Proszę spróbować ponownie.");
    }
    else
    {
        break;
    }
}

DateTime departure;
while (true)
{
    Console.Write("Podaj datę odjazdu (format: yyyy-mm-dd): ");
    departure = DateTime.Parse(Console.ReadLine());

    if ((departure - arrival).Days > 30)
    {
        Console.WriteLine("Maksymalny pobyt to 30 dni. Proszę spróbować ponownie.");
    }
    else
    {
        break;
    }
}

Console.Write("Podaj numer pokoju: ");
int roomNumber = int.Parse(Console.ReadLine());

Room room = new Room { Arrival = arrival, Departure = departure, RoomNumber = roomNumber };

HotelSingleton hotelSingleton = HotelSingleton.Instance;

Console.Write("Czy chcesz zarezerwować pokój VIP? (Tak/Nie): ");
string isVip = Console.ReadLine()?.ToLower();

if (isVip == "tak")
{
    Console.Write("Podaj dodatkowe informacje dla VIP: ");
    room.BookingInfo = Console.ReadLine();
    room.IsVip = true;
    hotelSingleton.RoomBooking = new VipRoomBookingAdapter();
}
else
{
    hotelSingleton.RoomBooking = new StandardRoomBooking();
}

hotelSingleton.RoomBooking.BookRoom(name, room);