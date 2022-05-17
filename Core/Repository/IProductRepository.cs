using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();

        Product GetByName(string Name);

        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);
    }
}
