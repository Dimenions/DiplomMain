using SSU.Coins.BLL.Interface;
using SSU.Coins.Entities;

namespace SSU.Coins.BLL
{
    public class MaterialLogic : IMaterialLogic
    {
        /*private IMaterialDao _materialLogic;

        public MaterialLogic(IMaterialDao materialLogic)
        {
            _materialLogic = materialLogic;
        }*/

        public IEnumerable<Material> GetAll()
        {
            //return _materialLogic.GetAll();
            return null;
        }

        public Material GetById(int id)
        {
            //return _materialLogic.GetById(id);
            return null;
        }

        public Material GetByTitle(string title)
        {
            //return _materialLogic.GetByTitle(title);
            return null;
        }

        public void RemoveById(int id, ICollection<Error> errorList)
        {
            //_materialLogic.RemoveById(id);

        }

        public void Update(Material coin, ICollection<Error> errorList)
        {
            //_materialLogic.Update(coin);
        }
    }
}