using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ice_cream.BL_Controller
{
    class CalculatNewStations
    {
        //this is a Fuction to calculate the value of Number of new added Station
        public int calculatNewStations(int actualRowsCount, int newRowsCount)
        {
            return (newRowsCount - actualRowsCount);
        }
    }
}
