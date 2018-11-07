using MillerTrucking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MillerTrucking.ModelBuilders
{
    public interface ITruckModelBuilder
    {
        IEnumerable<TruckModel> GetTruckModels(SearchModel searchModel);
    }
    public class TruckModelBuilder : ITruckModelBuilder
    {
        public IEnumerable<TruckModel> GetTruckModels(SearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
