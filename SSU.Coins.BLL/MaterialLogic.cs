using SSU.Coins.BLL.Extensions;
using SSU.Coins.BLL.Interface;
using SSU.Coins.Entities;

namespace SSU.Coins.BLL
{
    public class MaterialLogic : IMaterialLogic
    {
        private CoinsContext _context;

        public MaterialLogic(CoinsContext materialLogic)
        {
            _context = materialLogic;
        }

        public IEnumerable<Material> GetAll()
        {
            return _context.Materials.Select(p => p.ToMaterial());
        }

        public Material GetById(int id)
        {
            var material = _context.Materials
                .FirstOrDefault(p => p.MaterialId == id);

            return material.ToMaterial();
        }

        public IEnumerable<Material> GetByTitle(string title)
        {
            return _context.Materials
                .Where(p => p.Title == title)
                .Select(p => p.ToMaterial());
        }

        public void RemoveById(int id, ICollection<Error> errorList)
        {
            var material = _context.Materials
                 .FirstOrDefault(p => p.MaterialId == id);
            if (material == null) { return; }

            _context.Materials.Remove(material);
            _context.SaveChanges();

        }

        public void Update(Material material, ICollection<Error> errorList)
        {
            var materialModel = material.ToMaterialModel;

            var newMaterial = _context.Materials
                .FirstOrDefault(c => c.Title == material.Title);

            _context.SaveChanges();
        }
    }
}