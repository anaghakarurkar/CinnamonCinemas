using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonTheatre.Models.Seat
{
    public class FoldBackSeat : ISeat
    {
        public int SeatID { get; private set; }
        public bool IsAvailable { get; private set; }
        public SeatType Type { get; private set; }

        public FoldBackSeat(int seatID, bool isAvailable)
        {
            Type = SeatType.FoldBack;
            SeatID = seatID;
            IsAvailable = isAvailable;
        }
    }
}

