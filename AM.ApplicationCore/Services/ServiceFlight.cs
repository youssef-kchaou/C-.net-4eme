using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
  internal class ServiceFlight : Service<Flight>, IServiceFlight
  {
    public ServiceFlight(Interfaces.IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }

    public IEnumerable<Staff> GetStaffInFlightById(int FlightId)
    {
     return  GetById(FlightId).Passengers.OfType<Staff>();
    }

    public IEnumerable<Traveller> GetTravellerInPlaneByDate(DateTime date, Plane plane)
    {
      return GetMany(f=>f.Plane.Equals(plane.PlaneId) && f.FlightDate.Equals(date))
                                         .SelectMany(f=>f.Passengers).OfType<Traveller>();

    }
  }
}
