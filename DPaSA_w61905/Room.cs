namespace DPaSA_w61905;

public class Room
{
    public int RoomNumber { get; set; }
    public DateTime Arrival { get; set; }
    public DateTime Departure { get; set; }
    public bool IsVip { get; set; }
    public string? BookingInfo { get; set; }
}