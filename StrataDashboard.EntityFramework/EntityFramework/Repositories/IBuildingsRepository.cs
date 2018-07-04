using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using StrataDashboard.Entities;

namespace StrataDashboard.EntityFramework.Repositories
{
    public interface IBuildingsRepository : IRepository<Building>
    {
    }
}
