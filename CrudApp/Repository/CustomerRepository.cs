using CrudApp.Models;
using CrudApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp
{
    public class CustomerRepository : IRepository<Customers>
    {
        CrudAppDbContext dbContext;  // field

        public CustomerRepository()
        {
            dbContext = new CrudAppDbContext();
        }

        public int Create(Customers item)
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

        public int Delete(Customers item)
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

        public Customers FindById(int ID)
        {
            return dbContext.Musteriler.Find(ID);
        }

        public List<Customers> List()
        {
            return dbContext.Musteriler.ToList();
        }

        public int Update(Customers item)
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
