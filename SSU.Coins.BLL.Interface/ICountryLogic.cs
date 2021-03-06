using SSU.Coins.Entities;
using System.Collections.Generic;

namespace SSU.Coins.BLL.Interface
{
    public interface ICountryLogic
    {
        Country GetById(int id);

        IEnumerable<Country> GetAll();
        IEnumerable<Country> GetByTitle(string title);

        void RemoveById(int id, ICollection<Error> errorList);

        void Update(Country coin, ICollection<Error> errorList);
    }
}

