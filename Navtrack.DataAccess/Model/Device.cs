using System.Collections.Generic;

namespace Navtrack.DataAccess.Model
{
    public class Device
    {
        public Device()
        {
            Locations = new HashSet<Location>();
        }
        
        public int Id { get; set; }
        public string IMEI { get; set; }
        public ICollection<Location> Locations { get; set; }
    }
}