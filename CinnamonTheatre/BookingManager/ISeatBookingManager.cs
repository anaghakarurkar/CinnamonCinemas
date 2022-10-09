using CinnamonTheatre.Models.Seat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonTheatre.SeatBookingManager
{
    public interface ISeatBookingManager
    {
        public bool BookSeat();
        public bool BookSeat(ISeat seat, int seatCount = 1);
        public bool BookSeat(int seatCount);
    }
}
