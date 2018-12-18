using MillerTrucking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MillerTrucking.Data.Entities;

namespace MillerTrucking.ModelBuilders
{
    public interface ITruckModelBuilder
    {
        IEnumerable<TruckModel> GetTruckModels(IEnumerable<Truck> trucks);
    }
    public class TruckModelBuilder : ITruckModelBuilder
    {
        public IEnumerable<TruckModel> GetTruckModels(IEnumerable<Truck> trucks)
        {
            throw new NotImplementedException();
        }
    }
}
