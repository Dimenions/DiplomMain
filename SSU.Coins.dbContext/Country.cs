using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SSU.Coins.dbContext
{
    public class Country
    {
        public int CountryId { get; set; }

        public int CoinId { get; set; } //Внешний ключ
        public Coin Coin { get; set; } // навигационное свойство
        public string Title { get; set; }


    }
}
