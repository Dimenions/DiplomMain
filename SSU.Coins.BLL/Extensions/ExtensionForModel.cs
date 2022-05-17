using SSU.Coins.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinModel = SSU.Coins.dbContext.Coin;
using UserModel = SSU.Coins.dbContext.User;
using CountryModel = SSU.Coins.dbContext.Country;
using MaterialModel = SSU.Coins.dbContext.Material;


namespace SSU.Coins.BLL.Extensions
{
   public static class ExtensionForModel
    {
        public static Coin ToCoin(this CoinModel coinModel) => new Coin
        {
            Date = coinModel.Date,
            Description = coinModel.Description,
            Picture = coinModel.Picture,
            Price = coinModel.Price,
            Title = coinModel.Title,
            Country = coinModel.Country.Title,
            Material = coinModel.Material.Title,
        };

        public static CoinModel ToCoinModel(this Coin coin) => new CoinModel
        {
            Date = coin.Date,
            Description = coin.Description,
            Picture = coin.Picture,
            Price = coin.Price.Value,
            Title = coin.Title,
        };

        public static User ToUser(this UserModel userModel) => new User
        {
            FirstName = userModel.FirstName,
            LastName = userModel.LastName,
            MiddleName = userModel.MiddleName,
            Avatar = userModel.Avatar,
            HashPassword = userModel.HashPassword,
            Login = userModel.Login,
            RoleWebSite = userModel.RoleWebSite.Name,
            
        };

        public static UserModel ToUserModel(this User user) => new UserModel
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            MiddleName = user.MiddleName,
            Avatar = user.Avatar,
            HashPassword = user.HashPassword,
            Login = user.Login,
            //RoleWebSite = user.RoleWebSite.Name,

        };

        public static Country ToCountry(this CountryModel countryModel) => new Country
        {
            Title = countryModel.Title,
        };

        public static CountryModel ToCountryModel(this Country country) => new CountryModel
        {
            Title = country.Title,
        };

        public static Material ToMaterial(this MaterialModel countryModel) => new Material
        {
            Title = countryModel.Title,
        };

        public static MaterialModel ToMaterialModel(this Material material) => new MaterialModel
        {
            Title = material.Title,
        };

    }
}
