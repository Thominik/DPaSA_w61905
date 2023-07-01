namespace DPaSA_w61905;

public class VipRoomBooking : IRoomBooking
{
    public void BookRoom(string ownerName, Room room)
    {
        Console.WriteLine($"Pobyt VIP na {ownerName}, " +
                          $"od {room.Arrival.ToShortDateString()} do {room.Departure.ToShortDateString()}, " +
                          $"pokój numer {room.RoomNumber}, VIP pokój {room.IsVip = true}, " +
                          $"dodatkowe usługi {room.BookingInfo}.");
    }
}