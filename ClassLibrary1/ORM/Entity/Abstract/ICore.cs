using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.ORM.Entity.Abstract
{
   public interface ICore
    {
        int ID { get; set; }

        DateTime AddedDate { set; get; }

        DateTime? UpdateDate { set; get; }
        DateTime? DeleteDate { set; get; }

    }
}
