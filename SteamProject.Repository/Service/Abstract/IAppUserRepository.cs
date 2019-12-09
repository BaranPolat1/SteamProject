using ClassLibrary1.ORM.Entity.Concerte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamProject.Repository.Service.Abstract
{
   public interface IAppUserRepository
    {
        void Add(string firstname, string lastname, string email, string phone, string adress, string country, Role role, DateTime birthdate);

        void Update(int id, string firstname, string lastname, string email, string phone, string adress, string country, Role role, DateTime birthdate);
        void Delete(int id);

        List<AppUser> TakeList();

        List<AppUser> GetAll();

        List<AppUser> FindByName(string firstname, string lastname);

        List<AppUser> GetByDateTime(DateTime startedDate, DateTime endDate);

        void GetEnum(ComboBox cmbAdd, ComboBox cmbUpdate);
        void TextboxCmbBoxEraser(GroupBox groupBox);
    }
}
