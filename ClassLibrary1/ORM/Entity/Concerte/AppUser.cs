using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.ORM.Entity.Concerte
{
    public enum Role { Admin, Emplooye, Member, Author, }
    public class AppUser:BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Adress { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }

        public List<Game> Games { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
