using System;
using System.Collections.Generic;

namespace SPA1.Shared.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Watchhistory = new HashSet<Watchhistory>();
        }

        public string CustomerMailAddress { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentCardNumber { get; set; }
        public string ContractType { get; set; }
        public DateTime SubscriptionStart { get; set; }
        public DateTime? SubscriptionEnd { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CountryName { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }

        public virtual Contract ContractTypeNavigation { get; set; }
        public virtual Country CountryNameNavigation { get; set; }
        public virtual Payment PaymentMethodNavigation { get; set; }
        public virtual ICollection<Watchhistory> Watchhistory { get; set; }
    }
}
