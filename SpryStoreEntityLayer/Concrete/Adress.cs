using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStoreEntityLayer.Concrete
{
    public class Adress
    {
        public int AdressID { get; set; }
        public string Title { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }

        public string MapLocation { get; set; }
    }
}
