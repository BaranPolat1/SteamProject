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
    public class CategoryRepository : BaseRepository, ICategoryReposityory
    {
        Category service = new Category();
        public void Add(string name, string descreption)
        {

            service.Name = name;
            service.Descreption = descreption;
            db.Categories.Add(service);
            db.SaveChanges();
            MessageBox.Show("Category has been added");




        }

        public void Delete(int id)
        {



            service = db.Categories.FirstOrDefault(x => x.ID == id);
            service.DeleteDate = DateTime.Now;
            service.Status = Status.Passive;
            db.SaveChanges();
            MessageBox.Show("Category has been deleted");


        }

        public List<Category> FindByName(string name)
        {
            return db.Categories.Where(x => x.Name == name).ToList();
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public List<Category> GetByDate(DateTime startedDate, DateTime endDate)
        {
            return db.Categories.Where(x => x.AddedDate >= startedDate && x.AddedDate <= endDate).ToList();

        }

        public List<Category> TakeList()
        {
            return db.Categories.Where(x => x.Status == Status.Active || x.Status == Status.Updated).ToList();
        }

        public void TextBoxCmbBoxEraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        public void Update(int id, string name, string descreption)
        {

            service = db.Categories.FirstOrDefault(x => x.ID == id);
            service.Name = name;
            service.Descreption = descreption;
            service.UpdateDate = DateTime.Now;
            service.Status = Status.Updated;
            db.SaveChanges();
            MessageBox.Show("Category has been updated");



        }
    }
}
