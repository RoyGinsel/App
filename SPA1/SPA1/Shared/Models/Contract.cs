using System;
using System.Collections.Generic;

namespace SPA1.Shared.Models
{
    public partial class Contract
    {
        public Contract()
        {
            Customer = new HashSet<Customer>();
        }

        public string ContractType { get; set; }
        public decimal PricePerMonth { get; set; }
        public decimal DiscountPercentage { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
