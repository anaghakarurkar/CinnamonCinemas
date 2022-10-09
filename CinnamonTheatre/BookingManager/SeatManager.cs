using CinnamonTheatre.Models.Layout;
using CinnamonTheatre.Models.Seat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonTheatre.SeatBookingManager
{
    public class SeatManager : ISeatBookingManager
    {

        private ISeatingLayout _currentLayout;
        public SeatManager(ISeatingLayout currentLayout)
        {
           _currentLayout = currentLayout;
        }

        public bool BookSeat()
        {
            return false;
        }

        public bool BookSeat(ISeat seat, int seatCount)
        {
            return false;
        }

        public bool BookSeat(int seatCount)
        {
            return false;
        }
    }
}
