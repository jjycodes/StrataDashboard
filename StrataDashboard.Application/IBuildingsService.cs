using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using StrataDashboard.Entities;

namespace StrataDashboard
{
    public interface IBuildingsService : IApplicationService
    {
        Task<BuildingsOutput> GetAllBuildings();
    }
}
