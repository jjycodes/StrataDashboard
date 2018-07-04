using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrataDashboard.Entities;
using StrataDashboard.EntityFramework.Repositories;

namespace StrataDashboard
{
    public class BuildingsService : IBuildingsService
    {
        private readonly IBuildingsRepository _buildingsRepository;

        public BuildingsService(IBuildingsRepository buildingsRepository)
        {
            _buildingsRepository = buildingsRepository;
        }

        public async Task<BuildingsOutput> GetAllBuildings()
        {
            return await Task.FromResult(new BuildingsOutput()
            {
                Buildings = _buildingsRepository.GetAllList()
            });
        }

    }

    public class BuildingsOutput
    {
        public IEnumerable<Building> Buildings { get; set; }
    }
}
