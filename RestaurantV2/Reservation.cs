using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantV2
{
    [Serializable]
    public class Reservation : IComparable<Reservation>
    {
        public int Id;
        public string creatorName;
        public double price;

        public Reservation(int id, string creatorName, double price)
        {
            Id = id;
            this.creatorName = creatorName;
            this.price = price;
        }

        public int CompareTo(Reservation other)
        {
            return price.CompareTo(other.price);
        }
    }
}
