namespace DPaSA_w61905;

public sealed class HotelSingleton
{
    private static HotelSingleton _instance = null;
    private static readonly object padlock = new object();

    public IRoomBooking RoomBooking { get; set; }

    HotelSingleton()
    {
    }

    public static HotelSingleton Instance
    {
        get
        {
            lock (padlock)
            {
                if (_instance == null)
                {
                    _instance = new HotelSingleton();
                }
                return _instance;
            }
        }
    }

    // public IRoomBooking roomBooking;
    //
    // public void SetRoomBooking(IRoomBooking roomBooking)
    // {
    //     this.roomBooking = roomBooking;
    // }
}