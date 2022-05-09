using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantV2
{
    [Serializable]
    public class Restaurant
    {
        public List<Reservation> reservations = new List<Reservation>();
    }
}
