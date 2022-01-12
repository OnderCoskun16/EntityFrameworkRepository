using CrudApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Repository
{
    // User sınıfın crud işlemlerinden sorumlu
    public class UserRepository : IRepository<User>
    {
        CrudAppDbContext dbContext;  // field

        public UserRepository()
        {
            dbContext = new CrudAppDbContext();
        }

        public int Create(User item)
        {
            dbContext.Add(item);
            try
            {
                return dbContext.SaveChanges();
            }
            catch 
            {
                return 0;
            }
        }

        public int Delete(User item)
        {
            try
            {
                dbContext.Remove(item);
                return dbContext.SaveChanges();
            }
            catch 
            {
                return 0;
            }
        }

        public User FindById(int ID)
        {
            return dbContext.Kullanici.Find(ID);

        }

        public List<User> List()
        {
            return dbContext.Kullanici.ToList();
        }

        public int Update(User item)
        {
            try
            {
               return dbContext.SaveChanges();
            }
            catch 
            {
                return 0;
            }
        }
    }
}
