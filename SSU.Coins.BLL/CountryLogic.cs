using SSU.Coins.BLL.Extensions;
using SSU.Coins.BLL.Interface;
using SSU.Coins.Entities;

namespace SSU.Coins.BLL
{
    public class CountryLogic : ICountryLogic
    {
        private CoinsContext _context;

        public CountryLogic(CoinsContext countryLogic)
        {
            _context = countryLogic;
        }

        public IEnumerable<Country> GetAll()
        {
            return _context.Countries.Select(p => p.ToCountry());
        }

        public Country GetById(int id)
        {
            var country = _context.Countries
                .FirstOrDefault(p => p.CountryId == id);

            return country.ToCountry();
        }

        public IEnumerable<Country> GetByTitle(string title)
        {
            return _context.Countries
                .Where(p => p.Title == title)
                .Select(p => p.ToCountry());
        }

        public void RemoveById(int id, ICollection<Error> errorList)
        {
            var country = _context.Countries
                 .FirstOrDefault(p => p.CoinId == id);
            if (country == null) { return; }

            _context.Countries.Remove(country);
            _context.SaveChanges();
        }

        public void Update(Country country, ICollection<Error> errorList)
        {
            var countryModel = country.ToCountryModel();

            var newCoin = _context.Countries
                .FirstOrDefault(c => c.Title == country.Title);

            _context.SaveChanges();
        }
    }
}

