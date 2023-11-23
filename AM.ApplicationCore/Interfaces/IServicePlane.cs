using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public interface IServicePlane:IService<Plane>
    {
    IEnumerable<Passenger> GetPassengerByPlane(Plane p);
    IEnumerable<Flight> GetFlightByDepart(int n);
    void DeletePlaneByManufactureDate();
    Boolean ReserverPlaces(Flight f , int n);
  }
}
