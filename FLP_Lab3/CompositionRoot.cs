using Core.Repository;
using DataAccess.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLP_Lab3
{
    public static class CompositionRoot
    {
        public static IConsumptionRepository ConsumptionRepository { get;  } = new ConsumptionRepository();

        public static IProductRepository ProductRepository { get; } = new ProductRepository();



    }
}
