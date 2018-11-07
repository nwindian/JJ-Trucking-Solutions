using Microsoft.EntityFrameworkCore;
using MillerTrucking.Data.Entities;
using MillerTrucking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MillerTrucking.Repositories
{
    public interface ITruckRepository
    {
        IEnumerable<Truck> getTrucks(SearchModel searchModel);
    }
    public class TruckRepository : ITruckRepository
    {
        public IEnumerable<Truck> getTrucks(SearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
