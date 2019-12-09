using ClassLibrary1.ORM.Entity.Concerte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamProject.Repository.Service.Abstract
{
    public interface IGameRepository
    {

        void Add(string name, string descreption, decimal price, string systemRequirements, DateTime releaseDate,int categoryID, int appuserID,string pictureUrl);

        void Update(int id, string name, string descreption, decimal price, string systemRequirements, DateTime releaseDate,int categoryID,int appuserID, string pictureUrl);

        void Delete(int id);

        void TextboxCmbBoxEraser(GroupBox groupBox);

        List<Game> TakeList();

        List<Game> GetAll();

        List<Game> FindByName(string name);

        List<Game> GetByDateTime(DateTime startedDate, DateTime endDate);

        List<Category> TakeCategoryList();

        List<AppUser> TakeAppUserList();

        
    }
}
