using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace User.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AppUser> AppUsers { get; set; }

        public static implicit operator Gender(string v)
        {
            throw new NotImplementedException();
        }
    }
}
