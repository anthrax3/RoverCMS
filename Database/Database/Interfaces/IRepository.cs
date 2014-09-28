using System.Linq;

namespace Database.Database.Interfaces
{
    public interface IRepository<TEntityType> where TEntityType : class
    {
        IQueryable<TEntityType> GetList();

        void Remove(TEntityType item);

        void Add(TEntityType item);
    }
}