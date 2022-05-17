using SSU.Coins.BLL.Interface;
using SSU.Coins.Entities;
using Microsoft.EntityFrameworkCore;
using SSU.Coins.BLL.Extensions;

namespace SSU.Coins.BLL
{
    public class CoinLogic : ICoinLogic
    {
        private CoinsContext _context;

        public CoinLogic(CoinsContext coinLogic)
        {
            _context = coinLogic;
        }
        
        public void Add(Coin coin, out ICollection<Error> errorList)
        {
            errorList = new List<Error>();
            try
            {
                _context.Add(coin);
            }
            catch (Exception ex)
            {
                errorList.Add(new Error { Message = ex.Message });
            }
        }

        public IEnumerable<Coin> GetAll()
        {
            return _context.Coins.Select(p=>p.ToCoin());
        }

        public IEnumerable<Coin> GetByCountry(string nameCountry)
        {
            return _context.Coins
                .Where(p => p.Country.Title == nameCountry)
                .Select(p => p.ToCoin());
        }

        public IEnumerable<Coin> GetByDate(int year)
        {
            return _context.Coins
                .Where(p => p.Date.Year == year)
                .Select(p => p.ToCoin());
        }

        public Coin GetById(int id)
        {
            var coin = _context.Coins
                .FirstOrDefault(p => p.CoinId == id);

            return coin.ToCoin();
        }

        public IEnumerable<Coin> GetByMaterial(string material)
        {
            return _context.Coins
                .Where(p => p.Material.Title == material)
                .Select(p => p.ToCoin());
        }

        public IEnumerable<Coin> GetByPrice(int price)
        {
            return _context.Coins
                .Where(p => p.Price == price)
                .Select(p => p.ToCoin());
        }

        public IEnumerable<Coin> GetByTitle(string title)
        {
            return _context.Coins
                .Where(p => p.Title == title)
                .Select(p => p.ToCoin());
        }

        public IEnumerable<Coin> GetByTitleAndCountry(string title, string nameCountry)
        {
            return _context.Coins
                .Where(p => p.Title == title && p.Country.Title == nameCountry)
                .Select(p => p.ToCoin());
        }

        public void RemoveById(int id, ICollection<Error> errorList)
        {

            var coin = _context.Coins
                 .FirstOrDefault(p => p.CoinId == id);
            if (coin == null) { return; }

            _context.Coins.Remove(coin);
            _context.SaveChanges();
        }

        public void Update(Coin coin, ICollection<Error> errorList)
        {
            var coinModel = coin.ToCoinModel();

            var newCoin = _context.Coins
       .FirstOrDefault(c => c.Title == coin.Title);

            var newCountry = _context.Countries
       .FirstOrDefault(c => c.Title == coin.Country);

            var newMaterial = _context.Materials
       .FirstOrDefault(c => c.Title == coin.Material);

            coinModel.Country = newCountry;
            coinModel.Material = newMaterial ;

            _context.Coins.Update(coinModel);

            _context.SaveChanges();
        }
    }
}