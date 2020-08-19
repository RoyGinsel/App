using System;
using System.Collections.Generic;

namespace SPA1.Shared.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Customer = new HashSet<Customer>();
        }

        public string PaymentMethod { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
