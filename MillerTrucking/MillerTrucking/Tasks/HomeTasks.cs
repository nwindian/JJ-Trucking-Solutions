using MillerTrucking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MillerTrucking.Data.Repositories;
using MillerTrucking.Data.Entities;
using MillerTrucking.ModelBuilders;

namespace MillerTrucking.Tasks
{
    public interface IHomeTasks
    {
        IEnumerable<TruckModel> GetTrucks(SearchModel searchModel);
    }
    public class HomeTasks : IHomeTasks
    {
        private TruckRepository _truckRepository = new TruckRepository();
        private TruckModelBuilder _truckModelBuilder = new TruckModelBuilder();

        public IEnumerable<TruckModel> GetTrucks(SearchModel searchModel)
        {
            IEnumerable<Truck> trucks = _truckRepository.getTrucks(searchModel);

            return _truckModelBuilder.GetTruckModels(trucks);
        }
    }
}
