using System.Collections.Generic;

namespace Navtrack.DataAccess.Model
{
    public class Asset
    {
        public Asset()
        {
            Locations = new HashSet<Location>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Location> Locations { get; set; }
    }
}