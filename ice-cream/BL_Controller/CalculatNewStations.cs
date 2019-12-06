using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ice_cream.BL_Controller
{
    class CalculatNewStations
    {
        public int calculatNewStations(int actualRowsCount, int newRowsCount)
        {
            return (newRowsCount - actualRowsCount);
        }
    }
}
