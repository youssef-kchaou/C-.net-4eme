using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {
        public ServicePlane(ApplicationCore.Interfaces.IUnitOfWork unitOfWork) : base(unitOfWork)
        {
      
        }

        public IEnumerable<Passenger> GetPassengerByPlane(Plane p)
        {
          return p.Flights.SelectMany(p => p.Passengers);
        }

        public IEnumerable<Flight> GetFlightByDepart(int n)
        {
         return GetAll().SelectMany(p=> p.Flights).OrderByDescending(p=>p.FlightDate).Take(n);
        }

    public void DeletePlaneByManufactureDate()
    {
      Delete(p => (DateTime.Now - p.ManufactureDate).TotalDays < 10 * 365);
    }

    public bool ReserverPlaces(Flight f, int n)
    {
      return f.Plane.Capacity > f.Passengers.Count() + n;
    }
  }
}
