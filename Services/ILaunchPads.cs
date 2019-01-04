using System.Collections.Generic;
using System.Threading.Tasks;
using spacex_pads.Models;

namespace spacex_pads.Services
{
    public interface ILaunchPads
    {
         Task<List<LaunchPad>> GetAllPads();
         LaunchPad GetPad(int padId);
    }
}