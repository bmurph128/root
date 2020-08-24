using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RootInsuranceKata.Data
{
  public class Driver
  {
    public Driver()
    {
      Trips = new List<Trip>();
    }

    public string Command { get; set; }
    public string Name { get; set; }

    public List<Trip> Trips { get; set; }

    


  }
}
