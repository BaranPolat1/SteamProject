using SteamProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamProject.Repository.Service.Concerte
{
   public class BaseRepository
    {
        public ProjeContext db;
        public BaseRepository()
        {
            db = new ProjeContext();
        }
    }
}
