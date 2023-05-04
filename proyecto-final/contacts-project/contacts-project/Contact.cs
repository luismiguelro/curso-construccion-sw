using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_project
{
    public  class Contact
    {
        // definir mismas propiedades de la bd
        public int id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Phone{ get; set; }
        public String Address { get; set; }
    }
}
