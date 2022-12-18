using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parkingapp.Models;

namespace parkingapp.Services
{
    public interface IDataStore
    {
        List<Parking> ParkingList { get; set; }

        Task<List<Parking>> GetParkings();
        Task<List<List<Parking>>> GetParkingsByStad();
        Task Parkeer(int pid);
        Task Vertrek(int pid);
    }
}
