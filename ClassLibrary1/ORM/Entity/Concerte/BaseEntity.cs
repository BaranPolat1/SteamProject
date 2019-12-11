using ClassLibrary1.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.ORM.Entity.Concerte
{
    public enum Status { Active, Passive, Updated, None }
    public class BaseEntity : ICore
    {

        public int ID { get; set; }

        private DateTime _addedDate = DateTime.Now;
        public DateTime AddedDate { get { return _addedDate; } set { _addedDate = value; } }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        private Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }
    }
}
