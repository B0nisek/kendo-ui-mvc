using DAL.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BL.DTO
{
    public class CustomerDTO
    {
        public CustomerDTO()
        {
            Address = new HashSet<Address>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string IC { get; set; }
        public string DIC { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
