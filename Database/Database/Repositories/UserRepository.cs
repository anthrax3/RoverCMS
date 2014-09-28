using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Database.Entities;
using Database.Database.Interfaces;

namespace Database.Database.Repositories
{
    public class UserRepository : DataSource<Users>, IRepository<Users>, IUsers<Users>
    {
        public IQueryable<Users> GetList()
        {
            return GetTable();
        }

        public void Remove(Users item)
        {
            GetTable().Remove(item);
            SaveChanges();
        }

        public void Add(Users item)
        {
            GetTable().Add(item);
            SaveChanges();
        }

        public int GetAmountUsersOnline()
        {
            return GetTable().Count(user => user.Online);
        }

        public bool IsUniqueUsername(string username)
        {
            return !GetTable().Any(user => username.ToLower() == user.Username.ToLower());
        }

        public bool IsUniqueEmail(string email)
        {
            return !GetTable().Any(user => email.ToLower() == user.Mail.ToLower());
        }
    }
}
