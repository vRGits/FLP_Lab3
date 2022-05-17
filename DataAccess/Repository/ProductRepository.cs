using Core.Model;
using Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly CalorieContext _context;
        public ProductRepository()
        {
            _context = new CalorieContext();
        }
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(Product product)
        {
            _context.Remove(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetByName(string Name) => _context.Products.Where(p => p.Name == Name).FirstOrDefault();


        public void Update(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }
    }
}
