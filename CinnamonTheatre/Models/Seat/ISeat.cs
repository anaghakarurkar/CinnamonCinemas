using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinnamonTheatre.Models.Seat
{
    public interface ISeat
    {
        public int SeatID { get; }
        public SeatType Type { get; }
        public bool IsAvailable { get; }
    }
}