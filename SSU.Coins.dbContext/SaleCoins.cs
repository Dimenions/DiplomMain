using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.dbContext
{
    public class SaleCoins
    {
        public int SaleCoinsId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<Coin> CoinId { get; set; }
        //public int CoinId { get; set; }

        public Coin Coin { get; set; }

        public double SaleCoin { get; set; }

        public string Information { get; set; }

        public bool Activ { get; set; }

        public byte[] Picture { get; set; }
    }
}
