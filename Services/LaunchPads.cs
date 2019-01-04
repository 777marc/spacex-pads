using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using spacex_pads.Models;

namespace spacex_pads.Services
{
    public class LaunchPads : ILaunchPads
    {
        static HttpClient _client = new HttpClient();

        public async Task<List<LaunchPad>> GetAllPads()
        {
            var padList = new List<LaunchPad>();
            var path = "https://api.spacexdata.com/v2/launchpads";

            HttpResponseMessage response = await _client.GetAsync(path);

            var pads = await response.Content.ReadAsStringAsync();
    
            var pad1 = new LaunchPad();
            pad1.PadId = 1;
            pad1.Name = "pad one";
            padList.Add(pad1);

            var pad2 = new LaunchPad();
            pad2.PadId = 2;
            pad2.Name = "pad two";
            padList.Add(pad2);

            return padList;
            
        }

        public LaunchPad GetPad(int padId)
        {
            var pad1 = new LaunchPad();
            pad1.PadId = padId;
            pad1.Name = "pad " + padId.ToString();
            return pad1;
        }
    }
}