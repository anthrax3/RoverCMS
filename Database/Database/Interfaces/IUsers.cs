using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Database.Interfaces
{
    interface IUsers<TEntityType> where TEntityType : class
    {
        int GetAmountUsersOnline();

        bool IsUniqueUsername(string username);

        bool IsUniqueEmail(string username);
    }
}
