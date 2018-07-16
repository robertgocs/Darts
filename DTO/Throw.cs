using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DartThrow
    {
        public int Multiplayer { get; private set; }
        public int Sector { get; private set; }

        public DartThrow(int sector, int multiplayer)
        {
            if((sector > 20 || sector < 0) && sector != 25)
            {
                throw new ArgumentOutOfRangeException("sector value is not valid");
            }
            if(multiplayer > 3 || multiplayer < 1 || (sector == 25 && multiplayer > 2))
            {
                throw new ArgumentOutOfRangeException("multiplayer value is not valid");
            }

            Sector = sector;
            Multiplayer = multiplayer;
        }

        public int GetScore() => Multiplayer * Sector;
    }
}
