using MillerTrucking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MillerTrucking.Tasks
{
    public interface IHomeTasks
    {
        IEnumerable<TruckModel> GetTrucks(SearchModel searchModel);
    }
    public class HomeTasks : IHomeTasks
    {
        public IEnumerable<TruckModel> GetTrucks(SearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
