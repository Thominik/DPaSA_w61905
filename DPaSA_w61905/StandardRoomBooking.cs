namespace DPaSA_w61905;

public class StandardRoomBooking : IRoomBooking
{
    public void BookRoom(string ownerName, Room room)
    {
        Console.WriteLine($"Rezerwacja pokoju na {ownerName}, od {room.Arrival.ToShortDateString()} do {room.Departure.ToShortDateString()}, pokój numer {room.RoomNumber}.");
    }
}