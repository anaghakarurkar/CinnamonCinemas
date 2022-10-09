using CinnamonTheatre.Models.Seat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonTheatre.Models.Layout
{
    public interface ISeatingLayout
    {
        public bool CreateSeatingArea(int rows, int columns);
        public bool CreateSeatingArea(int[] rows, int[] columns);
        public bool ModifyRow(char row, IList<ISeat> seatsInThisRow);
    }
}
