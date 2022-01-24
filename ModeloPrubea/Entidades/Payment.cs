using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloPrubea.Entidades
{
    public class Payment
    {
        public int payment_id { get; set; }
        public Customer Customer { get; set; }
        public int customer_id { get; set; }
        public int staff_id { get; set; }
        public Rental Rentals { get; set; }
        public int rental_id  {get; set; }
        public float amount { get; set; }
        public DateTime payment_date  {get; set; }


}
}
