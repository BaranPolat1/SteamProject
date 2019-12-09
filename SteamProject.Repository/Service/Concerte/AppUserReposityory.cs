using ClassLibrary1.ORM.Entity.Concerte;
using SteamProject.Repository.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamProject.Repository.Service.Concerte
{
    public class AppUserReposityory : BaseRepository, IAppUserRepository
    {
        AppUser service = new AppUser();
        public void Add(string firstname, string lastname, string email, string phone, string adress, string country, Role role, DateTime birthdate)
        {
            service.FirstName = firstname;
            service.LastName = lastname;
            service.Email = email;
            service.Phone = phone;
            service.Adress = adress;
            service.Country = country;
            service.Role = role;
            service.BirthDate = birthdate;
            db.AppUsers.Add(service);
            db.SaveChanges();
            MessageBox.Show("User has been added");
        }

        public void Delete(int id)
        {
            service = db.AppUsers.FirstOrDefault(x => x.ID == id);
            service.DeleteDate = DateTime.Now;
            service.Status = Status.Passive;
            db.SaveChanges();
            MessageBox.Show("User has been deleted!");
        }

        public List<AppUser> FindByName(string firstname, string lastname)
        {
            return db.AppUsers.Where(x => x.FirstName == firstname && x.LastName == lastname).ToList();
        }

        public List<AppUser> GetAll()
        {
            return db.AppUsers.ToList();
        }

        public List<AppUser> GetByDateTime(DateTime startedDate, DateTime endDate)
        {
            return db.AppUsers.Where(x => x.AddedDate >= startedDate && x.AddedDate <= endDate).ToList();
        }

        public void GetEnum(ComboBox cmbAdd, ComboBox cmbUpdate)
        {
            cmbAdd.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbAdd.SelectedIndex = 0;

            cmbUpdate.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbUpdate.SelectedIndex = 0;
        }

        public List<AppUser> TakeList()
        {
            return db.AppUsers.Where(x => x.Status == Status.Active || x.Status == Status.Updated).ToList();
        }

        public void TextboxCmbBoxEraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox || item is ComboBox || item is MaskedTextBox)
                {
                    item.Text = "";

                }
            }
        }

        public void Update(int id, string firstname, string lastname, string email, string phone, string adress, string country, Role role, DateTime birthdate)
        {
            service = db.AppUsers.FirstOrDefault(x => x.ID == id);
            service.FirstName = firstname;
            service.LastName = lastname;
            service.Email = email;
            service.Phone = phone;
            service.Adress = adress;
            service.Country = country;
            service.Role = role;
            service.BirthDate = birthdate;

            db.SaveChanges();
            MessageBox.Show("User has been updated");
        }
    
    }
}
