using CinnamonTheatre.Models.Seat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonTheatre.Models.Layout
{
    public class CinnamonTheatreLayout : ISeatingLayout
    {
        public IDictionary<char, IList<ISeat>> _seatingArea { get; private set; }
        private const int STARTING_ROW_NAME = 65;
        public CinnamonTheatreLayout()
        {
            _seatingArea = new Dictionary<char, IList<ISeat>>();
        }
        public bool CreateSeatingArea(int rows, int columns)
        {
            int currentRowName = STARTING_ROW_NAME;
            for (int row = 0; row < rows; row++)
            {
                IList<ISeat> seatsInARow = new List<ISeat>();
                for (int column = 0; column < columns; column++)
                {
                    seatsInARow.Add(new FoldBackSeat(column+1, true));
                }
                _seatingArea.Add((char)currentRowName, seatsInARow);
                currentRowName++;
            }
            Console.WriteLine(_seatingArea.Count);
            return _seatingArea.Count > 0;
        }

        public bool CreateSeatingArea(int[] rows, int[] columns)
        {
            return false;
        }

        public bool ModifyRow(char row, IList<ISeat> seatsInThisRow)
        {
            return false;
        }
    }
}
