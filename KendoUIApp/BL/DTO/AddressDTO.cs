using DAL.Entities;
using System.Collections.Generic;

namespace BL.DTO
{
    public class AddressDTO
    {
        public AddressDTO()
        {
             Customer = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
