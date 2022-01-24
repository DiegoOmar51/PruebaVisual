using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloPrubea.Entidades
{
    public class Customer
    {
        public int Id  {get; set; }
        public int store_id { get; set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String email { get; set; }
        public Boolean  activateboll {get; set; }
        public DateTime create_date { get; set; }
        public DateTime last_update { get; set; }
        public Boolean activate { get; set; }
        public ICollection<Payment> Payments { get; set; }


    }
}
