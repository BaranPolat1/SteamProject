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
    public class GameRepository : BaseRepository, IGameRepository
    {
        Game service = new Game();
        public void Add(string name, string descreption, decimal price, string systemRequirements, DateTime releaseDate, int categoryID, int appuserID, string pictureUrl)
        {
            service.Name = name;
            service.Descreption = descreption;
            service.Price = price;
            service.SystemRequirements = systemRequirements;
            service.ReleaseDate = releaseDate;
            service.CategoryID = categoryID;
            service.AppUserID = appuserID;
            service.PictureUrl = pictureUrl;
            db.Games.Add(service);
            db.SaveChanges();
            MessageBox.Show("Game has been added");
        }

        public void Delete(int id)
        {
            service = db.Games.FirstOrDefault(x => x.ID == id);
            service.DeleteDate = DateTime.Now;
            service.Status = Status.Passive;
            db.SaveChanges();
            MessageBox.Show("Game has been deleted");
        }

        public List<Game> FindByName(string name)
        {
            return db.Games.Where(x => x.Name == name).ToList();
        }

        public List<Game> GetAll()
        {
            return db.Games.ToList();
        }

        public List<Game> GetByDateTime(DateTime startedDate, DateTime endDate)
        {
            return db.Games.Where(x => x.AddedDate >= startedDate && x.AddedDate <= endDate).ToList();
        }

       

        public List<AppUser> TakeAppUserList()
        {
            return db.AppUsers.Where(x => x.Status == Status.Active || x.Status == Status.Updated).ToList();
        }

        public List<Category> TakeCategoryList()
        {
            return db.Categories.Where(x => x.Status == Status.Active || x.Status == Status.Updated).ToList();
        }

        public List<Game> TakeList()
        {
            return db.Games.Where(x => x.Status == Status.Active || x.Status == Status.Updated).ToList();
        }

        public void TextboxCmbBoxEraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        public void Update(int id, string name, string descreption, decimal price, string systemRequirements, DateTime releaseDate, int categoryID, int appuserID, string pictureUrl)
        {
            service = db.Games.FirstOrDefault(x => x.ID == id);
            service.Name = name;
            service.Descreption = descreption;
            service.Price = price;
            service.SystemRequirements = systemRequirements;
            service.ReleaseDate = releaseDate;
            service.CategoryID = categoryID;
            service.AppUserID = appuserID;
            service.PictureUrl = pictureUrl;
            service.Status = Status.Updated;
            service.UpdateDate = DateTime.Now;
            
            db.SaveChanges();
            MessageBox.Show("Game has been updated");

           
        }
    }
}
