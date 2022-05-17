using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class ConsumptionRepository : IConsumptionRepository
    {
        private readonly CalorieContext _context;

        public ConsumptionRepository()
        {
            _context = new CalorieContext();
        }

        public void Add(Consumption consumption)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Consumption> consumption)
        {
            _context.AttachRange(consumption.Select(x => x.Product));
            _context.AddRange(consumption);
            _context.SaveChanges();
        }

        public void Delete(Consumption consumption)
        {
            _context.Consumptions.Remove(consumption);
            _context.SaveChanges();
        }

        public Consumption Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Consumption> GetByDate(DateTime date)
        {
            return _context.Consumptions.Include(c=>c.Product).Where(c => c.Date.Date == date.Date);
        }

        public void Update(Consumption consumption)
        {
            _context.Attach(consumption.Product);
            _context.Add(consumption);
            _context.SaveChanges();
        }
    }
}
