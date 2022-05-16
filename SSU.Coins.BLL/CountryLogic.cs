using SSU.Coins.BLL.Interface;
using SSU.Coins.Entities;

namespace SSU.Coins.BLL
{
    public class CountryLogic : ICountryLogic
    {
        /*private IContext _countryLogic;

        public CountryLogic(IContext countryLogic)
        {
            _countryLogic = countryLogic;
        }*/

        public IEnumerable<Country> GetAll()
        {
            return null;
        }

        public Country GetById(int id)
        {
            return null;
        }

        public Country GetByTitle(string title)
        {
            return null;
        }

        public void RemoveById(int id, ICollection<Error> errorList)
        {
            //_countryLogic.RemoveById(id);
        }

        public void Update(Country coin, ICollection<Error> errorList)
        {
            //_countryLogic.Update(coin);
        }
    }
}

