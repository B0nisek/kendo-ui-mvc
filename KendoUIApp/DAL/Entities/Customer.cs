using Riganti.Utils.Infrastructure.Core;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Customer : IEntity<int>
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
        }
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string IC { get; set; }
        public string DIC { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
