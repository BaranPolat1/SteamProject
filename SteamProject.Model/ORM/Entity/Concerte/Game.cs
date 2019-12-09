using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.ORM.Entity.Concerte
{
   public class Game:BaseEntity
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string Descreption { get; set; }

        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }

        public string SystemRequirements { get; set; }

        public string PictureUrl { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
