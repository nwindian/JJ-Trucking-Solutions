using Microsoft.EntityFrameworkCore;
using MillerTrucking.Data.Entities;
using MillerTrucking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MillerTrucking.Data.Repositories
{
    public interface ITruckRepository
    {
        IEnumerable<Truck> getTrucks(SearchModel searchModel);
    }
    public class TruckRepository : ITruckRepository
    {
        private modelContext context = new modelContext();

        public IEnumerable<Truck> getTrucks(SearchModel searchModel)
        {
            return context.Truck.Select(t => t)
                                .Where(t => t.Id == 1)
                                .ToList();
        }
    }
}
