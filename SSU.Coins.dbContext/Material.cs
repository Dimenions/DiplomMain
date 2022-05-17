using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SSU.Coins.dbContext
{
    public class Material
    {
        public int MaterialId { get; set; }

        public Coin Coin { get; set; }

        public int CoinId { get; set; }

        public string Title { get; set; }


    }
}
