using parkingapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parkingapp.Environments;
using Newtonsoft.Json;

namespace parkingapp.Services
{
    public class ApiDataStore : IDataStore
    {
        public List<Parking> ParkingList { get; set; }

        public async Task<List<Parking>> GetParkings()
        {
            HttpClient client = new HttpClient();
            string res = await client.GetStringAsync(Env.url + "parking");

            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine(res);

            return JsonConvert.DeserializeObject<List<Parking>>(res);
        }
    }
}
