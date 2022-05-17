using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IConsumptionRepository
    {
        Consumption Get();

        IEnumerable<Consumption> GetByDate(DateTime date);

        void Add(Consumption consumption);

        void AddRange(IEnumerable<Consumption> consumption);

        void Update(Consumption consumption);

        void Delete(Consumption consumption);
    }
}
