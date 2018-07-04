using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace StrataDashboard.Entities
{
    public class Building : Entity<int>
    {
        public long StrataPlanNumber { get; set; }
        public string BuildingDisplay { get; set; }
        public int PostCode { get; set; }
        public string LocalGovernment { get; set; }
        public int NumberOfLots { get; set; }
        public string StrataManager { get; set; }
    }
}
