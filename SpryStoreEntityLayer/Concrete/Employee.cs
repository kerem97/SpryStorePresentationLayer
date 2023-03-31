using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStoreEntityLayer.Concrete
{
   public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
    }
}
