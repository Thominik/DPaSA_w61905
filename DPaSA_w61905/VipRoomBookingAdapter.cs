namespace DPaSA_w61905;

public class VipRoomBookingAdapter : IRoomBooking
{
    private VipRoomBooking _vipRoomBooking = new VipRoomBooking();
    public void BookRoom(string ownerName, Room room)
    {
        room.IsVip = true;
        _vipRoomBooking.BookRoom(ownerName, room);
    }
}