using ClassLibrary1.ORM.Entity.Concerte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamProject.Repository.Service.Abstract
{
    public interface ICategoryReposityory
    {
        void Add(string name, string descreption);

        void Delete(int id);

        void Update(int id, string name, string descreption);

        void TextBoxCmbBoxEraser(GroupBox groupBox);

        List<Category> TakeList();

        List<Category> FindByName(string name);
        List<Category> GetAll();

        List<Category> GetByDate(DateTime startedDate, DateTime endDate);
    }
}
