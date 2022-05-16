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
        public Coin Coin { get; set; }
        public string Title { get; set; }

    }
}
