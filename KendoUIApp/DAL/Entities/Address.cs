using Riganti.Utils.Infrastructure.Core;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Address : IEntity<int>
    {
        public Address()
        {
            Customers = new HashSet<Customer>();
        }
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
