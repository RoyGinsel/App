using System;
using System.Collections.Generic;

namespace SPA1.Shared.Models
{
    public partial class Country
    {
        public Country()
        {
            Customer = new HashSet<Customer>();
        }

        public string CountryName { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
