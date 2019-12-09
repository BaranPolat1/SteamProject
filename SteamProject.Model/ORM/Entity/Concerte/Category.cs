using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.ORM.Entity.Concerte
{
    public class Category:BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Descreption { get; set; }

        public List<Game> Games { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
